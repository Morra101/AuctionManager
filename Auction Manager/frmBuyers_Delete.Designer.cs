namespace Auction_Manager
{
    partial class frmBuyers_Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch = new System.Windows.Forms.Panel();
            this.CB_buyerDel = new System.Windows.Forms.ComboBox();
            this.btnSearchbuyerRemove = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.lblSupplierDeleteHeading = new System.Windows.Forms.Label();
            this.btnSuppBackToLand = new System.Windows.Forms.Button();
            this.bynSupplierViewHelp = new System.Windows.Forms.Button();
            this.pbBackSuppDelete = new System.Windows.Forms.PictureBox();
            this.DB_buyerDel = new System.Windows.Forms.DataGridView();
            this.pnlSuppDeleteSearch1.SuspendLayout();
            this.pnlSuppViewSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_buyerDel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuppDeleteSearch1
            // 
            this.pnlSuppDeleteSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppDeleteSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppDeleteSearch1.Controls.Add(this.label1);
            this.pnlSuppDeleteSearch1.Controls.Add(this.pnlSuppViewSearch);
            this.pnlSuppDeleteSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppDeleteSearch1.Location = new System.Drawing.Point(69, 315);
            this.pnlSuppDeleteSearch1.Name = "pnlSuppDeleteSearch1";
            this.pnlSuppDeleteSearch1.Size = new System.Drawing.Size(709, 100);
            this.pnlSuppDeleteSearch1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Please note a buyer that has purchased stock items cant be removed";
            // 
            // pnlSuppViewSearch
            // 
            this.pnlSuppViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlSuppViewSearch.Controls.Add(this.CB_buyerDel);
            this.pnlSuppViewSearch.Controls.Add(this.btnSearchbuyerRemove);
            this.pnlSuppViewSearch.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppViewSearch.Location = new System.Drawing.Point(107, 23);
            this.pnlSuppViewSearch.Name = "pnlSuppViewSearch";
            this.pnlSuppViewSearch.Size = new System.Drawing.Size(509, 34);
            this.pnlSuppViewSearch.TabIndex = 41;
            // 
            // CB_buyerDel
            // 
            this.CB_buyerDel.FormattingEnabled = true;
            this.CB_buyerDel.Items.AddRange(new object[] {
            "00000124",
            "00000125",
            "00000126",
            "00000127",
            "00000128",
            "00000129",
            "00000130"});
            this.CB_buyerDel.Location = new System.Drawing.Point(255, 6);
            this.CB_buyerDel.Name = "CB_buyerDel";
            this.CB_buyerDel.Size = new System.Drawing.Size(146, 21);
            this.CB_buyerDel.TabIndex = 45;
            // 
            // btnSearchbuyerRemove
            // 
            this.btnSearchbuyerRemove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchbuyerRemove.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbuyerRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchbuyerRemove.Location = new System.Drawing.Point(407, 3);
            this.btnSearchbuyerRemove.Name = "btnSearchbuyerRemove";
            this.btnSearchbuyerRemove.Size = new System.Drawing.Size(90, 30);
            this.btnSearchbuyerRemove.TabIndex = 44;
            this.btnSearchbuyerRemove.Text = "DELETE";
            this.btnSearchbuyerRemove.UseVisualStyleBackColor = false;
            this.btnSearchbuyerRemove.Click += new System.EventHandler(this.btnSearchbuyerRemove_Click);
            // 
            // lblSupplierIDView
            // 
            this.lblSupplierIDView.AutoSize = true;
            this.lblSupplierIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDView.Location = new System.Drawing.Point(10, 7);
            this.lblSupplierIDView.Name = "lblSupplierIDView";
            this.lblSupplierIDView.Size = new System.Drawing.Size(59, 16);
            this.lblSupplierIDView.TabIndex = 41;
            this.lblSupplierIDView.Text = "Buyer ID";
            // 
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(103, 0);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(454, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Select the BuyerID of the buyer you would like to delete";
            // 
            // lblSupplierDeleteHeading
            // 
            this.lblSupplierDeleteHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierDeleteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDeleteHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierDeleteHeading.Location = new System.Drawing.Point(61, 29);
            this.lblSupplierDeleteHeading.Name = "lblSupplierDeleteHeading";
            this.lblSupplierDeleteHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSupplierDeleteHeading.TabIndex = 54;
            this.lblSupplierDeleteHeading.Text = "REMOVE BUYER";
            this.lblSupplierDeleteHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSuppBackToLand
            // 
            this.btnSuppBackToLand.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppBackToLand.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppBackToLand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppBackToLand.Location = new System.Drawing.Point(661, 421);
            this.btnSuppBackToLand.Name = "btnSuppBackToLand";
            this.btnSuppBackToLand.Size = new System.Drawing.Size(117, 45);
            this.btnSuppBackToLand.TabIndex = 58;
            this.btnSuppBackToLand.Text = "B A C K";
            this.btnSuppBackToLand.UseVisualStyleBackColor = false;
            this.btnSuppBackToLand.Click += new System.EventHandler(this.btnSuppBackToLand_Click);
            // 
            // bynSupplierViewHelp
            // 
            this.bynSupplierViewHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bynSupplierViewHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynSupplierViewHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bynSupplierViewHelp.Location = new System.Drawing.Point(69, 423);
            this.bynSupplierViewHelp.Name = "bynSupplierViewHelp";
            this.bynSupplierViewHelp.Size = new System.Drawing.Size(117, 45);
            this.bynSupplierViewHelp.TabIndex = 57;
            this.bynSupplierViewHelp.Text = "H E L P";
            this.bynSupplierViewHelp.UseVisualStyleBackColor = false;
            this.bynSupplierViewHelp.Click += new System.EventHandler(this.bynSupplierViewHelp_Click);
            // 
            // pbBackSuppDelete
            // 
            this.pbBackSuppDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Location = new System.Drawing.Point(-232, -2);
            this.pbBackSuppDelete.Name = "pbBackSuppDelete";
            this.pbBackSuppDelete.Size = new System.Drawing.Size(1076, 719);
            this.pbBackSuppDelete.TabIndex = 56;
            this.pbBackSuppDelete.TabStop = false;
            // 
            // DB_buyerDel
            // 
            this.DB_buyerDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_buyerDel.Location = new System.Drawing.Point(61, 85);
            this.DB_buyerDel.Name = "DB_buyerDel";
            this.DB_buyerDel.ReadOnly = true;
            this.DB_buyerDel.Size = new System.Drawing.Size(717, 224);
            this.DB_buyerDel.TabIndex = 59;
            this.DB_buyerDel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DB_buyerDel_CellClick);
            // 
            // frmBuyers_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 481);
            this.Controls.Add(this.DB_buyerDel);
            this.Controls.Add(this.pnlSuppDeleteSearch1);
            this.Controls.Add(this.lblSupplierDeleteHeading);
            this.Controls.Add(this.btnSuppBackToLand);
            this.Controls.Add(this.bynSupplierViewHelp);
            this.Controls.Add(this.pbBackSuppDelete);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(861, 520);
            this.MinimumSize = new System.Drawing.Size(861, 520);
            this.Name = "frmBuyers_Delete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Buyer ";
            this.Load += new System.EventHandler(this.FrmBuyers_Delete_Load);
            this.pnlSuppDeleteSearch1.ResumeLayout(false);
            this.pnlSuppDeleteSearch1.PerformLayout();
            this.pnlSuppViewSearch.ResumeLayout(false);
            this.pnlSuppViewSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_buyerDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppDeleteSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSuppViewSearch;
        private System.Windows.Forms.ComboBox CB_buyerDel;
        private System.Windows.Forms.Button btnSearchbuyerRemove;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Label lblSupplierDeleteHeading;
        private System.Windows.Forms.Button btnSuppBackToLand;
        private System.Windows.Forms.Button bynSupplierViewHelp;
        private System.Windows.Forms.PictureBox pbBackSuppDelete;
        private System.Windows.Forms.DataGridView DB_buyerDel;
    }
}