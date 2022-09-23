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
    public partial class frmManageBuyersLanding : Form
    {
        public User UserInfo { get; set; }

        public frmManageBuyersLanding()
        {
            InitializeComponent();
        }

        public frmManageBuyersLanding(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnBuyersView_MouseHover(object sender, EventArgs e)
        {
            btnBuyersView.BackgroundImage = Properties.Resources.ViewSelected;
        }

        private void btnBuyersView_MouseLeave(object sender, EventArgs e)
        {
            btnBuyersView.BackgroundImage = Properties.Resources.ViewUnselected;
        }

        private void btnBuyersAdd_MouseHover(object sender, EventArgs e)
        {
            btnBuyersAdd.BackgroundImage = Properties.Resources.AddSelected;
        }

        private void btnBuyersAdd_MouseLeave(object sender, EventArgs e)
        {
            btnBuyersAdd.BackgroundImage = Properties.Resources.AddUnselected;
        }

        private void btnBuyersEdit_MouseHover(object sender, EventArgs e)
        {
            btnBuyersEdit.BackgroundImage = Properties.Resources.EditSelected;
        }

        private void btnBuyersEdit_MouseLeave(object sender, EventArgs e)
        {
            btnBuyersEdit.BackgroundImage = Properties.Resources.EditUnselected;
        }

        private void btnBuyersDelete_MouseHover(object sender, EventArgs e)
        {
            btnBuyersDelete.BackgroundImage = Properties.Resources.DeleteSelected;
        }

        private void btnBuyersDelete_MouseLeave(object sender, EventArgs e)
        {
            btnBuyersDelete.BackgroundImage = Properties.Resources.DeleteUnselected;
        }
        private void btnBuyBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



                

        private void FrmManageBuyersLanding_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuyersView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuyers_View frmBuyerView = new frmBuyers_View(UserInfo);
            var result = frmBuyerView.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnBuyersAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuyers_Add frmBuyerAdd = new frmBuyers_Add(UserInfo);
            var result = frmBuyerAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnBuyersEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuyers_Edit frmBuyerEdit = new frmBuyers_Edit(UserInfo);
            var result = frmBuyerEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnBuyersDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuyers_Delete frmBuyerDelete = new frmBuyers_Delete(UserInfo);
            var result = frmBuyerDelete.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void btnBuyHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on the image above the label of the task you would like to proceed with for e.g." +
                "\n'View' -Click on the picture of the eye above the words View ");
        }
    }
}
