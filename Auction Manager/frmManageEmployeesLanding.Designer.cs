
namespace Auction_Manager
{
    partial class frmManageEmployeesLanding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbEmployeesLDPage = new System.Windows.Forms.PictureBox();
            this.lblEmployeesWelcome = new System.Windows.Forms.Label();
            this.lblEmployeeLDHint = new System.Windows.Forms.Label();
            this.btnEmployeeLDView = new System.Windows.Forms.Button();
            this.btnEmployeeLDAdd = new System.Windows.Forms.Button();
            this.btnEmployeeLDEdit = new System.Windows.Forms.Button();
            this.btnEmployeeLDDelete = new System.Windows.Forms.Button();
            this.lblEmployeeLDView = new System.Windows.Forms.Label();
            this.lblEmployeeLDAdd = new System.Windows.Forms.Label();
            this.lblEmployeeLDUpdate = new System.Windows.Forms.Label();
            this.lblEmployeeLDDelete = new System.Windows.Forms.Label();
            this.btnEmployeeLDHelp = new System.Windows.Forms.Button();
            this.btnEmployeeLDBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeesLDPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEmployeesLDPage
            // 
            this.pbEmployeesLDPage.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbEmployeesLDPage.Location = new System.Drawing.Point(0, 0);
            this.pbEmployeesLDPage.Name = "pbEmployeesLDPage";
            this.pbEmployeesLDPage.Size = new System.Drawing.Size(840, 470);
            this.pbEmployeesLDPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEmployeesLDPage.TabIndex = 52;
            this.pbEmployeesLDPage.TabStop = false;
            // 
            // lblEmployeesWelcome
            // 
            this.lblEmployeesWelcome.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeesWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesWelcome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblEmployeesWelcome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmployeesWelcome.Location = new System.Drawing.Point(254, 0);
            this.lblEmployeesWelcome.Name = "lblEmployeesWelcome";
            this.lblEmployeesWelcome.Size = new System.Drawing.Size(376, 53);
            this.lblEmployeesWelcome.TabIndex = 53;
            this.lblEmployeesWelcome.Text = "Manage Users";
            this.lblEmployeesWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeLDHint
            // 
            this.lblEmployeeLDHint.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeeLDHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLDHint.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblEmployeeLDHint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmployeeLDHint.Location = new System.Drawing.Point(44, 62);
            this.lblEmployeeLDHint.Name = "lblEmployeeLDHint";
            this.lblEmployeeLDHint.Size = new System.Drawing.Size(730, 34);
            this.lblEmployeeLDHint.TabIndex = 54;
            this.lblEmployeeLDHint.Text = "Please select one of the buttons below to proceed";
            this.lblEmployeeLDHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmployeeLDView
            // 
            this.btnEmployeeLDView.BackgroundImage = global::Auction_Manager.Properties.Resources.ViewUnselected;
            this.btnEmployeeLDView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeLDView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeLDView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLDView.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeLDView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployeeLDView.Location = new System.Drawing.Point(47, 133);
            this.btnEmployeeLDView.Name = "btnEmployeeLDView";
            this.btnEmployeeLDView.Size = new System.Drawing.Size(155, 155);
            this.btnEmployeeLDView.TabIndex = 55;
            this.btnEmployeeLDView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployeeLDView.UseVisualStyleBackColor = true;
            this.btnEmployeeLDView.Click += new System.EventHandler(this.BtnEmployeeLDView_Click);
            this.btnEmployeeLDView.MouseLeave += new System.EventHandler(this.btnEmployeeLDView_MouseLeave);
            this.btnEmployeeLDView.MouseHover += new System.EventHandler(this.btnEmployeeLDView_MouseHover);
            // 
            // btnEmployeeLDAdd
            // 
            this.btnEmployeeLDAdd.BackgroundImage = global::Auction_Manager.Properties.Resources.AddUnselected;
            this.btnEmployeeLDAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeLDAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeLDAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeLDAdd.Location = new System.Drawing.Point(238, 133);
            this.btnEmployeeLDAdd.Name = "btnEmployeeLDAdd";
            this.btnEmployeeLDAdd.Size = new System.Drawing.Size(155, 155);
            this.btnEmployeeLDAdd.TabIndex = 56;
            this.btnEmployeeLDAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployeeLDAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeLDAdd.Click += new System.EventHandler(this.BtnEmployeeLDAdd_Click);
            this.btnEmployeeLDAdd.MouseLeave += new System.EventHandler(this.btnEmployeeLDAdd_MouseLeave);
            this.btnEmployeeLDAdd.MouseHover += new System.EventHandler(this.btnEmployeeLDAdd_MouseHover);
            // 
            // btnEmployeeLDEdit
            // 
            this.btnEmployeeLDEdit.BackgroundImage = global::Auction_Manager.Properties.Resources.EditUnselected;
            this.btnEmployeeLDEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeLDEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeLDEdit.Location = new System.Drawing.Point(426, 133);
            this.btnEmployeeLDEdit.Name = "btnEmployeeLDEdit";
            this.btnEmployeeLDEdit.Size = new System.Drawing.Size(155, 155);
            this.btnEmployeeLDEdit.TabIndex = 57;
            this.btnEmployeeLDEdit.UseVisualStyleBackColor = true;
            this.btnEmployeeLDEdit.Click += new System.EventHandler(this.BtnEmployeeLDEdit_Click);
            this.btnEmployeeLDEdit.MouseLeave += new System.EventHandler(this.btnEmployeeLDEdit_MouseLeave);
            this.btnEmployeeLDEdit.MouseHover += new System.EventHandler(this.btnEmployeeLDEdit_MouseHover);
            // 
            // btnEmployeeLDDelete
            // 
            this.btnEmployeeLDDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.DeleteUnselected;
            this.btnEmployeeLDDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeLDDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeLDDelete.Location = new System.Drawing.Point(619, 133);
            this.btnEmployeeLDDelete.Name = "btnEmployeeLDDelete";
            this.btnEmployeeLDDelete.Size = new System.Drawing.Size(155, 155);
            this.btnEmployeeLDDelete.TabIndex = 58;
            this.btnEmployeeLDDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeLDDelete.Click += new System.EventHandler(this.BtnEmployeeLDDelete_Click);
            this.btnEmployeeLDDelete.MouseLeave += new System.EventHandler(this.btnEmployeeLDDelete_MouseLeave);
            this.btnEmployeeLDDelete.MouseHover += new System.EventHandler(this.btnEmployeeLDDelete_MouseHover);
            // 
            // lblEmployeeLDView
            // 
            this.lblEmployeeLDView.BackColor = System.Drawing.Color.DimGray;
            this.lblEmployeeLDView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLDView.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEmployeeLDView.Location = new System.Drawing.Point(47, 280);
            this.lblEmployeeLDView.Name = "lblEmployeeLDView";
            this.lblEmployeeLDView.Size = new System.Drawing.Size(155, 30);
            this.lblEmployeeLDView.TabIndex = 59;
            this.lblEmployeeLDView.Text = "View";
            this.lblEmployeeLDView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeLDAdd
            // 
            this.lblEmployeeLDAdd.BackColor = System.Drawing.Color.DimGray;
            this.lblEmployeeLDAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLDAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEmployeeLDAdd.Location = new System.Drawing.Point(238, 280);
            this.lblEmployeeLDAdd.Name = "lblEmployeeLDAdd";
            this.lblEmployeeLDAdd.Size = new System.Drawing.Size(155, 30);
            this.lblEmployeeLDAdd.TabIndex = 60;
            this.lblEmployeeLDAdd.Text = "Add";
            this.lblEmployeeLDAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeLDUpdate
            // 
            this.lblEmployeeLDUpdate.BackColor = System.Drawing.Color.DimGray;
            this.lblEmployeeLDUpdate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLDUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEmployeeLDUpdate.Location = new System.Drawing.Point(426, 280);
            this.lblEmployeeLDUpdate.Name = "lblEmployeeLDUpdate";
            this.lblEmployeeLDUpdate.Size = new System.Drawing.Size(155, 30);
            this.lblEmployeeLDUpdate.TabIndex = 61;
            this.lblEmployeeLDUpdate.Text = "Edit Users";
            this.lblEmployeeLDUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeLDDelete
            // 
            this.lblEmployeeLDDelete.BackColor = System.Drawing.Color.DimGray;
            this.lblEmployeeLDDelete.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLDDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEmployeeLDDelete.Location = new System.Drawing.Point(619, 280);
            this.lblEmployeeLDDelete.Name = "lblEmployeeLDDelete";
            this.lblEmployeeLDDelete.Size = new System.Drawing.Size(155, 30);
            this.lblEmployeeLDDelete.TabIndex = 62;
            this.lblEmployeeLDDelete.Text = "Delete";
            this.lblEmployeeLDDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmployeeLDHelp
            // 
            this.btnEmployeeLDHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeLDHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLDHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeLDHelp.Location = new System.Drawing.Point(12, 390);
            this.btnEmployeeLDHelp.Name = "btnEmployeeLDHelp";
            this.btnEmployeeLDHelp.Size = new System.Drawing.Size(90, 45);
            this.btnEmployeeLDHelp.TabIndex = 63;
            this.btnEmployeeLDHelp.Text = "Help";
            this.btnEmployeeLDHelp.UseVisualStyleBackColor = false;
            this.btnEmployeeLDHelp.Click += new System.EventHandler(this.btnEmployeeLDHelp_Click);
            // 
            // btnEmployeeLDBack
            // 
            this.btnEmployeeLDBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmployeeLDBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLDBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployeeLDBack.Location = new System.Drawing.Point(737, 390);
            this.btnEmployeeLDBack.Name = "btnEmployeeLDBack";
            this.btnEmployeeLDBack.Size = new System.Drawing.Size(90, 45);
            this.btnEmployeeLDBack.TabIndex = 64;
            this.btnEmployeeLDBack.Text = "BACK";
            this.btnEmployeeLDBack.UseVisualStyleBackColor = false;
            this.btnEmployeeLDBack.Click += new System.EventHandler(this.btnEmployeeLDBack_Click);
            // 
            // frmManageEmployeesLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 468);
            this.Controls.Add(this.btnEmployeeLDBack);
            this.Controls.Add(this.btnEmployeeLDHelp);
            this.Controls.Add(this.lblEmployeeLDDelete);
            this.Controls.Add(this.lblEmployeeLDUpdate);
            this.Controls.Add(this.lblEmployeeLDAdd);
            this.Controls.Add(this.lblEmployeeLDView);
            this.Controls.Add(this.btnEmployeeLDDelete);
            this.Controls.Add(this.btnEmployeeLDEdit);
            this.Controls.Add(this.btnEmployeeLDAdd);
            this.Controls.Add(this.btnEmployeeLDView);
            this.Controls.Add(this.lblEmployeeLDHint);
            this.Controls.Add(this.lblEmployeesWelcome);
            this.Controls.Add(this.pbEmployeesLDPage);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(855, 507);
            this.MinimumSize = new System.Drawing.Size(855, 507);
            this.Name = "frmManageEmployeesLanding";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.FrmManageEmployeesLanding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeesLDPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEmployeesLDPage;
        private System.Windows.Forms.Label lblEmployeesWelcome;
        private System.Windows.Forms.Label lblEmployeeLDHint;
        private System.Windows.Forms.Button btnEmployeeLDView;
        private System.Windows.Forms.Button btnEmployeeLDAdd;
        private System.Windows.Forms.Button btnEmployeeLDEdit;
        private System.Windows.Forms.Button btnEmployeeLDDelete;
        private System.Windows.Forms.Label lblEmployeeLDView;
        private System.Windows.Forms.Label lblEmployeeLDAdd;
        private System.Windows.Forms.Label lblEmployeeLDUpdate;
        private System.Windows.Forms.Label lblEmployeeLDDelete;
        private System.Windows.Forms.Button btnEmployeeLDHelp;
        private System.Windows.Forms.Button btnEmployeeLDBack;
    }
}