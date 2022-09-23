
namespace Auction_Manager
{
    partial class frmBidsFromBuyers
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
            this.btnSuppViewBack = new System.Windows.Forms.Button();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSupplierViewHint2 = new System.Windows.Forms.Label();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch2 = new System.Windows.Forms.Panel();
            this.cmbPurch = new System.Windows.Forms.ComboBox();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblStockID = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSuppliersAddAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPurch = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch1 = new System.Windows.Forms.Panel();
            this.dbgBidView = new System.Windows.Forms.DataGridView();
            this.pnlAuctionEdit2 = new System.Windows.Forms.Panel();
            this.cmbBidAucId = new System.Windows.Forms.ComboBox();
            this.btnEmployeeEditSearch1 = new System.Windows.Forms.Button();
            this.lblAuctionIDView = new System.Windows.Forms.Label();
            this.lblSuppliersAddHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuppViewSearch2.SuspendLayout();
            this.pnlSuppViewSearch1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgBidView)).BeginInit();
            this.pnlAuctionEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppViewBack
            // 
            this.btnSuppViewBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppViewBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppViewBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppViewBack.Location = new System.Drawing.Point(562, 535);
            this.btnSuppViewBack.Name = "btnSuppViewBack";
            this.btnSuppViewBack.Size = new System.Drawing.Size(80, 45);
            this.btnSuppViewBack.TabIndex = 53;
            this.btnSuppViewBack.Text = "B A C K";
            this.btnSuppViewBack.UseVisualStyleBackColor = false;
            this.btnSuppViewBack.Click += new System.EventHandler(this.btnSuppViewBack_Click);
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(328, 126);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(267, 20);
            this.txtBid.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(20, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 64;
            this.button1.Text = "H E L P";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSupplierViewHint2
            // 
            this.lblSupplierViewHint2.AutoSize = true;
            this.lblSupplierViewHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierViewHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSupplierViewHint2.Location = new System.Drawing.Point(16, 78);
            this.lblSupplierViewHint2.Name = "lblSupplierViewHint2";
            this.lblSupplierViewHint2.Size = new System.Drawing.Size(437, 20);
            this.lblSupplierViewHint2.TabIndex = 42;
            this.lblSupplierViewHint2.Text = "Below are all the stock Items for the selected Auction";
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(21, 9);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(374, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Select the Auction you wish to Input Data For";
            // 
            // pnlSuppViewSearch2
            // 
            this.pnlSuppViewSearch2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSuppViewSearch2.Controls.Add(this.cmbPurch);
            this.pnlSuppViewSearch2.Controls.Add(this.lblNumItems);
            this.pnlSuppViewSearch2.Controls.Add(this.label3);
            this.pnlSuppViewSearch2.Controls.Add(this.btnApply);
            this.pnlSuppViewSearch2.Controls.Add(this.lblStockID);
            this.pnlSuppViewSearch2.Controls.Add(this.btnNext);
            this.pnlSuppViewSearch2.Controls.Add(this.txtBid);
            this.pnlSuppViewSearch2.Controls.Add(this.lblSuppliersAddAddress);
            this.pnlSuppViewSearch2.Controls.Add(this.label2);
            this.pnlSuppViewSearch2.Controls.Add(this.lblPurch);
            this.pnlSuppViewSearch2.Location = new System.Drawing.Point(20, 274);
            this.pnlSuppViewSearch2.Name = "pnlSuppViewSearch2";
            this.pnlSuppViewSearch2.Size = new System.Drawing.Size(622, 255);
            this.pnlSuppViewSearch2.TabIndex = 29;
            // 
            // cmbPurch
            // 
            this.cmbPurch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurch.FormattingEnabled = true;
            this.cmbPurch.Location = new System.Drawing.Point(328, 77);
            this.cmbPurch.Name = "cmbPurch";
            this.cmbPurch.Size = new System.Drawing.Size(267, 21);
            this.cmbPurch.TabIndex = 46;
            // 
            // lblNumItems
            // 
            this.lblNumItems.BackColor = System.Drawing.Color.White;
            this.lblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.Location = new System.Drawing.Point(365, 167);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(233, 39);
            this.lblNumItems.TabIndex = 69;
            this.lblNumItems.Text = ": 1 of 20";
            this.lblNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(583, 39);
            this.label3.TabIndex = 67;
            this.label3.Text = "Number of Items to Process";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(368, 209);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(109, 36);
            this.btnApply.TabIndex = 65;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblStockID
            // 
            this.lblStockID.BackColor = System.Drawing.Color.DimGray;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStockID.Location = new System.Drawing.Point(328, 23);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblStockID.Size = new System.Drawing.Size(267, 29);
            this.lblStockID.TabIndex = 64;
            this.lblStockID.Text = "lblStockID";
            this.lblStockID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(489, 209);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 36);
            this.btnNext.TabIndex = 63;
            this.btnNext.Text = "Next Item";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblSuppliersAddAddress
            // 
            this.lblSuppliersAddAddress.BackColor = System.Drawing.Color.White;
            this.lblSuppliersAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddAddress.Location = new System.Drawing.Point(15, 18);
            this.lblSuppliersAddAddress.Name = "lblSuppliersAddAddress";
            this.lblSuppliersAddAddress.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSuppliersAddAddress.Size = new System.Drawing.Size(583, 39);
            this.lblSuppliersAddAddress.TabIndex = 61;
            this.lblSuppliersAddAddress.Text = "StockID";
            this.lblSuppliersAddAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(583, 39);
            this.label2.TabIndex = 66;
            this.label2.Text = "Bid Price( Excl VAT ) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPurch
            // 
            this.lblPurch.BackColor = System.Drawing.Color.White;
            this.lblPurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurch.Location = new System.Drawing.Point(15, 67);
            this.lblPurch.Name = "lblPurch";
            this.lblPurch.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPurch.Size = new System.Drawing.Size(583, 39);
            this.lblPurch.TabIndex = 70;
            this.lblPurch.Text = "PurchID";
            this.lblPurch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSuppViewSearch1
            // 
            this.pnlSuppViewSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppViewSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppViewSearch1.Controls.Add(this.dbgBidView);
            this.pnlSuppViewSearch1.Controls.Add(this.pnlAuctionEdit2);
            this.pnlSuppViewSearch1.Controls.Add(this.btnSuppViewBack);
            this.pnlSuppViewSearch1.Controls.Add(this.button1);
            this.pnlSuppViewSearch1.Controls.Add(this.lblSupplierViewHint2);
            this.pnlSuppViewSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppViewSearch1.Controls.Add(this.pnlSuppViewSearch2);
            this.pnlSuppViewSearch1.Location = new System.Drawing.Point(54, 65);
            this.pnlSuppViewSearch1.Name = "pnlSuppViewSearch1";
            this.pnlSuppViewSearch1.Size = new System.Drawing.Size(677, 607);
            this.pnlSuppViewSearch1.TabIndex = 42;
            // 
            // dbgBidView
            // 
            this.dbgBidView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgBidView.Location = new System.Drawing.Point(20, 101);
            this.dbgBidView.Name = "dbgBidView";
            this.dbgBidView.Size = new System.Drawing.Size(622, 167);
            this.dbgBidView.TabIndex = 65;
            // 
            // pnlAuctionEdit2
            // 
            this.pnlAuctionEdit2.BackColor = System.Drawing.Color.White;
            this.pnlAuctionEdit2.Controls.Add(this.cmbBidAucId);
            this.pnlAuctionEdit2.Controls.Add(this.btnEmployeeEditSearch1);
            this.pnlAuctionEdit2.Controls.Add(this.lblAuctionIDView);
            this.pnlAuctionEdit2.Location = new System.Drawing.Point(25, 32);
            this.pnlAuctionEdit2.Name = "pnlAuctionEdit2";
            this.pnlAuctionEdit2.Size = new System.Drawing.Size(617, 34);
            this.pnlAuctionEdit2.TabIndex = 43;
            // 
            // cmbBidAucId
            // 
            this.cmbBidAucId.FormattingEnabled = true;
            this.cmbBidAucId.Location = new System.Drawing.Point(323, 6);
            this.cmbBidAucId.Name = "cmbBidAucId";
            this.cmbBidAucId.Size = new System.Drawing.Size(171, 21);
            this.cmbBidAucId.TabIndex = 45;
            // 
            // btnEmployeeEditSearch1
            // 
            this.btnEmployeeEditSearch1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeEditSearch1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEditSearch1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeEditSearch1.Location = new System.Drawing.Point(500, 0);
            this.btnEmployeeEditSearch1.Name = "btnEmployeeEditSearch1";
            this.btnEmployeeEditSearch1.Size = new System.Drawing.Size(90, 30);
            this.btnEmployeeEditSearch1.TabIndex = 44;
            this.btnEmployeeEditSearch1.Text = "Proceed";
            this.btnEmployeeEditSearch1.UseVisualStyleBackColor = false;
            this.btnEmployeeEditSearch1.Click += new System.EventHandler(this.BtnEmployeeEditSearch1_Click);
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
            // lblSuppliersAddHeading
            // 
            this.lblSuppliersAddHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuppliersAddHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersAddHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuppliersAddHeading.Location = new System.Drawing.Point(46, 9);
            this.lblSuppliersAddHeading.Name = "lblSuppliersAddHeading";
            this.lblSuppliersAddHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSuppliersAddHeading.TabIndex = 40;
            this.lblSuppliersAddHeading.Text = "RECEIVE AUCTION BIDS";
            this.lblSuppliersAddHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pictureBox1.Location = new System.Drawing.Point(-139, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 749);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // frmBidsFromBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.pnlSuppViewSearch1);
            this.Controls.Add(this.lblSuppliersAddHeading);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 750);
            this.MinimumSize = new System.Drawing.Size(806, 750);
            this.Name = "frmBidsFromBuyers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBidsFromBuyers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBidsFromBuyers_FormClosing);
            this.Load += new System.EventHandler(this.FrmBidsFromBuyers_Load);
            this.pnlSuppViewSearch2.ResumeLayout(false);
            this.pnlSuppViewSearch2.PerformLayout();
            this.pnlSuppViewSearch1.ResumeLayout(false);
            this.pnlSuppViewSearch1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgBidView)).EndInit();
            this.pnlAuctionEdit2.ResumeLayout(false);
            this.pnlAuctionEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSuppViewBack;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSupplierViewHint2;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Panel pnlSuppViewSearch2;
        private System.Windows.Forms.Label lblSuppliersAddAddress;
        private System.Windows.Forms.Panel pnlSuppViewSearch1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSuppliersAddHeading;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dbgBidView;
        private System.Windows.Forms.Panel pnlAuctionEdit2;
        private System.Windows.Forms.ComboBox cmbBidAucId;
        private System.Windows.Forms.Button btnEmployeeEditSearch1;
        private System.Windows.Forms.Label lblAuctionIDView;
        private System.Windows.Forms.Label lblPurch;
        private System.Windows.Forms.ComboBox cmbPurch;
    }
}