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
    public partial class frmStock_Delete : Form
    {
        public User UserInfo { get; set; }

        private DBConnectStock myConnection;
        public frmStock_Delete()
        {
            InitializeComponent();
        }

        public frmStock_Delete(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppBackToLand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #region gridview display
        private void displayDB()
        {
            string query = "SELECT * FROM stock";                   //populate gridview 
            DataSet ds = new DataSet();
            ds = myConnection.SelectStock(query, "");
            dbStockDelete.DataSource = ds;
            dbStockDelete.DataMember = "Source Table";

            query = "SELECT stockID FROM stock";                 //populate combo box 
            
            ds = myConnection.SelectStock(query, "");
            cmbStockID.DisplayMember = "stockID";
            cmbStockID.ValueMember = "stockID";
            cmbStockID.DataSource = ds.Tables["Source Table"];
        }
        #endregion
        private void FrmStock_Delete_Load(object sender, EventArgs e)
        {
            myConnection = new DBConnectStock();
            displayDB();
        }

        private void pbBackSuppDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            string selectedStock = cmbStockID.Text;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to delete the stock item: " + selectedStock, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                myConnection.Delete(selectedStock);
                displayDB();
                MessageBox.Show("Stock Deleted Successfully");
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private void bynSupplierViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the Stock ID you want to remove and click on 'Remove'");
        }
    }
}
