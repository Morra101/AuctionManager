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
    public partial class frmManageStockLanding : Form
    {
        public User UserInfo { get; set; }

        public frmManageStockLanding()
        {
            InitializeComponent();
        }

        public frmManageStockLanding(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }
        
        private void btnStockView_MouseHover(object sender, EventArgs e)
        {
            btnStockView.BackgroundImage = Properties.Resources.ViewSelected;
        }   // button icon change
        private void btnStockView_MouseLeave(object sender, EventArgs e)
        {
            btnStockView.BackgroundImage = Properties.Resources.ViewUnselected;
        }


        private void btnStockAdd_MouseHover(object sender, EventArgs e)
        {
            btnStockAdd.BackgroundImage = Properties.Resources.AddSelected;
        }   // button icon change
        private void btnStockAdd_MouseLeave(object sender, EventArgs e)
        {
            btnStockAdd.BackgroundImage = Properties.Resources.AddUnselected;
        }

        private void btnStockEdit_MouseHover(object sender, EventArgs e)
        {
            btnStockEdit.BackgroundImage = Properties.Resources.EditSelected;
        }   // button icon change
        private void btnStockEdit_MouseLeave(object sender, EventArgs e)
        {
            btnStockEdit.BackgroundImage = Properties.Resources.EditUnselected;
        }

        private void btnStockDelete_MouseHover(object sender, EventArgs e)
        {
            btnStockDelete.BackgroundImage = Properties.Resources.DeleteSelected;
        }
        private void btnStockDelete_MouseLeave(object sender, EventArgs e)
        {
            btnStockDelete.BackgroundImage = Properties.Resources.DeleteUnselected;
        }
                
        private void btnStockView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock_View frmStockView = new frmStock_View();
            var result = frmStockView.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock_Add frmStockAdd = new frmStock_Add(UserInfo);
            var result = frmStockAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnStockEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock_Edit frmStockEdit = new frmStock_Edit(UserInfo);
            var result = frmStockEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnStockDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock_Delete frmStockDelete = new frmStock_Delete(UserInfo);
            var result = frmStockDelete.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnStockLDBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmManageStockLanding_Load(object sender, EventArgs e)
        {

        }

        private void pbManageStockHome_Click(object sender, EventArgs e)
        {

        }

        private void btnStockLDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on the image above the label of the task you would like to proceed with for e.g." +
                "\n'View' -Click on the picture of the eye above the words View ");
        }
    }
}
