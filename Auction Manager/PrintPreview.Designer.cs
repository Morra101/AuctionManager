
namespace Auction_Manager
{
    partial class frmPrintPreview
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
            this.rptviewPrintPreview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPPExport = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnPPPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptviewPrintPreview
            // 
            this.rptviewPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviewPrintPreview.DocumentMapWidth = 29;
            this.rptviewPrintPreview.LocalReport.ReportEmbeddedResource = "Auction_Manager.bin.Debug.Auction Income.rdlc";
            this.rptviewPrintPreview.Location = new System.Drawing.Point(0, 0);
            this.rptviewPrintPreview.Name = "rptviewPrintPreview";
            this.rptviewPrintPreview.ServerReport.BearerToken = null;
            this.rptviewPrintPreview.ShowExportButton = false;
            this.rptviewPrintPreview.ShowPrintButton = false;
            this.rptviewPrintPreview.Size = new System.Drawing.Size(554, 714);
            this.rptviewPrintPreview.TabIndex = 0;
            this.rptviewPrintPreview.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.btnPPExport);
            this.splitContainer1.Panel1.Controls.Add(this.lblHeading);
            this.splitContainer1.Panel1.Controls.Add(this.btnPPPrint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rptviewPrintPreview);
            this.splitContainer1.Size = new System.Drawing.Size(554, 749);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(476, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPPExport
            // 
            this.btnPPExport.BackColor = System.Drawing.Color.Gray;
            this.btnPPExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPExport.Location = new System.Drawing.Point(314, 6);
            this.btnPPExport.Name = "btnPPExport";
            this.btnPPExport.Size = new System.Drawing.Size(75, 23);
            this.btnPPExport.TabIndex = 2;
            this.btnPPExport.Text = "EXPORT";
            this.btnPPExport.UseVisualStyleBackColor = false;
            this.btnPPExport.Click += new System.EventHandler(this.btnPPExport_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Gray;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(4, 6);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(385, 23);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "PRINT PREVIEW";
            // 
            // btnPPPrint
            // 
            this.btnPPPrint.BackColor = System.Drawing.Color.Gray;
            this.btnPPPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPPrint.Location = new System.Drawing.Point(395, 6);
            this.btnPPPrint.Name = "btnPPPrint";
            this.btnPPPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPPPrint.TabIndex = 1;
            this.btnPPPrint.Text = "PRINT";
            this.btnPPPrint.UseVisualStyleBackColor = false;
            this.btnPPPrint.Click += new System.EventHandler(this.btnPPPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 749);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(570, 788);
            this.Name = "frmPrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintPreview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptviewPrintPreview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPPPrint;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnPPExport;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnBack;
    }
}