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
    public partial class frmEmployees_Delete : Form
    {
        public User UserInfo { get; set; }
        private DBConnectEmployee myDataConnection;
        private DBConnectAdmin myAdminDataConnection;
        

        public frmEmployees_Delete()
        {
            InitializeComponent();            
        }

        public frmEmployees_Delete(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppBackToLand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmEmployees_Delete_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectEmployee();
            myAdminDataConnection = new DBConnectAdmin();
            displayDB();
        }

        private void displayDB()
        {
            DataSet ds = new DataSet();
            DataSet dsCmbBox = new DataSet();
            cmbEmployeeID.DataSource = null;

            if (adminUsers == true)
            {
                string query = "SELECT * FROM admin";                   //populate gridview 
                ds = new DataSet();
                ds = myAdminDataConnection.SelectAdmin(query, "");
                dbEmployeeDelete.DataSource = ds;
                dbEmployeeDelete.DataMember = "Source Table";

                query = "SELECT AdminID FROM admin";                 //populate combo box 
                dsCmbBox = new DataSet();
                dsCmbBox = myAdminDataConnection.SelectAdmin(query, "");
                cmbEmployeeID.DisplayMember = "AdminID";
                cmbEmployeeID.ValueMember = "AdminID";
                cmbEmployeeID.DataSource = ds.Tables["Source Table"];
            }
            if (adminUsers == false)
            {
                string query = "SELECT * FROM employees";                   //populate gridview 
                ds = new DataSet();
                ds = myDataConnection.SelectEmployee(query, "");
                dbEmployeeDelete.DataSource = ds;
                dbEmployeeDelete.DataMember = "Source Table";

                query = "SELECT EmployeeID FROM employees";                 //populate combo box 
                dsCmbBox = new DataSet();
                dsCmbBox = myDataConnection.SelectEmployee(query, "");
                cmbEmployeeID.DisplayMember = "EmployeeID";
                cmbEmployeeID.ValueMember = "EmployeeID";
                cmbEmployeeID.DataSource = ds.Tables["Source Table"];
            }
        }

        

        private void BtnSearchEmpDelete_Click(object sender, EventArgs e)
        {
            string selectedEmployee = cmbEmployeeID.Text;
            
            DialogResult exitRes = MessageBox.Show("Are you sure you want to delete Employee : "+ selectedEmployee, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                if (adminUsers==true)
                {
                    myAdminDataConnection.UpdateAdminPass("    ",selectedEmployee);                     //fill password with invisible character to disable users to use the admin User
                    MessageBox.Show("User Disabled Successfully");
                }
                else
                {
                    myDataConnection.Delete(selectedEmployee);
                    MessageBox.Show("Employee Deleted Successfully");
                }                
                displayDB();
                
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private bool adminUsers;

        private void ChkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployee.Checked)
            {
                chkAdmin.Checked = false;
                adminUsers = false;
            }
            else
            {
                chkAdmin.Checked = true;
                adminUsers = true;
            }
            displayDB();
        }

        private void ChkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                chkEmployee.Checked = false;
                adminUsers = true;
            }
            else
            {
                chkEmployee.Checked = true;
                adminUsers = false;
            }
            displayDB();
        }

        private void bynEmpRemoveHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select the checkbox of the type of user you want to delete \n Step 2. Select the User ID and click on 'Remove'");
        }
    }
}
