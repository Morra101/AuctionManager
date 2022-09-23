namespace Auction_Manager
{
    partial class frmStock_View
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
            this.lblStockViewHint2 = new System.Windows.Forms.Label();
            this.pnlStockViewSearch1 = new System.Windows.Forms.Panel();
            this.pnlStockViewSearch = new System.Windows.Forms.Panel();
            this.btnSearchStockView1 = new System.Windows.Forms.Button();
            this.lblStockIDView = new System.Windows.Forms.Label();
            this.txtStockIDSearch = new System.Windows.Forms.TextBox();
            this.lblStockHint = new System.Windows.Forms.Label();
            this.pnlStockViewSearch2 = new System.Windows.Forms.Panel();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.btnStockViewBack = new System.Windows.Forms.Button();
            this.txtAucSoldPrice = new System.Windows.Forms.TextBox();
            this.chkStockViewSoldPrice = new System.Windows.Forms.CheckBox();
            this.bynStockViewHelp = new System.Windows.Forms.Button();
            this.btnSearchStockView2 = new System.Windows.Forms.Button();
            this.txtChasNum = new System.Windows.Forms.TextBox();
            this.txtEngNum = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.chkStockViewDate = new System.Windows.Forms.CheckBox();
            this.chkStockViewEngNum = new System.Windows.Forms.CheckBox();
            this.chkStockViewRegNum = new System.Windows.Forms.CheckBox();
            this.chkStockViewChasNum = new System.Windows.Forms.CheckBox();
            this.lblStockView = new System.Windows.Forms.Label();
            this.dbStockView = new System.Windows.Forms.DataGridView();
            this.pbViewStockHome = new System.Windows.Forms.PictureBox();
            this.pnlStockViewSearch1.SuspendLayout();
            this.pnlStockViewSearch.SuspendLayout();
            this.pnlStockViewSearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewStockHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockViewHint2
            // 
            this.lblStockViewHint2.AutoSize = true;
            this.lblStockViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockViewHint2.Location = new System.Drawing.Point(46, 79);
            this.lblStockViewHint2.Name = "lblStockViewHint2";
            this.lblStockViewHint2.Size = new System.Drawing.Size(620, 20);
            this.lblStockViewHint2.TabIndex = 42;
            this.lblStockViewHint2.Text = "Select one of the check boxes if you would like to search by a certain criteria";
            // 
            // pnlStockViewSearch1
            // 
            this.pnlStockViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlStockViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStockViewSearch1.Controls.Add(this.lblStockViewHint2);
            this.pnlStockViewSearch1.Controls.Add(this.pnlStockViewSearch);
            this.pnlStockViewSearch1.Controls.Add(this.lblStockHint);
            this.pnlStockViewSearch1.Controls.Add(this.pnlStockViewSearch2);
            this.pnlStockViewSearch1.Location = new System.Drawing.Point(35, 303);
            this.pnlStockViewSearch1.Name = "pnlStockViewSearch1";
            this.pnlStockViewSearch1.Size = new System.Drawing.Size(717, 391);
            this.pnlStockViewSearch1.TabIndex = 41;
            // 
            // pnlStockViewSearch
            // 
            this.pnlStockViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlStockViewSearch.Controls.Add(this.btnSearchStockView1);
            this.pnlStockViewSearch.Controls.Add(this.lblStockIDView);
            this.pnlStockViewSearch.Controls.Add(this.txtStockIDSearch);
            this.pnlStockViewSearch.Location = new System.Drawing.Point(43, 33);
            this.pnlStockViewSearch.Name = "pnlStockViewSearch";
            this.pnlStockViewSearch.Size = new System.Drawing.Size(617, 30);
            this.pnlStockViewSearch.TabIndex = 41;
            // 
            // btnSearchStockView1
            // 
            this.btnSearchStockView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchStockView1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStockView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchStockView1.Location = new System.Drawing.Point(500, 0);
            this.btnSearchStockView1.Name = "btnSearchStockView1";
            this.btnSearchStockView1.Size = new System.Drawing.Size(90, 30);
            this.btnSearchStockView1.TabIndex = 44;
            this.btnSearchStockView1.Text = "SEARCH";
            this.btnSearchStockView1.UseVisualStyleBackColor = false;
            this.btnSearchStockView1.Click += new System.EventHandler(this.btnSearchStockView1_Click);
            // 
            // lblStockIDView
            // 
            this.lblStockIDView.AutoSize = true;
            this.lblStockIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockIDView.Location = new System.Drawing.Point(10, 7);
            this.lblStockIDView.Name = "lblStockIDView";
            this.lblStockIDView.Size = new System.Drawing.Size(58, 16);
            this.lblStockIDView.TabIndex = 41;
            this.lblStockIDView.Text = "Stock ID";
            // 
            // txtStockIDSearch
            // 
            this.txtStockIDSearch.Location = new System.Drawing.Point(310, 5);
            this.txtStockIDSearch.Name = "txtStockIDSearch";
            this.txtStockIDSearch.Size = new System.Drawing.Size(167, 20);
            this.txtStockIDSearch.TabIndex = 38;
            this.txtStockIDSearch.Click += new System.EventHandler(this.txtStockIDSearch_Click);
            this.txtStockIDSearch.TextChanged += new System.EventHandler(this.txtStockIDSearch_TextChanged);
            // 
            // lblStockHint
            // 
            this.lblStockHint.AutoSize = true;
            this.lblStockHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockHint.Location = new System.Drawing.Point(51, 10);
            this.lblStockHint.Name = "lblStockHint";
            this.lblStockHint.Size = new System.Drawing.Size(524, 20);
            this.lblStockHint.TabIndex = 39;
            this.lblStockHint.Text = "Enter the StockID of the stock item you would like to Search for ";
            // 
            // pnlStockViewSearch2
            // 
            this.pnlStockViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlStockViewSearch2.Controls.Add(this.dtpDateIn);
            this.pnlStockViewSearch2.Controls.Add(this.btnStockViewBack);
            this.pnlStockViewSearch2.Controls.Add(this.txtAucSoldPrice);
            this.pnlStockViewSearch2.Controls.Add(this.chkStockViewSoldPrice);
            this.pnlStockViewSearch2.Controls.Add(this.bynStockViewHelp);
            this.pnlStockViewSearch2.Controls.Add(this.btnSearchStockView2);
            this.pnlStockViewSearch2.Controls.Add(this.txtChasNum);
            this.pnlStockViewSearch2.Controls.Add(this.txtEngNum);
            this.pnlStockViewSearch2.Controls.Add(this.txtRegNum);
            this.pnlStockViewSearch2.Controls.Add(this.chkStockViewDate);
            this.pnlStockViewSearch2.Controls.Add(this.chkStockViewEngNum);
            this.pnlStockViewSearch2.Controls.Add(this.chkStockViewRegNum);
            this.pnlStockViewSearch2.Controls.Add(this.chkStockViewChasNum);
            this.pnlStockViewSearch2.Location = new System.Drawing.Point(43, 102);
            this.pnlStockViewSearch2.Name = "pnlStockViewSearch2";
            this.pnlStockViewSearch2.Size = new System.Drawing.Size(617, 269);
            this.pnlStockViewSearch2.TabIndex = 29;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIn.Location = new System.Drawing.Point(152, 17);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(145, 20);
            this.dtpDateIn.TabIndex = 43;
            this.dtpDateIn.ValueChanged += new System.EventHandler(this.DtpDateIn_ValueChanged);
            // 
            // btnStockViewBack
            // 
            this.btnStockViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStockViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockViewBack.Location = new System.Drawing.Point(532, 212);
            this.btnStockViewBack.Name = "btnStockViewBack";
            this.btnStockViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnStockViewBack.TabIndex = 52;
            this.btnStockViewBack.Text = "B A C K";
            this.btnStockViewBack.UseVisualStyleBackColor = false;
            this.btnStockViewBack.Click += new System.EventHandler(this.btnStockViewBack_Click);
            // 
            // txtAucSoldPrice
            // 
            this.txtAucSoldPrice.Location = new System.Drawing.Point(302, 112);
            this.txtAucSoldPrice.Name = "txtAucSoldPrice";
            this.txtAucSoldPrice.Size = new System.Drawing.Size(142, 20);
            this.txtAucSoldPrice.TabIndex = 51;
            // 
            // chkStockViewSoldPrice
            // 
            this.chkStockViewSoldPrice.BackColor = System.Drawing.Color.FloralWhite;
            this.chkStockViewSoldPrice.Location = new System.Drawing.Point(152, 107);
            this.chkStockViewSoldPrice.Name = "chkStockViewSoldPrice";
            this.chkStockViewSoldPrice.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkStockViewSoldPrice.Size = new System.Drawing.Size(302, 30);
            this.chkStockViewSoldPrice.TabIndex = 50;
            this.chkStockViewSoldPrice.Text = "Auction Sold Price";
            this.chkStockViewSoldPrice.UseVisualStyleBackColor = false;
            this.chkStockViewSoldPrice.CheckedChanged += new System.EventHandler(this.chkStockViewSoldPrice_CheckedChanged);
            // 
            // bynStockViewHelp
            // 
            this.bynStockViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bynStockViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynStockViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bynStockViewHelp.Location = new System.Drawing.Point(13, 212);
            this.bynStockViewHelp.Name = "bynStockViewHelp";
            this.bynStockViewHelp.Size = new System.Drawing.Size(80, 45);
            this.bynStockViewHelp.TabIndex = 45;
            this.bynStockViewHelp.Text = "H E L P";
            this.bynStockViewHelp.UseVisualStyleBackColor = false;
            this.bynStockViewHelp.Click += new System.EventHandler(this.bynStockViewHelp_Click);
            // 
            // btnSearchStockView2
            // 
            this.btnSearchStockView2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchStockView2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStockView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchStockView2.Location = new System.Drawing.Point(13, 163);
            this.btnSearchStockView2.Name = "btnSearchStockView2";
            this.btnSearchStockView2.Size = new System.Drawing.Size(599, 45);
            this.btnSearchStockView2.TabIndex = 43;
            this.btnSearchStockView2.Text = "S E A R C H  F O R  S T O C K  ";
            this.btnSearchStockView2.UseVisualStyleBackColor = false;
            this.btnSearchStockView2.Click += new System.EventHandler(this.btnSearchStockView2_Click);
            // 
            // txtChasNum
            // 
            this.txtChasNum.Location = new System.Drawing.Point(454, 65);
            this.txtChasNum.Name = "txtChasNum";
            this.txtChasNum.Size = new System.Drawing.Size(142, 20);
            this.txtChasNum.TabIndex = 36;
            // 
            // txtEngNum
            // 
            this.txtEngNum.Location = new System.Drawing.Point(152, 65);
            this.txtEngNum.Name = "txtEngNum";
            this.txtEngNum.Size = new System.Drawing.Size(142, 20);
            this.txtEngNum.TabIndex = 35;
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(455, 17);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(142, 20);
            this.txtRegNum.TabIndex = 34;
            // 
            // chkStockViewDate
            // 
            this.chkStockViewDate.BackColor = System.Drawing.Color.FloralWhite;
            this.chkStockViewDate.Location = new System.Drawing.Point(12, 12);
            this.chkStockViewDate.Name = "chkStockViewDate";
            this.chkStockViewDate.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkStockViewDate.Size = new System.Drawing.Size(292, 30);
            this.chkStockViewDate.TabIndex = 29;
            this.chkStockViewDate.Text = "Date In";
            this.chkStockViewDate.UseVisualStyleBackColor = false;
            this.chkStockViewDate.CheckedChanged += new System.EventHandler(this.chkStockViewDate_CheckedChanged);
            // 
            // chkStockViewEngNum
            // 
            this.chkStockViewEngNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkStockViewEngNum.Location = new System.Drawing.Point(12, 60);
            this.chkStockViewEngNum.Name = "chkStockViewEngNum";
            this.chkStockViewEngNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkStockViewEngNum.Size = new System.Drawing.Size(292, 30);
            this.chkStockViewEngNum.TabIndex = 32;
            this.chkStockViewEngNum.Text = "Engine Number";
            this.chkStockViewEngNum.UseVisualStyleBackColor = false;
            this.chkStockViewEngNum.CheckedChanged += new System.EventHandler(this.chkStockViewEngNum_CheckedChanged);
            // 
            // chkStockViewRegNum
            // 
            this.chkStockViewRegNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkStockViewRegNum.Location = new System.Drawing.Point(315, 12);
            this.chkStockViewRegNum.Name = "chkStockViewRegNum";
            this.chkStockViewRegNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkStockViewRegNum.Size = new System.Drawing.Size(292, 30);
            this.chkStockViewRegNum.TabIndex = 31;
            this.chkStockViewRegNum.Text = "Registration Number";
            this.chkStockViewRegNum.UseVisualStyleBackColor = false;
            this.chkStockViewRegNum.CheckedChanged += new System.EventHandler(this.chkStockViewRegNum_CheckedChanged);
            // 
            // chkStockViewChasNum
            // 
            this.chkStockViewChasNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkStockViewChasNum.Location = new System.Drawing.Point(315, 60);
            this.chkStockViewChasNum.Name = "chkStockViewChasNum";
            this.chkStockViewChasNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkStockViewChasNum.Size = new System.Drawing.Size(291, 30);
            this.chkStockViewChasNum.TabIndex = 30;
            this.chkStockViewChasNum.Text = "Chassis Number";
            this.chkStockViewChasNum.UseVisualStyleBackColor = false;
            this.chkStockViewChasNum.CheckedChanged += new System.EventHandler(this.chkStockViewChasNum_CheckedChanged);
            // 
            // lblStockView
            // 
            this.lblStockView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStockView.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockView.Location = new System.Drawing.Point(35, 9);
            this.lblStockView.Name = "lblStockView";
            this.lblStockView.Size = new System.Drawing.Size(717, 53);
            this.lblStockView.TabIndex = 40;
            this.lblStockView.Text = "VIEW STOCK";
            this.lblStockView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStockView.Click += new System.EventHandler(this.lblStockView_Click);
            // 
            // dbStockView
            // 
            this.dbStockView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbStockView.Location = new System.Drawing.Point(35, 65);
            this.dbStockView.Name = "dbStockView";
            this.dbStockView.ReadOnly = true;
            this.dbStockView.Size = new System.Drawing.Size(717, 232);
            this.dbStockView.TabIndex = 39;
            // 
            // pbViewStockHome
            // 
            this.pbViewStockHome.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewStockHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewStockHome.Location = new System.Drawing.Point(-139, -4);
            this.pbViewStockHome.Name = "pbViewStockHome";
            this.pbViewStockHome.Size = new System.Drawing.Size(1069, 719);
            this.pbViewStockHome.TabIndex = 42;
            this.pbViewStockHome.TabStop = false;
            this.pbViewStockHome.Click += new System.EventHandler(this.pbViewStockHome_Click);
            // 
            // frmStock_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.pnlStockViewSearch1);
            this.Controls.Add(this.lblStockView);
            this.Controls.Add(this.dbStockView);
            this.Controls.Add(this.pbViewStockHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 750);
            this.MinimumSize = new System.Drawing.Size(806, 726);
            this.Name = "frmStock_View";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Stock";
            this.Load += new System.EventHandler(this.FrmStock_View_Load);
            this.pnlStockViewSearch1.ResumeLayout(false);
            this.pnlStockViewSearch1.PerformLayout();
            this.pnlStockViewSearch.ResumeLayout(false);
            this.pnlStockViewSearch.PerformLayout();
            this.pnlStockViewSearch2.ResumeLayout(false);
            this.pnlStockViewSearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewStockHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStockViewHint2;
        private System.Windows.Forms.Panel pnlStockViewSearch1;
        private System.Windows.Forms.Panel pnlStockViewSearch;
        private System.Windows.Forms.Button btnSearchStockView1;
        private System.Windows.Forms.Label lblStockIDView;
        private System.Windows.Forms.Label lblStockHint;
        private System.Windows.Forms.Panel pnlStockViewSearch2;
        private System.Windows.Forms.Button btnStockViewBack;
        private System.Windows.Forms.TextBox txtAucSoldPrice;
        private System.Windows.Forms.CheckBox chkStockViewSoldPrice;
        private System.Windows.Forms.Button bynStockViewHelp;
        private System.Windows.Forms.Button btnSearchStockView2;
        private System.Windows.Forms.TextBox txtChasNum;
        private System.Windows.Forms.TextBox txtEngNum;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.CheckBox chkStockViewDate;
        private System.Windows.Forms.CheckBox chkStockViewEngNum;
        private System.Windows.Forms.CheckBox chkStockViewRegNum;
        private System.Windows.Forms.CheckBox chkStockViewChasNum;
        private System.Windows.Forms.Label lblStockView;
        private System.Windows.Forms.DataGridView dbStockView;
        private System.Windows.Forms.PictureBox pbViewStockHome;
        private System.Windows.Forms.TextBox txtStockIDSearch;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
    }
}