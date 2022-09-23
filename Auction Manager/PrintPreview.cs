using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Auction_Manager
{
    public partial class frmPrintPreview : Form
    {
        public frmPrintPreview()
        {
            InitializeComponent();
        }

        public frmPrintPreview(string option,ReportDataSource RDS)
        {
            InitializeComponent();
            this.option = option;
            this.RDS = RDS;
        }

        private ReportDataSource RDS;
        private string option;

        #region Display on load
        private void PrintPreview_Load(object sender, EventArgs e)
        {
            rptviewPrintPreview.LocalReport.DataSources.Clear();

            if (option== "Employees" )
            {                
                rptviewPrintPreview.LocalReport.ReportPath = "Employee.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
            if (option == "Stock")
            {
                rptviewPrintPreview.LocalReport.ReportPath = "Stock.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
            if (option == "Buyers")
            {
                rptviewPrintPreview.LocalReport.ReportPath = "Buyers.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
            if (option == "Suppliers")
            {
                rptviewPrintPreview.LocalReport.ReportPath = "Suppliers.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
            if (option=="Auction")
            {
                rptviewPrintPreview.LocalReport.ReportPath = "Auctions.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
            if (option == "AuctionI")
            {
                rptviewPrintPreview.LocalReport.ReportPath = "BuyersInvoice.rdlc";
                rptviewPrintPreview.LocalReport.DataSources.Add(RDS);
                rptviewPrintPreview.RefreshReport();
                rptviewPrintPreview.SetDisplayMode(DisplayMode.PrintLayout);
                rptviewPrintPreview.ZoomMode = ZoomMode.PageWidth;
            }
        }
        #endregion
        private void btnPPPrint_Click(object sender, EventArgs e)
        {
            rptviewPrintPreview.PrintDialog();
            
        }

        

        #region Export File
        private void btnPPExport_Click(object sender, EventArgs e)
        {
            string _sSuggestedName = String.Empty;

            byte[] byteViewerPDF = rptviewPrintPreview.LocalReport.Render("PDF");
            byte[] byteViewerExcel = rptviewPrintPreview.LocalReport.Render("Excel");
            byte[] byteViewerWord = rptviewPrintPreview.LocalReport.Render("Word");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf| Doc files (*.doc) | *.doc | Excel files(*.xls) | *.xls";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream newFile = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                if (saveFileDialog1.FilterIndex == 1)
                {
                    newFile.Write(byteViewerPDF, 0, byteViewerPDF.Length);
                    newFile.Close();
                }
                else
                  if (saveFileDialog1.FilterIndex == 2)
                {
                    newFile.Write(byteViewerWord, 0, byteViewerWord.Length);
                    newFile.Close();
                }
                else
                  if (saveFileDialog1.FilterIndex == 3)
                {
                    newFile.Write(byteViewerExcel, 0, byteViewerExcel.Length);
                    newFile.Close();
                }

            }
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

           
        }
    }
}
