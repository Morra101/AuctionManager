using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Auction_Manager
{
    public partial class frmStock_View : Form
    {
        public User UserInfo { get; set; }

        private DBConnectStock myConnection;

        public frmStock_View()
        {
            InitializeComponent();
        }

        public frmStock_View(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }


        private void btnStockViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void displayDB(string query, string stkID)                    //populate gridview 
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM stock";
            }
            DataSet ds = new DataSet();
            ds = myConnection.SelectStock(query, stkID);
            dbStockView.DataSource = ds;
            dbStockView.DataMember = "Source Table";
        }

        private void FrmStock_View_Load(object sender, EventArgs e)
        {
            myConnection = new DBConnectStock();
            string query = "SELECT stockID,SupplierID,DateIn,RegNum,EngNUm,ChasNum,AuctionID FROM stock";
            displayDB(query, "");
            dtpDateIn.Enabled = false;
            chkStockViewDate.Checked = false;
            chkStockViewEngNum.Checked = false;
            chkStockViewRegNum.Checked = false;
            chkStockViewChasNum.Checked = false;
            chkStockViewSoldPrice.Checked = false;            
            txtEngNum.Text = "";
            txtRegNum.Text = "";
            txtChasNum.Text = "";
            txtAucSoldPrice.Text = "";
            txtEngNum.Enabled = false;
            txtRegNum.Enabled = false;
            txtChasNum.Enabled = false;
            txtAucSoldPrice.Enabled = false;
        }

        private void pbViewStockHome_Click(object sender, EventArgs e)
        {

        }

        private void lblStockView_Click(object sender, EventArgs e)
        {

        }

        #region ButtonEvents
        private void btnSearchStockView1_Click(object sender, EventArgs e)
        {
            string stkID = "%" + txtStockIDSearch.Text + "%";
            string query = "SELECT * FROM stock WHERE stockID LIKE @stockID";
            displayDB(query, stkID);
        }

        private void btnSearchStockView2_Click(object sender, EventArgs e)
        {
            DateTime dateIn = dtpDateIn.Value ;
            string eNum = txtEngNum.Text;
            string rNum = txtRegNum.Text;
            string chsNum = txtChasNum.Text;
            // string aucSoldPrice = txtChasNum.Text;//Has decimal value in field
            decimal aucSoldPrice=0.0m;



            DataTable dt = new DataTable();
            dt = myConnection.GetStockList();
            dbStockView.DataSource = dt;
            if (dateSelected == false&&chkStockViewDate.Checked==true)
            {
                MessageBox.Show("Please choose a date");
                dtpDateIn.Focus();
            }


            if (!(dateSelected == false) || !(string.IsNullOrEmpty(eNum)) || !(string.IsNullOrEmpty(rNum)) || !(string.IsNullOrEmpty(chsNum)) || !(string.IsNullOrEmpty(txtAucSoldPrice.Text)))
            {                
                if (chkStockViewDate.Checked)
                {
                    DateTime dateSelected = dtpDateIn.Value;
                    string selectedDate = dateSelected.ToShortDateString();
                    string query = "SELECT stockID, SupplierID, DateIn, RegNum, EngNUm, ChasNum, AuctionID FROM stock WHERE DateIn = @date";
                    DataTable dtList = myConnection.GetStockList(query, selectedDate);
                    dbStockView.DataSource = dtList;

                    //(dbStockView.DataSource as DataTable).DefaultView.RowFilter = string.Format("DateIn = '{0}'", dtpDateIn.Value);
                }
                if (chkStockViewRegNum.Checked)
                {
                    (dbStockView.DataSource as DataTable).DefaultView.RowFilter = string.Format("RegNum LIKE '%{0}%'", txtRegNum.Text);
                }
                if (chkStockViewEngNum.Checked)
                {
                    (dbStockView.DataSource as DataTable).DefaultView.RowFilter = string.Format("EngNum LIKE '%{0}%'", txtEngNum.Text);
                }
                if (chkStockViewChasNum.Checked)
                {
                    (dbStockView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ChasNum LIKE '%{0}%'", txtChasNum.Text);
                }
                if (chkStockViewSoldPrice.Checked)
                {
                    if (decimal.TryParse(txtAucSoldPrice.Text, out aucSoldPrice))
                    {
                        (dbStockView.DataSource as DataTable).DefaultView.RowFilter = string.Format("AuctionSoldPrice LIKE '%{0}%'", txtAucSoldPrice.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid entry in the auction sold price field");
                        txtAucSoldPrice.Focus();
                    }
                    
                }
            }
        }
        #endregion
        #region Checkboxes
        private void DummyProof()
        {

            if ((chkStockViewDate.Checked) || (chkStockViewRegNum.Checked) || (chkStockViewEngNum.Checked) || (chkStockViewChasNum.Checked) || (chkStockViewSoldPrice.Checked))
            {
                btnSearchStockView2.Enabled = true;
                btnSearchStockView1.Enabled = false;
                txtStockIDSearch.Text = "";
            }
            else
            {
                btnSearchStockView2.Enabled = false;
            }
        }
        private void chkStockViewDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockViewDate.Checked)
            {
                txtStockIDSearch.Text = "";
                chkStockViewChasNum.Checked = false;
                chkStockViewEngNum.Checked = false;
                chkStockViewRegNum.Checked = false;
                chkStockViewSoldPrice.Checked = false;
                dtpDateIn.Enabled = true;
                dtpDateIn.Focus();
            }
            else
            {
                dtpDateIn.Enabled = false;
                dateSelected = false;
            }

            DummyProof();
        }

        private void chkStockViewEngNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockViewEngNum.Checked)
            {
                txtStockIDSearch.Text = "";
                chkStockViewChasNum.Checked = false;
                chkStockViewDate.Checked = false;
                chkStockViewRegNum.Checked = false;
                chkStockViewSoldPrice.Checked = false;
                txtEngNum.Enabled = true;
                txtEngNum.Focus();
            }
            else
            {
                txtEngNum.Enabled = false;
                txtEngNum.Text = "";
            }
            DummyProof();
        }

        private void chkStockViewRegNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockViewRegNum.Checked)
            {
                txtStockIDSearch.Text = "";
                chkStockViewChasNum.Checked = false;
                chkStockViewEngNum.Checked = false;
                chkStockViewDate.Checked = false;
                chkStockViewSoldPrice.Checked = false;
                txtRegNum.Enabled = true;
                txtRegNum.Focus();
            }
            else
            {
                txtRegNum.Enabled = false;
                txtRegNum.Text = "";
            }
            DummyProof();
        }

        private void chkStockViewChasNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockViewChasNum.Checked)
            {
                txtStockIDSearch.Text = "";
                chkStockViewDate.Checked = false;
                chkStockViewEngNum.Checked = false;
                chkStockViewRegNum.Checked = false;
                chkStockViewSoldPrice.Checked = false;
                txtChasNum.Enabled = true;
                txtChasNum.Focus();
            }
            else
            {
                txtChasNum.Enabled = false;
                txtChasNum.Text = "";
            }
            DummyProof();
        }

        private void chkStockViewSoldPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockViewSoldPrice.Checked)
            {
                txtStockIDSearch.Text = "";
                chkStockViewChasNum.Checked = false;
                chkStockViewEngNum.Checked = false;
                chkStockViewRegNum.Checked = false;
                chkStockViewDate.Checked = false;
                txtAucSoldPrice.Enabled = true;
                txtAucSoldPrice.Focus();
            }
            else
            {
                txtAucSoldPrice.Enabled = false;
                txtAucSoldPrice.Text = "";
            }
            DummyProof();
        }
        #endregion

        private void txtStockIDSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearchStockView1.Enabled = true;
            chkStockViewDate.Checked = false;
            chkStockViewEngNum.Checked = false;
            chkStockViewRegNum.Checked = false;
            chkStockViewChasNum.Checked = false;
            chkStockViewSoldPrice.Checked = false;            
            txtEngNum.Text = "";
            txtRegNum.Text = "";
            txtChasNum.Text = "";
            txtAucSoldPrice.Text = "";
        }

        private void txtStockIDSearch_Click(object sender, EventArgs e)
        {
            displayDB("","");
            btnSearchStockView1.Enabled = true;
            btnSearchStockView2.Enabled = false;
            chkStockViewDate.Checked = false;
            chkStockViewEngNum.Checked = false;
            chkStockViewRegNum.Checked = false;
            chkStockViewChasNum.Checked = false;
            chkStockViewSoldPrice.Checked = false;
        }

        private bool dateSelected = false;
       
        private void DtpDateIn_ValueChanged(object sender, EventArgs e)
        {
            dateSelected = true;
        }

        private void bynStockViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the Stock ID you want to view and click on 'Search' \n" +
               "OR select one of the checkboxes to search by a specific field and click on 'Search for stock'");
        }
    }

}
