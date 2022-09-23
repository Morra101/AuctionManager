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
using System.Data.SqlClient;

namespace Auction_Manager
{
    public partial class frmBuyers_Add : Form
    {
        
        
        public User UserInfo { get; set; }

        private DBConnectBuyers myDataConnection;
        private DataTable purchaserdt;

        public frmBuyers_Add()
        {
            InitializeComponent();
        }

        public frmBuyers_Add(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSuppViewBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmBuyers_Add_Load(object sender, EventArgs e)
        {
            myDataConnection = new DBConnectBuyers();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btnSearchSuppView2_Click(object sender, EventArgs e)
        {
            int value;
            int lenght = TB_buyer_ContactNum.Text.Length;
            if (String.IsNullOrEmpty(TB_buyer_name.Text) || TB_buyer_name.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the buyers Name");
                TB_buyer_name.Focus();
                TB_buyer_name.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(TB_buyer_surname.Text) || TB_buyer_surname.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the buyers Surname");
                TB_buyer_surname.Focus();
                TB_buyer_surname.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(TB_buyerID.Text) || TB_buyerID.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the buyers Identity number");
                TB_buyerID.Focus();
                TB_buyerID.BackColor = Color.Red;
                return;
            }
            else if (!(ValidateIDNum(TB_buyerID.Text)))
            {
                MessageBox.Show("Incorrect Identity number Entered");
                TB_buyerID.Focus();
                TB_buyerID.BackColor = Color.Red;
            }
            else if(String.IsNullOrEmpty(TB_buyerAddress.Text) || TB_buyerAddress.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the buyers Adress");
                TB_buyerAddress.Focus();
                TB_buyerAddress.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(TB_buyer_ContactNum.Text) || TB_buyer_ContactNum.Text.Equals(" "))
            {
                MessageBox.Show("Please Enter the buyers Adress");
                TB_buyer_ContactNum.Focus();
                TB_buyer_ContactNum.BackColor = Color.Red;
                return;
            }
           
            else if(!int.TryParse(TB_buyer_ContactNum.Text, out value)) 
            {
                MessageBox.Show("This is a number only field");
                TB_buyer_ContactNum.Focus();
                TB_buyer_ContactNum.BackColor = Color.Red;
            }
            else if(lenght < 10 || lenght > 10)
            {
                MessageBox.Show("Contact Number entered is incorrect");
                TB_buyer_ContactNum.Focus();
                TB_buyer_ContactNum.BackColor = Color.Red;
            }
            else
            {
                DBConnectBuyers buyerAddsql = new DBConnectBuyers();
                string buyer_name = Regex.Replace(TB_buyer_name.Text, @"\s", "");
                string buyer_surname = Regex.Replace(TB_buyer_surname.Text, @"\s", "");
                string buyer_address = TB_buyerAddress.Text;
                string buyer_ID = TB_buyerID.Text;
                string buyer_contactNum = TB_buyer_ContactNum.Text;
                string empID = UserInfo.GetUserID();
                if(UserInfo.GetUserID().Substring(0,1) == ("A"))
                {
                    empID = "Etest123";
                }
                
                if (buyerAddsql.InsertBuyers(buyer_name, buyer_surname, buyer_address, buyer_ID, buyer_contactNum , empID ))
                {
                   
                    TB_buyer_name.Text = "";
                    TB_buyer_surname.Text = "";
                    TB_buyerAddress.Text = "";
                    TB_buyerID.Text = "";
                    TB_buyer_ContactNum.Text = "";
    
                }
                else
                {
                    MessageBox.Show("Buyer couldnt be added");
                    return;
                }
                purchaserdt = new DataTable();
                purchaserdt = myDataConnection.GetPurchaserList();
                DataRow firstrow = purchaserdt.Rows[purchaserdt.Rows.Count - 1];
                string purchID = firstrow[0].ToString();

                lbl_BidNum.Text = purchID;
                MessageBox.Show("Record added succesfully\n" + "Buyer Bidnumber is: "+purchID);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter all the requested fields and click on 'Add Buyer'");
        }
    }
}
