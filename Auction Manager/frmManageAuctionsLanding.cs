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
    public partial class frmManageAuctionsLanding : Form
    {
        public User UserInfo { get; set; }

        public frmManageAuctionsLanding()
        {
            InitializeComponent();
        }

        public frmManageAuctionsLanding(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }       

        #region buttonIcons
        private void BtnAuctionView_MouseHover(object sender, EventArgs e)
        {
            btnAuctionView.BackgroundImage = Properties.Resources.ViewSelected;
        }

        private void BtnAuctionView_MouseLeave(object sender, EventArgs e)
        {
            btnAuctionView.BackgroundImage = Properties.Resources.ViewUnselected;
        }

        private void BtnAuctionAdd_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnAuctionAdd_Leave(object sender, EventArgs e)
        {

        }

        private void BtnAuctionEdit_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnAuctionEdit_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnAuctionDelete_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnAuctionDelete_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnAuctionBids_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnAuctionBids_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonClickEvents

        private void BtnAuctionView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuction_View frmAuctionView = new frmAuction_View(UserInfo);
            var result = frmAuctionView.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnAuctionAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuction_Add frmAuctionAdd = new frmAuction_Add(UserInfo);
            var result = frmAuctionAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnAuctionEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuction_Edit frmAuctionEdit = new frmAuction_Edit(UserInfo);
            var result = frmAuctionEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnAuctionDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuctionDelete frmAuctionDelete = new frmAuctionDelete(UserInfo);
            var result = frmAuctionDelete.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnAuctionBids_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBidsFromBuyers frmAuctionBids = new frmBidsFromBuyers(UserInfo);
            var result = frmAuctionBids.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnAuctionBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        #endregion

        private void BtnAuctionHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on the image above the label of the task you would like to proceed with for e.g." +
                "\n'View' -Click on the picture of the eye above the words View ");
        }
    }
}
