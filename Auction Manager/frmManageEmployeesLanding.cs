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
    public partial class frmManageEmployeesLanding : Form
    {
        public User UserInfo { get; set; }

        public frmManageEmployeesLanding()
        {
            InitializeComponent();
        }
        public frmManageEmployeesLanding(User uInfo)
        {
            InitializeComponent();
            UserInfo = uInfo;
        }

        private void btnEmployeeLDBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmManageEmployeesLanding_Load(object sender, EventArgs e)
        {

        }

        #region Button_Click_Events

        private void BtnEmployeeLDView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees_View frmEmployeesView = new frmEmployees_View(UserInfo);
            var result = frmEmployeesView.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnEmployeeLDAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees_Add frmEmployeesAdd = new frmEmployees_Add(UserInfo);
            var result = frmEmployeesAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnEmployeeLDEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees_Edit frmEmployeesEdit = new frmEmployees_Edit(UserInfo);
            var result = frmEmployeesEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void BtnEmployeeLDDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees_Delete frmEmployeesDelete = new frmEmployees_Delete(UserInfo);
            var result = frmEmployeesDelete.ShowDialog();
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

        #region MouseHoverEvents
        private void btnEmployeeLDView_MouseHover(object sender, EventArgs e)
        {
            btnEmployeeLDView.BackgroundImage = Properties.Resources.ViewSelected;
        }

        private void btnEmployeeLDView_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeLDView.BackgroundImage = Properties.Resources.ViewUnselected;
        }

        private void btnEmployeeLDAdd_MouseHover(object sender, EventArgs e)
        {
            btnEmployeeLDAdd.BackgroundImage = Properties.Resources.AddSelected;
        }

        private void btnEmployeeLDAdd_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeLDAdd.BackgroundImage = Properties.Resources.AddUnselected;
        }

        private void btnEmployeeLDEdit_MouseHover(object sender, EventArgs e)
        {
            btnEmployeeLDEdit.BackgroundImage = Properties.Resources.EditSelected;
        }

        private void btnEmployeeLDEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeLDEdit.BackgroundImage = Properties.Resources.EditUnselected;
        }

        private void btnEmployeeLDDelete_MouseHover(object sender, EventArgs e)
        {
            btnEmployeeLDDelete.BackgroundImage = Properties.Resources.DeleteSelected;
        }

        private void btnEmployeeLDDelete_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeLDDelete.BackgroundImage = Properties.Resources.DeleteUnselected;
        }

        #endregion

        private void btnEmployeeLDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click on the image above the label of the task you would like to proceed with for e.g." +
                "\n'View' -Click on the picture of the eye above the words View ");
        }
    }
}
