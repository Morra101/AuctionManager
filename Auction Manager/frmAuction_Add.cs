
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Manager
{
    public partial class frmAuction_Add : Form
    {
        public User UserInfo { get; set; }

        public frmAuction_Add()
        {
            InitializeComponent();
        }
        public frmAuction_Add(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        #region methods/Variables

        private DBConnectAuction mydbConnect;
        private DataTable dt;
        private DataTable aucdt;

        private bool dateSelected;
        private bool aucCreated;
        private bool stockSelected;
        private string aucID;

        private void DisplayStock()
        {
            dt = new DataTable();
            dt = mydbConnect.GetAvailableStockList();
            dt.Columns.Add("WholeRecord", typeof(string), "stockID + ' \t ' + RegNum + ' \t\t\t ' +SupplierID +' \t\t\t\t Date brought in : '+ DateIn");

            chklstAuctionAddStock.DataSource = dt;
            chklstAuctionAddStock.DisplayMember = "WholeRecord";
            chklstAuctionAddStock.ValueMember = dt.Columns[1].ToString();

        }
        private void GetAucListStock()
        {
            aucdt = new DataTable();
            aucdt = mydbConnect.GetAuctionList("", "");
        }

        #endregion

        #region FormEvents

        private void DtpAuctionDate_ValueChanged(object sender, EventArgs e)
        {
            dateSelected = true;
        }

        private void FrmAuction_Add_Load(object sender, EventArgs e)
        {
            pnlAucAddControls.Enabled = false;
            mydbConnect = new DBConnectAuction();
        }
       

        private void FrmAuction_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stockSelected != true && aucCreated)
            {
                DialogResult exitRes = MessageBox.Show("Are you sure you want to exit without adding stock items to the created auction", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exitRes == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                if (exitRes == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
            

        }

        #endregion

        #region Button Events

        private void BtnAddAuction_Click(object sender, EventArgs e)
        {
            if (dateSelected == false)
            {
                MessageBox.Show("Please select an auction date ");
                return;
            }
            else
            {
                pnlAucAddControls.Enabled = true;
                DateTime selectedAucDate = dtpAuctionDate.Value;                

                DialogResult exitRes = MessageBox.Show("Are you sure you want to create an Auction for : \n" + selectedAucDate.ToString("D"), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (exitRes == DialogResult.Yes)
                {
                    mydbConnect.InsertNewAuction(UserInfo.GetUserID(), selectedAucDate);
                    DisplayStock();
                    GetAucListStock();
                    DataRow lastRow = aucdt.Rows[aucdt.Rows.Count - 1];
                    aucID = lastRow[0].ToString();
                    aucCreated = true;
                    MessageBox.Show("Auction for " + selectedAucDate.ToString("d") + " Succesfully created\nAuctionID: " + aucID + " \nPlease proceed to select stock items to be sold on the auction below ");                    
                }
                if (exitRes == DialogResult.No)
                {
                    dtpAuctionDate.Focus();
                    dateSelected = false;
                    return;
                }
                if (exitRes == DialogResult.Cancel)
                {
                    dtpAuctionDate.Focus();
                    dateSelected = false;
                    return;
                }
            }


        }

        private void BtnAuctionAdd_Click(object sender, EventArgs e)
        {
            if (dateSelected == false)
            {
                MessageBox.Show("Please select a date in the date control above to start");
            }
            else
            {
                if (aucCreated != true)
                {
                    MessageBox.Show("an auction needs to be created first");
                    return;
                }

                if (chklstAuctionAddStock.CheckedItems.Count != 0)
                {                    
                    string stkID;
                    string regNum;
                    bool updateError = false;
                    foreach (var item in chklstAuctionAddStock.CheckedItems)
                    {
                        var row = (item as DataRowView).Row;
                        stkID = row["stockID"].ToString();
                        regNum = row["RegNum"].ToString();

                        if (!(mydbConnect.UpdateStock(aucID, stkID)))
                        {
                            MessageBox.Show("Stock Item " + stkID + " couldnt be updated");
                            if (!(updateError == true))
                            {
                                updateError = true;
                            }
                        }
                    }
                    if (updateError == false)
                    {
                        MessageBox.Show("Stock items successfully add for the auction ");
                        stockSelected = true;
                    }

                    pnlAucAddControls.Enabled = false;
                    dtpAuctionDate.Value = DateTime.Today;
                    dateSelected = false;

                }
            }
        }

        #endregion

        #region Back/Help

        private void btnAuctionAddBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
                

        private void BtnAuctionAddHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAuctionAddHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To Create a new auctions : \n" +
                "Step 1. Select a Date for the new auctions in the date picker\n" +
                "Step 2. Click the 'Create New Auction' to the right of the date picker\n" +
                "Step 3. The available stock list will be displayed below ,\n" +
                "click on the check box of the stock items you would like to add to the auction you've created\n" +
                "Step 4. Click on the button  'Add Selected Stock to Auction' ");
        }
    }
}
