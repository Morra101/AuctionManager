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
    public partial class frmBuyers_View : Form
    {
        public User UserInfo { get; set; }
        DBConnectBuyers myDataConnection;
        public frmBuyers_View()
        {
            InitializeComponent();
        }

        public frmBuyers_View(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnBuyViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void displayDB(string query, string buyer_ID)                    //populate gridview 
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM purchasers";
            }
            DataSet ds = new DataSet();
            ds = myDataConnection.SelectBuyer(query, buyer_ID);
            dbBuyerView.DataSource = ds;
            dbBuyerView.DataMember = "Source Table";
            dbBuyerView.Columns["PIDNumber"].DefaultCellStyle.Format = "D13";
            dbBuyerView.Columns["PContactNum"].DefaultCellStyle.Format = "D10";
        }
        private void resetform()
        {
            chkBuyViewName.Checked = false;
            chkBuyViewSurname.Checked = false;
            chkBuyViewAddress.Checked = false;
            chkBuyViewPriID.Checked = false;
            chkBuyViewConNum.Checked = false;
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtIDNum.Text = "";
            txtContactNum.Text = "";
        }
        private void DeactivateCheckboxes()
        {
            chkBuyViewName.Enabled = false;
            chkBuyViewSurname.Enabled = false;
            chkBuyViewAddress.Enabled = false;
            chkBuyViewPriID.Enabled = false;
            chkBuyViewConNum.Enabled = false;
        }

        private void ActivateCheckboxes()
        {
            chkBuyViewName.Enabled = true;
            chkBuyViewSurname.Enabled = true;
            chkBuyViewAddress.Enabled = true;
            chkBuyViewPriID.Enabled = true;
            chkBuyViewConNum.Enabled = true;
        }

        private void DeactivateTextboxes()
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtIDNum.Enabled = false;
            txtContactNum.Enabled = false;
            txtAddress.Enabled = false;
        }

        private void ActivateTextboxes()
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtIDNum.Enabled = true;
            txtContactNum.Enabled = true;
            txtAddress.Enabled = true;
        }


        private void FrmBuyers_View_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectBuyers();
            string query = "SELECT * FROM purchasers";
            displayDB(query, "");
            resetform();
            DeactivateTextboxes();
            
            
            
        }

        private void btnSearchBuyView1_Click(object sender, EventArgs e)
        {
            string buyer_ID = "%" + txtBuyIDSearch.Text + "%";
            string query = "SELECT * FROM purchasers WHERE PurchaserID LIKE @buyer_ID";
            displayDB(query, buyer_ID);
            
        }

        private void btnSearchBuyView2_Click(object sender, EventArgs e)
        {
            string name =txtName.Text ;
            string surname = txtSurname.Text;
            string address = txtAddress.Text;
            string buyer_ID = txtIDNum.Text;
            string contactNum = txtContactNum.Text;

            DataTable dt = new DataTable();
            dt = myDataConnection.GetPurchaserList();
            dbBuyerView.DataSource = dt;

            if (!(string.IsNullOrEmpty(name)) || !(string.IsNullOrEmpty(surname)) || !(string.IsNullOrEmpty(address)) || !(string.IsNullOrEmpty(buyer_ID))||!(string.IsNullOrEmpty(contactNum)))
            {
                if (chkBuyViewName.Checked)
                {
                    (dbBuyerView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PName LIKE '%{0}%'", txtName.Text);
                }
                if (chkBuyViewSurname.Checked)
                {
                    (dbBuyerView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PSurname LIKE '%{0}%'", txtSurname.Text);
                }
                if (chkBuyViewAddress.Checked)
                {
                    (dbBuyerView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PAddress LIKE '%{0}%'", txtAddress.Text);
                }
                if (chkBuyViewPriID.Checked)
                {
                    (dbBuyerView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PIDNumber LIKE '%{0}%'", txtIDNum.Text);
                }
                if (chkBuyViewConNum.Checked)
                {
                    (dbBuyerView.DataSource as DataTable).DefaultView.RowFilter = string.Format("PContactNum LIKE '%{0}%'", txtContactNum.Text);
                }
            }
        }

        private void bttnActivation()
        {
            if(chkBuyViewName.Checked || chkBuyViewSurname.Checked || chkBuyViewAddress.Checked || chkBuyViewPriID.Checked || chkBuyViewConNum.Checked)
            {

                btnSearchBuyView1.Enabled = false;
                btnSearchBuyView2.Enabled = true;
                
            }
            else
            {
                btnSearchBuyView2.Enabled = false;
            }
        }

        private void chkBuyViewName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyViewName.Checked)
            {
                txtBuyIDSearch.Text = "";                
                chkBuyViewSurname.Checked = false;
                chkBuyViewConNum.Checked = false;
                chkBuyViewAddress.Checked = false;
                chkBuyViewPriID.Checked = false;
                txtName.Enabled = true;
                txtName.Focus();
                txtSurname.Text = "";
                txtAddress.Text = "";
                txtIDNum.Text = "";
                txtContactNum.Text = "";
            }
            else
            {
                txtName.Enabled = false;
            }
            bttnActivation();
        }

        private void chkBuyViewPriID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyViewPriID.Checked)
            {
                txtBuyIDSearch.Text = "";
                chkBuyViewName.Checked = false;
                chkBuyViewSurname.Checked = false;
                chkBuyViewConNum.Checked = false;
                chkBuyViewAddress.Checked = false;
                txtIDNum.Enabled = true;
                txtIDNum.Focus();
                txtName.Text = "";
                txtSurname.Text = "";
                txtAddress.Text = "";
                txtContactNum.Text = "";
            }
            else
            {
                txtIDNum.Enabled = false;
            }
            bttnActivation();
        }

        private void chkBuyViewSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyViewSurname.Checked)
            {
                txtBuyIDSearch.Text = "";
                chkBuyViewName.Checked = false;                
                chkBuyViewConNum.Checked = false;
                chkBuyViewAddress.Checked = false;
                chkBuyViewPriID.Checked = false;
                txtSurname.Enabled = true;
                txtSurname.Focus();
                txtName.Text = "";
                txtAddress.Text = "";
                txtIDNum.Text = "";
                txtContactNum.Text = "";
            }
            else
            {
                txtSurname.Enabled = false;
            }
            bttnActivation();
        }

        private void chkBuyViewConNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyViewConNum.Checked)
            {
                txtBuyIDSearch.Text = "";
                chkBuyViewName.Checked = false;
                chkBuyViewSurname.Checked = false;                
                chkBuyViewAddress.Checked = false;
                chkBuyViewPriID.Checked = false;
                txtContactNum.Enabled = true;
                txtContactNum.Focus();
                txtName.Text = "";
                txtSurname.Text = "";
                txtAddress.Text = "";
                txtIDNum.Text = "";

            }
            else
            {
                txtContactNum.Enabled = false;
            }
            bttnActivation();
        }

        private void chkBuyViewAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyViewAddress.Checked)
            {
                txtBuyIDSearch.Text = "";
                chkBuyViewName.Checked = false;
                chkBuyViewSurname.Checked = false;
                chkBuyViewConNum.Checked = false;                
                chkBuyViewPriID.Checked = false;
                txtAddress.Enabled = true;
                txtAddress.Focus(); txtName.Text = "";
                txtSurname.Text = "";
                txtIDNum.Text = "";
                txtContactNum.Text = "";
            }
            else
            {
                txtAddress.Enabled = false;
            }
            bttnActivation();
        }

        private void txtBuyIDSearch_TextChanged(object sender, EventArgs e)
        {
            
            btnSearchBuyView1.Enabled = true;
            chkBuyViewName.Checked = false;
            chkBuyViewSurname.Checked = false;
            chkBuyViewAddress.Checked = false;
            chkBuyViewPriID.Checked = false;
            chkBuyViewConNum.Checked = false;
            txtName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtIDNum.Text = "";
            txtContactNum.Text = "";


        }

        private void pnlBuyViewSearch2_Click(object sender, EventArgs e)
        {
            ActivateCheckboxes();
            ActivateTextboxes();
        }

        private void txtBuyIDSearch_Click(object sender, EventArgs e)
        {
            displayDB("", "");
            chkBuyViewName.Checked = false;
            chkBuyViewSurname.Checked = false;
            chkBuyViewAddress.Checked = false;
            chkBuyViewPriID.Checked = false;
            chkBuyViewConNum.Checked = false;
            btnSearchBuyView1.Enabled = true;
            btnSearchBuyView2.Enabled = false;
        }

        private void btnBuyViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the Buyer ID you want to search and click on 'Search'\nSelect a textbox if you want to search by a certain criteria and click on 'Search for buyer'");
        }
    }
}
