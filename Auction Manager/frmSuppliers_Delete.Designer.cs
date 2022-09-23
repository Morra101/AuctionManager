
namespace Auction_Manager
{
    partial class frmSuppliers_Delete
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
            this.pnlSuppDeleteSearch = new System.Windows.Forms.Panel();
            this.cmbSupID = new System.Windows.Forms.ComboBox();
            this.btnSuppDel = new System.Windows.Forms.Button();
            this.lblSupplierIDView = new System.Windows.Forms.Label();
            this.lblSuppliersHint = new System.Windows.Forms.Label();
            this.btnSupplierDeleteHelp = new System.Windows.Forms.Button();
            this.lblSupplierDeleteHeading = new System.Windows.Forms.Label();
            this.dbSupplierDelete = new System.Windows.Forms.DataGridView();
            this.pbBackSuppDelete = new System.Windows.Forms.PictureBox();
            this.btnSuppBackToLand = new System.Windows.Forms.Button();
            this.pnlSuppDeleteSearch1.SuspendLayout();
            this.pnlSuppDeleteSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSupplierDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuppDeleteSearch1
            // 
            this.pnlSuppDeleteSearch1.BackColor = System.Drawing.Color.DimGray;
            this.pnlSuppDeleteSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSuppDeleteSearch1.Controls.Add(this.pnlSuppDeleteSearch);
            this.pnlSuppDeleteSearch1.Controls.Add(this.lblSuppliersHint);
            this.pnlSuppDeleteSearch1.Location = new System.Drawing.Point(44, 342);
            this.pnlSuppDeleteSearch1.Name = "pnlSuppDeleteSearch1";
            this.pnlSuppDeleteSearch1.Size = new System.Drawing.Size(717, 100);
            this.pnlSuppDeleteSearch1.TabIndex = 41;
            // 
            // pnlSuppDeleteSearch
            // 
            this.pnlSuppDeleteSearch.BackColor = System.Drawing.Color.White;
            this.pnlSuppDeleteSearch.Controls.Add(this.cmbSupID);
            this.pnlSuppDeleteSearch.Controls.Add(this.btnSuppDel);
            this.pnlSuppDeleteSearch.Controls.Add(this.lblSupplierIDView);
            this.pnlSuppDeleteSearch.Location = new System.Drawing.Point(107, 38);
            this.pnlSuppDeleteSearch.Name = "pnlSuppDeleteSearch";
            this.pnlSuppDeleteSearch.Size = new System.Drawing.Size(509, 34);
            this.pnlSuppDeleteSearch.TabIndex = 41;
            // 
            // cmbSupID
            // 
            this.cmbSupID.FormattingEnabled = true;
            this.cmbSupID.Location = new System.Drawing.Point(258, 7);
            this.cmbSupID.Name = "cmbSupID";
            this.cmbSupID.Size = new System.Drawing.Size(137, 21);
            this.cmbSupID.TabIndex = 45;
            // 
            // btnSuppDel
            // 
            this.btnSuppDel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppDel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppDel.Location = new System.Drawing.Point(407, 3);
            this.btnSuppDel.Name = "btnSuppDel";
            this.btnSuppDel.Size = new System.Drawing.Size(90, 30);
            this.btnSuppDel.TabIndex = 44;
            this.btnSuppDel.Text = "DELETE";
            this.btnSuppDel.UseVisualStyleBackColor = false;
            this.btnSuppDel.Click += new System.EventHandler(this.btnSuppDel_Click);
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
            // lblSuppliersHint
            // 
            this.lblSuppliersHint.AutoSize = true;
            this.lblSuppliersHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersHint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuppliersHint.Location = new System.Drawing.Point(103, 15);
            this.lblSuppliersHint.Name = "lblSuppliersHint";
            this.lblSuppliersHint.Size = new System.Drawing.Size(496, 20);
            this.lblSuppliersHint.TabIndex = 39;
            this.lblSuppliersHint.Text = "Select the SupplierID of the supplier you would like to Delete";
            // 
            // btnSupplierDeleteHelp
            // 
            this.btnSupplierDeleteHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierDeleteHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDeleteHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupplierDeleteHelp.Location = new System.Drawing.Point(44, 458);
            this.btnSupplierDeleteHelp.Name = "btnSupplierDeleteHelp";
            this.btnSupplierDeleteHelp.Size = new System.Drawing.Size(117, 45);
            this.btnSupplierDeleteHelp.TabIndex = 45;
            this.btnSupplierDeleteHelp.Text = "H E L P";
            this.btnSupplierDeleteHelp.UseVisualStyleBackColor = false;
            this.btnSupplierDeleteHelp.Click += new System.EventHandler(this.btnSupplierDeleteHelp_Click);
            // 
            // lblSupplierDeleteHeading
            // 
            this.lblSupplierDeleteHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplierDeleteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDeleteHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierDeleteHeading.Location = new System.Drawing.Point(44, 19);
            this.lblSupplierDeleteHeading.Name = "lblSupplierDeleteHeading";
            this.lblSupplierDeleteHeading.Size = new System.Drawing.Size(717, 53);
            this.lblSupplierDeleteHeading.TabIndex = 40;
            this.lblSupplierDeleteHeading.Text = "REMOVE SUPPLIER";
            this.lblSupplierDeleteHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbSupplierDelete
            // 
            this.dbSupplierDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbSupplierDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbSupplierDelete.Location = new System.Drawing.Point(44, 92);
            this.dbSupplierDelete.Name = "dbSupplierDelete";
            this.dbSupplierDelete.ReadOnly = true;
            this.dbSupplierDelete.Size = new System.Drawing.Size(717, 232);
            this.dbSupplierDelete.TabIndex = 39;
            // 
            // pbBackSuppDelete
            // 
            this.pbBackSuppDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbBackSuppDelete.Location = new System.Drawing.Point(-149, 0);
            this.pbBackSuppDelete.Name = "pbBackSuppDelete";
            this.pbBackSuppDelete.Size = new System.Drawing.Size(1069, 719);
            this.pbBackSuppDelete.TabIndex = 42;
            this.pbBackSuppDelete.TabStop = false;
            // 
            // btnSuppBackToLand
            // 
            this.btnSuppBackToLand.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuppBackToLand.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppBackToLand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuppBackToLand.Location = new System.Drawing.Point(644, 458);
            this.btnSuppBackToLand.Name = "btnSuppBackToLand";
            this.btnSuppBackToLand.Size = new System.Drawing.Size(117, 45);
            this.btnSuppBackToLand.TabIndex = 46;
            this.btnSuppBackToLand.Text = "B A C K";
            this.btnSuppBackToLand.UseVisualStyleBackColor = false;
            this.btnSuppBackToLand.Click += new System.EventHandler(this.btnSuppBackToLand_Click);
            // 
            // frmSuppliers_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 522);
            this.Controls.Add(this.btnSuppBackToLand);
            this.Controls.Add(this.pnlSuppDeleteSearch1);
            this.Controls.Add(this.btnSupplierDeleteHelp);
            this.Controls.Add(this.lblSupplierDeleteHeading);
            this.Controls.Add(this.dbSupplierDelete);
            this.Controls.Add(this.pbBackSuppDelete);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 561);
            this.MinimumSize = new System.Drawing.Size(806, 561);
            this.Name = "frmSuppliers_Delete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Supplier";
            this.Load += new System.EventHandler(this.FrmSuppliers_Delete_Load);
            this.pnlSuppDeleteSearch1.ResumeLayout(false);
            this.pnlSuppDeleteSearch1.PerformLayout();
            this.pnlSuppDeleteSearch.ResumeLayout(false);
            this.pnlSuppDeleteSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSupplierDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackSuppDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppDeleteSearch1;
        private System.Windows.Forms.Button btnSuppBackToLand;
        private System.Windows.Forms.Panel pnlSuppDeleteSearch;
        private System.Windows.Forms.Button btnSuppDel;
        private System.Windows.Forms.Label lblSupplierIDView;
        private System.Windows.Forms.Label lblSuppliersHint;
        private System.Windows.Forms.Button btnSupplierDeleteHelp;
        private System.Windows.Forms.Label lblSupplierDeleteHeading;
        private System.Windows.Forms.DataGridView dbSupplierDelete;
        private System.Windows.Forms.PictureBox pbBackSuppDelete;
        private System.Windows.Forms.ComboBox cmbSupID;
    }
}