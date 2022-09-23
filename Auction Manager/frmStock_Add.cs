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
    public partial class frmStock_Add : Form
    {
        public User UserInfo { get; set; }

        private DBConnectStock myConnection;

        public frmStock_Add()
        {
            InitializeComponent();
        }

        public frmStock_Add(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }


        private string CreateStockID()
        {
            string stockID = "STK";
            string regNum = Regex.Replace(txtAddRegNum.Text, @"\s", "");

            Random rand = new Random();
            int rand2Digitnum = rand.Next(1, 9);
            stockID += rand2Digitnum.ToString();
            rand2Digitnum = rand.Next(1, 9);
            stockID += rand2Digitnum.ToString();
            stockID += regNum;            
            return stockID;            
        }

        private void lblSuppliersAddName_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmStock_Add_Load(object sender, EventArgs e)
        {
            myConnection = new DBConnectStock();

            string query = "SELECT SupplierID FROM suppliers";                //populate combo box             
            DataSet ds= new DataSet();
            ds = myConnection.SelectStock(query, "");
            cmbAddSuppID.DisplayMember = "SupplierID";
            cmbAddSuppID.ValueMember = "SupplierID";
            cmbAddSuppID.DataSource = ds.Tables["Source Table"];

            txtAddRegNum.Focus();
            txtAddRegNum.TabIndex = 1;
            txtAddEngNum.TabIndex = 2;
            txtAddChasNum.TabIndex = 3;
            cmbAddSuppID.TabIndex = 4;
            dtpAuctionDate.TabIndex = 5;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchSuppView2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddRegNum.Text) || txtAddRegNum.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the Registration number");
                txtAddRegNum.Focus();
                txtAddRegNum.BackColor = Color.Red;
                return;
            }
            else if ((cmbAddSuppID.Equals(null)))
            {
                MessageBox.Show("Please Enter the Suppliers' details");
                cmbAddSuppID.Focus();
                cmbAddSuppID.BackColor = Color.Red;
                return;
            }
            else if (dtpAuctionDate.Equals(null))
            {
                MessageBox.Show("Please Enter the Date of the auction");
                dtpAuctionDate.Focus();
                dtpAuctionDate.BackColor = Color.Red;
                return;
            }
            else
            {
                myConnection = new DBConnectStock();

                string stkID = CreateStockID();                
                string userID= UserInfo.GetUserID();
                string suppID= cmbAddSuppID.SelectedValue.ToString();
                DateTime dateIn = dtpAuctionDate.Value;
                string rNum= txtAddRegNum.Text;
                string eNum= txtAddEngNum.Text;
                string chsNum=txtAddChasNum.Text;
                if (myConnection.InsertStock(stkID, userID,dateIn,rNum,eNum,chsNum, suppID))
                {
                    MessageBox.Show("Stock added successfully -  \n\n Registration : \t\t" +rNum);
                    txtAddRegNum.Text = "";
                    txtAddEngNum.Text = "";
                    txtAddChasNum.Text = "";
                    cmbAddSuppID.SelectedIndex = -1;

                    
                
                }
                else
                {
                    MessageBox.Show("Stock couldnt be added");
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Enter at least all the mandatory textboxes \n" +
                "Step 2. Click on 'Add Stock Item'");
        }
    }
}
