using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Manager
{
    public partial class frmLogin : Form
    {        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitRes = MessageBox.Show("Are you sure you want to close the program","Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                this.Close();
            }
            if (exitRes == DialogResult.Cancel)
            {
                return;                
            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "ConnectionConfig.txt");
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    ConfigVariables.server = lines[0];
                    ConfigVariables.port = lines[1];                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username");
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password");
                return;
            }
            string userID = txtUsername.Text;
            string password = txtPassword.Text;

            User UserInfo = new User(userID, password);

            DBConnectMySQL mySqlclass = new DBConnectMySQL();

            List<string>[] mylist; //= new List<string>[5];

            mylist = mySqlclass.SelectUser(UserInfo.GetAdmin(), UserInfo.GetUserID());

            string uID = string.Join("", mylist[0]);
            string pass =string.Join("",mylist[4]);
            UserInfo.SetfirstName(string.Join("", mylist[1]));
            UserInfo.SetLastName(string.Join("", mylist[2]));




            if (uID == UserInfo.GetUserID())
            {                
                if (pass == UserInfo.GetPassword())
                {
                    if (UserInfo.GetAdmin())
                    {
                        frmAdminHomeScreen adminForm = new frmAdminHomeScreen(UserInfo);                        
                        adminForm.ShowDialog();
                        UserInfo.LogOut();
                        UserInfo = null;
                        GC.Collect();
                        uID = null;
                        pass = null;
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        frmEmployeeHomeScreen employeeForm = new frmEmployeeHomeScreen(UserInfo);
                        employeeForm.ShowDialog();
                        UserInfo.LogOut();
                        UserInfo = null;                        
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Password entered");
                }
                

            }
            else
            {
                MessageBox.Show("Invalid credentials entered ");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageSuppliersLanding testForm = new frmManageSuppliersLanding();
            testForm.ShowDialog();
        }

        

        private void btnTestEmployee_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "ETest123";
            txtPassword.Text = "Test123";

        }

        private void btnTestAdmin_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "ATest123";
            txtPassword.Text = "Test123";

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            frmConSettings configForm = new frmConSettings();
            configForm.ShowDialog();
        }
    }
}
