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
    public partial class frmSuppliers_Delete : Form
    {
        public User UserInfo { get; set; }

        private DBConnectSuppliers myDataConnection;

        public frmSuppliers_Delete()
        {
            InitializeComponent();
        }

        public frmSuppliers_Delete(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void displayDB()
        {
            string query = "SELECT * FROM suppliers";                   //populate gridview 
            DataSet ds = new DataSet();
            ds = myDataConnection.SelectSupplier(query, "");
            dbSupplierDelete.DataSource = ds;
            dbSupplierDelete.DataMember = "Source Table";

            query = "SELECT SupplierID FROM suppliers";                //populate combo box 

            ds = myDataConnection.SelectSupplier(query, "");
            cmbSupID.DisplayMember = "SupplierID";
            cmbSupID.ValueMember = "SupplierID";
            cmbSupID.DataSource = ds.Tables["Source Table"];
            dbSupplierDelete.Columns["PrivateIDnum"].DefaultCellStyle.Format = "D13";
        }

        private void FrmSuppliers_Delete_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectSuppliers();
            displayDB();
        }

        private void btnSuppDel_Click(object sender, EventArgs e)
        {
            string selectedSup = cmbSupID.Text;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to delete Supplier : " + selectedSup, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                myDataConnection.Delete(selectedSup);
                displayDB();
                MessageBox.Show("Supplier Deleted Successfully");
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnSuppBackToLand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSupplierDeleteHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the Supplier ID you want to delete and click on 'Delete'");
        }
    }
}
