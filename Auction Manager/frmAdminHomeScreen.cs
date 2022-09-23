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
    public partial class frmAdminHomeScreen : Form
    {

        public User UserInfo { get; set; }

        public frmAdminHomeScreen()
        {
            InitializeComponent();
        }        
        
        public frmAdminHomeScreen(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;            
        }

        private void frmAdminHomeScreen_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = UserInfo.GetFirstName();
        }


        #region buttonIcons


        private void btnAdminReport_MouseHover(object sender, EventArgs e)   // button icon change
        {
            btnAdminReport.BackgroundImage = Properties.Resources.Report2;
        }
        private void btnAdminReport_MouseLeave(object sender, EventArgs e)
        {
            btnAdminReport.BackgroundImage = Properties.Resources.Report;
        }

        private void btnAdminBuyer_MouseHover(object sender, EventArgs e) // button icon change
        {
            btnAdminBuyer.BackgroundImage = Properties.Resources.Buyers2;
        }
        private void btnAdminBuyer_MouseLeave(object sender, EventArgs e)
        {
            btnAdminBuyer.BackgroundImage = Properties.Resources.Buyers;
        }

        private void btnAdminStock_MouseHover(object sender, EventArgs e)   // button icon change
        {
            btnAdminStock.BackgroundImage = Properties.Resources.Selected;
        }
        private void btnAdminStock_MouseLeave(object sender, EventArgs e)
        {
            btnAdminStock.BackgroundImage = Properties.Resources.Unselected;
        }

        private void btnAdminSupplier_MouseHover(object sender, EventArgs e)    // button icon change
        {
            btnAdminSupplier.BackgroundImage = Properties.Resources.SupplierSelected;
        }
        private void btnAdminSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnAdminSupplier.BackgroundImage = Properties.Resources.SupplierUnselected;
        }

        private void btnAdminAuction_MouseHover(object sender, EventArgs e)     // button icon change
        {
            btnAdminAuction.BackgroundImage = Properties.Resources.AuctionSelected;
        }
        private void btnAdminAuction_MouseLeave(object sender, EventArgs e)
        {
            btnAdminAuction.BackgroundImage = Properties.Resources.AuctionUnselected;
        }

        private void btnAdminEmp_MouseHover(object sender, EventArgs e)     // button icon change
        {
            btnAdminEmp.BackgroundImage = Properties.Resources.EmpSelected;
        }
        private void btnAdminEmp_MouseLeave(object sender, EventArgs e)
        {
            btnAdminEmp.BackgroundImage = Properties.Resources.EmpUnselected;
        }

        #endregion

        

        #region buttonClickEvents
        private void btnAdminStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageStockLanding frmStockLD = new frmManageStockLanding(UserInfo);
            var result =frmStockLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {                
                this.Show();
            }

        }

        private void btnAdminBuyer_Click(object sender, EventArgs e)
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

        private void btnAdminSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageSuppliersLanding frmSuppLD = new frmManageSuppliersLanding(UserInfo);
            var result = frmSuppLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnAdminAuction_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageAuctionsLanding frmAuctionLD = new frmManageAuctionsLanding(UserInfo);
            var result = frmAuctionLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnAdminEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageEmployeesLanding frmEmployeeLD = new frmManageEmployeesLanding(UserInfo);
            var result = frmEmployeeLD.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnAdminReport_Click(object sender, EventArgs e)
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

        private void btnAdminLDBack_Click(object sender, EventArgs e)
        {
            DialogResult exitRes = MessageBox.Show("Are you sure you want to Log Out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnAdminLDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Click on one of the buttons to proceed. \n\n-Click on log out to log out of the program.");
        }
    }
}
