using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Auction_Manager
{
    public partial class frmStock_Edit : Form
    {
        public User UserInfo { get; set; }

        private DBConnectStock myConnection;
        public frmStock_Edit()
        {
            InitializeComponent();
        }

        public frmStock_Edit(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        
        

        private void btnEmployeeEditBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmStock_Edit_Load(object sender, EventArgs e)
        {
            myConnection = new DBConnectStock();

            string query = "SELECT SupplierID FROM suppliers";                //populate combo box             
            DataSet ds = new DataSet();
            ds = myConnection.SelectStock(query, "");
            cmbEditSuppID.DisplayMember = "SupplierID";
            cmbEditSuppID.ValueMember = "SupplierID";
            cmbEditSuppID.DataSource = ds.Tables["Source Table"];

            query = "SELECT stockID FROM stock";                //populate combo box             
            ds = new DataSet();
            ds = myConnection.SelectStock(query, "");
            cmbEditStockID.DisplayMember = "stockID";
            cmbEditStockID.ValueMember = "stockID";
            cmbEditStockID.DataSource = ds.Tables["Source Table"];


            txtRegNum.Enabled = false;
            txtEngNum.Enabled = false;
            txtChasNum.Enabled = false;
            cmbEditSuppID.Enabled= false;
            dtpAuctionDate.Enabled=false;
            
        }

        private void pbEmployeeEdit_Click(object sender, EventArgs e)
        {

        }
        #region 
        private void btnEditStockApply_Click(object sender, EventArgs e)
        {
           lblSelectedStock.Text = selectedOptions;
            lblSelectedStock.Enabled = false;
            string rNum = txtRegNum.Text;
            string eNum = txtChasNum.Text;
            string chasNum = txtChasNum.Text;
            DateTime dateIN = dtpAuctionDate.Value;
            string suppID = cmbEditSuppID.Text;
           

            if (!(string.IsNullOrEmpty(selectedOptions)))
            {
                if (!(string.IsNullOrEmpty(rNum)) || !(string.IsNullOrEmpty(eNum)) || !(string.IsNullOrEmpty(chasNum)) || !(dateIN.Equals(null))||!(string.IsNullOrEmpty(suppID)))
                {
                    if (selectedOptions.Contains("Registration"))
                    {
                        myConnection.UpdateRNum(rNum, cmbEditStockID.Text);
                    }
                    if (selectedOptions.Contains("Enigine nr"))
                    {
                        myConnection.UpdateENum(eNum, cmbEditStockID.Text);
                    }
                    if (selectedOptions.Contains("Chassis nr"))
                    {
                        myConnection.UpdateChsNum(chasNum, cmbEditStockID.Text);
                    }
                    if (selectedOptions.Contains("Date"))
                    {
                        myConnection.UpdateDateIn(dateIN, cmbEditStockID.Text);
                    }
                    if (selectedOptions.Contains("Supplier"))
                    {
                        myConnection.UpdateSupplier(suppID, cmbEditStockID.Text);
                    }
                    MessageBox.Show("Stock Updated");
                    
                }
            }

        }
        #endregion
       
        private string selectedOptions;
        #region Validation
        private void DummyProof()
        {
            if (chkStockEditReg.Checked || chkEngNum.Checked || chkChasNum.Checked || chkDateIn.Checked || chkSuppID.Checked)
            {
                btnEditStockApply.Enabled = true;
            }
            else
            {
                btnEditStockApply.Enabled = false;
            }
        }
        private void chkAuctionEditDate_CheckedChanged(object sender, EventArgs e)
        {
            selectedOptions = "";

            if (chkStockEditReg.Checked)
            {
                txtRegNum.Enabled = true;
                selectedOptions += "Registration";
              
            }
            else
            {
                txtRegNum.Enabled = false;
            }


            DummyProof();



        }
        
        private void btnEmployeeEditSearch1_Click(object sender, EventArgs e)
        {
            string selectedStock = cmbEditStockID.SelectedValue.ToString();
            DialogResult exitRes = MessageBox.Show("Are you sure you want to edit Stock item : " + selectedStock, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                pnlStockEdit3.Enabled = true;
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
            DummyProof();
        }

        private void chkEngNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEngNum.Checked)
            {
                txtEngNum.Enabled = true;
                selectedOptions += "Enigine nr";
            }
            else
            {
                txtEngNum.Enabled = false;
            }
            DummyProof();
        }

        private void chkChasNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChasNum.Checked)
            {
                txtChasNum.Enabled = true;
                selectedOptions += "Chassis nr";
            }
            else
            {
                txtChasNum.Enabled = false;
            }
            DummyProof();
        }

        private void chkSuppID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuppID.Checked)
            {
                cmbEditSuppID.Enabled = true;
                selectedOptions += "Supplier";
            }
            else
            {
                cmbEditSuppID.Enabled = false;
            }
            DummyProof();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateIn.Checked)
            {
                dtpAuctionDate.Enabled = true;
                selectedOptions += "Date";
            }
            else
            {
                dtpAuctionDate.Enabled = false;
            }
            DummyProof();
        }
        #endregion

        private void btnEmployeeEditHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select the Stock ID you want to edit and click on 'Search' \n" +
                "Step 2. Select the checkbox of the field you want to edit and fill in the textbox \n" +
                "Step 3. Click on 'Apply Changes'");
        }
    }

}
