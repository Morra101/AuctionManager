
namespace Auction_Manager
{
    partial class frmEmployees_Delete
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
            this.pnlSuppDeleteSearch1 = new System.Windows.Forms.Panel();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.pnlSuppViewSearch = new System.Windows.Forms.Panel();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.btnSearchEmpDelete = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.lblSupplierDeleteHeading = new System.Windows.Forms.Label();
            this.bynEmpRemoveHelp = new System.Windows.Forms.Button();
            this.dbEmployeeDelete = new System.Windows.Forms.DataGridView();
            this.pbBackSuppDelete = new System.Windows.Forms.PictureBox();
            this.btnEmpRemoveBack = new System.Windows.Forms.Button();
            this.pnlSuppDeleteSearch1.SuspendLayout();
            this.pnlSuppViewSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuppDeleteSearch1
            // 
            this.pnlSuppDeleteSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppDeleteSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppDeleteSearch1.Controls.Add(this.chkEmployee);
            this.pnlSuppDeleteSearch1.Controls.Add(this.chkAdmin);
            this.pnlSuppDeleteSearch1.Controls.Add(this.pnlSuppViewSearch);
            this.pnlSuppDeleteSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppDeleteSearch1.Location = new System.Drawing.Point(72, 283);
            this.pnlSuppDeleteSearch1.Name = "pnlSuppDeleteSearch1";
            this.pnlSuppDeleteSearch1.Size = new System.Drawing.Size(717, 108);
            this.pnlSuppDeleteSearch1.TabIndex = 61;
            // 
            // chkEmployee
            // 
            this.chkEmployee.BackColor = System.Drawing.Color.Goldenrod;
            this.chkEmployee.Checked = true;
            this.chkEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEmployee.Location = new System.Drawing.Point(357, 3);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.chkEmployee.Size = new System.Drawing.Size(253, 26);
            this.chkEmployee.TabIndex = 46;
            this.chkEmployee.Text = "View Employee Users";
            this.chkEmployee.UseVisualStyleBackColor = false;
            this.chkEmployee.CheckedChanged += new System.EventHandler(this.ChkEmployee_CheckedChanged);
            // 
            // chkAdmin
            // 
            this.chkAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.chkAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdmin.Location = new System.Drawing.Point(101, 3);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.chkAdmin.Size = new System.Drawing.Size(253, 26);
            this.chkAdmin.TabIndex = 45;
            this.chkAdmin.Text = "View Admin Users";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.ChkAdmin_CheckedChanged);
            // 
            // pnlSuppViewSearch
            // 
            this.pnlSuppViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlSuppViewSearch.Controls.Add(this.cmbEmployeeID);
            this.pnlSuppViewSearch.Controls.Add(this.btnSearchEmpDelete);
            this.pnlSuppViewSearch.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppViewSearch.Location = new System.Drawing.Point(101, 61);
            this.pnlSuppViewSearch.Name = "pnlSuppViewSearch";
            this.pnlSuppViewSearch.Size = new System.Drawing.Size(509, 34);
            this.pnlSuppViewSearch.TabIndex = 41;
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Items.AddRange(new object[] {
            "00000124",
            "00000125",
            "00000126",
            "00000127",
            "00000128",
            "00000129",
            "00000130"});
            this.cmbEmployeeID.Location = new System.Drawing.Point(255, 6);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(146, 21);
            this.cmbEmployeeID.TabIndex = 45;
            // 
            // btnSearchEmpDelete
            // 
            this.btnSearchEmpDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchEmpDelete.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmpDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEmpDelete.Location = new System.Drawing.Point(407, 3);
            this.btnSearchEmpDelete.Name = "btnSearchEmpDelete";
            this.btnSearchEmpDelete.Size = new System.Drawing.Size(90, 30);
            this.btnSearchEmpDelete.TabIndex = 44;
            this.btnSearchEmpDelete.Text = "REMOVE ";
            this.btnSearchEmpDelete.UseVisualStyleBackColor = false;
            this.btnSearchEmpDelete.Click += new System.EventHandler(this.BtnSearchEmpDelete_Click);
            // 
            // lblSupplierIDView
            // 
            this.lblSupplierIDView.AutoSize = true;
            this.lblSupplierIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDView.Location = new System.Drawing.Point(10, 7);
            this.lblSupplierIDView.Name = "lblSupplierIDView";
            this.lblSupplierIDView.Size = new System.Drawing.Size(53, 16);
            this.lblSupplierIDView.TabIndex = 41;
            this.lblSupplierIDView.Text = "User ID";
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(97, 38);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(486, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Select the UserID of the employee you would like to remove";
            // 
            // lblSupplierDeleteHeading
            // 
            this.lblSupplierDeleteHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierDeleteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDeleteHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierDeleteHeading.Location = new System.Drawing.Point(72, -3);
            this.lblSupplierDeleteHeading.Name = "lblSupplierDeleteHeading";
            this.lblSupplierDeleteHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSupplierDeleteHeading.TabIndex = 60;
            this.lblSupplierDeleteHeading.Text = "REMOVE USER";
            this.lblSupplierDeleteHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bynEmpRemoveHelp
            // 
            this.bynEmpRemoveHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bynEmpRemoveHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynEmpRemoveHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bynEmpRemoveHelp.Location = new System.Drawing.Point(80, 397);
            this.bynEmpRemoveHelp.Name = "bynEmpRemoveHelp";
            this.bynEmpRemoveHelp.Size = new System.Drawing.Size(117, 45);
            this.bynEmpRemoveHelp.TabIndex = 63;
            this.bynEmpRemoveHelp.Text = "H E L P";
            this.bynEmpRemoveHelp.UseVisualStyleBackColor = false;
            this.bynEmpRemoveHelp.Click += new System.EventHandler(this.bynEmpRemoveHelp_Click);
            // 
            // dbEmployeeDelete
            // 
            this.dbEmployeeDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEmployeeDelete.Location = new System.Drawing.Point(72, 53);
            this.dbEmployeeDelete.Name = "dbEmployeeDelete";
            this.dbEmployeeDelete.ReadOnly = true;
            this.dbEmployeeDelete.Size = new System.Drawing.Size(717, 224);
            this.dbEmployeeDelete.TabIndex = 65;
            // 
            // pbBackSuppDelete
            // 
            this.pbBackSuppDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Location = new System.Drawing.Point(-221, -3);
            this.pbBackSuppDelete.Name = "pbBackSuppDelete";
            this.pbBackSuppDelete.Size = new System.Drawing.Size(1076, 719);
            this.pbBackSuppDelete.TabIndex = 62;
            this.pbBackSuppDelete.TabStop = false;
            // 
            // btnEmpRemoveBack
            // 
            this.btnEmpRemoveBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmpRemoveBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpRemoveBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpRemoveBack.Location = new System.Drawing.Point(672, 397);
            this.btnEmpRemoveBack.Name = "btnEmpRemoveBack";
            this.btnEmpRemoveBack.Size = new System.Drawing.Size(117, 45);
            this.btnEmpRemoveBack.TabIndex = 64;
            this.btnEmpRemoveBack.Text = "B A C K";
            this.btnEmpRemoveBack.UseVisualStyleBackColor = false;
            this.btnEmpRemoveBack.Click += new System.EventHandler(this.btnSuppBackToLand_Click);
            // 
            // frmEmployees_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.pnlSuppDeleteSearch1);
            this.Controls.Add(this.lblSupplierDeleteHeading);
            this.Controls.Add(this.bynEmpRemoveHelp);
            this.Controls.Add(this.dbEmployeeDelete);
            this.Controls.Add(this.btnEmpRemoveBack);
            this.Controls.Add(this.pbBackSuppDelete);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(867, 505);
            this.MinimumSize = new System.Drawing.Size(867, 505);
            this.Name = "frmEmployees_Delete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Employee";
            this.Load += new System.EventHandler(this.FrmEmployees_Delete_Load);
            this.pnlSuppDeleteSearch1.ResumeLayout(false);
            this.pnlSuppDeleteSearch1.PerformLayout();
            this.pnlSuppViewSearch.ResumeLayout(false);
            this.pnlSuppViewSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmployeeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppDeleteSearch1;
        private System.Windows.Forms.Panel pnlSuppViewSearch;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Button btnSearchEmpDelete;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Label lblSupplierDeleteHeading;
        private System.Windows.Forms.Button bynEmpRemoveHelp;
        private System.Windows.Forms.DataGridView dbEmployeeDelete;
        private System.Windows.Forms.PictureBox pbBackSuppDelete;
        private System.Windows.Forms.Button btnEmpRemoveBack;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.CheckBox chkAdmin;
    }
}