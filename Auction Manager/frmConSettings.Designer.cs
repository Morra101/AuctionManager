
namespace Auction_Manager
{
    partial class frmConSettings
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
            this.lblConManPassword = new System.Windows.Forms.Label();
            this.txtConfigPass = new System.Windows.Forms.TextBox();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnApplyConfig = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblConHint = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.pnlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConManPassword
            // 
            this.lblConManPassword.AutoSize = true;
            this.lblConManPassword.Location = new System.Drawing.Point(9, 41);
            this.lblConManPassword.Name = "lblConManPassword";
            this.lblConManPassword.Size = new System.Drawing.Size(53, 13);
            this.lblConManPassword.TabIndex = 0;
            this.lblConManPassword.Text = "Password";
            // 
            // txtConfigPass
            // 
            this.txtConfigPass.Location = new System.Drawing.Point(68, 38);
            this.txtConfigPass.Name = "txtConfigPass";
            this.txtConfigPass.Size = new System.Drawing.Size(100, 20);
            this.txtConfigPass.TabIndex = 2;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSetting.Controls.Add(this.btnTestConn);
            this.pnlSetting.Controls.Add(this.btnApplyConfig);
            this.pnlSetting.Controls.Add(this.txtPort);
            this.pnlSetting.Controls.Add(this.label1);
            this.pnlSetting.Controls.Add(this.lblServer);
            this.pnlSetting.Controls.Add(this.txtServer);
            this.pnlSetting.Location = new System.Drawing.Point(12, 71);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(237, 139);
            this.pnlSetting.TabIndex = 3;
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApplyConfig.Location = new System.Drawing.Point(134, 100);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(100, 36);
            this.btnApplyConfig.TabIndex = 4;
            this.btnApplyConfig.Text = "Apply";
            this.btnApplyConfig.UseVisualStyleBackColor = false;
            this.btnApplyConfig.Click += new System.EventHandler(this.BtnApplyConfig_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(56, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(149, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.TextChanged += new System.EventHandler(this.TxtPort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port :";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(6, 6);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(44, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server :";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(56, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(149, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextChanged += new System.EventHandler(this.TxtServer_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(174, 36);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblConHint
            // 
            this.lblConHint.AutoSize = true;
            this.lblConHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConHint.Location = new System.Drawing.Point(8, 0);
            this.lblConHint.Name = "lblConHint";
            this.lblConHint.Size = new System.Drawing.Size(178, 24);
            this.lblConHint.TabIndex = 5;
            this.lblConHint.Text = "Connection Settings";
            // 
            // btnTestConn
            // 
            this.btnTestConn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTestConn.Location = new System.Drawing.Point(0, 100);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(100, 36);
            this.btnTestConn.TabIndex = 5;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = false;
            this.btnTestConn.Click += new System.EventHandler(this.BtnTestConn_Click);
            // 
            // frmConSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.Controls.Add(this.lblConHint);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.txtConfigPass);
            this.Controls.Add(this.lblConManPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 275);
            this.Name = "frmConSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.FrmConSettings_Load);
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConManPassword;
        private System.Windows.Forms.TextBox txtConfigPass;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblConHint;
        private System.Windows.Forms.Button btnApplyConfig;
        private System.Windows.Forms.Button btnTestConn;
    }
}