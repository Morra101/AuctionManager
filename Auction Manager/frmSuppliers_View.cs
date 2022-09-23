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
    public partial class frmSuppliers_View : Form
    {
        private string business, privte;
        public User UserInfo { get; set; }

        private DBConnectSuppliers mydataconnection;
        public frmSuppliers_View()
        {
            InitializeComponent();
        }

        public frmSuppliers_View(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Clear Selections
        private void ResetForm()
        {
            chkSupplierViewName.Checked = false;
            chkSupplierViewSurname.Checked = false;
            chkSupplierViewAddress.Checked = false;
            chkSupplierViewPID.Checked = false;
            chkSupplierViewBusRegNum.Checked = false;
            chkSupplierBusiness.Checked = false;
            chkSupplierViewPrivate.Checked = false;
            txtName.Text = "";
            txtSurname.Text = "";
            txtSupplierAdress.Text = "";
            txtPersonalIDNum.Text = "";
            txtBusinessRegNum.Text = "";

        }

        private void DeactivateTextboxes()
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtSupplierAdress.Enabled = false;
            txtPersonalIDNum.Enabled = false;
            txtBusinessRegNum.Enabled = false;
        }
        #endregion

        private void FrmSuppliers_View_Load(object sender, EventArgs e)
        {
            mydataconnection = new DBConnectSuppliers();
            string query = "SELECT * FROM suppliers";
            displayDB(query, "");
            ResetForm();
            DeactivateTextboxes();
            btnSearchSuppView1.Enabled = false;
            btnSearchSuppView2.Enabled = false;
        }

        private void displayDB(string query, string supID)                    //populate gridview 
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM suppliers ";
            }
            DataSet ds = new DataSet();
            ds = mydataconnection.SelectSupplier(query, supID);
            dbSupplierView.DataSource = ds;
            dbSupplierView.DataMember = "Source Table";
            dbSupplierView.Columns["PrivateIDnum"].DefaultCellStyle.Format = "D13";
        }

        #region Buttons
        private void btnSearchSuppView1_Click(object sender, EventArgs e)
        {
            string supID = "%" + txtSupplierIDSearch.Text + "%";
            string query = "SELECT * FROM suppliers WHERE SupplierID LIKE @supID";
            displayDB(query, supID);
        }

        private void btnSearchSuppView2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string address = txtSupplierAdress.Text;
            string BusRegNum = txtBusinessRegNum.Text;
            string personIdNum = txtPersonalIDNum.Text;

            if (chkSupplierBusiness.Checked)
            {
                business = "B";
            }

            if (chkSupplierViewPrivate.Checked)
            {
                privte = "P";
            }

            DataTable dt = new DataTable();
            dt = mydataconnection.GetSuppliersList();
            dbSupplierView.DataSource = dt;

            if (!(string.IsNullOrEmpty(name)) || !(string.IsNullOrEmpty(surname)) || !(string.IsNullOrEmpty(address)) || !(string.IsNullOrEmpty(BusRegNum)) || !(string.IsNullOrEmpty(personIdNum)) || !(string.IsNullOrEmpty(business)) || !(string.IsNullOrEmpty(privte)))
            {

                if (chkSupplierViewName.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("SupplierName LIKE '%{0}%'", txtName.Text);
                }
                if (chkSupplierViewSurname.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("SupplierSurname LIKE '%{0}%'", txtSurname.Text);
                }
                if (chkSupplierViewAddress.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("SupplierAddress LIKE '%{0}%'", txtSupplierAdress.Text);
                }
                if (chkSupplierViewBusRegNum.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Business_RegNum LIKE '%{0}%'", txtBusinessRegNum.Text);
                }
                if (chkSupplierViewPID.Checked)
                {
                    //(dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PrivateIdNum LIKE '%{0}%", txtPersonalIDNum.Text);
                    string pvtidNum = "%" + txtPersonalIDNum.Text + "%";
                    string query = "SELECT * FROM suppliers WHERE PrivateIDnum LIKE @supID";
                    displayDB(query, pvtidNum);
                }
                if (chkSupplierBusiness.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("BusinessOrPrivate LIKE '%{0}%'", business);
                }
                if (chkSupplierViewPrivate.Checked)
                {
                    (dbSupplierView.DataSource as DataTable).DefaultView.RowFilter = string.Format("BusinessOrPrivate LIKE '%{0}%'", privte);
                }
            }
        }
        #endregion

        private void txtSupplierIDSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearchSuppView1.Enabled = true;
            ResetForm();
        }

        private void txtSupplierIDSearch_Click(object sender, EventArgs e)
        {
            displayDB("", "");
        }

        #region Checkboxes     

        

        

        private void chkSupplierViewPID_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierViewPID.Checked)
            {
                txtPersonalIDNum.Enabled = true;
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierBusiness.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtBusinessRegNum.Enabled = false;

                txtPersonalIDNum.Focus();
            }
            else
            {
                txtPersonalIDNum.Enabled = false;
                txtPersonalIDNum.Text = "";
            }
        }

        private void chkSupplierViewName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierViewName.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierBusiness.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtSurname.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = false;
                txtName.Enabled = true;
                txtName.Focus();
            }
            else
            {
                txtName.Enabled = false;
                txtName.Text = "";
            }
        }

        private void chkSupplierViewSurname_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierViewSurname.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierBusiness.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtName.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = false;
                txtSurname.Enabled = true;
                txtSurname.Focus();
            }
            else
            {
                txtSurname.Enabled = false;
                txtSurname.Text = "";
            }
        }

        private void chkSupplierViewAddress_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierViewAddress.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierBusiness.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = false;
                txtSupplierAdress.Enabled = true;
                txtSupplierAdress.Focus();
            }
            else
            {
                txtSupplierAdress.Enabled = false;
                txtSupplierAdress.Text = "";
            }
        }

        private void chkSupplierViewBusRegNum_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierViewBusRegNum.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierBusiness.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = true;
                txtBusinessRegNum.Focus();
            }
            else
            {
                txtBusinessRegNum.Enabled = false;
                txtBusinessRegNum.Text = "";
            }
        }

        private void chkSupplierBusiness_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSupplierBusiness.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierViewPrivate.Checked = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = false;

            }
        }

        private void bynSupplierViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the Supplier ID you want to view and click on 'Search' \n" +
               "OR select one of the checkboxes to search by a specific field and click on 'Search for supplier'");
        }

        private void chkSupplierViewPrivate_CheckedChanged_1(object sender, EventArgs e)
        {

            if (chkSupplierViewPrivate.Checked)
            {
                btnSearchSuppView2.Enabled = true;
                txtSupplierIDSearch.Text = "";
                chkSupplierViewName.Checked = false;
                chkSupplierViewSurname.Checked = false;
                chkSupplierViewBusRegNum.Checked = false;
                chkSupplierViewAddress.Checked = false;
                chkSupplierViewPID.Checked = false;
                chkSupplierBusiness.Checked = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtSupplierAdress.Enabled = false;
                txtPersonalIDNum.Enabled = false;
                txtBusinessRegNum.Enabled = false;

            }
        }

        
        #endregion


    }




}
