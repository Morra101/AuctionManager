namespace Auction_Manager
{
    partial class frmBuyers_View
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
            this.pbViewBuyHome = new System.Windows.Forms.PictureBox();
            this.lblBuyersView = new System.Windows.Forms.Label();
            this.dbBuyerView = new System.Windows.Forms.DataGridView();
            this.pnlBuyViewSearch1 = new System.Windows.Forms.Panel();
            this.lblBuyViewHint2 = new System.Windows.Forms.Label();
            this.pnlBuyViewSearch = new System.Windows.Forms.Panel();
            this.btnSearchBuyView1 = new System.Windows.Forms.Button();
            this.lblBuyIDView = new System.Windows.Forms.Label();
            this.txtBuyIDSearch = new System.Windows.Forms.TextBox();
            this.lblBuyHint = new System.Windows.Forms.Label();
            this.pnlBuyViewSearch2 = new System.Windows.Forms.Panel();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.chkBuyViewPriID = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkBuyViewName = new System.Windows.Forms.CheckBox();
            this.chkBuyViewConNum = new System.Windows.Forms.CheckBox();
            this.chkBuyViewSurname = new System.Windows.Forms.CheckBox();
            this.chkBuyViewAddress = new System.Windows.Forms.CheckBox();
            this.btnSearchBuyView2 = new System.Windows.Forms.Button();
            this.btnBuyViewBack = new System.Windows.Forms.Button();
            this.btnBuyViewHelp = new System.Windows.Forms.Button();
            this.lblEtest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBuyHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBuyerView)).BeginInit();
            this.pnlBuyViewSearch1.SuspendLayout();
            this.pnlBuyViewSearch.SuspendLayout();
            this.pnlBuyViewSearch2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbViewBuyHome
            // 
            this.pbViewBuyHome.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewBuyHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewBuyHome.Location = new System.Drawing.Point(-139, -4);
            this.pbViewBuyHome.Name = "pbViewBuyHome";
            this.pbViewBuyHome.Size = new System.Drawing.Size(1069, 719);
            this.pbViewBuyHome.TabIndex = 40;
            this.pbViewBuyHome.TabStop = false;
            // 
            // lblBuyersView
            // 
            this.lblBuyersView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBuyersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyersView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuyersView.Location = new System.Drawing.Point(27, 9);
            this.lblBuyersView.Name = "lblBuyersView";
            this.lblBuyersView.Size = new System.Drawing.Size(717, 53);
            this.lblBuyersView.TabIndex = 45;
            this.lblBuyersView.Text = "VIEW BUYERS";
            this.lblBuyersView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbBuyerView
            // 
            this.dbBuyerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbBuyerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBuyerView.Location = new System.Drawing.Point(27, 65);
            this.dbBuyerView.Name = "dbBuyerView";
            this.dbBuyerView.ReadOnly = true;
            this.dbBuyerView.Size = new System.Drawing.Size(717, 212);
            this.dbBuyerView.TabIndex = 46;
            // 
            // pnlBuyViewSearch1
            // 
            this.pnlBuyViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlBuyViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBuyViewSearch1.Controls.Add(this.lblBuyViewHint2);
            this.pnlBuyViewSearch1.Controls.Add(this.pnlBuyViewSearch);
            this.pnlBuyViewSearch1.Controls.Add(this.lblBuyHint);
            this.pnlBuyViewSearch1.Controls.Add(this.pnlBuyViewSearch2);
            this.pnlBuyViewSearch1.Controls.Add(this.btnBuyViewBack);
            this.pnlBuyViewSearch1.Controls.Add(this.btnBuyViewHelp);
            this.pnlBuyViewSearch1.Location = new System.Drawing.Point(27, 306);
            this.pnlBuyViewSearch1.Name = "pnlBuyViewSearch1";
            this.pnlBuyViewSearch1.Size = new System.Drawing.Size(717, 399);
            this.pnlBuyViewSearch1.TabIndex = 47;
            // 
            // lblBuyViewHint2
            // 
            this.lblBuyViewHint2.AutoSize = true;
            this.lblBuyViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuyViewHint2.Location = new System.Drawing.Point(16, 78);
            this.lblBuyViewHint2.Name = "lblBuyViewHint2";
            this.lblBuyViewHint2.Size = new System.Drawing.Size(620, 20);
            this.lblBuyViewHint2.TabIndex = 42;
            this.lblBuyViewHint2.Text = "Select one of the check boxes if you would like to search by a certain criteria";
            // 
            // pnlBuyViewSearch
            // 
            this.pnlBuyViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlBuyViewSearch.Controls.Add(this.btnSearchBuyView1);
            this.pnlBuyViewSearch.Controls.Add(this.lblBuyIDView);
            this.pnlBuyViewSearch.Controls.Add(this.txtBuyIDSearch);
            this.pnlBuyViewSearch.Location = new System.Drawing.Point(13, 32);
            this.pnlBuyViewSearch.Name = "pnlBuyViewSearch";
            this.pnlBuyViewSearch.Size = new System.Drawing.Size(617, 34);
            this.pnlBuyViewSearch.TabIndex = 41;
            // 
            // btnSearchBuyView1
            // 
            this.btnSearchBuyView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchBuyView1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBuyView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchBuyView1.Location = new System.Drawing.Point(500, 0);
            this.btnSearchBuyView1.Name = "btnSearchBuyView1";
            this.btnSearchBuyView1.Size = new System.Drawing.Size(90, 30);
            this.btnSearchBuyView1.TabIndex = 44;
            this.btnSearchBuyView1.Text = "SEARCH";
            this.btnSearchBuyView1.UseVisualStyleBackColor = false;
            this.btnSearchBuyView1.Click += new System.EventHandler(this.btnSearchBuyView1_Click);
            // 
            // lblBuyIDView
            // 
            this.lblBuyIDView.AutoSize = true;
            this.lblBuyIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyIDView.Location = new System.Drawing.Point(10, 7);
            this.lblBuyIDView.Name = "lblBuyIDView";
            this.lblBuyIDView.Size = new System.Drawing.Size(59, 16);
            this.lblBuyIDView.TabIndex = 41;
            this.lblBuyIDView.Text = "Buyer ID";
            // 
            // txtBuyIDSearch
            // 
            this.txtBuyIDSearch.Location = new System.Drawing.Point(310, 5);
            this.txtBuyIDSearch.Name = "txtBuyIDSearch";
            this.txtBuyIDSearch.Size = new System.Drawing.Size(167, 20);
            this.txtBuyIDSearch.TabIndex = 38;
            this.txtBuyIDSearch.Click += new System.EventHandler(this.txtBuyIDSearch_Click);
            this.txtBuyIDSearch.TextChanged += new System.EventHandler(this.txtBuyIDSearch_TextChanged);
            // 
            // lblBuyHint
            // 
            this.lblBuyHint.AutoSize = true;
            this.lblBuyHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuyHint.Location = new System.Drawing.Point(21, 9);
            this.lblBuyHint.Name = "lblBuyHint";
            this.lblBuyHint.Size = new System.Drawing.Size(505, 20);
            this.lblBuyHint.TabIndex = 39;
            this.lblBuyHint.Text = "Enter the BuyerID of the supplier you would like to Search for ";
            // 
            // pnlBuyViewSearch2
            // 
            this.pnlBuyViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlBuyViewSearch2.Controls.Add(this.txtIDNum);
            this.pnlBuyViewSearch2.Controls.Add(this.chkBuyViewPriID);
            this.pnlBuyViewSearch2.Controls.Add(this.txtAddress);
            this.pnlBuyViewSearch2.Controls.Add(this.txtContactNum);
            this.pnlBuyViewSearch2.Controls.Add(this.txtSurname);
            this.pnlBuyViewSearch2.Controls.Add(this.txtName);
            this.pnlBuyViewSearch2.Controls.Add(this.chkBuyViewName);
            this.pnlBuyViewSearch2.Controls.Add(this.chkBuyViewConNum);
            this.pnlBuyViewSearch2.Controls.Add(this.chkBuyViewSurname);
            this.pnlBuyViewSearch2.Controls.Add(this.chkBuyViewAddress);
            this.pnlBuyViewSearch2.Controls.Add(this.btnSearchBuyView2);
            this.pnlBuyViewSearch2.Location = new System.Drawing.Point(13, 101);
            this.pnlBuyViewSearch2.Name = "pnlBuyViewSearch2";
            this.pnlBuyViewSearch2.Size = new System.Drawing.Size(617, 218);
            this.pnlBuyViewSearch2.TabIndex = 29;
            this.pnlBuyViewSearch2.Click += new System.EventHandler(this.pnlBuyViewSearch2_Click);
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(460, 23);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(142, 20);
            this.txtIDNum.TabIndex = 62;
            // 
            // chkBuyViewPriID
            // 
            this.chkBuyViewPriID.BackColor = System.Drawing.Color.FloralWhite;
            this.chkBuyViewPriID.Location = new System.Drawing.Point(310, 18);
            this.chkBuyViewPriID.Name = "chkBuyViewPriID";
            this.chkBuyViewPriID.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkBuyViewPriID.Size = new System.Drawing.Size(302, 30);
            this.chkBuyViewPriID.TabIndex = 61;
            this.chkBuyViewPriID.Text = " ID number";
            this.chkBuyViewPriID.UseVisualStyleBackColor = false;
            this.chkBuyViewPriID.CheckedChanged += new System.EventHandler(this.chkBuyViewPriID_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(288, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 60;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(460, 63);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(142, 20);
            this.txtContactNum.TabIndex = 59;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(152, 63);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSurname.TabIndex = 58;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 57;
            // 
            // chkBuyViewName
            // 
            this.chkBuyViewName.BackColor = System.Drawing.Color.FloralWhite;
            this.chkBuyViewName.Location = new System.Drawing.Point(12, 18);
            this.chkBuyViewName.Name = "chkBuyViewName";
            this.chkBuyViewName.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkBuyViewName.Size = new System.Drawing.Size(292, 30);
            this.chkBuyViewName.TabIndex = 53;
            this.chkBuyViewName.Text = "Name";
            this.chkBuyViewName.UseVisualStyleBackColor = false;
            this.chkBuyViewName.CheckedChanged += new System.EventHandler(this.chkBuyViewName_CheckedChanged);
            // 
            // chkBuyViewConNum
            // 
            this.chkBuyViewConNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkBuyViewConNum.Location = new System.Drawing.Point(310, 58);
            this.chkBuyViewConNum.Name = "chkBuyViewConNum";
            this.chkBuyViewConNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkBuyViewConNum.Size = new System.Drawing.Size(302, 30);
            this.chkBuyViewConNum.TabIndex = 56;
            this.chkBuyViewConNum.Text = "Contact Number";
            this.chkBuyViewConNum.UseVisualStyleBackColor = false;
            this.chkBuyViewConNum.CheckedChanged += new System.EventHandler(this.chkBuyViewConNum_CheckedChanged);
            // 
            // chkBuyViewSurname
            // 
            this.chkBuyViewSurname.BackColor = System.Drawing.Color.FloralWhite;
            this.chkBuyViewSurname.Location = new System.Drawing.Point(12, 58);
            this.chkBuyViewSurname.Name = "chkBuyViewSurname";
            this.chkBuyViewSurname.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkBuyViewSurname.Size = new System.Drawing.Size(292, 30);
            this.chkBuyViewSurname.TabIndex = 55;
            this.chkBuyViewSurname.Text = "Surname";
            this.chkBuyViewSurname.UseVisualStyleBackColor = false;
            this.chkBuyViewSurname.CheckedChanged += new System.EventHandler(this.chkBuyViewSurname_CheckedChanged);
            // 
            // chkBuyViewAddress
            // 
            this.chkBuyViewAddress.BackColor = System.Drawing.Color.FloralWhite;
            this.chkBuyViewAddress.Location = new System.Drawing.Point(152, 103);
            this.chkBuyViewAddress.Name = "chkBuyViewAddress";
            this.chkBuyViewAddress.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkBuyViewAddress.Size = new System.Drawing.Size(300, 30);
            this.chkBuyViewAddress.TabIndex = 54;
            this.chkBuyViewAddress.Text = "Address";
            this.chkBuyViewAddress.UseVisualStyleBackColor = false;
            this.chkBuyViewAddress.CheckedChanged += new System.EventHandler(this.chkBuyViewAddress_CheckedChanged);
            // 
            // btnSearchBuyView2
            // 
            this.btnSearchBuyView2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchBuyView2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBuyView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchBuyView2.Location = new System.Drawing.Point(13, 163);
            this.btnSearchBuyView2.Name = "btnSearchBuyView2";
            this.btnSearchBuyView2.Size = new System.Drawing.Size(599, 45);
            this.btnSearchBuyView2.TabIndex = 43;
            this.btnSearchBuyView2.Text = "S E A R C H  F O R  B U Y E R";
            this.btnSearchBuyView2.UseVisualStyleBackColor = false;
            this.btnSearchBuyView2.Click += new System.EventHandler(this.btnSearchBuyView2_Click);
            // 
            // btnBuyViewBack
            // 
            this.btnBuyViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuyViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuyViewBack.Location = new System.Drawing.Point(550, 338);
            this.btnBuyViewBack.Name = "btnBuyViewBack";
            this.btnBuyViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnBuyViewBack.TabIndex = 52;
            this.btnBuyViewBack.Text = "B A C K";
            this.btnBuyViewBack.UseVisualStyleBackColor = false;
            this.btnBuyViewBack.Click += new System.EventHandler(this.btnBuyViewBack_Click);
            // 
            // btnBuyViewHelp
            // 
            this.btnBuyViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuyViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuyViewHelp.Location = new System.Drawing.Point(13, 338);
            this.btnBuyViewHelp.Name = "btnBuyViewHelp";
            this.btnBuyViewHelp.Size = new System.Drawing.Size(80, 45);
            this.btnBuyViewHelp.TabIndex = 45;
            this.btnBuyViewHelp.Text = "H E L P";
            this.btnBuyViewHelp.UseVisualStyleBackColor = false;
            this.btnBuyViewHelp.Click += new System.EventHandler(this.btnBuyViewHelp_Click);
            // 
            // lblEtest
            // 
            this.lblEtest.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEtest.Location = new System.Drawing.Point(27, 280);
            this.lblEtest.Name = "lblEtest";
            this.lblEtest.Size = new System.Drawing.Size(717, 23);
            this.lblEtest.TabIndex = 48;
            this.lblEtest.Text = "If EmployeeID \"Etest123\", buyer was added by an admin.";
            this.lblEtest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuyers_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.lblEtest);
            this.Controls.Add(this.pnlBuyViewSearch1);
            this.Controls.Add(this.dbBuyerView);
            this.Controls.Add(this.lblBuyersView);
            this.Controls.Add(this.pbViewBuyHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 750);
            this.MinimumSize = new System.Drawing.Size(806, 726);
            this.Name = "frmBuyers_View";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Buyers";
            this.Load += new System.EventHandler(this.FrmBuyers_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewBuyHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBuyerView)).EndInit();
            this.pnlBuyViewSearch1.ResumeLayout(false);
            this.pnlBuyViewSearch1.PerformLayout();
            this.pnlBuyViewSearch.ResumeLayout(false);
            this.pnlBuyViewSearch.PerformLayout();
            this.pnlBuyViewSearch2.ResumeLayout(false);
            this.pnlBuyViewSearch2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewBuyHome;
        private System.Windows.Forms.Label lblBuyersView;
        private System.Windows.Forms.DataGridView dbBuyerView;
        private System.Windows.Forms.Panel pnlBuyViewSearch1;
        private System.Windows.Forms.Label lblBuyViewHint2;
        private System.Windows.Forms.Panel pnlBuyViewSearch;
        private System.Windows.Forms.Button btnSearchBuyView1;
        private System.Windows.Forms.Label lblBuyIDView;
        private System.Windows.Forms.TextBox txtBuyIDSearch;
        private System.Windows.Forms.Label lblBuyHint;
        private System.Windows.Forms.Panel pnlBuyViewSearch2;
        private System.Windows.Forms.Button btnBuyViewBack;
        private System.Windows.Forms.Button btnBuyViewHelp;
        private System.Windows.Forms.Button btnSearchBuyView2;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.CheckBox chkBuyViewPriID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkBuyViewName;
        private System.Windows.Forms.CheckBox chkBuyViewConNum;
        private System.Windows.Forms.CheckBox chkBuyViewSurname;
        private System.Windows.Forms.CheckBox chkBuyViewAddress;
        private System.Windows.Forms.Label lblEtest;
    }
}