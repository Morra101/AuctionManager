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
    public partial class frmBuyers_Delete : Form
    {
        public User UserInfo { get; set; }
        private DBConnectBuyers myDataConnection;


        public frmBuyers_Delete()
        {
            InitializeComponent();
        }

        public frmBuyers_Delete(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppBackToLand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void displayDB()
        {
            string query = "SELECT * FROM purchasers";                   //populate gridview 
            DataSet ds = new DataSet();
            ds = myDataConnection.SelectBuyer(query, "");
            DB_buyerDel.DataSource = ds;
            DB_buyerDel.DataMember = "Source Table";

            query = "SELECT PurchaserID FROM purchasers";                 //populate combo box 
            //DataSet dsCmbBox = new DataSet();
            ds = myDataConnection.SelectBuyer(query, "");
            CB_buyerDel.DisplayMember = "PurchaserID";
            CB_buyerDel.ValueMember = "PurchaserID";
            CB_buyerDel.DataSource = ds.Tables["Source Table"];
            DB_buyerDel.Columns["PIDNumber"].DefaultCellStyle.Format = "D13";
            DB_buyerDel.Columns["PContactNum"].DefaultCellStyle.Format = "D10";
        }

        private void FrmBuyers_Delete_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectBuyers();
            displayDB();
        }

        private void btnSearchbuyerRemove_Click(object sender, EventArgs e)
        {
            string selectedBuyer = CB_buyerDel.Text;
            if (!string.IsNullOrEmpty(selectedBuyer))
            {
                DialogResult exitRes = MessageBox.Show("Are you sure you want to delete Buyer : " + selectedBuyer, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (exitRes == DialogResult.OK)
                {
                    myDataConnection.Delete(selectedBuyer);
                    displayDB();
                    MessageBox.Show("Buyer Deleted Successfully");
                }
                if (exitRes == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No buyer selected");
            }            
        }

        private void DB_buyerDel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CB_buyerDel.Text = DB_buyerDel.CurrentRow.Cells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = DB_buyerDel.Rows[index];
                row.Selected = true;
            }
        }

        private void bynSupplierViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the Buyer ID you want to delete and click on 'Delete'");
        }
    }
}
