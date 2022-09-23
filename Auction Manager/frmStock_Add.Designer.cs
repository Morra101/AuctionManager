namespace Auction_Manager
{
    partial class frmStock_Add
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSupplierAddLegend = new System.Windows.Forms.Label();
            this.txtAddRegNum = new System.Windows.Forms.TextBox();
            this.btnStockAdd = new System.Windows.Forms.Button();
            this.txtAddEngNum = new System.Windows.Forms.TextBox();
            this.lblSuppliersAddSurname = new System.Windows.Forms.Label();
            this.lblSuppliersAddName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddChasNum = new System.Windows.Forms.TextBox();
            this.btnSuppViewBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch2 = new System.Windows.Forms.Panel();
            this.dtpAuctionDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAddSuppID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSuppliersAddHeading = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch2.SuspendLayout();
            this.pnlSuppViewSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "*";
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
            this.lblSupplierAddLegend.Size = new System.Drawing.Size(303, 20);
            this.lblSupplierAddLegend.TabIndex = 55;
            this.lblSupplierAddLegend.Text = "Fields marked with a \"       \" are mandatory";
            // 
            // txtAddRegNum
            // 
            this.txtAddRegNum.Location = new System.Drawing.Point(428, 39);
            this.txtAddRegNum.Name = "txtAddRegNum";
            this.txtAddRegNum.Size = new System.Drawing.Size(208, 20);
            this.txtAddRegNum.TabIndex = 48;
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStockAdd.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockAdd.Location = new System.Drawing.Point(30, 201);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Size = new System.Drawing.Size(625, 45);
            this.btnStockAdd.TabIndex = 43;
            this.btnStockAdd.Text = "Add  Stock Item";
            this.btnStockAdd.UseVisualStyleBackColor = false;
            this.btnStockAdd.Click += new System.EventHandler(this.BtnSearchSuppView2_Click);
            // 
            // txtAddEngNum
            // 
            this.txtAddEngNum.Location = new System.Drawing.Point(428, 70);
            this.txtAddEngNum.Name = "txtAddEngNum";
            this.txtAddEngNum.Size = new System.Drawing.Size(208, 20);
            this.txtAddEngNum.TabIndex = 33;
            // 
            // lblSuppliersAddSurname
            // 
            this.lblSuppliersAddSurname.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddSurname.Location = new System.Drawing.Point(30, 127);
            this.lblSuppliersAddSurname.Name = "lblSuppliersAddSurname";
            this.lblSuppliersAddSurname.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddSurname.Size = new System.Drawing.Size(625, 29);
            this.lblSuppliersAddSurname.TabIndex = 53;
            this.lblSuppliersAddSurname.Text = "Supplier that provided the vehicle";
            this.lblSuppliersAddSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSuppliersAddName
            // 
            this.lblSuppliersAddName.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddName.Location = new System.Drawing.Point(30, 34);
            this.lblSuppliersAddName.Name = "lblSuppliersAddName";
            this.lblSuppliersAddName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddName.Size = new System.Drawing.Size(625, 29);
            this.lblSuppliersAddName.TabIndex = 52;
            this.lblSuppliersAddName.Text = "Vehicle Registration Number";
            this.lblSuppliersAddName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuppliersAddName.Click += new System.EventHandler(this.lblSuppliersAddName_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "*";
            // 
            // txtAddChasNum
            // 
            this.txtAddChasNum.Location = new System.Drawing.Point(428, 101);
            this.txtAddChasNum.Name = "txtAddChasNum";
            this.txtAddChasNum.Size = new System.Drawing.Size(208, 20);
            this.txtAddChasNum.TabIndex = 62;
            // 
            // btnSuppViewBack
            // 
            this.btnSuppViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppViewBack.Location = new System.Drawing.Point(621, 308);
            this.btnSuppViewBack.Name = "btnSuppViewBack";
            this.btnSuppViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnSuppViewBack.TabIndex = 53;
            this.btnSuppViewBack.Text = "B A C K";
            this.btnSuppViewBack.UseVisualStyleBackColor = false;
            this.btnSuppViewBack.Click += new System.EventHandler(this.btnSuppViewBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(25, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 64;
            this.button1.Text = "H E L P";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(21, 9);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(504, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Enter the details of the stock item you would like to add below";
            // 
            // pnlSuppViewSearch2
            // 
            this.pnlSuppViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSuppViewSearch2.Controls.Add(this.dtpAuctionDate);
            this.pnlSuppViewSearch2.Controls.Add(this.label7);
            this.pnlSuppViewSearch2.Controls.Add(this.cmbAddSuppID);
            this.pnlSuppViewSearch2.Controls.Add(this.label6);
            this.pnlSuppViewSearch2.Controls.Add(this.label1);
            this.pnlSuppViewSearch2.Controls.Add(this.txtAddChasNum);
            this.pnlSuppViewSearch2.Controls.Add(this.label4);
            this.pnlSuppViewSearch2.Controls.Add(this.label3);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSupplierAddLegend);
            this.pnlSuppViewSearch2.Controls.Add(this.txtAddRegNum);
            this.pnlSuppViewSearch2.Controls.Add(this.btnStockAdd);
            this.pnlSuppViewSearch2.Controls.Add(this.txtAddEngNum);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddSurname);
            this.pnlSuppViewSearch2.Controls.Add(this.label5);
            this.pnlSuppViewSearch2.Controls.Add(this.label2);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddName);
            this.pnlSuppViewSearch2.Location = new System.Drawing.Point(25, 42);
            this.pnlSuppViewSearch2.Name = "pnlSuppViewSearch2";
            this.pnlSuppViewSearch2.Size = new System.Drawing.Size(676, 260);
            this.pnlSuppViewSearch2.TabIndex = 29;
            // 
            // dtpAuctionDate
            // 
            this.dtpAuctionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAuctionDate.Location = new System.Drawing.Point(428, 161);
            this.dtpAuctionDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpAuctionDate.MinDate = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.dtpAuctionDate.Name = "dtpAuctionDate";
            this.dtpAuctionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpAuctionDate.Size = new System.Drawing.Size(208, 20);
            this.dtpAuctionDate.TabIndex = 77;
            this.dtpAuctionDate.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 158);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(625, 29);
            this.label7.TabIndex = 69;
            this.label7.Text = "Date Vehicle was brought in ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAddSuppID
            // 
            this.cmbAddSuppID.FormattingEnabled = true;
            this.cmbAddSuppID.Location = new System.Drawing.Point(428, 132);
            this.cmbAddSuppID.Name = "cmbAddSuppID";
            this.cmbAddSuppID.Size = new System.Drawing.Size(208, 21);
            this.cmbAddSuppID.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 96);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(625, 29);
            this.label5.TabIndex = 65;
            this.label5.Text = "Vehicle Chassis Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(625, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Vehicle Engine Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSuppViewSearch1
            // 
            this.pnlSuppViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppViewSearch1.Controls.Add(this.btnSuppViewBack);
            this.pnlSuppViewSearch1.Controls.Add(this.button1);
            this.pnlSuppViewSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppViewSearch1.Controls.Add(this.pnlSuppViewSearch2);
            this.pnlSuppViewSearch1.Location = new System.Drawing.Point(38, 81);
            this.pnlSuppViewSearch1.Name = "pnlSuppViewSearch1";
            this.pnlSuppViewSearch1.Size = new System.Drawing.Size(717, 366);
            this.pnlSuppViewSearch1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Location = new System.Drawing.Point(-154, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 620);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSuppliersAddHeading
            // 
            this.lblSuppliersAddHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuppliersAddHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuppliersAddHeading.Location = new System.Drawing.Point(38, 16);
            this.lblSuppliersAddHeading.Name = "lblSuppliersAddHeading";
            this.lblSuppliersAddHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSuppliersAddHeading.TabIndex = 40;
            this.lblSuppliersAddHeading.Text = "ADD STOCK";
            this.lblSuppliersAddHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStock_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 498);
            this.Controls.Add(this.pnlSuppViewSearch1);
            this.Controls.Add(this.lblSuppliersAddHeading);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 537);
            this.MinimumSize = new System.Drawing.Size(817, 537);
            this.Name = "frmStock_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Add New Stock Item";
            this.Load += new System.EventHandler(this.FrmStock_Add_Load);
            this.pnlSuppViewSearch2.ResumeLayout(false);
            this.pnlSuppViewSearch2.PerformLayout();
            this.pnlSuppViewSearch1.ResumeLayout(false);
            this.pnlSuppViewSearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSupplierAddLegend;
        private System.Windows.Forms.TextBox txtAddRegNum;
        private System.Windows.Forms.Button btnStockAdd;
        private System.Windows.Forms.TextBox txtAddEngNum;
        private System.Windows.Forms.Label lblSuppliersAddSurname;
        private System.Windows.Forms.Label lblSuppliersAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddChasNum;
        private System.Windows.Forms.Button btnSuppViewBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Panel pnlSuppViewSearch2;
        private System.Windows.Forms.Panel pnlSuppViewSearch1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSuppliersAddHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAddSuppID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAuctionDate;
    }
}