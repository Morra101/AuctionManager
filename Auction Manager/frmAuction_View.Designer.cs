
namespace Auction_Manager
{
    partial class frmAuction_View
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
            this.pbAucViewHome = new System.Windows.Forms.PictureBox();
            this.lblAucView = new System.Windows.Forms.Label();
            this.dbAuctionView = new System.Windows.Forms.DataGridView();
            this.pnlAucViewSearch1 = new System.Windows.Forms.Panel();
            this.lblAucViewHint2 = new System.Windows.Forms.Label();
            this.pnlAucViewSearch = new System.Windows.Forms.Panel();
            this.btnSearchAucView1 = new System.Windows.Forms.Button();
            this.lblAucIDView = new System.Windows.Forms.Label();
            this.txtAucIDSearch = new System.Windows.Forms.TextBox();
            this.lblAucViewHint1 = new System.Windows.Forms.Label();
            this.pnlAucViewSearch2 = new System.Windows.Forms.Panel();
            this.dtpAuctionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchAucView2 = new System.Windows.Forms.Button();
            this.chkAucViewDate = new System.Windows.Forms.CheckBox();
            this.btnAucViewBack = new System.Windows.Forms.Button();
            this.btnAucViewHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAucViewHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAuctionView)).BeginInit();
            this.pnlAucViewSearch1.SuspendLayout();
            this.pnlAucViewSearch.SuspendLayout();
            this.pnlAucViewSearch2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAucViewHome
            // 
            this.pbAucViewHome.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbAucViewHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbAucViewHome.Location = new System.Drawing.Point(-139, -2);
            this.pbAucViewHome.Name = "pbAucViewHome";
            this.pbAucViewHome.Size = new System.Drawing.Size(1069, 719);
            this.pbAucViewHome.TabIndex = 39;
            this.pbAucViewHome.TabStop = false;
            // 
            // lblAucView
            // 
            this.lblAucView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAucView.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAucView.Location = new System.Drawing.Point(33, 9);
            this.lblAucView.Name = "lblAucView";
            this.lblAucView.Size = new System.Drawing.Size(717, 53);
            this.lblAucView.TabIndex = 44;
            this.lblAucView.Text = "VIEW AUCTIONS";
            this.lblAucView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbAuctionView
            // 
            this.dbAuctionView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbAuctionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbAuctionView.Location = new System.Drawing.Point(33, 73);
            this.dbAuctionView.Name = "dbAuctionView";
            this.dbAuctionView.ReadOnly = true;
            this.dbAuctionView.Size = new System.Drawing.Size(717, 232);
            this.dbAuctionView.TabIndex = 45;
            // 
            // pnlAucViewSearch1
            // 
            this.pnlAucViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlAucViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAucViewSearch1.Controls.Add(this.lblAucViewHint2);
            this.pnlAucViewSearch1.Controls.Add(this.pnlAucViewSearch);
            this.pnlAucViewSearch1.Controls.Add(this.lblAucViewHint1);
            this.pnlAucViewSearch1.Controls.Add(this.pnlAucViewSearch2);
            this.pnlAucViewSearch1.Location = new System.Drawing.Point(33, 311);
            this.pnlAucViewSearch1.Name = "pnlAucViewSearch1";
            this.pnlAucViewSearch1.Size = new System.Drawing.Size(717, 311);
            this.pnlAucViewSearch1.TabIndex = 46;
            // 
            // lblAucViewHint2
            // 
            this.lblAucViewHint2.AutoSize = true;
            this.lblAucViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAucViewHint2.Location = new System.Drawing.Point(16, 78);
            this.lblAucViewHint2.Name = "lblAucViewHint2";
            this.lblAucViewHint2.Size = new System.Drawing.Size(620, 20);
            this.lblAucViewHint2.TabIndex = 42;
            this.lblAucViewHint2.Text = "Select one of the check boxes if you would like to search by a certain criteria";
            // 
            // pnlAucViewSearch
            // 
            this.pnlAucViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlAucViewSearch.Controls.Add(this.btnSearchAucView1);
            this.pnlAucViewSearch.Controls.Add(this.lblAucIDView);
            this.pnlAucViewSearch.Controls.Add(this.txtAucIDSearch);
            this.pnlAucViewSearch.Location = new System.Drawing.Point(13, 32);
            this.pnlAucViewSearch.Name = "pnlAucViewSearch";
            this.pnlAucViewSearch.Size = new System.Drawing.Size(617, 34);
            this.pnlAucViewSearch.TabIndex = 41;
            // 
            // btnSearchAucView1
            // 
            this.btnSearchAucView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchAucView1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAucView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchAucView1.Location = new System.Drawing.Point(500, 0);
            this.btnSearchAucView1.Name = "btnSearchAucView1";
            this.btnSearchAucView1.Size = new System.Drawing.Size(90, 30);
            this.btnSearchAucView1.TabIndex = 44;
            this.btnSearchAucView1.Text = "SEARCH";
            this.btnSearchAucView1.UseVisualStyleBackColor = false;
            this.btnSearchAucView1.Click += new System.EventHandler(this.BtnSearchAucView1_Click);
            // 
            // lblAucIDView
            // 
            this.lblAucIDView.AutoSize = true;
            this.lblAucIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucIDView.Location = new System.Drawing.Point(10, 7);
            this.lblAucIDView.Name = "lblAucIDView";
            this.lblAucIDView.Size = new System.Drawing.Size(68, 16);
            this.lblAucIDView.TabIndex = 41;
            this.lblAucIDView.Text = "Auction ID";
            // 
            // txtAucIDSearch
            // 
            this.txtAucIDSearch.Location = new System.Drawing.Point(310, 5);
            this.txtAucIDSearch.Name = "txtAucIDSearch";
            this.txtAucIDSearch.Size = new System.Drawing.Size(167, 20);
            this.txtAucIDSearch.TabIndex = 38;
            this.txtAucIDSearch.Click += new System.EventHandler(this.TxtAucIDSearch_Click_1);
            // 
            // lblAucViewHint1
            // 
            this.lblAucViewHint1.AutoSize = true;
            this.lblAucViewHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucViewHint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAucViewHint1.Location = new System.Drawing.Point(21, 9);
            this.lblAucViewHint1.Name = "lblAucViewHint1";
            this.lblAucViewHint1.Size = new System.Drawing.Size(520, 20);
            this.lblAucViewHint1.TabIndex = 39;
            this.lblAucViewHint1.Text = "Enter the AuctionID of the supplier you would like to Search for ";
            // 
            // pnlAucViewSearch2
            // 
            this.pnlAucViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlAucViewSearch2.Controls.Add(this.dtpAuctionDate);
            this.pnlAucViewSearch2.Controls.Add(this.btnSearchAucView2);
            this.pnlAucViewSearch2.Controls.Add(this.chkAucViewDate);
            this.pnlAucViewSearch2.Location = new System.Drawing.Point(13, 101);
            this.pnlAucViewSearch2.Name = "pnlAucViewSearch2";
            this.pnlAucViewSearch2.Size = new System.Drawing.Size(617, 186);
            this.pnlAucViewSearch2.TabIndex = 29;
            // 
            // dtpAuctionDate
            // 
            this.dtpAuctionDate.Location = new System.Drawing.Point(201, 17);
            this.dtpAuctionDate.Name = "dtpAuctionDate";
            this.dtpAuctionDate.Size = new System.Drawing.Size(205, 20);
            this.dtpAuctionDate.TabIndex = 53;
            // 
            // btnSearchAucView2
            // 
            this.btnSearchAucView2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchAucView2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAucView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchAucView2.Location = new System.Drawing.Point(12, 64);
            this.btnSearchAucView2.Name = "btnSearchAucView2";
            this.btnSearchAucView2.Size = new System.Drawing.Size(589, 45);
            this.btnSearchAucView2.TabIndex = 43;
            this.btnSearchAucView2.Text = "S E A R C H  F O R  A U C T I O N  ";
            this.btnSearchAucView2.UseVisualStyleBackColor = false;
            this.btnSearchAucView2.Click += new System.EventHandler(this.BtnSearchAucView2_Click);
            // 
            // chkAucViewDate
            // 
            this.chkAucViewDate.BackColor = System.Drawing.Color.FloralWhite;
            this.chkAucViewDate.Location = new System.Drawing.Point(13, 13);
            this.chkAucViewDate.Name = "chkAucViewDate";
            this.chkAucViewDate.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkAucViewDate.Size = new System.Drawing.Size(588, 30);
            this.chkAucViewDate.TabIndex = 29;
            this.chkAucViewDate.Text = "Date";
            this.chkAucViewDate.UseVisualStyleBackColor = false;
            this.chkAucViewDate.CheckedChanged += new System.EventHandler(this.ChkAucViewDate_CheckedChanged);
            // 
            // btnAucViewBack
            // 
            this.btnAucViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAucViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAucViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAucViewBack.Location = new System.Drawing.Point(670, 628);
            this.btnAucViewBack.Name = "btnAucViewBack";
            this.btnAucViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnAucViewBack.TabIndex = 52;
            this.btnAucViewBack.Text = "B A C K";
            this.btnAucViewBack.UseVisualStyleBackColor = false;
            this.btnAucViewBack.Click += new System.EventHandler(this.btnAucViewBack_Click);
            // 
            // btnAucViewHelp
            // 
            this.btnAucViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAucViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAucViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAucViewHelp.Location = new System.Drawing.Point(33, 628);
            this.btnAucViewHelp.Name = "btnAucViewHelp";
            this.btnAucViewHelp.Size = new System.Drawing.Size(80, 45);
            this.btnAucViewHelp.TabIndex = 45;
            this.btnAucViewHelp.Text = "H E L P";
            this.btnAucViewHelp.UseVisualStyleBackColor = false;
            this.btnAucViewHelp.Click += new System.EventHandler(this.BtnAucViewHelp_Click);
            // 
            // frmAuction_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 686);
            this.Controls.Add(this.pnlAucViewSearch1);
            this.Controls.Add(this.btnAucViewBack);
            this.Controls.Add(this.dbAuctionView);
            this.Controls.Add(this.btnAucViewHelp);
            this.Controls.Add(this.lblAucView);
            this.Controls.Add(this.pbAucViewHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 725);
            this.MinimumSize = new System.Drawing.Size(806, 725);
            this.Name = "frmAuction_View";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAuction_View";
            this.Load += new System.EventHandler(this.FrmAuction_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAucViewHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAuctionView)).EndInit();
            this.pnlAucViewSearch1.ResumeLayout(false);
            this.pnlAucViewSearch1.PerformLayout();
            this.pnlAucViewSearch.ResumeLayout(false);
            this.pnlAucViewSearch.PerformLayout();
            this.pnlAucViewSearch2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAucViewHome;
        private System.Windows.Forms.Label lblAucView;
        private System.Windows.Forms.DataGridView dbAuctionView;
        private System.Windows.Forms.Panel pnlAucViewSearch1;
        private System.Windows.Forms.Label lblAucViewHint2;
        private System.Windows.Forms.Panel pnlAucViewSearch;
        private System.Windows.Forms.Button btnSearchAucView1;
        private System.Windows.Forms.Label lblAucIDView;
        private System.Windows.Forms.TextBox txtAucIDSearch;
        private System.Windows.Forms.Label lblAucViewHint1;
        private System.Windows.Forms.Panel pnlAucViewSearch2;
        private System.Windows.Forms.Button btnAucViewBack;
        private System.Windows.Forms.Button btnAucViewHelp;
        private System.Windows.Forms.Button btnSearchAucView2;
        private System.Windows.Forms.CheckBox chkAucViewDate;
        private System.Windows.Forms.DateTimePicker dtpAuctionDate;
    }
}