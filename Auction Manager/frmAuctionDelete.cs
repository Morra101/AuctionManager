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
    public partial class frmAuctionDelete : Form
    {
        public User UserInfo { get; set; }

        public frmAuctionDelete()
        {
            InitializeComponent();
        }
        public frmAuctionDelete(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private DBConnectAuction myDataConnection;



        #region Form Events

        private void FrmAuctionDelete_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectAuction();
            displayDB("", "");
        }


        private void displayDB(string query, string aucID)                    //populate gridview 
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM auctions";
            }
            // dt = new DataTable();
            DataTable dt = myDataConnection.GetAuctionList(query, aucID);
            dbgAuctionRemove.DataSource = dt;

            query = "SELECT AuctionID FROM auctions";                //populate combo box             
            DataSet ds = new DataSet();
            ds = myDataConnection.GetAuctionListDS(query, "");
            cmbAucDelete.DisplayMember = "AuctionID";
            cmbAucDelete.ValueMember = "AuctionID";
            cmbAucDelete.DataSource = ds.Tables["Source Table"];
        }

        private void DbgAuctionRemove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbAucDelete.Text = dbgAuctionRemove.CurrentRow.Cells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dbgAuctionRemove.Rows[index];
                row.Selected = true;
            }            
        }

        #endregion

        #region button Events

        private void BtnAuctionRemove_Click(object sender, EventArgs e)
        {
            string selectedAuction = cmbAucDelete.Text;

            if (myDataConnection.StockAucIDCheck(selectedAuction))
            {
                MessageBox.Show("This Auction cannot be deleted as it has stock Items assigned to it");
            }
            else
            {
                DataTable dtSelectedAuc = myDataConnection.GetAuctionList("SELECT * FROM auctions WHERE AuctionID = @aucID", selectedAuction);
                string output = "";
                string outputID = "";
                string outputDate = "";
                foreach (DataRow row in dtSelectedAuc.Rows)
                {
                    outputID = row["AuctionID"].ToString();
                    outputDate = row["AuctionDate"].ToString();
                }
                output = "AuctionID : " + outputID + "  Date : " + outputDate;

                DialogResult exitRes = MessageBox.Show("Are you sure you want to delete this Auction : \n" + output, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (exitRes == DialogResult.OK)
                {
                    myDataConnection.Delete(selectedAuction);
                    displayDB("", "");
                    MessageBox.Show("Auction Deleted Successfully");
                }
                if (exitRes == DialogResult.Cancel)
                {
                    return;
                }

            }
        }

        #endregion

        #region back/help Events

        private void btnAucRemoveBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAuctionRemoveHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the Auction ID you want to remove and click on 'Remove'.");
        }


        #endregion


              

        


        
    }
}
