
namespace MyVPN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPublicIP = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.lblCurrentPrivateIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rbtnTCP = new System.Windows.Forms.RadioButton();
            this.rbtnUDP = new System.Windows.Forms.RadioButton();
            this.lblSelectAServer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.rbtnTCP);
            this.panel1.Controls.Add(this.rbtnUDP);
            this.panel1.Controls.Add(this.lblSelectAServer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 614);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCurrentPublicIP);
            this.panel2.Controls.Add(this.X);
            this.panel2.Controls.Add(this.lblCurrentPrivateIP);
            this.panel2.Controls.Add(this.lblIP);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 292);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(27, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Public IP -";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(27, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Private IP -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentPublicIP
            // 
            this.lblCurrentPublicIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCurrentPublicIP.Location = new System.Drawing.Point(147, 226);
            this.lblCurrentPublicIP.Name = "lblCurrentPublicIP";
            this.lblCurrentPublicIP.Size = new System.Drawing.Size(233, 36);
            this.lblCurrentPublicIP.TabIndex = 3;
            this.lblCurrentPublicIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.X.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.X.Location = new System.Drawing.Point(264, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(126, 26);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // lblCurrentPrivateIP
            // 
            this.lblCurrentPrivateIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCurrentPrivateIP.Location = new System.Drawing.Point(147, 181);
            this.lblCurrentPrivateIP.Name = "lblCurrentPrivateIP";
            this.lblCurrentPrivateIP.Size = new System.Drawing.Size(232, 36);
            this.lblCurrentPrivateIP.TabIndex = 2;
            this.lblCurrentPrivateIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIP.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIP.Location = new System.Drawing.Point(22, 136);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(357, 36);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "Your current IP address - ";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(24, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(344, 78);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "You are not connected!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(63, 524);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(273, 43);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(63, 439);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(273, 43);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rbtnTCP
            // 
            this.rbtnTCP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rbtnTCP.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rbtnTCP.Location = new System.Drawing.Point(249, 369);
            this.rbtnTCP.Name = "rbtnTCP";
            this.rbtnTCP.Size = new System.Drawing.Size(111, 34);
            this.rbtnTCP.TabIndex = 2;
            this.rbtnTCP.TabStop = true;
            this.rbtnTCP.Text = "TCP";
            this.rbtnTCP.UseVisualStyleBackColor = true;
            // 
            // rbtnUDP
            // 
            this.rbtnUDP.AutoSize = true;
            this.rbtnUDP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rbtnUDP.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rbtnUDP.Location = new System.Drawing.Point(91, 369);
            this.rbtnUDP.Name = "rbtnUDP";
            this.rbtnUDP.Size = new System.Drawing.Size(80, 34);
            this.rbtnUDP.TabIndex = 1;
            this.rbtnUDP.TabStop = true;
            this.rbtnUDP.Text = "UDP";
            this.rbtnUDP.UseVisualStyleBackColor = true;
            // 
            // lblSelectAServer
            // 
            this.lblSelectAServer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectAServer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSelectAServer.Location = new System.Drawing.Point(58, 312);
            this.lblSelectAServer.Name = "lblSelectAServer";
            this.lblSelectAServer.Size = new System.Drawing.Size(281, 41);
            this.lblSelectAServer.TabIndex = 0;
            this.lblSelectAServer.Text = "Select a Protocol";
            this.lblSelectAServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(394, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectAServer;
        private System.Windows.Forms.RadioButton rbtnUDP;
        private System.Windows.Forms.RadioButton rbtnTCP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCurrentPrivateIP;
        private System.Windows.Forms.Label lblCurrentPublicIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

