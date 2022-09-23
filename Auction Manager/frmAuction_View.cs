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
    public partial class frmAuction_View : Form
    {
        public User UserInfo { get; set; }

        public frmAuction_View()
        {
            InitializeComponent();
        }

        public frmAuction_View(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private DBConnectAuction myDataConnection;

        private void FrmAuction_View_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectAuction();
            displayDB("", "");
            dtpAuctionDate.Enabled = false;
            btnSearchAucView2.Enabled = false;
        }

        private void displayDB(string query, string aucID)                    //populate gridview 
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM auctions";
            }
            
            DataTable dt = myDataConnection.GetAuctionList(query, aucID);
            dbAuctionView.DataSource = dt;
        }

        #region button events

        private void BtnSearchAucView1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAucIDSearch.Text))
            {
                string aucID = "%" + txtAucIDSearch.Text + "%";
                string query = "SELECT * FROM auctions WHERE AuctionID LIKE @aucID";
                displayDB(query, aucID);
            }
            else
            {
                displayDB("", "");
            }
        }

        private void BtnSearchAucView2_Click(object sender, EventArgs e)
        {            
            DateTime dateSelected = dtpAuctionDate.Value;
            string selectedDate = dateSelected.ToShortDateString();
            string query = "select * FROM auctions WHERE AuctionDate = @date";            
            DataTable dt = myDataConnection.GetAuctionList(query, selectedDate);
            dbAuctionView.DataSource = dt;
        }

        #endregion

        #region back/Help

        private void btnAucViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAucViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The auctions that have been created previously \n" +
                "will be shown on the display above \n\n" +
                "You have the option to search for a specific auction by just typing it's\n" +
                "ID in the textbox labeled 'AuctionID'.  Once you have entered the AuctionID\n" +
                "that you wish to search for CLICK the 'SEARCH' button next to the TEXTBOX \n\n" +
                "Should you wish to filter the display above by the auction date you just\n" +
                "need to select the checkbox labeled 'Date', this will enable the date picker\n" +
                "to the right of the textbox.  Now all you have to do is select the date you\n" +
                "wish to filter the display by then click the button 'SEARCH FOR AUCTION'");
        }

        #endregion

        #region ValueChangeEvents

        
        private void TxtAucIDSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void ChkAucViewDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAucViewDate.Checked)
            {
                displayDB("", "");
                txtAucIDSearch.Text = "";
                btnSearchAucView2.Enabled = true;
                dtpAuctionDate.Enabled = true;
            }
            else
            {
                dtpAuctionDate.Enabled = false;
                btnSearchAucView2.Enabled = false;
            }
        }






        #endregion

        private void TxtAucIDSearch_Click_1(object sender, EventArgs e)
        {
            if (chkAucViewDate.Checked)
            {
                btnSearchAucView1.Enabled = true;
                chkAucViewDate.Checked = false;
                dtpAuctionDate.Value = DateTime.Today;
                displayDB("", "");
            }
        }
    }
}
