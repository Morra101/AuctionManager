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
    public partial class frmEmployees_Edit : Form
    {
        public User UserInfo { get; set; }

        private DBConnectEmployee myDataConnection;
        private DBConnectAdmin myAdminDataConnection;

        public frmEmployees_Edit()
        {
            InitializeComponent();
        }        

        public frmEmployees_Edit(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private bool adminUser=false;

        private void displayDB()
        {
            DataSet ds = new DataSet();
            DataSet dsCmbBox = new DataSet();
            cmbEmpEdit.DataSource =null;

            if (adminUser==true)
            {
                string query = "SELECT * FROM admin";                   //populate gridview 
                ds = new DataSet();
                ds = myAdminDataConnection.SelectAdmin(query, "");
                dbEmployeeEdit.DataSource = ds;
                dbEmployeeEdit.DataMember = "Source Table";

                query = "SELECT AdminID FROM admin";                 //populate combo box 
                dsCmbBox = new DataSet();
                dsCmbBox = myAdminDataConnection.SelectAdmin(query, "");
                cmbEmpEdit.DisplayMember = "AdminID";
                cmbEmpEdit.ValueMember = "AdminID";
                cmbEmpEdit.DataSource = ds.Tables["Source Table"];
            }
            if (adminUser == false)
            {
                string query = "SELECT * FROM employees";                   //populate gridview 
                ds = new DataSet();
                ds = myDataConnection.SelectEmployee(query, "");
                dbEmployeeEdit.DataSource = ds;
                dbEmployeeEdit.DataMember = "Source Table";

                query = "SELECT EmployeeID FROM employees";                 //populate combo box 
                dsCmbBox = new DataSet();
                dsCmbBox = myDataConnection.SelectEmployee(query, "");
                cmbEmpEdit.DisplayMember = "EmployeeID";
                cmbEmpEdit.ValueMember = "EmployeeID";
                cmbEmpEdit.DataSource = ds.Tables["Source Table"];
            }            
        }


        private void btnEmployeeEditBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmEmployees_Edit_Load(object sender, EventArgs e)
        {
            pnlEmployeeEditSearch2.Enabled = false;
            myDataConnection = new DBConnectEmployee();
            myAdminDataConnection = new DBConnectAdmin();            
            displayDB();            
            txtEmployeeEditName.Enabled = false;
            txtEmployeeEditSurname.Enabled = false;
            txtEmployeeEditPIDNum.Enabled = false;
            txtEmployeeEditPassword.Enabled = false;
        }

        private void BtnEmployeeEditSelect_Click(object sender, EventArgs e)
        {
            string selectedEmployee = cmbEmpEdit.Text;

            DialogResult exitRes = MessageBox.Show("Are you sure you want to edit User : " + selectedEmployee, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                pnlEmployeeEditSearch2.Enabled = true;
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;
            }
        }

        private string selectedOptions;

        private void ChkEmployeeEditSurname_CheckedChanged(object sender, EventArgs e)
        {
            selectedOptions = "";

            if (chkEmployeeEditName.Checked)
            {
                txtEmployeeEditName.Enabled = true;
                selectedOptions += " Name";
            }
            else
            {
                txtEmployeeEditName.Enabled = false;
            }
            
            if (chkEmployeeEditSurname.Checked)
            {
                txtEmployeeEditSurname.Enabled = true;
                selectedOptions += " Surname";
            }
            else
            {
                txtEmployeeEditSurname.Enabled = false;
            }
            
            if (chkEmployeeIDNumber.Checked)
            {
                txtEmployeeEditPIDNum.Enabled = true;
                selectedOptions += " EmployeeID";
            }
            else
            {
                txtEmployeeEditPIDNum.Enabled = false;
            }

            if (chkEmployeePassword.Checked)
            {
                txtEmployeeEditPassword.Enabled = true;
                selectedOptions += " Password";
            }
            else
            {                
                txtEmployeeEditPassword.Enabled = false;                
            }

            if (chkEmployeeEditName.Checked==true|| chkEmployeeEditSurname.Checked|| chkEmployeeIDNumber.Checked|| chkEmployeePassword.Checked)
            {
                btnEditEmployeeApply.Enabled=true;
            }
            else
            {
                btnEditEmployeeApply.Enabled = false;
            }

        }        

        private void BtnEditEmployeeApply_Click(object sender, EventArgs e)
        {            
            string empName = txtEmployeeEditName.Text;
            string empID = cmbEmpEdit.Text;
            string name = txtEmployeeEditName.Text;
            string surname = txtEmployeeEditSurname.Text;
            string empIdNum = txtEmployeeEditPIDNum.Text;
            string empPass = txtEmployeeEditPassword.Text;

            if (!(string.IsNullOrEmpty(selectedOptions)))
            {
                if (!(string.IsNullOrEmpty(name)) || !(string.IsNullOrEmpty(surname)) || !(string.IsNullOrEmpty(empIdNum)) || !(string.IsNullOrEmpty(empPass)))
                {
                    if (adminUser==true)
                    {
                        if (selectedOptions.Contains("Name"))
                        {
                            myAdminDataConnection.UpdateAdminName(name, empID);
                        }
                        if (selectedOptions.Contains("Surname"))
                        {
                            myAdminDataConnection.UpdateAdminSurname(surname, empID);
                        }
                        if (selectedOptions.Contains("EmployeeID"))
                        {
                            myAdminDataConnection.UpdateAdminIDNum(empIdNum, empID);
                        }
                        if (selectedOptions.Contains("Password"))
                        {
                            myAdminDataConnection.UpdateAdminPass(empPass, empID);
                        }
                        MessageBox.Show("Admin User Updated");
                        displayDB();

                    }
                    else
                    {
                        if (selectedOptions.Contains("Name"))
                        {
                            myDataConnection.UpdateEmpName(name, empID);
                        }
                        if (selectedOptions.Contains("Surname"))
                        {
                            myDataConnection.UpdateEmpSurname(surname, empID);
                        }
                        if (selectedOptions.Contains("EmployeeID"))
                        {
                            myDataConnection.UpdateEmpIDNum(empIdNum, empID);
                        }
                        if (selectedOptions.Contains("Password"))
                        {
                            myDataConnection.UpdateEmpPass(empPass, empID);
                        }
                        MessageBox.Show("Employee User Updated");
                        displayDB();
                    }
                    txtEmployeeEditName.Text = "";
                    txtEmployeeEditPassword.Text = "";
                    txtEmployeeEditPIDNum.Text = "";
                    txtEmployeeEditSurname.Text = "";                    
                }
            }
            
        }

        #region Check Change


        #endregion


        private void ChkEditAdmin_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void ChkEditEmployee_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ChkEditAdmin_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEditAdmin.Checked)
            {
                chkEditEmployee.Checked = false;
                adminUser = true;
            }
            displayDB();
        }

        private void ChkEditEmployee_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEditEmployee.Checked == true)
            {
                chkEditAdmin.Checked = false;
                adminUser = false;
            }
            displayDB();
        }

        private void btnEmployeeEditHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select the type of user you want to edit \n " +
                "Step 2. Select the User ID and click on 'Select' \n " +
                "Step 3. Select one of the checkboxes to edit a specific field and click on 'Apply Changes'");
        }
    }
}
