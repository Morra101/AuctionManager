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

namespace Auction_Manager
{
    public partial class frmEmployees_Add : Form
    {
        private User UserInfo { get; set; }

        public frmEmployees_Add()
        {
            InitializeComponent();
        }


        public frmEmployees_Add(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }
        private void FrmEmployees_Add_Load(object sender, EventArgs e)
        {
            lblEmpID.Text = "User ID             : ";
            lblEmpPassword.Text = "User Password : ";
            pnlShow_HidePass.Show();
            btnEmpEditShow.Enabled = false;
            pnlShow_HidePass.BackColor = Color.DarkGray;
            txtEmpAddName.Focus();
        }


        
        private bool ValidateIDNum(string IDnum)
        {
            try
            {
                string date = IDnum.Substring(0, 6);
                string remain = IDnum.Substring(6, 7);
                int iDate;
                int iRemain;

                if (int.TryParse(date, out iDate) || int.TryParse(remain, out iRemain))                 //check Luhn algorithm
                {
                    int nDigits = IDnum.Length;
                    int nSum = 0;
                    bool isSecond = false;
                    for (int i = nDigits - 1; i >= 0; i--)
                    {

                        int d = IDnum[i] - '0';
                        if (isSecond == true)
                            d = d * 2;
                        // We add two digits to handle
                        // cases that make two digits
                        // after doubling
                        nSum += d / 10;
                        nSum += d % 10;
                        isSecond = !isSecond;
                    }
                    return (nSum % 10 == 0);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }            
        }

        #region CreateNewUser
        private string CreatePassword()
        {
            String password = "";

            Random rand = new Random();
            int rand2Digitnum = rand.Next(1, 9);
            password += rand2Digitnum.ToString();
            rand2Digitnum = rand.Next(1, 9);
            password += rand2Digitnum.ToString();

            string name = Regex.Replace(txtEmpAddName.Text,@"\s","");
            string surname = Regex.Replace(txtEmpAddSurname.Text, @"\s", ""); ;

            password += name.Substring(0, 2);
            password += surname.Substring(0, 2);

            rand2Digitnum = rand.Next(1, 9);
            password += rand2Digitnum.ToString();
            rand2Digitnum = rand.Next(1, 9);
            password += rand2Digitnum.ToString();


            return password;
        }

        private string CreateUsername()
        {
            string username = "E";
            if (chkAdminConfirm.Checked)
            {
                username = "A";
            }
            
            string name = Regex.Replace(txtEmpAddName.Text, @"\s", "");
            string surname = Regex.Replace(txtEmpAddSurname.Text, @"\s", ""); ;

            int length = name.Length;

            if (length <= 3)
            {
                username += name;
            }
            else
            {
                username += name.Substring(0, 3); ;
            }

            length = surname.Length;
            if (length <= 3)
            {
                username += surname;
            }
            else
            {
                username += surname.Substring(0, 3); 
            }

            Random random = new Random();       //random number  to add to username
            int rand2Digitnum = random.Next(1, 9);            
            for (int j = 0; j < 5; j++)
            {
                rand2Digitnum = random.Next(1, 9);

            }
            for (int i = 0; i < 3; i++)
            {
                rand2Digitnum = random.Next(1, 9);
                username += rand2Digitnum.ToString();
            }
            return username;
        }

        #endregion

        #region TextChangeEvents

        private void ResetEmpAddForm()
        {
            lblEmpID.Text = "User ID                    : XXXXXXXXX";
            lblEmpPassword.Text = "User Password : ";
            txtEmpAddIDnum.Text = "";
            txtEmpAddName.Text = "";
            txtEmpAddSurname.Text = "";
            pnlShow_HidePass.Visible = false;
        }

        
        private void TxtEmpAddName_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpAddName.BackColor == Color.Red)
            {
                txtEmpAddName.BackColor = Color.White;
            }
        }
        private void TxtEmpAddSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpAddSurname.BackColor == Color.Red)
            {
                txtEmpAddSurname.BackColor = Color.White;
            }            
        }
        private void TxtEmpAddIDnum_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpAddIDnum.BackColor == Color.Red)
            {
                txtEmpAddIDnum.BackColor = Color.White;
            }
            
        }
        #endregion

        #region FormButtonClickEvents

        private void BtnEmpEditShow_Click(object sender, EventArgs e)
        {
            if (pnlShow_HidePass.Visible == false)
            {
                pnlShow_HidePass.Show();
            }
            else
            {
                pnlShow_HidePass.Hide();
            }
        }

        private void BtnEmpSuppView2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmpAddName.Text) || txtEmpAddName.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the User's Name");
                txtEmpAddName.Focus();
                txtEmpAddName.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(txtEmpAddSurname.Text) || txtEmpAddSurname.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the User's Surname");
                txtEmpAddSurname.Focus();
                txtEmpAddSurname.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(txtEmpAddIDnum.Text) || txtEmpAddSurname.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the Users's Identity number");
                txtEmpAddIDnum.Focus();
                txtEmpAddIDnum.BackColor = Color.Red;
                return;
            }
            else if (!(ValidateIDNum(txtEmpAddIDnum.Text)))
            {
                MessageBox.Show("Incorrect Identity number Entered");
                txtEmpAddIDnum.Focus();
                txtEmpAddIDnum.BackColor = Color.Red;
            }
            else
            {
                if (chkAdminConfirm.Checked)
                {
                    DBConnectAdmin adminAddsql = new DBConnectAdmin();
                    string adminPass = CreatePassword();
                    pnlShow_HidePass.Show();
                    btnEmpEditShow.Enabled = true;
                    lblEmpPassword.Text = "User ID                    : XXXXXXXXX" + adminPass;
                    string adminID = CreateUsername();
                    while (adminAddsql.AdminIDCheck(adminID) != false)                                     //Ensure no duplicate AdminID
                    {
                        adminID = CreateUsername();
                    }
                    lblEmpID.Text = "User ID                    : " + adminID;                    
                    string adminName = Regex.Replace(txtEmpAddName.Text, @"\s", "");
                    string adminSurn = Regex.Replace(txtEmpAddSurname.Text, @"\s", "");
                    string adminIDnum = txtEmpAddIDnum.Text;
                    if (adminAddsql.InsertAdmin(adminID, adminName, adminSurn, adminIDnum, adminPass))
                    {
                        MessageBox.Show("User added successfully -  \n\n UserID : \t\t" + adminID + "\n User Password : \t" + adminPass);
                        txtEmpAddName.Text = "";
                        txtEmpAddSurname.Text = "";
                        txtEmpAddIDnum.Text = "";
                        pnlShow_HidePass.BackColor = Color.Goldenrod;
                        btnEmpEditShow.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User couldnt be added");
                    }
                }
                else
                {
                    DBConnectEmployee empAddsql = new DBConnectEmployee();
                    string empPass = CreatePassword();
                    pnlShow_HidePass.Show();
                    btnEmpEditShow.Enabled = true;
                    lblEmpPassword.Text = "User ID                    : XXXXXXXXX" + empPass;
                    string empID = CreateUsername();
                    while (empAddsql.EmployeeIDCheck(empID) != false)                                     //Ensure no duplicate EmployeeID
                    {
                        empID = CreateUsername();
                    }
                    lblEmpID.Text = "Employee ID             : " + empID;
                    string adminID = UserInfo.GetUserID();
                    string empName = Regex.Replace(txtEmpAddName.Text, @"\s", "");
                    string empSurn = Regex.Replace(txtEmpAddSurname.Text, @"\s", "");
                    string empIDnum = txtEmpAddIDnum.Text;
                    if (empAddsql.InsertEmployee(empID, adminID, empName, empSurn, empIDnum, empPass))
                    {
                        MessageBox.Show("Employee added successfully -  \n\n EmployeeID : \t\t" + empID + "\n Employee Password : \t" + empPass);
                        txtEmpAddName.Text = "";
                        txtEmpAddSurname.Text = "";
                        txtEmpAddIDnum.Text = "";
                        pnlShow_HidePass.BackColor = Color.Goldenrod;
                        btnEmpEditShow.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Employee couldnt be added");
                    }
                }
                
                

            }
        }
        
        #endregion

        #region Help&Back_Buttons

        private void BtnEmpViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }











        #endregion
        private void btnEmpViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1. Fill in all the textboxes \nStep 2. Select the checkbox if you want to make the employee an admin \nStep 3. Click on 'Create User' and the relavent data will be displayed \nStep 4. Click on 'Hide/Show password' to view password");
        }

        #region OnClickEvents

        private void LblEmpAddIDnum_Click(object sender, EventArgs e)
        {
            if (lblEmpID.Text != "User ID                    : XXXXXXXXX")
            {
                DialogResult exitRes = MessageBox.Show("Do you want to Add another User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exitRes == DialogResult.Yes)
                {
                    ResetEmpAddForm();
                }
                if (exitRes == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void TxtEmpAddName_Click(object sender, EventArgs e)
        {
            if (lblEmpID.Text != "User ID                    : XXXXXXXXX")
            {
                DialogResult exitRes = MessageBox.Show("Do you want to Add another User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exitRes == DialogResult.Yes)
                {
                    ResetEmpAddForm();
                }
                if (exitRes == DialogResult.No)
                {
                    return;
                }

            }
        }

        #endregion




        private void ChkAdminConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdminConfirm.Checked)
            {
                DialogResult exitRes = MessageBox.Show("Are you sure you want to give this user admin privileges", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (exitRes == DialogResult.OK)
                {
                    
                }
                if (exitRes == DialogResult.Cancel)
                {
                    chkAdminConfirm.Checked = false;
                }
            }
            
        }
    }
}
