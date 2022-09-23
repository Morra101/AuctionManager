
namespace Auction_Manager
{
    partial class frmEmployees_Edit
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
            this.dbEmployeeEdit = new System.Windows.Forms.DataGridView();
            this.lblEmployeeHint2 = new System.Windows.Forms.Label();
            this.lblEmployeeHint1 = new System.Windows.Forms.Label();
            this.chkEmployeePassword = new System.Windows.Forms.CheckBox();
            this.btnEmployeeEditHelp = new System.Windows.Forms.Button();
            this.btnEmployeeEditBack = new System.Windows.Forms.Button();
            this.pnlEmployeeEditEmpID = new System.Windows.Forms.Panel();
            this.cmbEmpEdit = new System.Windows.Forms.ComboBox();
            this.btnEmployeeEditSelect = new System.Windows.Forms.Button();
            this.lblEmployeeIDView = new System.Windows.Forms.Label();
            this.txtEmployeeEditPIDNum = new System.Windows.Forms.TextBox();
            this.txtEmployeeEditSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeEditName = new System.Windows.Forms.TextBox();
            this.chkEmployeeEditName = new System.Windows.Forms.CheckBox();
            this.chkEmployeeIDNumber = new System.Windows.Forms.CheckBox();
            this.chkEmployeeEditSurname = new System.Windows.Forms.CheckBox();
            this.pnlEmployeeEditSearch2 = new System.Windows.Forms.Panel();
            this.btnEditEmployeeApply = new System.Windows.Forms.Button();
            this.txtEmployeeEditPassword = new System.Windows.Forms.TextBox();
            this.lblEmployeeEditHeading = new System.Windows.Forms.Label();
            this.pnlEmployeeEdit1 = new System.Windows.Forms.Panel();
            this.chkEditEmployee = new System.Windows.Forms.CheckBox();
            this.chkEditAdmin = new System.Windows.Forms.CheckBox();
            this.pbEmployeeEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeEdit)).BeginInit();
            this.pnlEmployeeEditEmpID.SuspendLayout();
            this.pnlEmployeeEditSearch2.SuspendLayout();
            this.pnlEmployeeEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dbEmployeeEdit
            // 
            this.dbEmployeeEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbEmployeeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEmployeeEdit.Location = new System.Drawing.Point(45, 92);
            this.dbEmployeeEdit.Name = "dbEmployeeEdit";
            this.dbEmployeeEdit.ReadOnly = true;
            this.dbEmployeeEdit.Size = new System.Drawing.Size(717, 232);
            this.dbEmployeeEdit.TabIndex = 43;
            // 
            // lblEmployeeHint2
            // 
            this.lblEmployeeHint2.AutoSize = true;
            this.lblEmployeeHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeeHint2.Location = new System.Drawing.Point(45, 117);
            this.lblEmployeeHint2.Name = "lblEmployeeHint2";
            this.lblEmployeeHint2.Size = new System.Drawing.Size(614, 20);
            this.lblEmployeeHint2.TabIndex = 42;
            this.lblEmployeeHint2.Text = "Select the check box of the field you would like to edit and enter new values";
            // 
            // lblEmployeeHint1
            // 
            this.lblEmployeeHint1.AutoSize = true;
            this.lblEmployeeHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeeHint1.Location = new System.Drawing.Point(45, 57);
            this.lblEmployeeHint1.Name = "lblEmployeeHint1";
            this.lblEmployeeHint1.Size = new System.Drawing.Size(597, 20);
            this.lblEmployeeHint1.TabIndex = 39;
            this.lblEmployeeHint1.Text = "Select the UserID(AdminId/EmployeeID) of the user you would like to edit";
            // 
            // chkEmployeePassword
            // 
            this.chkEmployeePassword.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmployeePassword.Location = new System.Drawing.Point(312, 48);
            this.chkEmployeePassword.Name = "chkEmployeePassword";
            this.chkEmployeePassword.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmployeePassword.Size = new System.Drawing.Size(292, 30);
            this.chkEmployeePassword.TabIndex = 30;
            this.chkEmployeePassword.Text = "Password";
            this.chkEmployeePassword.UseVisualStyleBackColor = false;
            this.chkEmployeePassword.CheckedChanged += new System.EventHandler(this.ChkEmployeeEditSurname_CheckedChanged);
            // 
            // btnEmployeeEditHelp
            // 
            this.btnEmployeeEditHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditHelp.Location = new System.Drawing.Point(45, 694);
            this.btnEmployeeEditHelp.Name = "btnEmployeeEditHelp";
            this.btnEmployeeEditHelp.Size = new System.Drawing.Size(117, 45);
            this.btnEmployeeEditHelp.TabIndex = 46;
            this.btnEmployeeEditHelp.Text = "H E L P";
            this.btnEmployeeEditHelp.UseVisualStyleBackColor = false;
            this.btnEmployeeEditHelp.Click += new System.EventHandler(this.btnEmployeeEditHelp_Click);
            // 
            // btnEmployeeEditBack
            // 
            this.btnEmployeeEditBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditBack.Location = new System.Drawing.Point(645, 694);
            this.btnEmployeeEditBack.Name = "btnEmployeeEditBack";
            this.btnEmployeeEditBack.Size = new System.Drawing.Size(117, 45);
            this.btnEmployeeEditBack.TabIndex = 45;
            this.btnEmployeeEditBack.Text = "B A C K";
            this.btnEmployeeEditBack.UseVisualStyleBackColor = false;
            this.btnEmployeeEditBack.Click += new System.EventHandler(this.btnEmployeeEditBack_Click);
            // 
            // pnlEmployeeEditEmpID
            // 
            this.pnlEmployeeEditEmpID.BackColor = System.Drawing.Color.White;
            this.pnlEmployeeEditEmpID.Controls.Add(this.cmbEmpEdit);
            this.pnlEmployeeEditEmpID.Controls.Add(this.btnEmployeeEditSelect);
            this.pnlEmployeeEditEmpID.Controls.Add(this.lblEmployeeIDView);
            this.pnlEmployeeEditEmpID.Location = new System.Drawing.Point(49, 80);
            this.pnlEmployeeEditEmpID.Name = "pnlEmployeeEditEmpID";
            this.pnlEmployeeEditEmpID.Size = new System.Drawing.Size(617, 34);
            this.pnlEmployeeEditEmpID.TabIndex = 41;
            // 
            // cmbEmpEdit
            // 
            this.cmbEmpEdit.FormattingEnabled = true;
            this.cmbEmpEdit.Location = new System.Drawing.Point(343, 6);
            this.cmbEmpEdit.Name = "cmbEmpEdit";
            this.cmbEmpEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpEdit.TabIndex = 45;
            // 
            // btnEmployeeEditSelect
            // 
            this.btnEmployeeEditSelect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditSelect.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditSelect.Location = new System.Drawing.Point(500, 0);
            this.btnEmployeeEditSelect.Name = "btnEmployeeEditSelect";
            this.btnEmployeeEditSelect.Size = new System.Drawing.Size(90, 30);
            this.btnEmployeeEditSelect.TabIndex = 44;
            this.btnEmployeeEditSelect.Text = "SELECT";
            this.btnEmployeeEditSelect.UseVisualStyleBackColor = false;
            this.btnEmployeeEditSelect.Click += new System.EventHandler(this.BtnEmployeeEditSelect_Click);
            // 
            // lblEmployeeIDView
            // 
            this.lblEmployeeIDView.AutoSize = true;
            this.lblEmployeeIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDView.Location = new System.Drawing.Point(11, 7);
            this.lblEmployeeIDView.Name = "lblEmployeeIDView";
            this.lblEmployeeIDView.Size = new System.Drawing.Size(53, 16);
            this.lblEmployeeIDView.TabIndex = 41;
            this.lblEmployeeIDView.Text = "User ID";
            // 
            // txtEmployeeEditPIDNum
            // 
            this.txtEmployeeEditPIDNum.Location = new System.Drawing.Point(154, 53);
            this.txtEmployeeEditPIDNum.Name = "txtEmployeeEditPIDNum";
            this.txtEmployeeEditPIDNum.Size = new System.Drawing.Size(142, 20);
            this.txtEmployeeEditPIDNum.TabIndex = 35;
            // 
            // txtEmployeeEditSurname
            // 
            this.txtEmployeeEditSurname.Location = new System.Drawing.Point(450, 17);
            this.txtEmployeeEditSurname.Name = "txtEmployeeEditSurname";
            this.txtEmployeeEditSurname.Size = new System.Drawing.Size(142, 20);
            this.txtEmployeeEditSurname.TabIndex = 34;
            // 
            // txtEmployeeEditName
            // 
            this.txtEmployeeEditName.Location = new System.Drawing.Point(154, 17);
            this.txtEmployeeEditName.Name = "txtEmployeeEditName";
            this.txtEmployeeEditName.Size = new System.Drawing.Size(142, 20);
            this.txtEmployeeEditName.TabIndex = 33;
            // 
            // chkEmployeeEditName
            // 
            this.chkEmployeeEditName.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmployeeEditName.Location = new System.Drawing.Point(14, 12);
            this.chkEmployeeEditName.Name = "chkEmployeeEditName";
            this.chkEmployeeEditName.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmployeeEditName.Size = new System.Drawing.Size(292, 30);
            this.chkEmployeeEditName.TabIndex = 29;
            this.chkEmployeeEditName.Text = "Name";
            this.chkEmployeeEditName.UseVisualStyleBackColor = false;
            this.chkEmployeeEditName.CheckedChanged += new System.EventHandler(this.ChkEmployeeEditSurname_CheckedChanged);
            // 
            // chkEmployeeIDNumber
            // 
            this.chkEmployeeIDNumber.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmployeeIDNumber.Location = new System.Drawing.Point(14, 48);
            this.chkEmployeeIDNumber.Name = "chkEmployeeIDNumber";
            this.chkEmployeeIDNumber.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmployeeIDNumber.Size = new System.Drawing.Size(292, 30);
            this.chkEmployeeIDNumber.TabIndex = 32;
            this.chkEmployeeIDNumber.Text = "Personal ID number";
            this.chkEmployeeIDNumber.UseVisualStyleBackColor = false;
            this.chkEmployeeIDNumber.CheckedChanged += new System.EventHandler(this.ChkEmployeeEditSurname_CheckedChanged);
            // 
            // chkEmployeeEditSurname
            // 
            this.chkEmployeeEditSurname.BackColor = System.Drawing.Color.FloralWhite;
            this.chkEmployeeEditSurname.Location = new System.Drawing.Point(312, 12);
            this.chkEmployeeEditSurname.Name = "chkEmployeeEditSurname";
            this.chkEmployeeEditSurname.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkEmployeeEditSurname.Size = new System.Drawing.Size(292, 30);
            this.chkEmployeeEditSurname.TabIndex = 31;
            this.chkEmployeeEditSurname.Text = "Surname";
            this.chkEmployeeEditSurname.UseVisualStyleBackColor = false;
            this.chkEmployeeEditSurname.CheckedChanged += new System.EventHandler(this.ChkEmployeeEditSurname_CheckedChanged);
            // 
            // pnlEmployeeEditSearch2
            // 
            this.pnlEmployeeEditSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlEmployeeEditSearch2.Controls.Add(this.btnEditEmployeeApply);
            this.pnlEmployeeEditSearch2.Controls.Add(this.txtEmployeeEditPassword);
            this.pnlEmployeeEditSearch2.Controls.Add(this.txtEmployeeEditPIDNum);
            this.pnlEmployeeEditSearch2.Controls.Add(this.txtEmployeeEditSurname);
            this.pnlEmployeeEditSearch2.Controls.Add(this.txtEmployeeEditName);
            this.pnlEmployeeEditSearch2.Controls.Add(this.chkEmployeeEditName);
            this.pnlEmployeeEditSearch2.Controls.Add(this.chkEmployeeIDNumber);
            this.pnlEmployeeEditSearch2.Controls.Add(this.chkEmployeeEditSurname);
            this.pnlEmployeeEditSearch2.Controls.Add(this.chkEmployeePassword);
            this.pnlEmployeeEditSearch2.Location = new System.Drawing.Point(49, 143);
            this.pnlEmployeeEditSearch2.Name = "pnlEmployeeEditSearch2";
            this.pnlEmployeeEditSearch2.Size = new System.Drawing.Size(617, 160);
            this.pnlEmployeeEditSearch2.TabIndex = 29;
            // 
            // btnEditEmployeeApply
            // 
            this.btnEditEmployeeApply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditEmployeeApply.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployeeApply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEmployeeApply.Location = new System.Drawing.Point(15, 101);
            this.btnEditEmployeeApply.Name = "btnEditEmployeeApply";
            this.btnEditEmployeeApply.Size = new System.Drawing.Size(589, 45);
            this.btnEditEmployeeApply.TabIndex = 43;
            this.btnEditEmployeeApply.Text = "A P P L Y   C H A N G E S ";
            this.btnEditEmployeeApply.UseVisualStyleBackColor = false;
            this.btnEditEmployeeApply.Click += new System.EventHandler(this.BtnEditEmployeeApply_Click);
            // 
            // txtEmployeeEditPassword
            // 
            this.txtEmployeeEditPassword.Location = new System.Drawing.Point(450, 53);
            this.txtEmployeeEditPassword.Name = "txtEmployeeEditPassword";
            this.txtEmployeeEditPassword.Size = new System.Drawing.Size(142, 20);
            this.txtEmployeeEditPassword.TabIndex = 36;
            // 
            // lblEmployeeEditHeading
            // 
            this.lblEmployeeEditHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeEditHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeEditHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeEditHeading.Location = new System.Drawing.Point(45, 19);
            this.lblEmployeeEditHeading.Name = "lblEmployeeEditHeading";
            this.lblEmployeeEditHeading.Size = new System.Drawing.Size(717, 53);
            this.lblEmployeeEditHeading.TabIndex = 44;
            this.lblEmployeeEditHeading.Text = "EDIT USERS";
            this.lblEmployeeEditHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmployeeEdit1
            // 
            this.pnlEmployeeEdit1.BackColor = System.Drawing.Color.DimGray;
            this.pnlEmployeeEdit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmployeeEdit1.Controls.Add(this.chkEditEmployee);
            this.pnlEmployeeEdit1.Controls.Add(this.lblEmployeeHint2);
            this.pnlEmployeeEdit1.Controls.Add(this.pnlEmployeeEditEmpID);
            this.pnlEmployeeEdit1.Controls.Add(this.chkEditAdmin);
            this.pnlEmployeeEdit1.Controls.Add(this.lblEmployeeHint1);
            this.pnlEmployeeEdit1.Controls.Add(this.pnlEmployeeEditSearch2);
            this.pnlEmployeeEdit1.Location = new System.Drawing.Point(45, 344);
            this.pnlEmployeeEdit1.Name = "pnlEmployeeEdit1";
            this.pnlEmployeeEdit1.Size = new System.Drawing.Size(717, 344);
            this.pnlEmployeeEdit1.TabIndex = 45;
            // 
            // chkEditEmployee
            // 
            this.chkEditEmployee.BackColor = System.Drawing.Color.Goldenrod;
            this.chkEditEmployee.Checked = true;
            this.chkEditEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEditEmployee.Location = new System.Drawing.Point(49, 15);
            this.chkEditEmployee.Name = "chkEditEmployee";
            this.chkEditEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.chkEditEmployee.Size = new System.Drawing.Size(307, 26);
            this.chkEditEmployee.TabIndex = 48;
            this.chkEditEmployee.Text = "Edit Employee Users";
            this.chkEditEmployee.UseVisualStyleBackColor = false;
            this.chkEditEmployee.CheckedChanged += new System.EventHandler(this.ChkEditEmployee_CheckedChanged);
            this.chkEditEmployee.CheckStateChanged += new System.EventHandler(this.ChkEditEmployee_CheckStateChanged);
            // 
            // chkEditAdmin
            // 
            this.chkEditAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.chkEditAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEditAdmin.Location = new System.Drawing.Point(362, 15);
            this.chkEditAdmin.Name = "chkEditAdmin";
            this.chkEditAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.chkEditAdmin.Size = new System.Drawing.Size(307, 26);
            this.chkEditAdmin.TabIndex = 47;
            this.chkEditAdmin.Text = "Edit Admin Users";
            this.chkEditAdmin.UseVisualStyleBackColor = false;
            this.chkEditAdmin.CheckedChanged += new System.EventHandler(this.ChkEditAdmin_CheckedChanged);
            this.chkEditAdmin.CheckStateChanged += new System.EventHandler(this.ChkEditAdmin_CheckStateChanged);
            // 
            // pbEmployeeEdit
            // 
            this.pbEmployeeEdit.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbEmployeeEdit.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbEmployeeEdit.Location = new System.Drawing.Point(-148, 0);
            this.pbEmployeeEdit.Name = "pbEmployeeEdit";
            this.pbEmployeeEdit.Size = new System.Drawing.Size(1069, 752);
            this.pbEmployeeEdit.TabIndex = 46;
            this.pbEmployeeEdit.TabStop = false;
            // 
            // frmEmployees_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.btnEmployeeEditBack);
            this.Controls.Add(this.btnEmployeeEditHelp);
            this.Controls.Add(this.dbEmployeeEdit);
            this.Controls.Add(this.lblEmployeeEditHeading);
            this.Controls.Add(this.pnlEmployeeEdit1);
            this.Controls.Add(this.pbEmployeeEdit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 790);
            this.MinimumSize = new System.Drawing.Size(816, 726);
            this.Name = "frmEmployees_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Employees";
            this.Load += new System.EventHandler(this.FrmEmployees_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeEdit)).EndInit();
            this.pnlEmployeeEditEmpID.ResumeLayout(false);
            this.pnlEmployeeEditEmpID.PerformLayout();
            this.pnlEmployeeEditSearch2.ResumeLayout(false);
            this.pnlEmployeeEditSearch2.PerformLayout();
            this.pnlEmployeeEdit1.ResumeLayout(false);
            this.pnlEmployeeEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbEmployeeEdit;
        private System.Windows.Forms.Label lblEmployeeHint2;
        private System.Windows.Forms.Label lblEmployeeHint1;
        private System.Windows.Forms.CheckBox chkEmployeePassword;
        private System.Windows.Forms.Button btnEmployeeEditHelp;
        private System.Windows.Forms.Button btnEmployeeEditBack;
        private System.Windows.Forms.Panel pnlEmployeeEditEmpID;
        private System.Windows.Forms.Button btnEmployeeEditSelect;
        private System.Windows.Forms.Label lblEmployeeIDView;
        private System.Windows.Forms.TextBox txtEmployeeEditPIDNum;
        private System.Windows.Forms.TextBox txtEmployeeEditSurname;
        private System.Windows.Forms.TextBox txtEmployeeEditName;
        private System.Windows.Forms.CheckBox chkEmployeeEditName;
        private System.Windows.Forms.CheckBox chkEmployeeIDNumber;
        private System.Windows.Forms.CheckBox chkEmployeeEditSurname;
        private System.Windows.Forms.Panel pnlEmployeeEditSearch2;
        private System.Windows.Forms.Button btnEditEmployeeApply;
        private System.Windows.Forms.TextBox txtEmployeeEditPassword;
        private System.Windows.Forms.Label lblEmployeeEditHeading;
        private System.Windows.Forms.Panel pnlEmployeeEdit1;
        private System.Windows.Forms.PictureBox pbEmployeeEdit;
        private System.Windows.Forms.ComboBox cmbEmpEdit;
        private System.Windows.Forms.CheckBox chkEditEmployee;
        private System.Windows.Forms.CheckBox chkEditAdmin;
    }
}