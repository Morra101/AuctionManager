namespace Auction_Manager
{
    partial class frmStock_Delete
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
            this.lblStockHint2 = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch = new System.Windows.Forms.Panel();
            this.cmbStockID = new System.Windows.Forms.ComboBox();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.lblStockHint1 = new System.Windows.Forms.Label();
            this.lblSupplierDeleteHeading = new System.Windows.Forms.Label();
            this.bynSupplierViewHelp = new System.Windows.Forms.Button();
            this.dbStockDelete = new System.Windows.Forms.DataGridView();
            this.pbBackSuppDelete = new System.Windows.Forms.PictureBox();
            this.btnStockBackToLand = new System.Windows.Forms.Button();
            this.pnlSuppDeleteSearch1.SuspendLayout();
            this.pnlSuppViewSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuppDeleteSearch1
            // 
            this.pnlSuppDeleteSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppDeleteSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppDeleteSearch1.Controls.Add(this.lblStockHint2);
            this.pnlSuppDeleteSearch1.Controls.Add(this.pnlSuppViewSearch);
            this.pnlSuppDeleteSearch1.Controls.Add(this.lblStockHint1);
            this.pnlSuppDeleteSearch1.Location = new System.Drawing.Point(37, 311);
            this.pnlSuppDeleteSearch1.Name = "pnlSuppDeleteSearch1";
            this.pnlSuppDeleteSearch1.Size = new System.Drawing.Size(709, 100);
            this.pnlSuppDeleteSearch1.TabIndex = 61;
            // 
            // lblStockHint2
            // 
            this.lblStockHint2.AutoSize = true;
            this.lblStockHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockHint2.Location = new System.Drawing.Point(103, 60);
            this.lblStockHint2.Name = "lblStockHint2";
            this.lblStockHint2.Size = new System.Drawing.Size(477, 20);
            this.lblStockHint2.TabIndex = 42;
            this.lblStockHint2.Text = "Please note Stock that has been sold can not be removed ";
            // 
            // pnlSuppViewSearch
            // 
            this.pnlSuppViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlSuppViewSearch.Controls.Add(this.cmbStockID);
            this.pnlSuppViewSearch.Controls.Add(this.btnRemoveStock);
            this.pnlSuppViewSearch.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppViewSearch.Location = new System.Drawing.Point(107, 23);
            this.pnlSuppViewSearch.Name = "pnlSuppViewSearch";
            this.pnlSuppViewSearch.Size = new System.Drawing.Size(509, 34);
            this.pnlSuppViewSearch.TabIndex = 41;
            // 
            // cmbStockID
            // 
            this.cmbStockID.FormattingEnabled = true;
            this.cmbStockID.Items.AddRange(new object[] {
            "00000124",
            "00000125",
            "00000126",
            "00000127",
            "00000128",
            "00000129",
            "00000130"});
            this.cmbStockID.Location = new System.Drawing.Point(255, 6);
            this.cmbStockID.Name = "cmbStockID";
            this.cmbStockID.Size = new System.Drawing.Size(146, 21);
            this.cmbStockID.TabIndex = 45;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveStock.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveStock.Location = new System.Drawing.Point(407, 3);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(90, 30);
            this.btnRemoveStock.TabIndex = 44;
            this.btnRemoveStock.Text = "REMOVE ";
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // lblSupplierIDView
            // 
            this.lblSupplierIDView.AutoSize = true;
            this.lblSupplierIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDView.Location = new System.Drawing.Point(10, 7);
            this.lblSupplierIDView.Name = "lblSupplierIDView";
            this.lblSupplierIDView.Size = new System.Drawing.Size(58, 16);
            this.lblSupplierIDView.TabIndex = 41;
            this.lblSupplierIDView.Text = "Stock ID";
            // 
            // lblStockHint1
            // 
            this.lblStockHint1.AutoSize = true;
            this.lblStockHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockHint1.Location = new System.Drawing.Point(103, 0);
            this.lblStockHint1.Name = "lblStockHint1";
            this.lblStockHint1.Size = new System.Drawing.Size(473, 20);
            this.lblStockHint1.TabIndex = 39;
            this.lblStockHint1.Text = "Select the StockID of the vehicle you would like to remove";
            // 
            // lblSupplierDeleteHeading
            // 
            this.lblSupplierDeleteHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierDeleteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDeleteHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierDeleteHeading.Location = new System.Drawing.Point(29, 25);
            this.lblSupplierDeleteHeading.Name = "lblSupplierDeleteHeading";
            this.lblSupplierDeleteHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSupplierDeleteHeading.TabIndex = 60;
            this.lblSupplierDeleteHeading.Text = "REMOVE STOCK";
            this.lblSupplierDeleteHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bynSupplierViewHelp
            // 
            this.bynSupplierViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bynSupplierViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynSupplierViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bynSupplierViewHelp.Location = new System.Drawing.Point(37, 419);
            this.bynSupplierViewHelp.Name = "bynSupplierViewHelp";
            this.bynSupplierViewHelp.Size = new System.Drawing.Size(117, 45);
            this.bynSupplierViewHelp.TabIndex = 63;
            this.bynSupplierViewHelp.Text = "H E L P";
            this.bynSupplierViewHelp.UseVisualStyleBackColor = false;
            this.bynSupplierViewHelp.Click += new System.EventHandler(this.bynSupplierViewHelp_Click);
            // 
            // dbStockDelete
            // 
            this.dbStockDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbStockDelete.Location = new System.Drawing.Point(29, 81);
            this.dbStockDelete.Name = "dbStockDelete";
            this.dbStockDelete.ReadOnly = true;
            this.dbStockDelete.Size = new System.Drawing.Size(717, 224);
            this.dbStockDelete.TabIndex = 65;
            // 
            // pbBackSuppDelete
            // 
            this.pbBackSuppDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Location = new System.Drawing.Point(-264, -6);
            this.pbBackSuppDelete.Name = "pbBackSuppDelete";
            this.pbBackSuppDelete.Size = new System.Drawing.Size(1076, 719);
            this.pbBackSuppDelete.TabIndex = 62;
            this.pbBackSuppDelete.TabStop = false;
            this.pbBackSuppDelete.Click += new System.EventHandler(this.pbBackSuppDelete_Click);
            // 
            // btnStockBackToLand
            // 
            this.btnStockBackToLand.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStockBackToLand.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockBackToLand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockBackToLand.Location = new System.Drawing.Point(629, 417);
            this.btnStockBackToLand.Name = "btnStockBackToLand";
            this.btnStockBackToLand.Size = new System.Drawing.Size(117, 45);
            this.btnStockBackToLand.TabIndex = 64;
            this.btnStockBackToLand.Text = "B A C K";
            this.btnStockBackToLand.UseVisualStyleBackColor = false;
            this.btnStockBackToLand.Click += new System.EventHandler(this.btnSuppBackToLand_Click);
            // 
            // frmStock_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 481);
            this.Controls.Add(this.pnlSuppDeleteSearch1);
            this.Controls.Add(this.lblSupplierDeleteHeading);
            this.Controls.Add(this.bynSupplierViewHelp);
            this.Controls.Add(this.dbStockDelete);
            this.Controls.Add(this.btnStockBackToLand);
            this.Controls.Add(this.pbBackSuppDelete);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 520);
            this.MinimumSize = new System.Drawing.Size(801, 520);
            this.Name = "frmStock_Delete";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Stock Item";
            this.Load += new System.EventHandler(this.FrmStock_Delete_Load);
            this.pnlSuppDeleteSearch1.ResumeLayout(false);
            this.pnlSuppDeleteSearch1.PerformLayout();
            this.pnlSuppViewSearch.ResumeLayout(false);
            this.pnlSuppViewSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbStockDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppDeleteSearch1;
        private System.Windows.Forms.Label lblStockHint2;
        private System.Windows.Forms.Panel pnlSuppViewSearch;
        private System.Windows.Forms.ComboBox cmbStockID;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Label lblStockHint1;
        private System.Windows.Forms.Label lblSupplierDeleteHeading;
        private System.Windows.Forms.Button bynSupplierViewHelp;
        private System.Windows.Forms.DataGridView dbStockDelete;
        private System.Windows.Forms.PictureBox pbBackSuppDelete;
        private System.Windows.Forms.Button btnStockBackToLand;
    }
}