
namespace Auction_Manager
{
    partial class frmSuppliers_Edit
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
            this.lblSupplierViewHint2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.pnlSuppEdit1 = new System.Windows.Forms.Panel();
            this.btnSuppEditHelp = new System.Windows.Forms.Button();
            this.btnSupplierEditBack = new System.Windows.Forms.Button();
            this.pnlSuppEditSuppID = new System.Windows.Forms.Panel();
            this.cmbSuppEditSupID = new System.Windows.Forms.ComboBox();
            this.txtSuppEditSelect = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.pnlSuppEdit2 = new System.Windows.Forms.Panel();
            this.txtSuppEditBusRegNum = new System.Windows.Forms.TextBox();
            this.chkSuppEditBusRegNum = new System.Windows.Forms.CheckBox();
            this.btnSuppApplyEdit = new System.Windows.Forms.Button();
            this.txtSuppEditAddress = new System.Windows.Forms.TextBox();
            this.txtSuppEditIDNum = new System.Windows.Forms.TextBox();
            this.txtSuppEditSurname = new System.Windows.Forms.TextBox();
            this.txtSuppEditName = new System.Windows.Forms.TextBox();
            this.chkSupplierEditName = new System.Windows.Forms.CheckBox();
            this.chkSupplierEditIDNum = new System.Windows.Forms.CheckBox();
            this.chkSupplierEditSurname = new System.Windows.Forms.CheckBox();
            this.chkSupplierEditAddress = new System.Windows.Forms.CheckBox();
            this.lblSupplierEdit = new System.Windows.Forms.Label();
            this.dbSupplierEdit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSuppEdit1.SuspendLayout();
            this.pnlSuppEditSuppID.SuspendLayout();
            this.pnlSuppEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSupplierEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplierViewHint2
            // 
            this.lblSupplierViewHint2.AutoSize = true;
            this.lblSupplierViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSupplierViewHint2.Location = new System.Drawing.Point(16, 78);
            this.lblSupplierViewHint2.Name = "lblSupplierViewHint2";
            this.lblSupplierViewHint2.Size = new System.Drawing.Size(439, 20);
            this.lblSupplierViewHint2.TabIndex = 42;
            this.lblSupplierViewHint2.Text = "Select the check box of the field you would like to edit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Location = new System.Drawing.Point(-158, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 719);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(21, 9);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(475, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Select the SupplierID of the supplier you would like to Edit";
            // 
            // pnlSuppEdit1
            // 
            this.pnlSuppEdit1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppEdit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppEdit1.Controls.Add(this.btnSuppEditHelp);
            this.pnlSuppEdit1.Controls.Add(this.btnSupplierEditBack);
            this.pnlSuppEdit1.Controls.Add(this.lblSupplierViewHint2);
            this.pnlSuppEdit1.Controls.Add(this.pnlSuppEditSuppID);
            this.pnlSuppEdit1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppEdit1.Controls.Add(this.pnlSuppEdit2);
            this.pnlSuppEdit1.Location = new System.Drawing.Point(35, 343);
            this.pnlSuppEdit1.Name = "pnlSuppEdit1";
            this.pnlSuppEdit1.Size = new System.Drawing.Size(717, 351);
            this.pnlSuppEdit1.TabIndex = 41;
            // 
            // btnSuppEditHelp
            // 
            this.btnSuppEditHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppEditHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppEditHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppEditHelp.Location = new System.Drawing.Point(13, 287);
            this.btnSuppEditHelp.Name = "btnSuppEditHelp";
            this.btnSuppEditHelp.Size = new System.Drawing.Size(117, 45);
            this.btnSuppEditHelp.TabIndex = 46;
            this.btnSuppEditHelp.Text = "H E L P";
            this.btnSuppEditHelp.UseVisualStyleBackColor = false;
            this.btnSuppEditHelp.Click += new System.EventHandler(this.btnSuppEditHelp_Click);
            // 
            // btnSupplierEditBack
            // 
            this.btnSupplierEditBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierEditBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierEditBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupplierEditBack.Location = new System.Drawing.Point(513, 287);
            this.btnSupplierEditBack.Name = "btnSupplierEditBack";
            this.btnSupplierEditBack.Size = new System.Drawing.Size(117, 45);
            this.btnSupplierEditBack.TabIndex = 45;
            this.btnSupplierEditBack.Text = "B A C K";
            this.btnSupplierEditBack.UseVisualStyleBackColor = false;
            this.btnSupplierEditBack.Click += new System.EventHandler(this.btnSupplierEditBack_Click);
            // 
            // pnlSuppEditSuppID
            // 
            this.pnlSuppEditSuppID.BackColor = System.Drawing.Color.White;
            this.pnlSuppEditSuppID.Controls.Add(this.cmbSuppEditSupID);
            this.pnlSuppEditSuppID.Controls.Add(this.txtSuppEditSelect);
            this.pnlSuppEditSuppID.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppEditSuppID.Location = new System.Drawing.Point(13, 32);
            this.pnlSuppEditSuppID.Name = "pnlSuppEditSuppID";
            this.pnlSuppEditSuppID.Size = new System.Drawing.Size(617, 34);
            this.pnlSuppEditSuppID.TabIndex = 41;
            // 
            // cmbSuppEditSupID
            // 
            this.cmbSuppEditSupID.FormattingEnabled = true;
            this.cmbSuppEditSupID.Location = new System.Drawing.Point(351, 7);
            this.cmbSuppEditSupID.Name = "cmbSuppEditSupID";
            this.cmbSuppEditSupID.Size = new System.Drawing.Size(143, 21);
            this.cmbSuppEditSupID.TabIndex = 45;
            // 
            // txtSuppEditSelect
            // 
            this.txtSuppEditSelect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSuppEditSelect.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppEditSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSuppEditSelect.Location = new System.Drawing.Point(500, 0);
            this.txtSuppEditSelect.Name = "txtSuppEditSelect";
            this.txtSuppEditSelect.Size = new System.Drawing.Size(90, 30);
            this.txtSuppEditSelect.TabIndex = 44;
            this.txtSuppEditSelect.Text = "SELECT";
            this.txtSuppEditSelect.UseVisualStyleBackColor = false;
            this.txtSuppEditSelect.Click += new System.EventHandler(this.txtSuppEditSelect_Click);
            // 
            // lblSupplierIDView
            // 
            this.lblSupplierIDView.AutoSize = true;
            this.lblSupplierIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDView.Location = new System.Drawing.Point(10, 7);
            this.lblSupplierIDView.Name = "lblSupplierIDView";
            this.lblSupplierIDView.Size = new System.Drawing.Size(74, 16);
            this.lblSupplierIDView.TabIndex = 41;
            this.lblSupplierIDView.Text = "Supplier ID";
            // 
            // pnlSuppEdit2
            // 
            this.pnlSuppEdit2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSuppEdit2.Controls.Add(this.txtSuppEditBusRegNum);
            this.pnlSuppEdit2.Controls.Add(this.chkSuppEditBusRegNum);
            this.pnlSuppEdit2.Controls.Add(this.btnSuppApplyEdit);
            this.pnlSuppEdit2.Controls.Add(this.txtSuppEditAddress);
            this.pnlSuppEdit2.Controls.Add(this.txtSuppEditIDNum);
            this.pnlSuppEdit2.Controls.Add(this.txtSuppEditSurname);
            this.pnlSuppEdit2.Controls.Add(this.txtSuppEditName);
            this.pnlSuppEdit2.Controls.Add(this.chkSupplierEditName);
            this.pnlSuppEdit2.Controls.Add(this.chkSupplierEditIDNum);
            this.pnlSuppEdit2.Controls.Add(this.chkSupplierEditSurname);
            this.pnlSuppEdit2.Controls.Add(this.chkSupplierEditAddress);
            this.pnlSuppEdit2.Location = new System.Drawing.Point(13, 101);
            this.pnlSuppEdit2.Name = "pnlSuppEdit2";
            this.pnlSuppEdit2.Size = new System.Drawing.Size(617, 168);
            this.pnlSuppEdit2.TabIndex = 29;
            // 
            // txtSuppEditBusRegNum
            // 
            this.txtSuppEditBusRegNum.Location = new System.Drawing.Point(308, 89);
            this.txtSuppEditBusRegNum.Name = "txtSuppEditBusRegNum";
            this.txtSuppEditBusRegNum.Size = new System.Drawing.Size(142, 20);
            this.txtSuppEditBusRegNum.TabIndex = 45;
            // 
            // chkSuppEditBusRegNum
            // 
            this.chkSuppEditBusRegNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkSuppEditBusRegNum.Location = new System.Drawing.Point(168, 84);
            this.chkSuppEditBusRegNum.Name = "chkSuppEditBusRegNum";
            this.chkSuppEditBusRegNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkSuppEditBusRegNum.Size = new System.Drawing.Size(292, 30);
            this.chkSuppEditBusRegNum.TabIndex = 44;
            this.chkSuppEditBusRegNum.Text = "Business Reg Number";
            this.chkSuppEditBusRegNum.UseVisualStyleBackColor = false;
            this.chkSuppEditBusRegNum.CheckedChanged += new System.EventHandler(this.chkSupplierEditSurname_CheckedChanged);
            // 
            // btnSuppApplyEdit
            // 
            this.btnSuppApplyEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppApplyEdit.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppApplyEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppApplyEdit.Location = new System.Drawing.Point(12, 120);
            this.btnSuppApplyEdit.Name = "btnSuppApplyEdit";
            this.btnSuppApplyEdit.Size = new System.Drawing.Size(589, 45);
            this.btnSuppApplyEdit.TabIndex = 43;
            this.btnSuppApplyEdit.Text = "A P P L Y   C H A N G E S ";
            this.btnSuppApplyEdit.UseVisualStyleBackColor = false;
            this.btnSuppApplyEdit.Click += new System.EventHandler(this.btnSuppApplyEdit_Click);
            // 
            // txtSuppEditAddress
            // 
            this.txtSuppEditAddress.Location = new System.Drawing.Point(448, 53);
            this.txtSuppEditAddress.Name = "txtSuppEditAddress";
            this.txtSuppEditAddress.Size = new System.Drawing.Size(142, 20);
            this.txtSuppEditAddress.TabIndex = 36;
            // 
            // txtSuppEditIDNum
            // 
            this.txtSuppEditIDNum.Location = new System.Drawing.Point(152, 53);
            this.txtSuppEditIDNum.Name = "txtSuppEditIDNum";
            this.txtSuppEditIDNum.Size = new System.Drawing.Size(142, 20);
            this.txtSuppEditIDNum.TabIndex = 35;
            // 
            // txtSuppEditSurname
            // 
            this.txtSuppEditSurname.Location = new System.Drawing.Point(448, 17);
            this.txtSuppEditSurname.Name = "txtSuppEditSurname";
            this.txtSuppEditSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSuppEditSurname.TabIndex = 34;
            // 
            // txtSuppEditName
            // 
            this.txtSuppEditName.Location = new System.Drawing.Point(152, 17);
            this.txtSuppEditName.Name = "txtSuppEditName";
            this.txtSuppEditName.Size = new System.Drawing.Size(142, 20);
            this.txtSuppEditName.TabIndex = 33;
            // 
            // chkSupplierEditName
            // 
            this.chkSupplierEditName.BackColor = System.Drawing.Color.FloralWhite;
            this.chkSupplierEditName.Location = new System.Drawing.Point(12, 12);
            this.chkSupplierEditName.Name = "chkSupplierEditName";
            this.chkSupplierEditName.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkSupplierEditName.Size = new System.Drawing.Size(292, 30);
            this.chkSupplierEditName.TabIndex = 29;
            this.chkSupplierEditName.Text = "Name";
            this.chkSupplierEditName.UseVisualStyleBackColor = false;
            this.chkSupplierEditName.CheckedChanged += new System.EventHandler(this.chkSupplierEditSurname_CheckedChanged);
            // 
            // chkSupplierEditIDNum
            // 
            this.chkSupplierEditIDNum.BackColor = System.Drawing.Color.FloralWhite;
            this.chkSupplierEditIDNum.Location = new System.Drawing.Point(12, 48);
            this.chkSupplierEditIDNum.Name = "chkSupplierEditIDNum";
            this.chkSupplierEditIDNum.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkSupplierEditIDNum.Size = new System.Drawing.Size(292, 30);
            this.chkSupplierEditIDNum.TabIndex = 32;
            this.chkSupplierEditIDNum.Text = "ID Number";
            this.chkSupplierEditIDNum.UseVisualStyleBackColor = false;
            this.chkSupplierEditIDNum.CheckedChanged += new System.EventHandler(this.chkSupplierEditSurname_CheckedChanged);
            // 
            // chkSupplierEditSurname
            // 
            this.chkSupplierEditSurname.BackColor = System.Drawing.Color.FloralWhite;
            this.chkSupplierEditSurname.Location = new System.Drawing.Point(310, 12);
            this.chkSupplierEditSurname.Name = "chkSupplierEditSurname";
            this.chkSupplierEditSurname.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkSupplierEditSurname.Size = new System.Drawing.Size(292, 30);
            this.chkSupplierEditSurname.TabIndex = 31;
            this.chkSupplierEditSurname.Text = "Surname";
            this.chkSupplierEditSurname.UseVisualStyleBackColor = false;
            this.chkSupplierEditSurname.CheckedChanged += new System.EventHandler(this.chkSupplierEditSurname_CheckedChanged);
            // 
            // chkSupplierEditAddress
            // 
            this.chkSupplierEditAddress.BackColor = System.Drawing.Color.FloralWhite;
            this.chkSupplierEditAddress.Location = new System.Drawing.Point(310, 48);
            this.chkSupplierEditAddress.Name = "chkSupplierEditAddress";
            this.chkSupplierEditAddress.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkSupplierEditAddress.Size = new System.Drawing.Size(292, 30);
            this.chkSupplierEditAddress.TabIndex = 30;
            this.chkSupplierEditAddress.Text = "Address";
            this.chkSupplierEditAddress.UseVisualStyleBackColor = false;
            this.chkSupplierEditAddress.CheckedChanged += new System.EventHandler(this.chkSupplierEditSurname_CheckedChanged);
            // 
            // lblSupplierEdit
            // 
            this.lblSupplierEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierEdit.Location = new System.Drawing.Point(35, 18);
            this.lblSupplierEdit.Name = "lblSupplierEdit";
            this.lblSupplierEdit.Size = new System.Drawing.Size(717, 53);
            this.lblSupplierEdit.TabIndex = 40;
            this.lblSupplierEdit.Text = "EDIT SUPPLIERS";
            this.lblSupplierEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbSupplierEdit
            // 
            this.dbSupplierEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbSupplierEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbSupplierEdit.Location = new System.Drawing.Point(35, 91);
            this.dbSupplierEdit.Name = "dbSupplierEdit";
            this.dbSupplierEdit.ReadOnly = true;
            this.dbSupplierEdit.Size = new System.Drawing.Size(717, 232);
            this.dbSupplierEdit.TabIndex = 39;
            // 
            // frmSuppliers_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.pnlSuppEdit1);
            this.Controls.Add(this.lblSupplierEdit);
            this.Controls.Add(this.dbSupplierEdit);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 750);
            this.MinimumSize = new System.Drawing.Size(806, 726);
            this.Name = "frmSuppliers_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Suppliers";
            this.Load += new System.EventHandler(this.FrmSuppliers_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSuppEdit1.ResumeLayout(false);
            this.pnlSuppEdit1.PerformLayout();
            this.pnlSuppEditSuppID.ResumeLayout(false);
            this.pnlSuppEditSuppID.PerformLayout();
            this.pnlSuppEdit2.ResumeLayout(false);
            this.pnlSuppEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSupplierEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierViewHint2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Panel pnlSuppEdit1;
        private System.Windows.Forms.Button btnSuppEditHelp;
        private System.Windows.Forms.Button btnSupplierEditBack;
        private System.Windows.Forms.Panel pnlSuppEditSuppID;
        private System.Windows.Forms.Button txtSuppEditSelect;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Panel pnlSuppEdit2;
        private System.Windows.Forms.Button btnSuppApplyEdit;
        private System.Windows.Forms.TextBox txtSuppEditAddress;
        private System.Windows.Forms.TextBox txtSuppEditIDNum;
        private System.Windows.Forms.TextBox txtSuppEditSurname;
        private System.Windows.Forms.TextBox txtSuppEditName;
        private System.Windows.Forms.CheckBox chkSupplierEditName;
        private System.Windows.Forms.CheckBox chkSupplierEditIDNum;
        private System.Windows.Forms.CheckBox chkSupplierEditSurname;
        private System.Windows.Forms.CheckBox chkSupplierEditAddress;
        private System.Windows.Forms.Label lblSupplierEdit;
        private System.Windows.Forms.DataGridView dbSupplierEdit;
        private System.Windows.Forms.ComboBox cmbSuppEditSupID;
        private System.Windows.Forms.TextBox txtSuppEditBusRegNum;
        private System.Windows.Forms.CheckBox chkSuppEditBusRegNum;
    }
}