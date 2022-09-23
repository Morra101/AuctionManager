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
    public partial class frmEmployees_View : Form
    {
        public User UserInfo { get; set; }

        private DBConnectEmployee myDataConnection;
        private DBConnectAdmin myAdminDataConnection;

        public frmEmployees_View()
        {
            InitializeComponent();
        }

        public frmEmployees_View(User uInfo)
        {
            InitializeComponent();

            UserInfo = uInfo;
        }
        

        private void displayDB(string query,string empID)                    //populate gridview 
        {
            if (adminUsers==true)
            {
                if (string.IsNullOrEmpty(query))
                {
                    query = "SELECT * FROM admin";
                }
                DataSet ds = new DataSet();
                ds = myAdminDataConnection.SelectAdmin(query, empID);
                dbEmployeeView.DataSource = ds;
                dbEmployeeView.DataMember = "Source Table";
            }
            else
            {
                if (string.IsNullOrEmpty(query))
                {
                    query = "SELECT * FROM employees";
                }
                DataSet ds = new DataSet();
                ds = myDataConnection.SelectEmployee(query, empID);
                dbEmployeeView.DataSource = ds;
                dbEmployeeView.DataMember = "Source Table";
            }
                      
        }

        private void btnEmpViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void FrmEmployees_View_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectEmployee();
            myAdminDataConnection = new DBConnectAdmin();
            string query = "SELECT * FROM employees";
            displayDB(query,"");
            chkEmpViewID.Checked = false;
            chkEmpViewName.Checked = false;
            chkEmpViewSurname.Checked = false;
            txtIDNum.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtIDNum.Enabled = false;
            chkEmployee.Checked = true;
        }





        #region buttonEvents

        private void BtnSearchEmpView1_Click(object sender, EventArgs e)
        {
            string empID = "%" + txtEmpIDSearch.Text + "%";
            string query;
            if (adminUsers==true)
            {
                query = "SELECT * FROM admin WHERE AdminID LIKE @adminID";
            }
            else
            {
                query = "SELECT * FROM employees WHERE EmployeeID LIKE @empID";
            }            
            displayDB(query, empID);
        }

        private void BtnSearchEmpView2_Click(object sender, EventArgs e)
        {               
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string empIdNum = txtIDNum.Text;

            DataTable dt = new DataTable();
            if (adminUsers==true)
            {
                dt = myAdminDataConnection.GetAdminList();
            }
            else
            {
                dt = myDataConnection.GetEmployeeList();
            }
            
            dbEmployeeView.DataSource = dt;

            if (!(string.IsNullOrEmpty(name)) || !(string.IsNullOrEmpty(surname)) || !(string.IsNullOrEmpty(empIdNum)) )            
            {
                if (adminUsers==true)
                {
                    if (chkEmpViewName.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("AdminName LIKE '%{0}%'", txtName.Text);
                    }
                    if (chkEmpViewSurname.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("AdminSurname LIKE '%{0}%'", txtSurname.Text);
                    }
                    if (chkEmpViewID.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("AdminIDNumber LIKE '%{0}%'", txtIDNum.Text);
                    }
                }
                else
                {
                    if (chkEmpViewName.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmployeeName LIKE '%{0}%'", txtName.Text);
                    }
                    if (chkEmpViewSurname.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmployeeSurname LIKE '%{0}%'", txtSurname.Text);
                    }
                    if (chkEmpViewID.Checked)
                    {
                        (dbEmployeeView.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmployeeIDNumber LIKE '%{0}%'", txtIDNum.Text);
                    }
                }
                                   
            }            
        }

        #endregion

        #region checkboxes

        private void ChkEmpViewName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpViewName.Checked)
            {
                txtEmpIDSearch.Text = "";
                chkEmpViewID.Checked = false;
                chkEmpViewSurname.Checked = false;
                txtName.Enabled = true;
                txtName.Focus();
            }
            else
            {
                txtName.Enabled = false;
                txtName.Text = "";
            }

            if (chkEmpViewName.Checked || chkEmpViewSurname.Checked || chkEmpViewID.Checked)
            {
                btnSearchEmpView2.Enabled = true;
                btnSearchEmpView1.Enabled = false;
                txtEmpIDSearch.Text = "";
            }
            else
            {
                btnSearchEmpView2.Enabled = false;
            }
        }

        private void ChkEmpViewSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpViewSurname.Checked)
            {
                txtEmpIDSearch.Text = "";
                chkEmpViewID.Checked = false;
                chkEmpViewName.Checked = false;
                txtSurname.Enabled = true;
                txtSurname.Focus();
            }
            else
            {
                txtSurname.Enabled = false;
                txtSurname.Text = "";
            }

            if (chkEmpViewName.Checked || chkEmpViewSurname.Checked || chkEmpViewID.Checked)
            {
                btnSearchEmpView2.Enabled = true;
            }
            else
            {
                btnSearchEmpView2.Enabled = false;
            }
        }

        private void ChkEmpViewID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpViewID.Checked)
            {
                txtEmpIDSearch.Text = "";
                chkEmpViewName.Checked = false;
                chkEmpViewSurname.Checked = false;
                txtIDNum.Enabled = true;
                txtIDNum.Focus();
            }
            else
            {
                txtIDNum.Enabled = false;
                txtIDNum.Text = "";
            }

            if (chkEmpViewName.Checked || chkEmpViewSurname.Checked || chkEmpViewID.Checked)
            {
                btnSearchEmpView2.Enabled = true;
            }
            else
            {
                btnSearchEmpView2.Enabled = false;
            }
        }
        #endregion


        

        private void TxtEmpIDSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearchEmpView1.Enabled = true;
            chkEmpViewID.Checked = false;
            chkEmpViewName.Checked = false;
            chkEmpViewSurname.Checked = false;
            txtIDNum.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void BtnEmpViewResetFilter_Click(object sender, EventArgs e)
        {
            displayDB("", "");
            chkEmpViewID.Checked = false;
            chkEmpViewName.Checked = false;
            chkEmpViewSurname.Checked = false;
        }

        private void TxtEmpIDSearch_Click(object sender, EventArgs e)
        {
            displayDB("","");
            chkEmpViewID.Checked = false;
            chkEmpViewName.Checked = false;
            chkEmpViewSurname.Checked = false;
            btnSearchEmpView1.Enabled = true;
            btnSearchEmpView2.Enabled = false;
        }


        bool adminUsers;

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
            displayDB("", "");
        }

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
            displayDB("", "");
        }

        private void btnEmpViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Select the type of user you want to view \n" +
                "Step 2. Select the User ID and click on 'Search' \n" +
                "OR select one of the checkboxes to filter by a specific field and click on 'Apply Filter' \n" +
                "Step 3. Click on 'Reset Filters' to clear all filters");
        }
    }
}
