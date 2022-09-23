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
    public partial class frmEmployeeHomeScreen : Form
    {
        public User UserInfo { get; set; }


        public frmEmployeeHomeScreen()
        {
            InitializeComponent();
        }

        public frmEmployeeHomeScreen(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void FrmEmployeeHomeScreen_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = UserInfo.GetFirstName();
        }

        #region Icons

        private void btnEmpStock_MouseHover(object sender, EventArgs e)
        {
            btnEmpStock.BackgroundImage = Properties.Resources.Selected;
        }
        private void BtnEmpStock_MouseLeave(object sender, EventArgs e)
        {
            btnEmpStock.BackgroundImage = Properties.Resources.Unselected;
        }        

        private void BtnEmpBuyers_MouseHover(object sender, EventArgs e)
        {
            btnEmpBuyers.BackgroundImage = Properties.Resources.Buyers2;
        }
        private void BtnEmpBuyers_MouseLeave(object sender, EventArgs e)
        {
            btnEmpBuyers.BackgroundImage = Properties.Resources.Buyers;
        }

        private void BtnEmpReports_MouseHover(object sender, EventArgs e)
        {
            btnEmpReports.BackgroundImage = Properties.Resources.Report2;
        }
        private void BtnEmpReports_MouseLeave(object sender, EventArgs e)
        {
            btnEmpReports.BackgroundImage = Properties.Resources.Report;
        }

        #endregion

        #region Back/Help

        private void BtnEmployeeHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on one of the above images to proceed ");
        }

        private void btnBackEmp_Click(object sender, EventArgs e)
        {

            DialogResult exitRes = MessageBox.Show("Are you sure you want to logout of the program", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (exitRes == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            if (exitRes == DialogResult.Cancel)
            {

            }

        }

        #endregion

        #region Button Events

        private void BtnEmpReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReports frmReportLD = new frmReports(UserInfo);
            var result = frmReportLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnEmpBuyers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageBuyersLanding frmBuyerLD = new frmManageBuyersLanding(UserInfo);
            var result = frmBuyerLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnEmpStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageStockLanding frmStockLD = new frmManageStockLanding(UserInfo);
            var result = frmStockLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        #endregion

        
    }
}
