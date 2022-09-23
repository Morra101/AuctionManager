using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Auction_Manager
{
    public partial class frmSuppliers_Add : Form
    {
        public string BoP,supIDnum;
        public User UserInfo { get; set; }

        public frmSuppliers_Add()
        {
            InitializeComponent();
        }

        public frmSuppliers_Add(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bynSupplierViewHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmSuppliers_Add_Load(object sender, EventArgs e)
        {

        }

        #region ValidateID
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
        #endregion

        #region Create Username
        private string CreateUsername()
        {
            String username = "Sup";
            BoP = "";
            string name = Regex.Replace(txtSupName.Text, @"\s", "");


            if (chkSuppliersAddPrivate.Checked)
            {
                BoP = "P";
                username += BoP;               
            }

            if (chkSuppliersAddBusiness.Checked)
            {
                BoP = "B";
                username += BoP;                
            }

            int length = name.Length;

            if (length <= 3)
            {
                username += name;
            }
            else
            {
                username += name.Substring(0, 3); ;
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

       
        private void ResetSupAddForm()
        {
            txtSupIDNum.Text = "";
            txtSupName.Text = "";
            txtSupSurn.Text = "";
            txtSupBusRegNum.Text = "";
            txtSupAdress.Text = "";
            chkSuppliersAddPrivate.Checked = false;
            chkSuppliersAddBusiness.Checked = false;
            chkSuppliersAddBusiness.Enabled = true;
            chkSuppliersAddPrivate.Enabled = true;
            txtSupBusRegNum.Enabled = true;
            txtSupSurn.Enabled = true;
            txtSupIDNum.Enabled = true;
        }      
        

        

        #region Text changed
        private void txtSupName_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSupName.BackColor == Color.Red)
            {
                txtSupName.BackColor = Color.White;
            }
        }

        private void txtSupIDNum_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSupIDNum.BackColor == Color.Red)
            {
                txtSupIDNum.BackColor = Color.White;
            }
        }

        private void txtSupSurn_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSupSurn.BackColor == Color.Red)
            {
                txtSupSurn.BackColor = Color.White;
            }
        }

        private void txtSupAdress_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSupAdress.BackColor == Color.Red)
            {
                txtSupAdress.BackColor = Color.White;
            }
        }

        private void chkSuppliersAddPrivate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSuppliersAddPrivate.BackColor == Color.Red)
            {
                chkSuppliersAddPrivate.BackColor = Color.DimGray;
                chkSuppliersAddBusiness.BackColor = Color.DimGray;
            }
            chkSuppliersAddBusiness.Checked = false;
            txtSupIDNum.Enabled = true;
            txtSupBusRegNum.Enabled = false;
            txtSupSurn.Enabled = true;
        }

        private void chkSuppliersAddBusiness_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSuppliersAddBusiness.BackColor == Color.Red)
            {
                chkSuppliersAddBusiness.BackColor = Color.DimGray;
                chkSuppliersAddPrivate.BackColor = Color.DimGray;
            }
            chkSuppliersAddPrivate.Checked = false;
            txtSupSurn.Enabled = false;
            txtSupBusRegNum.Enabled = true;
            txtSupIDNum.Enabled = false;
        }

        private void btnSupAddHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill in at least all the mandatory fields and click on 'Add Supplier'");
        }

        #endregion

        #region Buttons
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtSupIDNum.Text)))

            {
                if (!(ValidateIDNum(txtSupIDNum.Text)))
                {
                    MessageBox.Show("Incorrect Identity number Entered");
                    txtSupIDNum.Focus();
                    txtSupIDNum.BackColor = Color.Red;
                }
            }
            if (chkSuppliersAddPrivate.Checked == false && chkSuppliersAddBusiness.Checked == false)
            {
                MessageBox.Show("Please select if you are private or business");
                chkSuppliersAddBusiness.BackColor = Color.Red;
                chkSuppliersAddPrivate.BackColor = Color.Red;
            }
            else if (String.IsNullOrEmpty(txtSupName.Text) || txtSupName.Text.Equals(" "))
            {
                MessageBox.Show("Please enter the supplier's name");
                txtSupName.Focus();
                txtSupName.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(txtSupAdress.Text) || txtSupAdress.Text.Equals(" "))
            {
                MessageBox.Show("Please enter the suppliers's address");
                txtSupAdress.Focus();
                txtSupAdress.BackColor = Color.Red;
                return;
            }
            else
            {
                DBConnectSuppliers supAddsql = new DBConnectSuppliers();


                string supID = CreateUsername();
                string supName = txtSupName.Text;
                string supSurn = txtSupSurn.Text;
                if (supAddsql.SupplierCheck(supName, supSurn) == true)                                     //Ensure no duplicate Supplier
                {

                    MessageBox.Show("Supplier already exists. Please edit this supplier");
                }
                else
                {
                    supID = CreateUsername();
                    string adminID = UserInfo.GetUserID();
                    string supName1 = Regex.Replace(txtSupName.Text, @"\s", "");
                    string supSurn1 = Regex.Replace(txtSupSurn.Text, @"\s", "");
                    if (String.IsNullOrEmpty(txtSupIDNum.Text) || txtSupIDNum.Text.Equals(" "))
                    {
                        supIDnum = null;
                    }
                    else
                    {
                        supIDnum = txtSupIDNum.Text;
                    }
                    
                    string supBusRegNum = txtSupBusRegNum.Text;
                    string supAddress = txtSupAdress.Text;
                    char supBoP = char.Parse(BoP);

                    if (supAddsql.InsertSupplier(supID, adminID, supBoP, supAddress, supName1, supSurn1, supIDnum, supBusRegNum))
                    {
                        MessageBox.Show("Supplier added successfully -  \n\n SupplierID : \t\t" + supID);
                        ResetSupAddForm();

                    }
                    else
                    {
                        MessageBox.Show("Supplier could not be added");
                    }
                }



            }
        }
        #endregion
    }
}
