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
    public partial class frmBuyers_Edit : Form
    {
        public User UserInfo { get; set; }
        private DBConnectBuyers myDataConnection;

        public frmBuyers_Edit()
        {
            InitializeComponent();
        }

        public frmBuyers_Edit(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        #region ID Validation
        private bool ValidateIDNum(string IDnum)
        {
            try
            {
                string date = IDnum.Substring(0, 6);
                string remain = IDnum.Substring(6, 7);
                int iDate;
                int iRemain;

                if (int.TryParse(date, out iDate) || int.TryParse(remain, out iRemain))                 //check Luhn algorithm
                {
                    int nDigits = IDnum.Length;
                    int nSum = 0;
                    bool isSecond = false;
                    for (int i = nDigits - 1; i >= 0; i--)
                    {

                        int d = IDnum[i] - '0';
                        if (isSecond == true)
                            d = d * 2;
                        // We add two digits to handle
                        // cases that make two digits
                        // after doubling
                        nSum += d / 10;
                        nSum += d % 10;
                        isSecond = !isSecond;
                    }
                    return (nSum % 10 == 0);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        private void CheckboxCheck()
        {

            if (chkBuyersEditName.Checked || chkBuyersEditSurname.Checked || chkBuyersEditIDnumber.Checked || chkBuyersEditContactNum.Checked || chkBuyersEditAddress.Checked)
            {
                btnBuyersEditApplyEdit.Enabled = true;
            }
            else
            {
                btnBuyersEditApplyEdit.Enabled = false;
            }
        }

        private void displayDB()
        {
            string query = "SELECT * FROM purchasers";
            DataSet ds = new DataSet();
            ds = myDataConnection.SelectBuyer(query, "");
            dbBuyersEdit.DataSource = ds;
            dbBuyersEdit.DataMember = "Source Table";

            query = "SELECT PurchaserID FROM purchasers";
            DataSet dsCmbBox = new DataSet();
            ds = myDataConnection.SelectBuyer(query, "");
            CB_buyerID.DisplayMember = "PurchaserID";
            CB_buyerID.ValueMember = "PurchaserID";
            CB_buyerID.DataSource = ds.Tables["Source Table"];
            dbBuyersEdit.Columns["PIDNumber"].DefaultCellStyle.Format = "D13";
            dbBuyersEdit.Columns["PContactNum"].DefaultCellStyle.Format = "D10";

        }

        private void btnBuyersEditBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmBuyers_Edit_Load(object sender, EventArgs e)
        {
            pnlBuyerEdit3.Enabled = false;
            myDataConnection = new DBConnectBuyers();
            displayDB();
            txtBuyersEditName.Enabled = false;
            txtBuyersEditSurname.Enabled = false;
            txtBuyersEditPIDNum.Enabled = false;
            txtBuyersEditAddress.Enabled = false;
        }

        private void btnBuyerEditSearch_Click(object sender, EventArgs e)
        {
            string selectedBuyer = CB_buyerID.Text;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to edit Buyers : " + selectedBuyer, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                pnlBuyerEdit3.Enabled = true;
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private string options = "";

        private void chkBuyersEditSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyersEditSurname.Checked)
            {
                txtBuyersEditSurname.Enabled = true;
                txtBuyersEditSurname.Focus();
                options += " Surname";
            }
            else
            {
                txtBuyersEditSurname.Enabled = false;
            }
            CheckboxCheck();





        }

        private void btnBuyersEditApplyEdit_Click(object sender, EventArgs e)
        {
            string buyer_ID = CB_buyerID.Text;
            string buyer_IDNum = txtBuyersEditPIDNum.Text;
            string buyer_name = txtBuyersEditName.Text;
            string buyer_surname = txtBuyersEditSurname.Text;
            string buyer_address = txtBuyersEditAddress.Text;
            string buyer_contactNum = txtBuyersEditContactNum.Text;


            if (!(string.IsNullOrEmpty(options)))
            {
                if (!(string.IsNullOrEmpty(buyer_name)) || !(string.IsNullOrEmpty(buyer_surname)) || !(string.IsNullOrEmpty(buyer_address)) || !(string.IsNullOrEmpty(buyer_IDNum)) || !(string.IsNullOrEmpty(buyer_contactNum)) || !(string.IsNullOrEmpty(buyer_ID)))
                {
                    if (options.Contains("Name"))
                    {
                        myDataConnection.UpdateBuyerName(buyer_name, buyer_ID);
                        txtBuyersEditName.Enabled = false;
                        txtBuyersEditName.Clear();
                        chkBuyersEditName.Checked = false;
                    }
                    if (options.Contains("Surname"))
                    {
                        myDataConnection.UpdateBuyerSurname(buyer_surname, buyer_ID);
                        txtBuyersEditSurname.Enabled = false;
                        txtBuyersEditSurname.Clear();
                        chkBuyersEditSurname.Checked = false;
                    }
                    if (options.Contains("Adress"))
                    {
                        myDataConnection.UpdateBuyerAddress(buyer_address, buyer_ID);
                        txtBuyersEditAddress.Enabled = false;
                        txtBuyersEditAddress.Clear();
                        chkBuyersEditAddress.Checked = false;
                    }
                    if (options.Contains("IDnumber"))
                    {
                        if (!(string.IsNullOrEmpty(txtBuyersEditPIDNum.Text)))
                        {
                            if (!(ValidateIDNum(txtBuyersEditPIDNum.Text)))
                            {
                                MessageBox.Show("Incorrect Identity number Entered");
                                txtBuyersEditPIDNum.Focus();
                                return;
                            }
                            else
                            {
                                myDataConnection.UpdateBuyerID(buyer_IDNum, buyer_ID);
                                txtBuyersEditPIDNum.Clear();
                                chkBuyersEditIDnumber.Checked = false;
                            }
                        }

                    }
                    if (options.Contains("ContactNumber"))
                    {
                        myDataConnection.UpdateBuyerContactNum(buyer_contactNum, buyer_ID);
                        txtBuyersEditContactNum.Enabled = false;
                        txtBuyersEditContactNum.Clear();
                        chkBuyersEditContactNum.Checked = false;
                    }
                    MessageBox.Show("Buyer Updated");
                    displayDB();
                }                
            }
        }

   

       

        private void chkBuyersEditName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyersEditName.Checked)
            {
                txtBuyersEditName.Enabled = true;
                txtBuyersEditName.Focus();
                options += " Name";
            }
            else
            {
                txtBuyersEditName.Enabled = false;
            }
            CheckboxCheck();
        }

        private void chkBuyersEditIDnumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyersEditIDnumber.Checked)
            {
                txtBuyersEditPIDNum.Enabled = true;
                txtBuyersEditPIDNum.Focus();
                options += " BuyerID";
            }
            else
            {
                txtBuyersEditPIDNum.Enabled = false;
            }
            CheckboxCheck();
        }

        private void chkBuyersEditAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyersEditAddress.Checked)
            {
                txtBuyersEditAddress.Enabled = true;
                txtBuyersEditAddress.Focus();
                options += " Address";
            }
            else
            {
                txtBuyersEditAddress.Enabled = false;
            }
            CheckboxCheck();
        }

        private void chkBuyersEditContactNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyersEditContactNum.Checked)
            {
                txtBuyersEditContactNum.Enabled = true;
                txtBuyersEditContactNum.Focus();
                options += " Contact Number";
            }
            else
            {
                txtBuyersEditContactNum.Enabled = false;
            }
            CheckboxCheck();
        }

        private void btnBuyersEditHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the Buyer ID you want to edit and click on 'Select' \nSelect the checkboxes you want to edit and add the data \nClick on apply changes");
        }
    }
}
