using System;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;

namespace MyVPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPrivateIP();
            GetPublicIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (rbtnUDP.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config inudp.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }

            else if (rbtnTCP.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config intcp.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }

            GetPrivateIP();
            GetPublicIP();

            lblStatus.Text = "You are connected and secured!";
            lblStatus.ForeColor = System.Drawing.Color.Chartreuse;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();

            KillTask();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            KillTask();
            GetPrivateIP();
            GetPublicIP();

            lblStatus.Text = "You are not connected!";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }

        public void GetPrivateIP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    lblCurrentPrivateIP.Text = localIP;
                }
            }
        }

        public void GetPublicIP()
        {
            var endPoint = "https://api.ipify.org/";
            var request = (HttpWebRequest)WebRequest.Create(endPoint);
            var response = (HttpWebResponse)request.GetResponse();
            var resStream = response.GetResponseStream();
            var streamReader = new StreamReader(resStream);
            lblCurrentPublicIP.Text = streamReader.ReadToEnd();
        }

        public void KillTask()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/f /im openvpn.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();
        }
    }
}
