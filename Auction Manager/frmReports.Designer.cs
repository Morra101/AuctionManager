
namespace Auction_Manager
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctiondbDataSet = new Auction_Manager.auctiondbDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblReportHeading = new System.Windows.Forms.Label();
            this.btnReportBack = new System.Windows.Forms.Button();
            this.btnReportHelp = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlReportGrouping = new System.Windows.Forms.Panel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnReportsShow = new System.Windows.Forms.Button();
            this.gbReports = new System.Windows.Forms.GroupBox();
            this.rbAuctionIncome = new System.Windows.Forms.RadioButton();
            this.rbReportEmployees = new System.Windows.Forms.RadioButton();
            this.rbReportAuction = new System.Windows.Forms.RadioButton();
            this.rbReportSuppliers = new System.Windows.Forms.RadioButton();
            this.rbReportBuyers = new System.Windows.Forms.RadioButton();
            this.rbReportStock = new System.Windows.Forms.RadioButton();
            this.stockTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.stockTableAdapter();
            this.purchasersTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.purchasersTableAdapter();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.suppliersTableAdapter();
            this.auctionsTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.auctionsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.employeesTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.AuctionIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Auction_Manager.auctiondbDataSetTableAdapters.adminTableAdapter();
            this.pbxReportHomeScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctiondbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasersBindingSource)).BeginInit();
            this.pnlReportGrouping.SuspendLayout();
            this.gbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReportHomeScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "auctions";
            this.auctionsBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // auctiondbDataSet
            // 
            this.auctiondbDataSet.DataSetName = "auctiondbDataSet";
            this.auctiondbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // purchasersBindingSource
            // 
            this.purchasersBindingSource.DataMember = "purchasers";
            this.purchasersBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // lblReportHeading
            // 
            this.lblReportHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReportHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReportHeading.Location = new System.Drawing.Point(35, 9);
            this.lblReportHeading.Name = "lblReportHeading";
            this.lblReportHeading.Size = new System.Drawing.Size(805, 53);
            this.lblReportHeading.TabIndex = 40;
            this.lblReportHeading.Text = "REPORTS";
            this.lblReportHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportBack
            // 
            this.btnReportBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReportBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportBack.Location = new System.Drawing.Point(760, 654);
            this.btnReportBack.Name = "btnReportBack";
            this.btnReportBack.Size = new System.Drawing.Size(80, 45);
            this.btnReportBack.TabIndex = 53;
            this.btnReportBack.Text = "B A C K";
            this.btnReportBack.UseVisualStyleBackColor = false;
            this.btnReportBack.Click += new System.EventHandler(this.btnReportBack_Click);
            // 
            // btnReportHelp
            // 
            this.btnReportHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReportHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportHelp.Location = new System.Drawing.Point(43, 654);
            this.btnReportHelp.Name = "btnReportHelp";
            this.btnReportHelp.Size = new System.Drawing.Size(80, 45);
            this.btnReportHelp.TabIndex = 54;
            this.btnReportHelp.Text = "H E L P";
            this.btnReportHelp.UseVisualStyleBackColor = false;
            this.btnReportHelp.Click += new System.EventHandler(this.btnReportHelp_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Auction_Manager.bin.Debug.Auction Income.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 215);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(805, 409);
            this.reportViewer1.TabIndex = 55;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // pnlReportGrouping
            // 
            this.pnlReportGrouping.BackColor = System.Drawing.Color.DimGray;
            this.pnlReportGrouping.Controls.Add(this.btnPrintPreview);
            this.pnlReportGrouping.Controls.Add(this.btnReportsShow);
            this.pnlReportGrouping.Controls.Add(this.gbReports);
            this.pnlReportGrouping.Location = new System.Drawing.Point(35, 91);
            this.pnlReportGrouping.Name = "pnlReportGrouping";
            this.pnlReportGrouping.Size = new System.Drawing.Size(805, 128);
            this.pnlReportGrouping.TabIndex = 56;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrintPreview.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintPreview.Location = new System.Drawing.Point(626, 64);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(164, 30);
            this.btnPrintPreview.TabIndex = 47;
            this.btnPrintPreview.Text = "PRINT PREVIEW";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.BtnPrintPreview_Click);
            // 
            // btnReportsShow
            // 
            this.btnReportsShow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReportsShow.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportsShow.Location = new System.Drawing.Point(626, 16);
            this.btnReportsShow.Name = "btnReportsShow";
            this.btnReportsShow.Size = new System.Drawing.Size(164, 30);
            this.btnReportsShow.TabIndex = 45;
            this.btnReportsShow.Text = "GENERATE REPORT";
            this.btnReportsShow.UseVisualStyleBackColor = false;
            this.btnReportsShow.Click += new System.EventHandler(this.btnReportsShow_Click);
            // 
            // gbReports
            // 
            this.gbReports.Controls.Add(this.rbAuctionIncome);
            this.gbReports.Controls.Add(this.rbReportEmployees);
            this.gbReports.Controls.Add(this.rbReportAuction);
            this.gbReports.Controls.Add(this.rbReportSuppliers);
            this.gbReports.Controls.Add(this.rbReportBuyers);
            this.gbReports.Controls.Add(this.rbReportStock);
            this.gbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReports.Location = new System.Drawing.Point(13, 16);
            this.gbReports.Name = "gbReports";
            this.gbReports.Size = new System.Drawing.Size(602, 69);
            this.gbReports.TabIndex = 0;
            this.gbReports.TabStop = false;
            this.gbReports.Tag = "radioButtons";
            this.gbReports.Text = "Select what report you want to generate";
            // 
            // rbAuctionIncome
            // 
            this.rbAuctionIncome.AutoSize = true;
            this.rbAuctionIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuctionIncome.Location = new System.Drawing.Point(458, 29);
            this.rbAuctionIncome.Name = "rbAuctionIncome";
            this.rbAuctionIncome.Size = new System.Drawing.Size(121, 17);
            this.rbAuctionIncome.TabIndex = 5;
            this.rbAuctionIncome.TabStop = true;
            this.rbAuctionIncome.Text = "BUYER INVOICE";
            this.rbAuctionIncome.UseVisualStyleBackColor = true;
            this.rbAuctionIncome.CheckedChanged += new System.EventHandler(this.rbAuctionIncome_CheckedChanged);
            // 
            // rbReportEmployees
            // 
            this.rbReportEmployees.AutoSize = true;
            this.rbReportEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportEmployees.Location = new System.Drawing.Point(353, 29);
            this.rbReportEmployees.Name = "rbReportEmployees";
            this.rbReportEmployees.Size = new System.Drawing.Size(99, 17);
            this.rbReportEmployees.TabIndex = 4;
            this.rbReportEmployees.TabStop = true;
            this.rbReportEmployees.Text = "EMPLOYEES";
            this.rbReportEmployees.UseVisualStyleBackColor = true;
            this.rbReportEmployees.CheckedChanged += new System.EventHandler(this.rbReportEmployees_CheckedChanged);
            // 
            // rbReportAuction
            // 
            this.rbReportAuction.AutoSize = true;
            this.rbReportAuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportAuction.Location = new System.Drawing.Point(259, 29);
            this.rbReportAuction.Name = "rbReportAuction";
            this.rbReportAuction.Size = new System.Drawing.Size(88, 17);
            this.rbReportAuction.TabIndex = 3;
            this.rbReportAuction.TabStop = true;
            this.rbReportAuction.Text = "AUCTIONS";
            this.rbReportAuction.UseVisualStyleBackColor = true;
            this.rbReportAuction.CheckedChanged += new System.EventHandler(this.rbReportAuction_CheckedChanged);
            // 
            // rbReportSuppliers
            // 
            this.rbReportSuppliers.AutoSize = true;
            this.rbReportSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportSuppliers.Location = new System.Drawing.Point(159, 29);
            this.rbReportSuppliers.Name = "rbReportSuppliers";
            this.rbReportSuppliers.Size = new System.Drawing.Size(94, 17);
            this.rbReportSuppliers.TabIndex = 2;
            this.rbReportSuppliers.TabStop = true;
            this.rbReportSuppliers.Text = "SUPPLIERS";
            this.rbReportSuppliers.UseVisualStyleBackColor = true;
            this.rbReportSuppliers.CheckedChanged += new System.EventHandler(this.rbReportSuppliers_CheckedChanged);
            // 
            // rbReportBuyers
            // 
            this.rbReportBuyers.AutoSize = true;
            this.rbReportBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportBuyers.Location = new System.Drawing.Point(78, 29);
            this.rbReportBuyers.Name = "rbReportBuyers";
            this.rbReportBuyers.Size = new System.Drawing.Size(75, 17);
            this.rbReportBuyers.TabIndex = 1;
            this.rbReportBuyers.TabStop = true;
            this.rbReportBuyers.Text = "BUYERS";
            this.rbReportBuyers.UseVisualStyleBackColor = true;
            this.rbReportBuyers.CheckedChanged += new System.EventHandler(this.rbReportBuyers_CheckedChanged);
            // 
            // rbReportStock
            // 
            this.rbReportStock.AutoSize = true;
            this.rbReportStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReportStock.Location = new System.Drawing.Point(6, 29);
            this.rbReportStock.Name = "rbReportStock";
            this.rbReportStock.Size = new System.Drawing.Size(66, 17);
            this.rbReportStock.TabIndex = 0;
            this.rbReportStock.TabStop = true;
            this.rbReportStock.Text = "STOCK";
            this.rbReportStock.UseVisualStyleBackColor = true;
            this.rbReportStock.CheckedChanged += new System.EventHandler(this.rbReportStock_CheckedChanged);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // purchasersTableAdapter
            // 
            this.purchasersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // AuctionIncomeBindingSource
            // 
            this.AuctionIncomeBindingSource.DataMember = "stock";
            this.AuctionIncomeBindingSource.DataSource = this.auctiondbDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // pbxReportHomeScreen
            // 
            this.pbxReportHomeScreen.BackgroundImage = global::Auction_Manager.Properties.Resources.Background3;
            this.pbxReportHomeScreen.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbxReportHomeScreen.Location = new System.Drawing.Point(-139, -4);
            this.pbxReportHomeScreen.Name = "pbxReportHomeScreen";
            this.pbxReportHomeScreen.Size = new System.Drawing.Size(999, 719);
            this.pbxReportHomeScreen.TabIndex = 39;
            this.pbxReportHomeScreen.TabStop = false;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 711);
            this.Controls.Add(this.pnlReportGrouping);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReportHelp);
            this.Controls.Add(this.btnReportBack);
            this.Controls.Add(this.lblReportHeading);
            this.Controls.Add(this.pbxReportHomeScreen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 750);
            this.MinimumSize = new System.Drawing.Size(876, 726);
            this.Name = "frmReports";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.Shown += new System.EventHandler(this.frmReports_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctiondbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasersBindingSource)).EndInit();
            this.pnlReportGrouping.ResumeLayout(false);
            this.gbReports.ResumeLayout(false);
            this.gbReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReportHomeScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxReportHomeScreen;
        private System.Windows.Forms.Label lblReportHeading;
        private System.Windows.Forms.Button btnReportBack;
        private System.Windows.Forms.Button btnReportHelp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlReportGrouping;
        private System.Windows.Forms.GroupBox gbReports;
        private System.Windows.Forms.Button btnReportsShow;
        private System.Windows.Forms.RadioButton rbReportBuyers;
        private System.Windows.Forms.RadioButton rbReportStock;
        private System.Windows.Forms.RadioButton rbReportEmployees;
        private System.Windows.Forms.RadioButton rbReportAuction;
        private System.Windows.Forms.RadioButton rbReportSuppliers;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private auctiondbDataSet auctiondbDataSet;
        private auctiondbDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource purchasersBindingSource;
        private auctiondbDataSetTableAdapters.purchasersTableAdapter purchasersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private auctiondbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private auctiondbDataSetTableAdapters.auctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private auctiondbDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RadioButton rbAuctionIncome;
        private System.Windows.Forms.BindingSource AuctionIncomeBindingSource;
        private auctiondbDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button btnPrintPreview;
    }
}