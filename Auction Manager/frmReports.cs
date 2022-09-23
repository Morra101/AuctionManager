using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;




namespace Auction_Manager
{
    public partial class frmReports : Form
    {
        public User UserInfo { get; set; }

        public frmReports()
        {
            InitializeComponent();
        }

        public frmReports(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }
                

        

        private void btnReportBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private string purID = "";
        #region Generate Report
        private void btnReportsShow_Click(object sender, EventArgs e)
        {            
            DBConnectMySQLReports myDBConnect = new DBConnectMySQLReports();
            ReportDataSource RDS;

                        
            if (rbReportStock.Checked)
            {
                
                RDS = new ReportDataSource("DSStock", myDBConnect.StockInfo());
                reportViewer1.LocalReport.ReportPath = "Stock.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();
                
            }

            
            else if (rbReportBuyers.Checked)
            {
                RDS = new ReportDataSource("DSBuyers", myDBConnect.PurchaserInfo());
                reportViewer1.LocalReport.ReportPath = "Buyers.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();
                
            }
            
            else if (rbReportSuppliers.Checked)
            {
               
                RDS = new ReportDataSource("DSSuppliers", myDBConnect.SupplierInfo());
                reportViewer1.LocalReport.ReportPath = "Suppliers.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();
                
            }
            
            else if (rbReportAuction.Checked)
            {
                
                RDS = new ReportDataSource("DSAuction", myDBConnect.AuctionInfo());
                reportViewer1.LocalReport.ReportPath = "Auctions.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();
                
            }
            
            else if (rbReportEmployees.Checked)
            {
                
                RDS = new ReportDataSource("DSEmployees", myDBConnect.EmployeeInfo());
                reportViewer1.LocalReport.ReportPath = "Employee.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();
                
            }

            else if (rbAuctionIncome.Checked)
            {
                purID = Interaction.InputBox("Enter Purchaser ID");
                DataTable dt = new DataTable();
                dt = myDBConnect.InvoiceInfo(purID);
                RDS = new ReportDataSource("DSBuyersInvoice", dt);
                reportViewer1.LocalReport.ReportPath = "BuyersInvoice.rdlc";
                reportViewer1.LocalReport.DataSources.Add(RDS);
                reportViewer1.RefreshReport();


            }
            else 
            {
                MessageBox.Show("Please select a report to show");
            }
            
            
            
        }
        #endregion


        #region Print Preview Report
        private void BtnPrintPreview_Click(object sender, EventArgs e)
        {
            DBConnectMySQLReports myDBConnect = new DBConnectMySQLReports();
            ReportDataSource RDS;

            if (rbReportStock.Checked)
            {
                RDS = new ReportDataSource("DSStock", myDBConnect.StockInfo());
                frmPrintPreview printPrevfrm = new frmPrintPreview("Stock", RDS);
                printPrevfrm.ShowDialog();
               
            }
            else if (rbReportBuyers.Checked)
            {
                RDS = new ReportDataSource("DSBuyers", myDBConnect.PurchaserInfo());
                frmPrintPreview printPrevfrm = new frmPrintPreview("Buyers", RDS);
                printPrevfrm.ShowDialog();
            }
            else if (rbReportSuppliers.Checked)
            {
                RDS = new ReportDataSource("DSSuppliers", myDBConnect.SupplierInfo());
                frmPrintPreview printPrevfrm = new frmPrintPreview("Suppliers", RDS);
                printPrevfrm.ShowDialog();
            }
            else if (rbReportAuction.Checked)
            {
                RDS = new ReportDataSource("DSAuction", myDBConnect.AuctionInfo());
                frmPrintPreview printPrevfrm = new frmPrintPreview("Auction", RDS);
                printPrevfrm.ShowDialog();
            }
            else if (rbReportEmployees.Checked)
            {
                RDS = new ReportDataSource("DSEmployees", myDBConnect.EmployeeInfo());
                frmPrintPreview printPrevfrm = new frmPrintPreview("Employees", RDS);
                printPrevfrm.ShowDialog();
            }
            else if (rbAuctionIncome.Checked)
            {
                RDS = new ReportDataSource("DSBuyersInvoice", myDBConnect.InvoiceInfo(purID));
                frmPrintPreview printPrevfrm = new frmPrintPreview("AuctionI", RDS);
                printPrevfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Report not generated please contact system administrator");
            }

            
        }
        #endregion

        private void btnReportHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select one of the reports you want to see and click on 'Generate Report' to view on screen or 'Print Preview' to save or print.");
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            
        }

        private void frmReports_Shown(object sender, EventArgs e)
        {
            
        }

        private void rbReportStock_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbReportBuyers_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbReportSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbReportAuction_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbReportEmployees_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbAuctionIncome_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
