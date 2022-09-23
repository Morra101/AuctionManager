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
    public partial class frmBidsFromBuyers : Form
    {
        public User UserInfo { get; set; }

        public frmBidsFromBuyers()
        {
            InitializeComponent();
        }

        public frmBidsFromBuyers(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private DBConnectAuction myDataConnection;
        private DBConnectBuyers myBuyDataConnection;
        private bool aucSelected = false;
        private string aucID;


        private void FrmBidsFromBuyers_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectAuction();
            btnEmployeeEditSearch1.Enabled = true;

            string query = "SELECT AuctionID FROM auctions ";                //populate combo box             
            DataSet ds = new DataSet();
            ds = myDataConnection.GetAuctionListDS(query, "");
            cmbBidAucId.DisplayMember = "AuctionID";
            cmbBidAucId.ValueMember = "AuctionID";
            cmbBidAucId.DataSource = ds.Tables["Source Table"];
        }

        private DataTable myDt;
        private int count = 0;
        private int selected = 0;

        private void BtnEmployeeEditSearch1_Click(object sender, EventArgs e)
        {
            string aucID = cmbBidAucId.Text;
            if (!string.IsNullOrEmpty(aucID))
            {
                dbgBidView.DataSource = null;
                if (myDataConnection.CheckAuctionStock(aucID))
                {
                    myDt = new DataTable();
                    myDt = myDataConnection.GetAuctionStockListDT(aucID);
                    dbgBidView.DataSource = myDt;
                    count = myDt.Rows.Count;
                    selected++;
                    lblNumItems.Text = ": " + selected + " of " + count.ToString();
                    lblStockID.Text = "StockID :" + myDt.Rows[0]["StockID"];
                    btnEmployeeEditSearch1.Enabled = false;
                    cmbBidAucId.Enabled = false;

                    string query = "SELECT PurchaserID FROM purchasers";
                    DataSet ds = new DataSet();
                    myBuyDataConnection = new DBConnectBuyers();
                    ds = myBuyDataConnection.SelectBuyer(query, "");
                    cmbPurch.DisplayMember = "PurchaserID";
                    cmbPurch.ValueMember = "PurchaserID";
                    cmbPurch.DataSource = ds.Tables["Source Table"];
                }
                else
                {
                    MessageBox.Show("Selected Auction currently doesnt have any stock items assigned to it");
                }
            }
            else
            {
                MessageBox.Show("No Auction Selected");
            }

        }

        decimal totalIncomeReceived = 0.00m;
        decimal totalSARS = 0.00m;

        private void Button2_Click(object sender, EventArgs e)
        {
            decimal value = 0.0m;
            if (!string.IsNullOrEmpty(txtBid.Text))
            {
                if (decimal.TryParse(txtBid.Text, out value))
                {
                    string stockID = (string)myDt.Rows[0]["StockID"];
                    myDataConnection.UpdateStockPurch(stockID, value * 115 / 100);
                    string purchID = cmbPurch.SelectedValue.ToString();
                    myDataConnection.UpdateSTKPurchID( stockID,  purchID);
                    btnApply.Enabled = false;
                    btnNext.Enabled = true;
                    totalIncomeReceived += value*115/100;
                    txtBid.Text = "";
                    MessageBox.Show("BID for "+stockID+"Received");
                   
                }
                else
                {
                    MessageBox.Show("Invalid Bid Entry");
                }
            }
            else
            {
                MessageBox.Show("Bid Received cannot be empty");
            }
        }

        private bool done = false;

        private void BtnNext_Click(object sender, EventArgs e)
        {
            selected++;
            if (selected > count)
            {
                totalSARS = totalIncomeReceived * 15 / 115;
                aucID = cmbBidAucId.Text;
                myDataConnection.UpdateTotals(aucID, totalIncomeReceived, count, totalSARS);
                MessageBox.Show("Receiveing Bids complete");
                done = true;
            }
            else
            {
                lblNumItems.Text = ": " + selected + " of " + count.ToString();
                lblStockID.Text = "StockID :" + myDt.Rows[selected-1]["StockID"];
                btnEmployeeEditSearch1.Enabled = false;
                cmbBidAucId.Enabled = false;
                btnApply.Enabled = true;
                btnNext.Enabled = false;
            }            
        }

        private void FrmBidsFromBuyers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmbBidAucId.Enabled==false&& done ==false)
            {
                DialogResult exitRes = MessageBox.Show("You need to finish receiving bids for all the auction stock items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (exitRes == DialogResult.OK)
                {                    
                    e.Cancel = true;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select Auction ID and click on 'Proceed'\n"+
                            "Step 2. Select purchaser ID\n" +
                            "Step 3. Enter bid price in the textbox\n" +
                            "Step 4. Click on button 'Apply'\n" +
                            "Step 5. Click on button 'Next item'\n" +
                            "Step 6. Repeat Step 3-5 until completed.\n" +
                            "The program will say 'Receiving bids complete' when done\n" +
                            "The program will not exit until done!");
        }
    }
}
