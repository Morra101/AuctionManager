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
    public partial class frmManageSuppliersLanding : Form
    {
        public User UserInfo { get; set; }

        public frmManageSuppliersLanding()
        {
            InitializeComponent();
        }

        public frmManageSuppliersLanding(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnSupplierLDBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnViewSuppliers_MouseHover(object sender, EventArgs e)
        {
            btnViewSuppliers.BackgroundImage = Properties.Resources.ViewSelected;
        }
        private void btnViewSuppliers_MouseLeave(object sender, EventArgs e)  
        {  
            btnViewSuppliers.BackgroundImage = Properties.Resources.ViewUnselected;
        }

        private void btnAddSupplier_MouseHover(object sender, EventArgs e)
        {
            btnAddSupplier.BackgroundImage = Properties.Resources.AddSelected;
        }
        private void btnAddSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnAddSupplier.BackgroundImage = Properties.Resources.AddUnselected;
        }

        
        private void btnEditSupplier_MouseHover(object sender, EventArgs e)
        {
            btnEditSupplier.BackgroundImage = Properties.Resources.EditSelected;
        }
        private void btnEditSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnEditSupplier.BackgroundImage = Properties.Resources.EditUnselected;
        }

        private void btnDeleteSupplier_MouseHover(object sender, EventArgs e)
        {
            btnDeleteSupplier.BackgroundImage = Properties.Resources.DeleteSelected;
        }
        private void btnDeleteSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteSupplier.BackgroundImage = Properties.Resources.DeleteUnselected; ;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppliers_Edit frmSupplierEdit = new frmSuppliers_Edit(UserInfo);
            var result = frmSupplierEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppliers_Add frmSupplierAdd = new frmSuppliers_Add(UserInfo);
            var result = frmSupplierAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppliers_View frmSupplierView = new frmSuppliers_View(UserInfo);
            var result = frmSupplierView.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }        

        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppliers_Delete frmSupplierDelete = new frmSuppliers_Delete(UserInfo);
            var result = frmSupplierDelete.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnSuppLDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on the image above the label of the task you would like to proceed with for e.g." +
                "\n'View' -Click on the picture of the eye above the words View ");
        }
    }
}
