
namespace Auction_Manager
{
    partial class frmSuppliers_Add
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
            this.lblSuppliersAddHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuppViewSearch1 = new System.Windows.Forms.Panel();
            this.btnSuppAddBack = new System.Windows.Forms.Button();
            this.btnSupAddHelp = new System.Windows.Forms.Button();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch2 = new System.Windows.Forms.Panel();
            this.lblAstricsAddress = new System.Windows.Forms.Label();
            this.txtSupAdress = new System.Windows.Forms.TextBox();
            this.lblSuppliersAddAddress = new System.Windows.Forms.Label();
            this.lblAstricsCheck = new System.Windows.Forms.Label();
            this.pnlChoiceBorP = new System.Windows.Forms.Panel();
            this.txtSupBusRegNum = new System.Windows.Forms.TextBox();
            this.lblSuppAddBusRegNum = new System.Windows.Forms.Label();
            this.txtSupIDNum = new System.Windows.Forms.TextBox();
            this.chkSuppliersAddPrivate = new System.Windows.Forms.CheckBox();
            this.chkSuppliersAddBusiness = new System.Windows.Forms.CheckBox();
            this.lblSuppAddIDNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSupplierAddLegend = new System.Windows.Forms.Label();
            this.lblAstricsName = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.txtSupSurn = new System.Windows.Forms.TextBox();
            this.lblSuppliersAddSurname = new System.Windows.Forms.Label();
            this.lblSuppliersAddName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSuppViewSearch1.SuspendLayout();
            this.pnlSuppViewSearch2.SuspendLayout();
            this.pnlChoiceBorP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSuppliersAddHeading
            // 
            this.lblSuppliersAddHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuppliersAddHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuppliersAddHeading.Location = new System.Drawing.Point(32, 18);
            this.lblSuppliersAddHeading.Name = "lblSuppliersAddHeading";
            this.lblSuppliersAddHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSuppliersAddHeading.TabIndex = 35;
            this.lblSuppliersAddHeading.Text = "ADD SUPPLIER";
            this.lblSuppliersAddHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Location = new System.Drawing.Point(-161, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 620);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSuppViewSearch1
            // 
            this.pnlSuppViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppViewSearch1.Controls.Add(this.btnSuppAddBack);
            this.pnlSuppViewSearch1.Controls.Add(this.btnSupAddHelp);
            this.pnlSuppViewSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppViewSearch1.Controls.Add(this.pnlSuppViewSearch2);
            this.pnlSuppViewSearch1.Location = new System.Drawing.Point(32, 83);
            this.pnlSuppViewSearch1.Name = "pnlSuppViewSearch1";
            this.pnlSuppViewSearch1.Size = new System.Drawing.Size(717, 446);
            this.pnlSuppViewSearch1.TabIndex = 39;
            // 
            // btnSuppAddBack
            // 
            this.btnSuppAddBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppAddBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppAddBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppAddBack.Location = new System.Drawing.Point(621, 383);
            this.btnSuppAddBack.Name = "btnSuppAddBack";
            this.btnSuppAddBack.Size = new System.Drawing.Size(80, 45);
            this.btnSuppAddBack.TabIndex = 53;
            this.btnSuppAddBack.Text = "B A C K";
            this.btnSuppAddBack.UseVisualStyleBackColor = false;
            this.btnSuppAddBack.Click += new System.EventHandler(this.btnSuppViewBack_Click);
            // 
            // btnSupAddHelp
            // 
            this.btnSupAddHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupAddHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupAddHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupAddHelp.Location = new System.Drawing.Point(25, 383);
            this.btnSupAddHelp.Name = "btnSupAddHelp";
            this.btnSupAddHelp.Size = new System.Drawing.Size(80, 45);
            this.btnSupAddHelp.TabIndex = 64;
            this.btnSupAddHelp.Text = "H E L P";
            this.btnSupAddHelp.UseVisualStyleBackColor = false;
            this.btnSupAddHelp.Click += new System.EventHandler(this.btnSupAddHelp_Click);
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(21, 9);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(485, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Enter the details of the supplier you would like to add below";
            // 
            // pnlSuppViewSearch2
            // 
            this.pnlSuppViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSuppViewSearch2.Controls.Add(this.lblAstricsAddress);
            this.pnlSuppViewSearch2.Controls.Add(this.txtSupAdress);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddAddress);
            this.pnlSuppViewSearch2.Controls.Add(this.lblAstricsCheck);
            this.pnlSuppViewSearch2.Controls.Add(this.pnlChoiceBorP);
            this.pnlSuppViewSearch2.Controls.Add(this.label3);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSupplierAddLegend);
            this.pnlSuppViewSearch2.Controls.Add(this.lblAstricsName);
            this.pnlSuppViewSearch2.Controls.Add(this.txtSupName);
            this.pnlSuppViewSearch2.Controls.Add(this.btnAddSup);
            this.pnlSuppViewSearch2.Controls.Add(this.txtSupSurn);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddSurname);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddName);
            this.pnlSuppViewSearch2.Location = new System.Drawing.Point(25, 42);
            this.pnlSuppViewSearch2.Name = "pnlSuppViewSearch2";
            this.pnlSuppViewSearch2.Size = new System.Drawing.Size(676, 325);
            this.pnlSuppViewSearch2.TabIndex = 29;
            // 
            // lblAstricsAddress
            // 
            this.lblAstricsAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAstricsAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstricsAddress.Location = new System.Drawing.Point(1, 201);
            this.lblAstricsAddress.Name = "lblAstricsAddress";
            this.lblAstricsAddress.Size = new System.Drawing.Size(26, 23);
            this.lblAstricsAddress.TabIndex = 63;
            this.lblAstricsAddress.Text = "*";
            // 
            // txtSupAdress
            // 
            this.txtSupAdress.Location = new System.Drawing.Point(494, 206);
            this.txtSupAdress.Name = "txtSupAdress";
            this.txtSupAdress.Size = new System.Drawing.Size(142, 20);
            this.txtSupAdress.TabIndex = 62;
            this.txtSupAdress.TextChanged += new System.EventHandler(this.txtSupAdress_TextChanged_1);
            // 
            // lblSuppliersAddAddress
            // 
            this.lblSuppliersAddAddress.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddAddress.Location = new System.Drawing.Point(30, 201);
            this.lblSuppliersAddAddress.Name = "lblSuppliersAddAddress";
            this.lblSuppliersAddAddress.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddAddress.Size = new System.Drawing.Size(625, 29);
            this.lblSuppliersAddAddress.TabIndex = 61;
            this.lblSuppliersAddAddress.Text = "Address";
            this.lblSuppliersAddAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAstricsCheck
            // 
            this.lblAstricsCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblAstricsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstricsCheck.Location = new System.Drawing.Point(1, 62);
            this.lblAstricsCheck.Name = "lblAstricsCheck";
            this.lblAstricsCheck.Size = new System.Drawing.Size(26, 23);
            this.lblAstricsCheck.TabIndex = 60;
            this.lblAstricsCheck.Text = "*";
            // 
            // pnlChoiceBorP
            // 
            this.pnlChoiceBorP.BackColor = System.Drawing.Color.DimGray;
            this.pnlChoiceBorP.Controls.Add(this.txtSupBusRegNum);
            this.pnlChoiceBorP.Controls.Add(this.lblSuppAddBusRegNum);
            this.pnlChoiceBorP.Controls.Add(this.txtSupIDNum);
            this.pnlChoiceBorP.Controls.Add(this.chkSuppliersAddPrivate);
            this.pnlChoiceBorP.Controls.Add(this.chkSuppliersAddBusiness);
            this.pnlChoiceBorP.Controls.Add(this.lblSuppAddIDNum);
            this.pnlChoiceBorP.Location = new System.Drawing.Point(30, 37);
            this.pnlChoiceBorP.Name = "pnlChoiceBorP";
            this.pnlChoiceBorP.Size = new System.Drawing.Size(625, 72);
            this.pnlChoiceBorP.TabIndex = 59;
            // 
            // txtSupBusRegNum
            // 
            this.txtSupBusRegNum.Location = new System.Drawing.Point(464, 44);
            this.txtSupBusRegNum.Name = "txtSupBusRegNum";
            this.txtSupBusRegNum.Size = new System.Drawing.Size(142, 20);
            this.txtSupBusRegNum.TabIndex = 63;
            // 
            // lblSuppAddBusRegNum
            // 
            this.lblSuppAddBusRegNum.BackColor = System.Drawing.Color.White;
            this.lblSuppAddBusRegNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppAddBusRegNum.Location = new System.Drawing.Point(262, 39);
            this.lblSuppAddBusRegNum.Name = "lblSuppAddBusRegNum";
            this.lblSuppAddBusRegNum.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppAddBusRegNum.Size = new System.Drawing.Size(354, 29);
            this.lblSuppAddBusRegNum.TabIndex = 64;
            this.lblSuppAddBusRegNum.Text = "Business Registration Number";
            this.lblSuppAddBusRegNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupIDNum
            // 
            this.txtSupIDNum.Location = new System.Drawing.Point(464, 9);
            this.txtSupIDNum.Name = "txtSupIDNum";
            this.txtSupIDNum.Size = new System.Drawing.Size(142, 20);
            this.txtSupIDNum.TabIndex = 61;
            this.txtSupIDNum.TextChanged += new System.EventHandler(this.txtSupIDNum_TextChanged_1);
            // 
            // chkSuppliersAddPrivate
            // 
            this.chkSuppliersAddPrivate.AutoSize = true;
            this.chkSuppliersAddPrivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkSuppliersAddPrivate.Location = new System.Drawing.Point(3, 16);
            this.chkSuppliersAddPrivate.Name = "chkSuppliersAddPrivate";
            this.chkSuppliersAddPrivate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chkSuppliersAddPrivate.Size = new System.Drawing.Size(105, 17);
            this.chkSuppliersAddPrivate.TabIndex = 57;
            this.chkSuppliersAddPrivate.Text = "Private Person";
            this.chkSuppliersAddPrivate.UseVisualStyleBackColor = true;
            this.chkSuppliersAddPrivate.CheckedChanged += new System.EventHandler(this.chkSuppliersAddPrivate_CheckedChanged_1);
            // 
            // chkSuppliersAddBusiness
            // 
            this.chkSuppliersAddBusiness.AutoSize = true;
            this.chkSuppliersAddBusiness.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkSuppliersAddBusiness.Location = new System.Drawing.Point(3, 39);
            this.chkSuppliersAddBusiness.Name = "chkSuppliersAddBusiness";
            this.chkSuppliersAddBusiness.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chkSuppliersAddBusiness.Size = new System.Drawing.Size(78, 17);
            this.chkSuppliersAddBusiness.TabIndex = 58;
            this.chkSuppliersAddBusiness.Text = "Business";
            this.chkSuppliersAddBusiness.UseVisualStyleBackColor = true;
            this.chkSuppliersAddBusiness.CheckedChanged += new System.EventHandler(this.chkSuppliersAddBusiness_CheckedChanged_1);
            // 
            // lblSuppAddIDNum
            // 
            this.lblSuppAddIDNum.BackColor = System.Drawing.Color.White;
            this.lblSuppAddIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppAddIDNum.Location = new System.Drawing.Point(262, 4);
            this.lblSuppAddIDNum.Name = "lblSuppAddIDNum";
            this.lblSuppAddIDNum.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppAddIDNum.Size = new System.Drawing.Size(354, 29);
            this.lblSuppAddIDNum.TabIndex = 61;
            this.lblSuppAddIDNum.Text = "ID number";
            this.lblSuppAddIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "*";
            // 
            // lblSupplierAddLegend
            // 
            this.lblSupplierAddLegend.AutoSize = true;
            this.lblSupplierAddLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddLegend.Location = new System.Drawing.Point(26, 11);
            this.lblSupplierAddLegend.Name = "lblSupplierAddLegend";
            this.lblSupplierAddLegend.Size = new System.Drawing.Size(299, 20);
            this.lblSupplierAddLegend.TabIndex = 55;
            this.lblSupplierAddLegend.Text = "Fields marked with a \"       \" are mantatory";
            // 
            // lblAstricsName
            // 
            this.lblAstricsName.BackColor = System.Drawing.Color.Transparent;
            this.lblAstricsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstricsName.Location = new System.Drawing.Point(1, 112);
            this.lblAstricsName.Name = "lblAstricsName";
            this.lblAstricsName.Size = new System.Drawing.Size(26, 23);
            this.lblAstricsName.TabIndex = 54;
            this.lblAstricsName.Text = "*";
            this.lblAstricsName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(494, 115);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(142, 20);
            this.txtSupName.TabIndex = 48;
            this.txtSupName.TextChanged += new System.EventHandler(this.txtSupName_TextChanged_1);
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddSup.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSup.Location = new System.Drawing.Point(30, 246);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(625, 45);
            this.btnAddSup.TabIndex = 43;
            this.btnAddSup.Text = "Add  Supplier";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // txtSupSurn
            // 
            this.txtSupSurn.Location = new System.Drawing.Point(494, 163);
            this.txtSupSurn.Name = "txtSupSurn";
            this.txtSupSurn.Size = new System.Drawing.Size(142, 20);
            this.txtSupSurn.TabIndex = 33;
            this.txtSupSurn.TextChanged += new System.EventHandler(this.txtSupSurn_TextChanged_1);
            // 
            // lblSuppliersAddSurname
            // 
            this.lblSuppliersAddSurname.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddSurname.Location = new System.Drawing.Point(30, 158);
            this.lblSuppliersAddSurname.Name = "lblSuppliersAddSurname";
            this.lblSuppliersAddSurname.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddSurname.Size = new System.Drawing.Size(625, 29);
            this.lblSuppliersAddSurname.TabIndex = 53;
            this.lblSuppliersAddSurname.Text = "Surname";
            this.lblSuppliersAddSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSuppliersAddName
            // 
            this.lblSuppliersAddName.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddName.Location = new System.Drawing.Point(30, 112);
            this.lblSuppliersAddName.Name = "lblSuppliersAddName";
            this.lblSuppliersAddName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddName.Size = new System.Drawing.Size(625, 29);
            this.lblSuppliersAddName.TabIndex = 52;
            this.lblSuppliersAddName.Text = "Name";
            this.lblSuppliersAddName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSuppliers_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 550);
            this.Controls.Add(this.pnlSuppViewSearch1);
            this.Controls.Add(this.lblSuppliersAddHeading);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 589);
            this.MinimumSize = new System.Drawing.Size(806, 589);
            this.Name = "frmSuppliers_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.FrmSuppliers_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSuppViewSearch1.ResumeLayout(false);
            this.pnlSuppViewSearch1.PerformLayout();
            this.pnlSuppViewSearch2.ResumeLayout(false);
            this.pnlSuppViewSearch2.PerformLayout();
            this.pnlChoiceBorP.ResumeLayout(false);
            this.pnlChoiceBorP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSuppliersAddHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSuppViewSearch1;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Panel pnlSuppViewSearch2;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.TextBox txtSupSurn;
        private System.Windows.Forms.Label lblSuppliersAddName;
        private System.Windows.Forms.Label lblAstricsName;
        private System.Windows.Forms.Label lblSuppliersAddSurname;
        private System.Windows.Forms.Label lblSuppliersAddAddress;
        private System.Windows.Forms.Label lblAstricsCheck;
        private System.Windows.Forms.Panel pnlChoiceBorP;
        private System.Windows.Forms.TextBox txtSupBusRegNum;
        private System.Windows.Forms.Label lblSuppAddBusRegNum;
        private System.Windows.Forms.TextBox txtSupIDNum;
        private System.Windows.Forms.CheckBox chkSuppliersAddPrivate;
        private System.Windows.Forms.CheckBox chkSuppliersAddBusiness;
        private System.Windows.Forms.Label lblSuppAddIDNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSupplierAddLegend;
        private System.Windows.Forms.Label lblAstricsAddress;
        private System.Windows.Forms.TextBox txtSupAdress;
        private System.Windows.Forms.Button btnSupAddHelp;
        private System.Windows.Forms.Button btnSuppAddBack;
    }
}