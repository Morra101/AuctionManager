using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Auction_Manager
{
    public partial class frmAuction_Edit : Form
    {
        public User UserInfo { get; set; }


        public frmAuction_Edit()
        {
            InitializeComponent();
        }
        public frmAuction_Edit(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private DBConnectAuction myDataConnection;
        private bool aucSelected = false;
        private string aucID;

        private void FrmAuction_Edit_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectAuction();

            string query = "SELECT AuctionID FROM auctions";                //populate combo box             
            DataSet ds = new DataSet();
            ds = myDataConnection.GetAuctionListDS(query, "");
            cmbAucEditIDSelect.DisplayMember = "AuctionID";
            cmbAucEditIDSelect.ValueMember = "AuctionID";
            cmbAucEditIDSelect.DataSource = ds.Tables["Source Table"];



            btnAuctionEditSearch.Enabled = true;
            btnAuctionEditViewStock2.Enabled = false;
            btnAuctionEditAddStock.Enabled = false;
            btnAuctionEditApplyDate.Enabled = false;
            btnAuctionEditViewStock1.Enabled = false;
            btnAuctionEditRemoveStock.Enabled = false;
            cmbAuctionEditIDList.Enabled = false;
            dtpAuctionDate.Enabled = false;
            cbAuctionEditStockID.Enabled = false;
        }


        #region Button Events

        private void BtnAuctionEditSearch_Click(object sender, EventArgs e)
        {
            aucID = cmbAucEditIDSelect.SelectedValue.ToString();

            DataTable dtSelectedAuc = myDataConnection.GetAuctionList("SELECT * FROM auctions WHERE AuctionID = @aucID", aucID);
            string output = "";
            string outputID = "";
            string outputDate = "";
            foreach (DataRow row in dtSelectedAuc.Rows)
            {
                outputID = row["AuctionID"].ToString();
                outputDate = row["AuctionDate"].ToString();
            }

            output = "AuctionID : " + outputID + "  Date : " + outputDate;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to edit this Auction : \n" + output, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                dtpAuctionDate.Value = DateTime.Parse(outputDate);
                aucSelected = true;

                DataSet ds = new DataSet();
                ds = myDataConnection.GetAuctionStockList(aucID);
                cbAuctionEditStockID.DisplayMember = "stockID";
                cbAuctionEditStockID.ValueMember = "stockID";
                cbAuctionEditStockID.DataSource = ds.Tables["Source Table"];

                DataSet dsAvailable = myDataConnection.GetAvailableStockID();
                cmbAuctionEditIDList.DisplayMember = "stockID";
                cmbAuctionEditIDList.ValueMember = "stockID";
                cmbAuctionEditIDList.DataSource = dsAvailable.Tables["Source Table"];
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private void BtnAuctionEditViewStock1_Click(object sender, EventArgs e)
        {
            frmStock_View myStockView = new frmStock_View();
            myStockView.ShowDialog();
        }

        private void BtnAuctionEditRemoveStock_Click(object sender, EventArgs e)
        {
            if (!(cbAuctionEditStockID.SelectedIndex==-1))
            {
                string stockID = cbAuctionEditStockID.SelectedValue.ToString();
                if (myDataConnection.UpdateStock(null, stockID))
                {
                    MessageBox.Show("Stock Item has been removed from Auction : " + aucID);
                    DataSet ds = new DataSet();
                    ds = myDataConnection.GetAuctionStockList(aucID);
                    cbAuctionEditStockID.DisplayMember = "stockID";
                    cbAuctionEditStockID.ValueMember = "stockID";
                    cbAuctionEditStockID.DataSource = ds.Tables["Source Table"];
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        cbAuctionEditStockID.Text = "";  
                    }
                }
                else
                {
                    MessageBox.Show("Stock Item couldnt be removed from Auction : " + aucID);
                }
            }


        }


        private void BtnAuctionEditViewStock2_Click(object sender, EventArgs e)
        {
            frmStock_View myStockView = new frmStock_View();
            myStockView.ShowDialog();
        }


        private void BtnAuctionEditAddStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbAuctionEditIDList.SelectedValue.ToString()))
            {
                string stkID = cmbAuctionEditIDList.SelectedValue.ToString();
                if (myDataConnection.UpdateStock(aucID, stkID))
                {
                    MessageBox.Show("Item succesfully added to Auction : " + aucID);

                    DataSet dsAvailable = myDataConnection.GetAvailableStockID();
                    cmbAuctionEditIDList.DisplayMember = "stockID";
                    cmbAuctionEditIDList.ValueMember = "stockID";
                    cmbAuctionEditIDList.DataSource = dsAvailable.Tables["Source Table"];
                }

            }
            else
            {
                MessageBox.Show("Please select a stock Item");
            }
        }


        #endregion

        #region Back/help

        private void btnEmployeeEditBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion


              

        
        

        private void BtnAuctionEditApplyDate_Click(object sender, EventArgs e)
        {

        }

        #region Check ChangeEvents

        private void ChkAuctionEditDate_CheckedChanged(object sender, EventArgs e)
        {
            if (aucSelected)
            {
                if (chkAuctionEditDate.Checked)
                {
                    //cmbAucID.Enabled = false;       AucID cmbbox
                    chkAucEditAddStock.Checked = false;
                    chkAucEditRemoveStock.Checked = false;
                    dtpAuctionDate.Enabled = true;
                    btnAuctionEditApplyDate.Enabled = true;
                }
                else
                {
                    dtpAuctionDate.Enabled = false;
                    btnAuctionEditApplyDate.Enabled = false;
                }

                if (chkAuctionEditDate.Checked || chkAucEditAddStock.Checked || chkAucEditRemoveStock.Checked)
                {
                    btnAuctionEditSearch.Enabled = false;
                }
                else
                {
                    btnAuctionEditSearch.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please Select an Auction to edit");
                cmbAucEditIDSelect.Focus();
                cmbAucEditIDSelect.BackColor = Color.Red;
                aucSelected = true;
                chkAuctionEditDate.Checked = false;
                aucSelected = false;

            }
        }

        private void ChkAucEditRemoveStock_CheckedChanged(object sender, EventArgs e)
        {
            if (aucSelected)
            {
                if (chkAucEditRemoveStock.Checked)
                {
                    //cmbAucID.Enabled = false;       AucID cmbbox
                    chkAucEditAddStock.Checked = false;
                    chkAuctionEditDate.Checked = false;
                    btnAuctionEditViewStock1.Enabled = true;
                    btnAuctionEditRemoveStock.Enabled = true;
                    cbAuctionEditStockID.Enabled = true;
                    DataSet ds = new DataSet();
                    ds = myDataConnection.GetAuctionStockList(aucID);
                    cbAuctionEditStockID.DisplayMember = "stockID";
                    cbAuctionEditStockID.ValueMember = "stockID";
                    cbAuctionEditStockID.DataSource = ds.Tables["Source Table"];
                }
                else
                {
                    btnAuctionEditViewStock1.Enabled = false;
                    btnAuctionEditRemoveStock.Enabled = false;
                    cbAuctionEditStockID.Enabled = false;
                }

                if (chkAuctionEditDate.Checked || chkAucEditAddStock.Checked || chkAucEditRemoveStock.Checked)
                {
                    btnAuctionEditSearch.Enabled = false;
                }
                else
                {
                    btnAuctionEditSearch.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please Select an Auction to edit");
                cmbAucEditIDSelect.Focus();
                cmbAucEditIDSelect.BackColor = Color.Red;
                aucSelected = true;
                chkAucEditRemoveStock.Checked = false;
                aucSelected = false;
            }
        }

        private void ChkAucEditAddStock_CheckedChanged(object sender, EventArgs e)
        {
            if (aucSelected)
            {
                if (chkAucEditAddStock.Checked)
                {
                    //cmbAucID.Enabled = false;       AucID cmbbox
                    chkAucEditRemoveStock.Checked = false;
                    chkAuctionEditDate.Checked = false;
                    btnAuctionEditViewStock2.Enabled = true;
                    btnAuctionEditAddStock.Enabled = true;
                    cmbAuctionEditIDList.Enabled = true;
                }
                else
                {
                    btnAuctionEditViewStock2.Enabled = false;
                    btnAuctionEditAddStock.Enabled = false;
                    cmbAuctionEditIDList.Enabled = false;
                }

                if (chkAuctionEditDate.Checked || chkAucEditAddStock.Checked || chkAucEditRemoveStock.Checked)
                {
                    btnAuctionEditSearch.Enabled = false;
                }
                else
                {
                    btnAuctionEditSearch.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please Select an Auction to edit");
                cmbAucEditIDSelect.Focus();
                cmbAucEditIDSelect.BackColor = Color.Red;
                aucSelected = true;
                chkAucEditAddStock.Checked = false;
                aucSelected = false;
            }


        }

        #endregion






        private void BtnEmployeeEditHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Edit an auction : \n" +
                "Step 1. Select an Auction ID and click on search\n" +
                "Step 2. Select one of the checkboxes you would like to edit\n" +
                "Step 3. Click on the corresponding button to apply your changes\n" +                
                "- Click on the back button to go back ");
        }

        
    }
}
