
namespace Auction_Manager
{
    partial class frmAuctionDelete
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
            this.pnlAuctionDeleteSearch1 = new System.Windows.Forms.Panel();
            this.lblAuctionRemoveHint2 = new System.Windows.Forms.Label();
            this.pnlSuppViewSearch = new System.Windows.Forms.Panel();
            this.cmbAucDelete = new System.Windows.Forms.ComboBox();
            this.btnAuctionRemove = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.lblAuctionRemoveHint1 = new System.Windows.Forms.Label();
            this.btnAucRemoveBack = new System.Windows.Forms.Button();
            this.btnAuctionRemoveHelp = new System.Windows.Forms.Button();
            this.lblAuctionDeleteHeading = new System.Windows.Forms.Label();
            this.pbAuctionRemove = new System.Windows.Forms.PictureBox();
            this.dbgAuctionRemove = new System.Windows.Forms.DataGridView();
            this.pnlAuctionDeleteSearch1.SuspendLayout();
            this.pnlSuppViewSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuctionRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgAuctionRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAuctionDeleteSearch1
            // 
            this.pnlAuctionDeleteSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlAuctionDeleteSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAuctionDeleteSearch1.Controls.Add(this.lblAuctionRemoveHint2);
            this.pnlAuctionDeleteSearch1.Controls.Add(this.pnlSuppViewSearch);
            this.pnlAuctionDeleteSearch1.Controls.Add(this.lblAuctionRemoveHint1);
            this.pnlAuctionDeleteSearch1.Location = new System.Drawing.Point(20, 299);
            this.pnlAuctionDeleteSearch1.Name = "pnlAuctionDeleteSearch1";
            this.pnlAuctionDeleteSearch1.Size = new System.Drawing.Size(709, 100);
            this.pnlAuctionDeleteSearch1.TabIndex = 49;
            // 
            // lblAuctionRemoveHint2
            // 
            this.lblAuctionRemoveHint2.AutoSize = true;
            this.lblAuctionRemoveHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionRemoveHint2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuctionRemoveHint2.Location = new System.Drawing.Point(63, 76);
            this.lblAuctionRemoveHint2.Name = "lblAuctionRemoveHint2";
            this.lblAuctionRemoveHint2.Size = new System.Drawing.Size(605, 20);
            this.lblAuctionRemoveHint2.TabIndex = 42;
            this.lblAuctionRemoveHint2.Text = "Please note an auction that has had stock items sold in it cant be removed";
            // 
            // pnlSuppViewSearch
            // 
            this.pnlSuppViewSearch.BackColor = System.Drawing.Color.White;
            this.pnlSuppViewSearch.Controls.Add(this.cmbAucDelete);
            this.pnlSuppViewSearch.Controls.Add(this.btnAuctionRemove);
            this.pnlSuppViewSearch.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppViewSearch.Location = new System.Drawing.Point(107, 23);
            this.pnlSuppViewSearch.Name = "pnlSuppViewSearch";
            this.pnlSuppViewSearch.Size = new System.Drawing.Size(509, 34);
            this.pnlSuppViewSearch.TabIndex = 41;
            // 
            // cmbAucDelete
            // 
            this.cmbAucDelete.DropDownHeight = 100;
            this.cmbAucDelete.FormattingEnabled = true;
            this.cmbAucDelete.IntegralHeight = false;
            this.cmbAucDelete.ItemHeight = 13;
            this.cmbAucDelete.Items.AddRange(new object[] {
            "00000124",
            "00000125",
            "00000126",
            "00000127",
            "00000128",
            "00000129",
            "00000130"});
            this.cmbAucDelete.Location = new System.Drawing.Point(255, 6);
            this.cmbAucDelete.MaxDropDownItems = 5;
            this.cmbAucDelete.MaxLength = 5;
            this.cmbAucDelete.Name = "cmbAucDelete";
            this.cmbAucDelete.Size = new System.Drawing.Size(146, 21);
            this.cmbAucDelete.TabIndex = 45;
            // 
            // btnAuctionRemove
            // 
            this.btnAuctionRemove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionRemove.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionRemove.Location = new System.Drawing.Point(407, 3);
            this.btnAuctionRemove.Name = "btnAuctionRemove";
            this.btnAuctionRemove.Size = new System.Drawing.Size(90, 30);
            this.btnAuctionRemove.TabIndex = 44;
            this.btnAuctionRemove.Text = "REMOVE ";
            this.btnAuctionRemove.UseVisualStyleBackColor = false;
            this.btnAuctionRemove.Click += new System.EventHandler(this.BtnAuctionRemove_Click);
            // 
            // lblSupplierIDView
            // 
            this.lblSupplierIDView.AutoSize = true;
            this.lblSupplierIDView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDView.Location = new System.Drawing.Point(10, 7);
            this.lblSupplierIDView.Name = "lblSupplierIDView";
            this.lblSupplierIDView.Size = new System.Drawing.Size(68, 16);
            this.lblSupplierIDView.TabIndex = 41;
            this.lblSupplierIDView.Text = "Auction ID";
            // 
            // lblAuctionRemoveHint1
            // 
            this.lblAuctionRemoveHint1.AutoSize = true;
            this.lblAuctionRemoveHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionRemoveHint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuctionRemoveHint1.Location = new System.Drawing.Point(103, 0);
            this.lblAuctionRemoveHint1.Name = "lblAuctionRemoveHint1";
            this.lblAuctionRemoveHint1.Size = new System.Drawing.Size(492, 20);
            this.lblAuctionRemoveHint1.TabIndex = 39;
            this.lblAuctionRemoveHint1.Text = "Select the AuctionID of the auction you would like to remove";
            // 
            // btnAucRemoveBack
            // 
            this.btnAucRemoveBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAucRemoveBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAucRemoveBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAucRemoveBack.Location = new System.Drawing.Point(612, 405);
            this.btnAucRemoveBack.Name = "btnAucRemoveBack";
            this.btnAucRemoveBack.Size = new System.Drawing.Size(117, 45);
            this.btnAucRemoveBack.TabIndex = 52;
            this.btnAucRemoveBack.Text = "B A C K";
            this.btnAucRemoveBack.UseVisualStyleBackColor = false;
            this.btnAucRemoveBack.Click += new System.EventHandler(this.btnAucRemoveBack_Click);
            // 
            // btnAuctionRemoveHelp
            // 
            this.btnAuctionRemoveHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionRemoveHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionRemoveHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionRemoveHelp.Location = new System.Drawing.Point(20, 407);
            this.btnAuctionRemoveHelp.Name = "btnAuctionRemoveHelp";
            this.btnAuctionRemoveHelp.Size = new System.Drawing.Size(117, 45);
            this.btnAuctionRemoveHelp.TabIndex = 51;
            this.btnAuctionRemoveHelp.Text = "H E L P";
            this.btnAuctionRemoveHelp.UseVisualStyleBackColor = false;
            this.btnAuctionRemoveHelp.Click += new System.EventHandler(this.BtnAuctionRemoveHelp_Click);
            // 
            // lblAuctionDeleteHeading
            // 
            this.lblAuctionDeleteHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAuctionDeleteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionDeleteHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAuctionDeleteHeading.Location = new System.Drawing.Point(12, 13);
            this.lblAuctionDeleteHeading.Name = "lblAuctionDeleteHeading";
            this.lblAuctionDeleteHeading.Size = new System.Drawing.Size(717, 53);
            this.lblAuctionDeleteHeading.TabIndex = 48;
            this.lblAuctionDeleteHeading.Text = "REMOVE AUCTION";
            this.lblAuctionDeleteHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAuctionRemove
            // 
            this.pbAuctionRemove.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbAuctionRemove.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbAuctionRemove.Location = new System.Drawing.Point(-281, -18);
            this.pbAuctionRemove.Name = "pbAuctionRemove";
            this.pbAuctionRemove.Size = new System.Drawing.Size(1076, 719);
            this.pbAuctionRemove.TabIndex = 50;
            this.pbAuctionRemove.TabStop = false;
            // 
            // dbgAuctionRemove
            // 
            this.dbgAuctionRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgAuctionRemove.Location = new System.Drawing.Point(12, 69);
            this.dbgAuctionRemove.Name = "dbgAuctionRemove";
            this.dbgAuctionRemove.ReadOnly = true;
            this.dbgAuctionRemove.Size = new System.Drawing.Size(717, 224);
            this.dbgAuctionRemove.TabIndex = 53;
            this.dbgAuctionRemove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgAuctionRemove_CellClick);
            // 
            // frmAuctionDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 471);
            this.Controls.Add(this.dbgAuctionRemove);
            this.Controls.Add(this.pnlAuctionDeleteSearch1);
            this.Controls.Add(this.btnAucRemoveBack);
            this.Controls.Add(this.btnAuctionRemoveHelp);
            this.Controls.Add(this.lblAuctionDeleteHeading);
            this.Controls.Add(this.pbAuctionRemove);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 510);
            this.MinimumSize = new System.Drawing.Size(758, 510);
            this.Name = "frmAuctionDelete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Auction ";
            this.Load += new System.EventHandler(this.FrmAuctionDelete_Load);
            this.pnlAuctionDeleteSearch1.ResumeLayout(false);
            this.pnlAuctionDeleteSearch1.PerformLayout();
            this.pnlSuppViewSearch.ResumeLayout(false);
            this.pnlSuppViewSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuctionRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgAuctionRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAuctionDeleteSearch1;
        private System.Windows.Forms.Label lblAuctionRemoveHint2;
        private System.Windows.Forms.Panel pnlSuppViewSearch;
        private System.Windows.Forms.ComboBox cmbAucDelete;
        private System.Windows.Forms.Button btnAuctionRemove;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Label lblAuctionRemoveHint1;
        private System.Windows.Forms.Button btnAucRemoveBack;
        private System.Windows.Forms.Button btnAuctionRemoveHelp;
        private System.Windows.Forms.Label lblAuctionDeleteHeading;
        private System.Windows.Forms.PictureBox pbAuctionRemove;
        private System.Windows.Forms.DataGridView dbgAuctionRemove;
    }
}