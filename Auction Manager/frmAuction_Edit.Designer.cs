
namespace Auction_Manager
{
    partial class frmAuction_Edit
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
            this.lblAuctionEditHeading = new System.Windows.Forms.Label();
            this.pbEmployeeEdit = new System.Windows.Forms.PictureBox();
            this.btnAuctionEditApplyDate = new System.Windows.Forms.Button();
            this.pnlAuctionEdit3 = new System.Windows.Forms.Panel();
            this.pnlAuctionEdit5 = new System.Windows.Forms.Panel();
            this.cmbAuctionEditIDList = new System.Windows.Forms.ComboBox();
            this.btnAuctionEditAddStock = new System.Windows.Forms.Button();
            this.btnAuctionEditViewStock2 = new System.Windows.Forms.Button();
            this.lblAuctionEditHint6 = new System.Windows.Forms.Label();
            this.lblAuctionEditHint5 = new System.Windows.Forms.Label();
            this.chkAucEditAddStock = new System.Windows.Forms.CheckBox();
            this.pnlAuctionEdit4 = new System.Windows.Forms.Panel();
            this.cbAuctionEditStockID = new System.Windows.Forms.ComboBox();
            this.btnAuctionEditRemoveStock = new System.Windows.Forms.Button();
            this.btnAuctionEditViewStock1 = new System.Windows.Forms.Button();
            this.lblAuctionEditHint3 = new System.Windows.Forms.Label();
            this.lblAuctionEditHint4 = new System.Windows.Forms.Label();
            this.chkAucEditRemoveStock = new System.Windows.Forms.CheckBox();
            this.dtpAuctionDate = new System.Windows.Forms.DateTimePicker();
            this.chkAuctionEditDate = new System.Windows.Forms.CheckBox();
            this.pnlAuctionEdit1 = new System.Windows.Forms.Panel();
            this.btnEmployeeEditHelp = new System.Windows.Forms.Button();
            this.btnEmployeeEditBack = new System.Windows.Forms.Button();
            this.lblAuctionHint2 = new System.Windows.Forms.Label();
            this.pnlAuctionEdit2 = new System.Windows.Forms.Panel();
            this.cmbAucEditIDSelect = new System.Windows.Forms.ComboBox();
            this.btnAuctionEditSearch = new System.Windows.Forms.Button();
            this.lblAuctionIDView = new System.Windows.Forms.Label();
            this.lblAuctionHint1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeEdit)).BeginInit();
            this.pnlAuctionEdit3.SuspendLayout();
            this.pnlAuctionEdit5.SuspendLayout();
            this.pnlAuctionEdit4.SuspendLayout();
            this.pnlAuctionEdit1.SuspendLayout();
            this.pnlAuctionEdit2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuctionEditHeading
            // 
            this.lblAuctionEditHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAuctionEditHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionEditHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAuctionEditHeading.Location = new System.Drawing.Point(37, 17);
            this.lblAuctionEditHeading.Name = "lblAuctionEditHeading";
            this.lblAuctionEditHeading.Size = new System.Drawing.Size(717, 53);
            this.lblAuctionEditHeading.TabIndex = 48;
            this.lblAuctionEditHeading.Text = "EDIT AUCTION";
            this.lblAuctionEditHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeEdit
            // 
            this.pbEmployeeEdit.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbEmployeeEdit.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbEmployeeEdit.Location = new System.Drawing.Point(-156, -2);
            this.pbEmployeeEdit.Name = "pbEmployeeEdit";
            this.pbEmployeeEdit.Size = new System.Drawing.Size(1069, 719);
            this.pbEmployeeEdit.TabIndex = 50;
            this.pbEmployeeEdit.TabStop = false;
            // 
            // btnAuctionEditApplyDate
            // 
            this.btnAuctionEditApplyDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditApplyDate.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditApplyDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditApplyDate.Location = new System.Drawing.Point(489, 6);
            this.btnAuctionEditApplyDate.Name = "btnAuctionEditApplyDate";
            this.btnAuctionEditApplyDate.Size = new System.Drawing.Size(112, 45);
            this.btnAuctionEditApplyDate.TabIndex = 43;
            this.btnAuctionEditApplyDate.Text = "Apply Date Change";
            this.btnAuctionEditApplyDate.UseVisualStyleBackColor = false;
            this.btnAuctionEditApplyDate.Click += new System.EventHandler(this.BtnAuctionEditApplyDate_Click);
            // 
            // pnlAuctionEdit3
            // 
            this.pnlAuctionEdit3.BackColor = System.Drawing.Color.DarkGray;
            this.pnlAuctionEdit3.Controls.Add(this.pnlAuctionEdit5);
            this.pnlAuctionEdit3.Controls.Add(this.chkAucEditAddStock);
            this.pnlAuctionEdit3.Controls.Add(this.pnlAuctionEdit4);
            this.pnlAuctionEdit3.Controls.Add(this.chkAucEditRemoveStock);
            this.pnlAuctionEdit3.Controls.Add(this.dtpAuctionDate);
            this.pnlAuctionEdit3.Controls.Add(this.btnAuctionEditApplyDate);
            this.pnlAuctionEdit3.Controls.Add(this.chkAuctionEditDate);
            this.pnlAuctionEdit3.Location = new System.Drawing.Point(49, 102);
            this.pnlAuctionEdit3.Name = "pnlAuctionEdit3";
            this.pnlAuctionEdit3.Size = new System.Drawing.Size(617, 436);
            this.pnlAuctionEdit3.TabIndex = 29;
            // 
            // pnlAuctionEdit5
            // 
            this.pnlAuctionEdit5.BackColor = System.Drawing.Color.Silver;
            this.pnlAuctionEdit5.Controls.Add(this.cmbAuctionEditIDList);
            this.pnlAuctionEdit5.Controls.Add(this.btnAuctionEditAddStock);
            this.pnlAuctionEdit5.Controls.Add(this.btnAuctionEditViewStock2);
            this.pnlAuctionEdit5.Controls.Add(this.lblAuctionEditHint6);
            this.pnlAuctionEdit5.Controls.Add(this.lblAuctionEditHint5);
            this.pnlAuctionEdit5.Location = new System.Drawing.Point(18, 255);
            this.pnlAuctionEdit5.Name = "pnlAuctionEdit5";
            this.pnlAuctionEdit5.Size = new System.Drawing.Size(577, 128);
            this.pnlAuctionEdit5.TabIndex = 58;
            // 
            // cmbAuctionEditIDList
            // 
            this.cmbAuctionEditIDList.FormattingEnabled = true;
            this.cmbAuctionEditIDList.Location = new System.Drawing.Point(310, 79);
            this.cmbAuctionEditIDList.Name = "cmbAuctionEditIDList";
            this.cmbAuctionEditIDList.Size = new System.Drawing.Size(121, 21);
            this.cmbAuctionEditIDList.TabIndex = 57;
            // 
            // btnAuctionEditAddStock
            // 
            this.btnAuctionEditAddStock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditAddStock.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditAddStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditAddStock.Location = new System.Drawing.Point(437, 66);
            this.btnAuctionEditAddStock.Name = "btnAuctionEditAddStock";
            this.btnAuctionEditAddStock.Size = new System.Drawing.Size(118, 42);
            this.btnAuctionEditAddStock.TabIndex = 56;
            this.btnAuctionEditAddStock.Text = "ADD";
            this.btnAuctionEditAddStock.UseVisualStyleBackColor = false;
            this.btnAuctionEditAddStock.Click += new System.EventHandler(this.BtnAuctionEditAddStock_Click);
            // 
            // btnAuctionEditViewStock2
            // 
            this.btnAuctionEditViewStock2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditViewStock2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditViewStock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditViewStock2.Location = new System.Drawing.Point(437, 10);
            this.btnAuctionEditViewStock2.Name = "btnAuctionEditViewStock2";
            this.btnAuctionEditViewStock2.Size = new System.Drawing.Size(118, 42);
            this.btnAuctionEditViewStock2.TabIndex = 54;
            this.btnAuctionEditViewStock2.Text = "View Current Stock";
            this.btnAuctionEditViewStock2.UseVisualStyleBackColor = false;
            this.btnAuctionEditViewStock2.Click += new System.EventHandler(this.BtnAuctionEditViewStock2_Click);
            // 
            // lblAuctionEditHint6
            // 
            this.lblAuctionEditHint6.BackColor = System.Drawing.Color.White;
            this.lblAuctionEditHint6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionEditHint6.Location = new System.Drawing.Point(6, 63);
            this.lblAuctionEditHint6.Name = "lblAuctionEditHint6";
            this.lblAuctionEditHint6.Padding = new System.Windows.Forms.Padding(4);
            this.lblAuctionEditHint6.Size = new System.Drawing.Size(549, 49);
            this.lblAuctionEditHint6.TabIndex = 54;
            this.lblAuctionEditHint6.Text = "Select the StockID of the Item you would like to add";
            this.lblAuctionEditHint6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuctionEditHint5
            // 
            this.lblAuctionEditHint5.BackColor = System.Drawing.Color.White;
            this.lblAuctionEditHint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionEditHint5.Location = new System.Drawing.Point(6, 7);
            this.lblAuctionEditHint5.Name = "lblAuctionEditHint5";
            this.lblAuctionEditHint5.Padding = new System.Windows.Forms.Padding(5);
            this.lblAuctionEditHint5.Size = new System.Drawing.Size(549, 49);
            this.lblAuctionEditHint5.TabIndex = 55;
            this.lblAuctionEditHint5.Text = "View current stock for the selected Auction ";
            this.lblAuctionEditHint5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAucEditAddStock
            // 
            this.chkAucEditAddStock.BackColor = System.Drawing.Color.FloralWhite;
            this.chkAucEditAddStock.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAucEditAddStock.Location = new System.Drawing.Point(12, 229);
            this.chkAucEditAddStock.Name = "chkAucEditAddStock";
            this.chkAucEditAddStock.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkAucEditAddStock.Size = new System.Drawing.Size(589, 166);
            this.chkAucEditAddStock.TabIndex = 54;
            this.chkAucEditAddStock.Text = "Add Stock Item To the current Auction";
            this.chkAucEditAddStock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAucEditAddStock.UseVisualStyleBackColor = false;
            this.chkAucEditAddStock.CheckedChanged += new System.EventHandler(this.ChkAucEditAddStock_CheckedChanged);
            // 
            // pnlAuctionEdit4
            // 
            this.pnlAuctionEdit4.BackColor = System.Drawing.Color.Silver;
            this.pnlAuctionEdit4.Controls.Add(this.cbAuctionEditStockID);
            this.pnlAuctionEdit4.Controls.Add(this.btnAuctionEditRemoveStock);
            this.pnlAuctionEdit4.Controls.Add(this.btnAuctionEditViewStock1);
            this.pnlAuctionEdit4.Controls.Add(this.lblAuctionEditHint3);
            this.pnlAuctionEdit4.Controls.Add(this.lblAuctionEditHint4);
            this.pnlAuctionEdit4.Location = new System.Drawing.Point(18, 86);
            this.pnlAuctionEdit4.Name = "pnlAuctionEdit4";
            this.pnlAuctionEdit4.Size = new System.Drawing.Size(577, 128);
            this.pnlAuctionEdit4.TabIndex = 53;
            // 
            // cbAuctionEditStockID
            // 
            this.cbAuctionEditStockID.FormattingEnabled = true;
            this.cbAuctionEditStockID.Location = new System.Drawing.Point(310, 79);
            this.cbAuctionEditStockID.Name = "cbAuctionEditStockID";
            this.cbAuctionEditStockID.Size = new System.Drawing.Size(121, 21);
            this.cbAuctionEditStockID.TabIndex = 57;
            // 
            // btnAuctionEditRemoveStock
            // 
            this.btnAuctionEditRemoveStock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditRemoveStock.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditRemoveStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditRemoveStock.Location = new System.Drawing.Point(437, 66);
            this.btnAuctionEditRemoveStock.Name = "btnAuctionEditRemoveStock";
            this.btnAuctionEditRemoveStock.Size = new System.Drawing.Size(118, 42);
            this.btnAuctionEditRemoveStock.TabIndex = 56;
            this.btnAuctionEditRemoveStock.Text = "Remove";
            this.btnAuctionEditRemoveStock.UseVisualStyleBackColor = false;
            this.btnAuctionEditRemoveStock.Click += new System.EventHandler(this.BtnAuctionEditRemoveStock_Click);
            // 
            // btnAuctionEditViewStock1
            // 
            this.btnAuctionEditViewStock1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditViewStock1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditViewStock1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditViewStock1.Location = new System.Drawing.Point(437, 10);
            this.btnAuctionEditViewStock1.Name = "btnAuctionEditViewStock1";
            this.btnAuctionEditViewStock1.Size = new System.Drawing.Size(118, 42);
            this.btnAuctionEditViewStock1.TabIndex = 54;
            this.btnAuctionEditViewStock1.Text = "View Current Stock";
            this.btnAuctionEditViewStock1.UseVisualStyleBackColor = false;
            this.btnAuctionEditViewStock1.Click += new System.EventHandler(this.BtnAuctionEditViewStock1_Click);
            // 
            // lblAuctionEditHint3
            // 
            this.lblAuctionEditHint3.BackColor = System.Drawing.Color.White;
            this.lblAuctionEditHint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionEditHint3.Location = new System.Drawing.Point(6, 63);
            this.lblAuctionEditHint3.Name = "lblAuctionEditHint3";
            this.lblAuctionEditHint3.Padding = new System.Windows.Forms.Padding(4);
            this.lblAuctionEditHint3.Size = new System.Drawing.Size(549, 49);
            this.lblAuctionEditHint3.TabIndex = 54;
            this.lblAuctionEditHint3.Text = "Select the StockID of the Item you would like to remove";
            this.lblAuctionEditHint3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuctionEditHint4
            // 
            this.lblAuctionEditHint4.BackColor = System.Drawing.Color.White;
            this.lblAuctionEditHint4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionEditHint4.Location = new System.Drawing.Point(6, 7);
            this.lblAuctionEditHint4.Name = "lblAuctionEditHint4";
            this.lblAuctionEditHint4.Padding = new System.Windows.Forms.Padding(5);
            this.lblAuctionEditHint4.Size = new System.Drawing.Size(549, 49);
            this.lblAuctionEditHint4.TabIndex = 55;
            this.lblAuctionEditHint4.Text = "View current stock for the selected Auction ";
            this.lblAuctionEditHint4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAucEditRemoveStock
            // 
            this.chkAucEditRemoveStock.BackColor = System.Drawing.Color.FloralWhite;
            this.chkAucEditRemoveStock.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAucEditRemoveStock.Location = new System.Drawing.Point(12, 57);
            this.chkAucEditRemoveStock.Name = "chkAucEditRemoveStock";
            this.chkAucEditRemoveStock.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkAucEditRemoveStock.Size = new System.Drawing.Size(589, 166);
            this.chkAucEditRemoveStock.TabIndex = 52;
            this.chkAucEditRemoveStock.Text = "Remove Stock Item From the current Auction";
            this.chkAucEditRemoveStock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAucEditRemoveStock.UseVisualStyleBackColor = false;
            this.chkAucEditRemoveStock.CheckedChanged += new System.EventHandler(this.ChkAucEditRemoveStock_CheckedChanged);
            // 
            // dtpAuctionDate
            // 
            this.dtpAuctionDate.Location = new System.Drawing.Point(279, 16);
            this.dtpAuctionDate.Name = "dtpAuctionDate";
            this.dtpAuctionDate.Size = new System.Drawing.Size(190, 20);
            this.dtpAuctionDate.TabIndex = 48;
            // 
            // chkAuctionEditDate
            // 
            this.chkAuctionEditDate.BackColor = System.Drawing.Color.FloralWhite;
            this.chkAuctionEditDate.Location = new System.Drawing.Point(13, 6);
            this.chkAuctionEditDate.Name = "chkAuctionEditDate";
            this.chkAuctionEditDate.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.chkAuctionEditDate.Size = new System.Drawing.Size(470, 45);
            this.chkAuctionEditDate.TabIndex = 50;
            this.chkAuctionEditDate.Text = "Auction Date";
            this.chkAuctionEditDate.UseVisualStyleBackColor = false;
            this.chkAuctionEditDate.CheckedChanged += new System.EventHandler(this.ChkAuctionEditDate_CheckedChanged);
            // 
            // pnlAuctionEdit1
            // 
            this.pnlAuctionEdit1.BackColor = System.Drawing.Color.DimGray;
            this.pnlAuctionEdit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAuctionEdit1.Controls.Add(this.btnEmployeeEditHelp);
            this.pnlAuctionEdit1.Controls.Add(this.btnEmployeeEditBack);
            this.pnlAuctionEdit1.Controls.Add(this.lblAuctionHint2);
            this.pnlAuctionEdit1.Controls.Add(this.pnlAuctionEdit2);
            this.pnlAuctionEdit1.Controls.Add(this.lblAuctionHint1);
            this.pnlAuctionEdit1.Controls.Add(this.pnlAuctionEdit3);
            this.pnlAuctionEdit1.Location = new System.Drawing.Point(37, 73);
            this.pnlAuctionEdit1.Name = "pnlAuctionEdit1";
            this.pnlAuctionEdit1.Size = new System.Drawing.Size(717, 620);
            this.pnlAuctionEdit1.TabIndex = 49;
            // 
            // btnEmployeeEditHelp
            // 
            this.btnEmployeeEditHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditHelp.Location = new System.Drawing.Point(49, 544);
            this.btnEmployeeEditHelp.Name = "btnEmployeeEditHelp";
            this.btnEmployeeEditHelp.Size = new System.Drawing.Size(117, 45);
            this.btnEmployeeEditHelp.TabIndex = 46;
            this.btnEmployeeEditHelp.Text = "H E L P";
            this.btnEmployeeEditHelp.UseVisualStyleBackColor = false;
            this.btnEmployeeEditHelp.Click += new System.EventHandler(this.BtnEmployeeEditHelp_Click);
            // 
            // btnEmployeeEditBack
            // 
            this.btnEmployeeEditBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditBack.Location = new System.Drawing.Point(549, 544);
            this.btnEmployeeEditBack.Name = "btnEmployeeEditBack";
            this.btnEmployeeEditBack.Size = new System.Drawing.Size(117, 45);
            this.btnEmployeeEditBack.TabIndex = 45;
            this.btnEmployeeEditBack.Text = "B A C K";
            this.btnEmployeeEditBack.UseVisualStyleBackColor = false;
            this.btnEmployeeEditBack.Click += new System.EventHandler(this.btnEmployeeEditBack_Click);
            // 
            // lblAuctionHint2
            // 
            this.lblAuctionHint2.AutoSize = true;
            this.lblAuctionHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuctionHint2.Location = new System.Drawing.Point(52, 79);
            this.lblAuctionHint2.Name = "lblAuctionHint2";
            this.lblAuctionHint2.Size = new System.Drawing.Size(439, 20);
            this.lblAuctionHint2.TabIndex = 42;
            this.lblAuctionHint2.Text = "Select the check box of the field you would like to edit";
            // 
            // pnlAuctionEdit2
            // 
            this.pnlAuctionEdit2.BackColor = System.Drawing.Color.White;
            this.pnlAuctionEdit2.Controls.Add(this.cmbAucEditIDSelect);
            this.pnlAuctionEdit2.Controls.Add(this.btnAuctionEditSearch);
            this.pnlAuctionEdit2.Controls.Add(this.lblAuctionIDView);
            this.pnlAuctionEdit2.Location = new System.Drawing.Point(49, 33);
            this.pnlAuctionEdit2.Name = "pnlAuctionEdit2";
            this.pnlAuctionEdit2.Size = new System.Drawing.Size(617, 34);
            this.pnlAuctionEdit2.TabIndex = 41;
            // 
            // cmbAucEditIDSelect
            // 
            this.cmbAucEditIDSelect.FormattingEnabled = true;
            this.cmbAucEditIDSelect.Location = new System.Drawing.Point(322, 6);
            this.cmbAucEditIDSelect.Name = "cmbAucEditIDSelect";
            this.cmbAucEditIDSelect.Size = new System.Drawing.Size(147, 21);
            this.cmbAucEditIDSelect.TabIndex = 58;
            // 
            // btnAuctionEditSearch
            // 
            this.btnAuctionEditSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionEditSearch.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionEditSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionEditSearch.Location = new System.Drawing.Point(500, 0);
            this.btnAuctionEditSearch.Name = "btnAuctionEditSearch";
            this.btnAuctionEditSearch.Size = new System.Drawing.Size(90, 30);
            this.btnAuctionEditSearch.TabIndex = 44;
            this.btnAuctionEditSearch.Text = "SEARCH";
            this.btnAuctionEditSearch.UseVisualStyleBackColor = false;
            this.btnAuctionEditSearch.Click += new System.EventHandler(this.BtnAuctionEditSearch_Click);
            // 
            // lblAuctionIDView
            // 
            this.lblAuctionIDView.AutoSize = true;
            this.lblAuctionIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionIDView.Location = new System.Drawing.Point(10, 7);
            this.lblAuctionIDView.Name = "lblAuctionIDView";
            this.lblAuctionIDView.Size = new System.Drawing.Size(68, 16);
            this.lblAuctionIDView.TabIndex = 41;
            this.lblAuctionIDView.Text = "Auction ID";
            // 
            // lblAuctionHint1
            // 
            this.lblAuctionHint1.AutoSize = true;
            this.lblAuctionHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionHint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuctionHint1.Location = new System.Drawing.Point(57, 10);
            this.lblAuctionHint1.Name = "lblAuctionHint1";
            this.lblAuctionHint1.Size = new System.Drawing.Size(468, 20);
            this.lblAuctionHint1.TabIndex = 39;
            this.lblAuctionHint1.Text = "Select the AuctionID of the Auction you would like to Edit";
            // 
            // frmAuction_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.lblAuctionEditHeading);
            this.Controls.Add(this.pnlAuctionEdit1);
            this.Controls.Add(this.pbEmployeeEdit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 750);
            this.MinimumSize = new System.Drawing.Size(816, 726);
            this.Name = "frmAuction_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Auction";
            this.Load += new System.EventHandler(this.FrmAuction_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeEdit)).EndInit();
            this.pnlAuctionEdit3.ResumeLayout(false);
            this.pnlAuctionEdit5.ResumeLayout(false);
            this.pnlAuctionEdit4.ResumeLayout(false);
            this.pnlAuctionEdit1.ResumeLayout(false);
            this.pnlAuctionEdit1.PerformLayout();
            this.pnlAuctionEdit2.ResumeLayout(false);
            this.pnlAuctionEdit2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAuctionEditHeading;
        private System.Windows.Forms.PictureBox pbEmployeeEdit;
        private System.Windows.Forms.Button btnAuctionEditApplyDate;
        private System.Windows.Forms.Panel pnlAuctionEdit3;
        private System.Windows.Forms.Panel pnlAuctionEdit1;
        private System.Windows.Forms.Button btnEmployeeEditHelp;
        private System.Windows.Forms.Button btnEmployeeEditBack;
        private System.Windows.Forms.Label lblAuctionHint2;
        private System.Windows.Forms.Panel pnlAuctionEdit2;
        private System.Windows.Forms.Button btnAuctionEditSearch;
        private System.Windows.Forms.Label lblAuctionIDView;
        private System.Windows.Forms.Label lblAuctionHint1;
        private System.Windows.Forms.DateTimePicker dtpAuctionDate;
        private System.Windows.Forms.CheckBox chkAuctionEditDate;
        private System.Windows.Forms.Button btnAuctionEditViewStock1;
        private System.Windows.Forms.Panel pnlAuctionEdit4;
        private System.Windows.Forms.CheckBox chkAucEditRemoveStock;
        private System.Windows.Forms.Label lblAuctionEditHint4;
        private System.Windows.Forms.Label lblAuctionEditHint3;
        private System.Windows.Forms.Panel pnlAuctionEdit5;
        private System.Windows.Forms.ComboBox cmbAuctionEditIDList;
        private System.Windows.Forms.Button btnAuctionEditAddStock;
        private System.Windows.Forms.Button btnAuctionEditViewStock2;
        private System.Windows.Forms.Label lblAuctionEditHint6;
        private System.Windows.Forms.Label lblAuctionEditHint5;
        private System.Windows.Forms.CheckBox chkAucEditAddStock;
        private System.Windows.Forms.ComboBox cbAuctionEditStockID;
        private System.Windows.Forms.Button btnAuctionEditRemoveStock;
        private System.Windows.Forms.ComboBox cmbAucEditIDSelect;
    }
}