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
    public partial class frmSuppliers_Edit : Form
    {
        public User UserInfo { get; set; }

        private DBConnectSuppliers myDataConnection;

        public frmSuppliers_Edit()
        {
            InitializeComponent();
        }

        public frmSuppliers_Edit(User uInfo)
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

        private void displayDB()
        {
            string query = "SELECT * FROM suppliers";                   //populate gridview 
            DataSet ds = new DataSet();
            ds = myDataConnection.SelectSupplier(query, "");
            dbSupplierEdit.DataSource = ds;
            dbSupplierEdit.DataMember = "Source Table";

            query = "SELECT SupplierID FROM suppliers";                 //populate combo box 
            DataSet dsCmbBox = new DataSet();
            dsCmbBox = myDataConnection.SelectSupplier(query, "");
            cmbSuppEditSupID.DisplayMember = "SupplierID";
            cmbSuppEditSupID.ValueMember = "SupplierID";
            cmbSuppEditSupID.DataSource = ds.Tables["Source Table"];
            dbSupplierEdit.Columns["PrivateIDnum"].DefaultCellStyle.Format = "D13";
        }

        private void btnSupplierEditBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmSuppliers_Edit_Load(object sender, EventArgs e)
        {
            pnlSuppEdit2.Enabled = false;
            myDataConnection = new DBConnectSuppliers();
            displayDB();
            txtSuppEditName.Enabled = false;
            txtSuppEditSurname.Enabled = false;
            txtSuppEditIDNum.Enabled = false;
            txtSuppEditAddress.Enabled = false;
            txtSuppEditBusRegNum.Enabled = false;
        }

        private void txtSuppEditSelect_Click(object sender, EventArgs e)
        {
            string selectedSupplier = cmbSuppEditSupID.Text;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to edit Supplier : " + selectedSupplier, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                pnlSuppEdit2.Enabled = true;
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private string selectedOptions;

        #region CheckedChanged
        private void chkSupplierEditSurname_CheckedChanged(object sender, EventArgs e)
        {
            selectedOptions = "";

            if (chkSupplierEditName.Checked)
            {
                txtSuppEditName.Enabled = true;
                txtSuppEditName.Focus();
                selectedOptions += " Name";
            }
            else
            {
                txtSuppEditName.Enabled = false;
            }

            if (chkSupplierEditSurname.Checked)
            {
                txtSuppEditSurname.Enabled = true;
                txtSuppEditSurname.Focus();
                selectedOptions += " Surname";
            }
            else
            {
                txtSuppEditSurname.Enabled = false;
            }

            if (chkSupplierEditIDNum.Checked)
            {
                txtSuppEditIDNum.Enabled = true;
                txtSuppEditIDNum.Focus();
                selectedOptions += " IDNum";
            }
            else
            {
                txtSuppEditIDNum.Enabled = false;
            }

            if (chkSupplierEditAddress.Checked)
            {
                txtSuppEditAddress.Enabled = true;
                txtSuppEditAddress.Focus();
                selectedOptions += " Address";
            }
            else
            {
                txtSuppEditAddress.Enabled = false;
            }

            if (chkSuppEditBusRegNum.Checked)
            {
                txtSuppEditBusRegNum.Enabled = true;
                txtSuppEditBusRegNum.Focus();
                selectedOptions += " BusRegNum";
            }
            else
            {
                txtSuppEditBusRegNum.Enabled = false;
            }

            if (chkSupplierEditName.Checked == true || chkSupplierEditSurname.Checked == true || chkSupplierEditIDNum.Checked == true || chkSupplierEditAddress.Checked == true || chkSuppEditBusRegNum.Checked == true)
            {
                btnSuppApplyEdit.Enabled = true;
            }
            else
            {
                btnSuppApplyEdit.Enabled = false;
            }
        }
        #endregion

        #region Button Apply Changes
        private void btnSuppApplyEdit_Click(object sender, EventArgs e)
        {
            string name = txtSuppEditName.Text;
            string supID = cmbSuppEditSupID.Text;
            string surname = txtSuppEditSurname.Text;
            string IDNum = txtSuppEditIDNum.Text;
            string address = txtSuppEditAddress.Text;
            string busRegNum = txtSuppEditBusRegNum.Text;

            if (!(string.IsNullOrEmpty(selectedOptions)))
            {
                if (!(string.IsNullOrEmpty(name)) || !(string.IsNullOrEmpty(surname)) || !(string.IsNullOrEmpty(IDNum)) || !(string.IsNullOrEmpty(address)) || !(string.IsNullOrEmpty(busRegNum)))
                {
                    if (selectedOptions.Contains("Name"))
                    {
                        myDataConnection.UpdateSupName(name, supID);
                        txtSuppEditName.Enabled = false;
                        txtSuppEditName.Clear();
                        chkSupplierEditName.Checked = false;

                    }
                    if (selectedOptions.Contains("Surname"))
                    {
                        myDataConnection.UpdateSupSurname(surname, supID);
                        txtSuppEditSurname.Clear();
                        chkSupplierEditSurname.Checked = false;
                    }
                    if (selectedOptions.Contains("IDNum"))
                    {
                        if (!(String.IsNullOrEmpty(txtSuppEditIDNum.Text)))

                        {
                            if (!(ValidateIDNum(txtSuppEditIDNum.Text)))
                            {
                                MessageBox.Show("Incorrect Identity number Entered");
                                txtSuppEditIDNum.Focus();
                                return;

                            }
                            else
                            {
                                myDataConnection.UpdateSupIDNum(IDNum, supID);
                                txtSuppEditIDNum.Clear();
                                chkSupplierEditIDNum.Checked = false;
                            }
                        }

                    }
                    if (selectedOptions.Contains("Address"))
                    {
                        myDataConnection.UpdateSupAddress(address, supID);
                        txtSuppEditAddress.Clear();
                        chkSupplierEditAddress.Checked = false;
                    }
                    if (selectedOptions.Contains("BusRegNum"))
                    {
                        myDataConnection.UpdateSupBusRegNum(busRegNum, supID);
                        txtSuppEditBusRegNum.Clear();
                        chkSuppEditBusRegNum.Checked = false;
                    }
                    MessageBox.Show("Supplier Updated");
                    displayDB();
                }
            }
        }
        #endregion

        private void btnSuppEditHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select the Supplier ID you want to edit and click on 'Select' \n" +
                "Step 2. Select the checkbox of the field you want to edit and fill in the textbox \n" +
                "Step 3. Click on 'Apply Changes'");
        }
    }
}
