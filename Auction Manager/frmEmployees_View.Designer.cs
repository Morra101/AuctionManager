
namespace Auction_Manager
{
    partial class frmEmployees_View
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
            this.btnSearchEmpView1 = new System.Windows.Forms.Button();
            this.txtEmpIDSearch = new System.Windows.Forms.TextBox();
            this.pnlEmpViewSearch = new System.Windows.Forms.Panel();
            this.lblEmpIDView = new System.Windows.Forms.Label();
            this.pnlEmpViewSearch1 = new System.Windows.Forms.Panel();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.lblEmpViewHint2 = new System.Windows.Forms.Label();
            this.lblEmpHint = new System.Windows.Forms.Label();
            this.pnlEmpViewSearch2 = new System.Windows.Forms.Panel();
            this.btnEmpViewResetFilter = new System.Windows.Forms.Button();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.chkEmpViewID = new System.Windows.Forms.CheckBox();
            this.btnSearchEmpView2 = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkEmpViewName = new System.Windows.Forms.CheckBox();
            this.chkEmpViewSurname = new System.Windows.Forms.CheckBox();
            this.btnEmpViewBack = new System.Windows.Forms.Button();
            this.btnEmpViewHelp = new System.Windows.Forms.Button();
            this.pbViewEmpHome = new System.Windows.Forms.PictureBox();
            this.lblEmpView = new System.Windows.Forms.Label();
            this.dbEmployeeView = new System.Windows.Forms.DataGridView();
            this.pnlEmpViewSearch.SuspendLayout();
            this.pnlEmpViewSearch1.SuspendLayout();
            this.pnlEmpViewSearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewEmpHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmpView1
            // 
            this.btnSearchEmpView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchEmpView1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmpView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEmpView1.Location = new System.Drawing.Point(500, 0);
            this.btnSearchEmpView1.Name = "btnSearchEmpView1";
            this.btnSearchEmpView1.Size = new System.Drawing.Size(90, 30);
            this.btnSearchEmpView1.TabIndex = 2;
            this.btnSearchEmpView1.Text = "SEARCH";
            this.btnSearchEmpView1.UseVisualStyleBackColor = false;
            this.btnSearchEmpView1.Click += new System.EventHandler(this.BtnSearchEmpView1_Click);
            // 
            // txtEmpIDSearch
            // 
            this.txtEmpIDSearch.Location = new System.Drawing.Point(311, 6);
            this.txtEmpIDSearch.Name = "txtEmpIDSearch";
            this.txtEmpIDSearch.Size = new System.Drawing.Size(167, 20);
            this.txtEmpIDSearch.TabIndex = 1;
            this.txtEmpIDSearch.Click += new System.EventHandler(this.TxtEmpIDSearch_Click);
            this.txtEmpIDSearch.TextChanged += new System.EventHandler(this.TxtEmpIDSearch_TextChanged);
            // 
            // pnlEmpViewSearch
            // 
            this.pnlEmpViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlEmpViewSearch.Controls.Add(this.btnSearchEmpView1);
            this.pnlEmpViewSearch.Controls.Add(this.lblEmpIDView);
            this.pnlEmpViewSearch.Controls.Add(this.txtEmpIDSearch);
            this.pnlEmpViewSearch.Location = new System.Drawing.Point(43, 76);
            this.pnlEmpViewSearch.Name = "pnlEmpViewSearch";
            this.pnlEmpViewSearch.Size = new System.Drawing.Size(617, 34);
            this.pnlEmpViewSearch.TabIndex = 0;
            // 
            // lblEmpIDView
            // 
            this.lblEmpIDView.AutoSize = true;
            this.lblEmpIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpIDView.Location = new System.Drawing.Point(10, 7);
            this.lblEmpIDView.Name = "lblEmpIDView";
            this.lblEmpIDView.Size = new System.Drawing.Size(53, 16);
            this.lblEmpIDView.TabIndex = 41;
            this.lblEmpIDView.Text = "User ID";
            // 
            // pnlEmpViewSearch1
            // 
            this.pnlEmpViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlEmpViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmpViewSearch1.Controls.Add(this.chkEmployee);
            this.pnlEmpViewSearch1.Controls.Add(this.chkAdmin);
            this.pnlEmpViewSearch1.Controls.Add(this.lblEmpViewHint2);
            this.pnlEmpViewSearch1.Controls.Add(this.pnlEmpViewSearch);
            this.pnlEmpViewSearch1.Controls.Add(this.lblEmpHint);
            this.pnlEmpViewSearch1.Controls.Add(this.pnlEmpViewSearch2);
            this.pnlEmpViewSearch1.Location = new System.Drawing.Point(35, 277);
            this.pnlEmpViewSearch1.Name = "pnlEmpViewSearch1";
            this.pnlEmpViewSearch1.Size = new System.Drawing.Size(717, 324);
            this.pnlEmpViewSearch1.TabIndex = 0;
            // 
            // chkEmployee
            // 
            this.chkEmployee.BackColor = System.Drawing.Color.Goldenrod;
            this.chkEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEmployee.Location = new System.Drawing.Point(353, 3);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.chkEmployee.Size = new System.Drawing.Size(307, 26);
            this.chkEmployee.TabIndex = 44;
            this.chkEmployee.Text = "View Employee Users";
            this.chkEmployee.UseVisualStyleBackColor = false;
            this.chkEmployee.CheckedChanged += new System.EventHandler(this.ChkEmployee_CheckedChanged);
            // 
            // chkAdmin
            // 
            this.chkAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.chkAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdmin.Location = new System.Drawing.Point(43, 3);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.chkAdmin.Size = new System.Drawing.Size(307, 26);
            this.chkAdmin.TabIndex = 43;
            this.chkAdmin.Text = "View Admin Users";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.ChkAdmin_CheckedChanged);
            // 
            // lblEmpViewHint2
            // 
            this.lblEmpViewHint2.AutoSize = true;
            this.lblEmpViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpViewHint2.Location = new System.Drawing.Point(40, 122);
            this.lblEmpViewHint2.Name = "lblEmpViewHint2";
            this.lblEmpViewHint2.Size = new System.Drawing.Size(564, 20);
            this.lblEmpViewHint2.TabIndex = 42;
            this.lblEmpViewHint2.Text = "Select the check boxes if you would like to search by a certain criteria";
            // 
            // lblEmpHint
            // 
            this.lblEmpHint.AutoSize = true;
            this.lblEmpHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpHint.Location = new System.Drawing.Point(40, 44);
            this.lblEmpHint.Name = "lblEmpHint";
            this.lblEmpHint.Size = new System.Drawing.Size(466, 20);
            this.lblEmpHint.TabIndex = 39;
            this.lblEmpHint.Text = "Enter the UserID of the user you would like to search for ";
            // 
            // pnlEmpViewSearch2
            // 
            this.pnlEmpViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlEmpViewSearch2.Controls.Add(this.btnEmpViewResetFilter);
            this.pnlEmpViewSearch2.Controls.Add(this.txtIDNum);
            this.pnlEmpViewSearch2.Controls.Add(this.chkEmpViewID);
            this.pnlEmpViewSearch2.Controls.Add(this.btnSearchEmpView2);
            this.pnlEmpViewSearch2.Controls.Add(this.txtSurname);
            this.pnlEmpViewSearch2.Controls.Add(this.txtName);
            this.pnlEmpViewSearch2.Controls.Add(this.chkEmpViewName);
            this.pnlEmpViewSearch2.Controls.Add(this.chkEmpViewSurname);
            this.pnlEmpViewSearch2.Location = new System.Drawing.Point(43, 145);
            this.pnlEmpViewSearch2.Name = "pnlEmpViewSearch2";
            this.pnlEmpViewSearch2.Size = new System.Drawing.Size(617, 163);
            this.pnlEmpViewSearch2.TabIndex = 1;
            // 
            // btnEmpViewResetFilter
            // 
            this.btnEmpViewResetFilter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmpViewResetFilter.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpViewResetFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpViewResetFilter.Location = new System.Drawing.Point(302, 121);
            this.btnEmpViewResetFilter.Name = "btnEmpViewResetFilter";
            this.btnEmpViewResetFilter.Size = new System.Drawing.Size(150, 36);
            this.btnEmpViewResetFilter.TabIndex = 3;
            this.btnEmpViewResetFilter.Text = "RESET FILTERS";
            this.btnEmpViewResetFilter.UseVisualStyleBackColor = false;
            this.btnEmpViewResetFilter.Click += new System.EventHandler(this.BtnEmpViewResetFilter_Click);
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(448, 90);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(142, 20);
            this.txtIDNum.TabIndex = 2;
            // 
            // chkEmpViewID
            // 
            this.chkEmpViewID.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmpViewID.Location = new System.Drawing.Point(13, 85);
            this.chkEmpViewID.Name = "chkEmpViewID";
            this.chkEmpViewID.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmpViewID.Size = new System.Drawing.Size(588, 30);
            this.chkEmpViewID.TabIndex = 47;
            this.chkEmpViewID.Text = "ID number";
            this.chkEmpViewID.UseVisualStyleBackColor = false;
            this.chkEmpViewID.CheckedChanged += new System.EventHandler(this.ChkEmpViewID_CheckedChanged);
            // 
            // btnSearchEmpView2
            // 
            this.btnSearchEmpView2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchEmpView2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmpView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEmpView2.Location = new System.Drawing.Point(458, 121);
            this.btnSearchEmpView2.Name = "btnSearchEmpView2";
            this.btnSearchEmpView2.Size = new System.Drawing.Size(150, 36);
            this.btnSearchEmpView2.TabIndex = 4;
            this.btnSearchEmpView2.Text = "APPLY FILTER";
            this.btnSearchEmpView2.UseVisualStyleBackColor = false;
            this.btnSearchEmpView2.Click += new System.EventHandler(this.BtnSearchEmpView2_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(448, 55);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(448, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 0;
            // 
            // chkEmpViewName
            // 
            this.chkEmpViewName.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmpViewName.Location = new System.Drawing.Point(13, 15);
            this.chkEmpViewName.Name = "chkEmpViewName";
            this.chkEmpViewName.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmpViewName.Size = new System.Drawing.Size(588, 30);
            this.chkEmpViewName.TabIndex = 29;
            this.chkEmpViewName.Text = "Name";
            this.chkEmpViewName.UseVisualStyleBackColor = false;
            this.chkEmpViewName.CheckedChanged += new System.EventHandler(this.ChkEmpViewName_CheckedChanged);
            // 
            // chkEmpViewSurname
            // 
            this.chkEmpViewSurname.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmpViewSurname.Location = new System.Drawing.Point(13, 50);
            this.chkEmpViewSurname.Name = "chkEmpViewSurname";
            this.chkEmpViewSurname.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmpViewSurname.Size = new System.Drawing.Size(588, 30);
            this.chkEmpViewSurname.TabIndex = 31;
            this.chkEmpViewSurname.Text = "Surname";
            this.chkEmpViewSurname.UseVisualStyleBackColor = false;
            this.chkEmpViewSurname.CheckedChanged += new System.EventHandler(this.ChkEmpViewSurname_CheckedChanged);
            // 
            // btnEmpViewBack
            // 
            this.btnEmpViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmpViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpViewBack.Location = new System.Drawing.Point(672, 607);
            this.btnEmpViewBack.Name = "btnEmpViewBack";
            this.btnEmpViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnEmpViewBack.TabIndex = 2;
            this.btnEmpViewBack.Text = "B A C K";
            this.btnEmpViewBack.UseVisualStyleBackColor = false;
            this.btnEmpViewBack.Click += new System.EventHandler(this.btnEmpViewBack_Click);
            // 
            // btnEmpViewHelp
            // 
            this.btnEmpViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmpViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpViewHelp.Location = new System.Drawing.Point(35, 607);
            this.btnEmpViewHelp.Name = "btnEmpViewHelp";
            this.btnEmpViewHelp.Size = new System.Drawing.Size(80, 45);
            this.btnEmpViewHelp.TabIndex = 1;
            this.btnEmpViewHelp.Text = "H E L P";
            this.btnEmpViewHelp.UseVisualStyleBackColor = false;
            this.btnEmpViewHelp.Click += new System.EventHandler(this.btnEmpViewHelp_Click);
            // 
            // pbViewEmpHome
            // 
            this.pbViewEmpHome.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewEmpHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbViewEmpHome.Location = new System.Drawing.Point(-139, -4);
            this.pbViewEmpHome.Name = "pbViewEmpHome";
            this.pbViewEmpHome.Size = new System.Drawing.Size(1069, 719);
            this.pbViewEmpHome.TabIndex = 42;
            this.pbViewEmpHome.TabStop = false;
            // 
            // lblEmpView
            // 
            this.lblEmpView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpView.Location = new System.Drawing.Point(35, 9);
            this.lblEmpView.Name = "lblEmpView";
            this.lblEmpView.Size = new System.Drawing.Size(720, 53);
            this.lblEmpView.TabIndex = 1;
            this.lblEmpView.Text = "VIEW USERS";
            this.lblEmpView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbEmployeeView
            // 
            this.dbEmployeeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEmployeeView.Location = new System.Drawing.Point(35, 56);
            this.dbEmployeeView.Name = "dbEmployeeView";
            this.dbEmployeeView.ReadOnly = true;
            this.dbEmployeeView.Size = new System.Drawing.Size(717, 215);
            this.dbEmployeeView.TabIndex = 3;
            // 
            // frmEmployees_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.dbEmployeeView);
            this.Controls.Add(this.lblEmpView);
            this.Controls.Add(this.btnEmpViewBack);
            this.Controls.Add(this.btnEmpViewHelp);
            this.Controls.Add(this.pnlEmpViewSearch1);
            this.Controls.Add(this.pbViewEmpHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 750);
            this.MinimumSize = new System.Drawing.Size(806, 726);
            this.Name = "frmEmployees_View";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmployees_View";
            this.Load += new System.EventHandler(this.FrmEmployees_View_Load);
            this.pnlEmpViewSearch.ResumeLayout(false);
            this.pnlEmpViewSearch.PerformLayout();
            this.pnlEmpViewSearch1.ResumeLayout(false);
            this.pnlEmpViewSearch1.PerformLayout();
            this.pnlEmpViewSearch2.ResumeLayout(false);
            this.pnlEmpViewSearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewEmpHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchEmpView1;
        private System.Windows.Forms.TextBox txtEmpIDSearch;
        private System.Windows.Forms.Panel pnlEmpViewSearch;
        private System.Windows.Forms.Label lblEmpIDView;
        private System.Windows.Forms.Panel pnlEmpViewSearch1;
        private System.Windows.Forms.Label lblEmpViewHint2;
        private System.Windows.Forms.Label lblEmpHint;
        private System.Windows.Forms.Panel pnlEmpViewSearch2;
        private System.Windows.Forms.Button btnEmpViewBack;
        private System.Windows.Forms.Button btnEmpViewHelp;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.CheckBox chkEmpViewID;
        private System.Windows.Forms.Button btnSearchEmpView2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkEmpViewName;
        private System.Windows.Forms.CheckBox chkEmpViewSurname;
        private System.Windows.Forms.PictureBox pbViewEmpHome;
        private System.Windows.Forms.Label lblEmpView;
        private System.Windows.Forms.DataGridView dbEmployeeView;
        private System.Windows.Forms.Button btnEmpViewResetFilter;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.CheckBox chkAdmin;
    }
}