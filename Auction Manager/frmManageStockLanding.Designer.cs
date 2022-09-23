
namespace Auction_Manager
{
    partial class frmManageStockLanding
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
            this.btnStockLDHelp = new System.Windows.Forms.Button();
            this.btnStockLDBack = new System.Windows.Forms.Button();
            this.lblStockView = new System.Windows.Forms.Label();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.lblStockDelete = new System.Windows.Forms.Label();
            this.btnStockDelete = new System.Windows.Forms.Button();
            this.lblStockLDHint1 = new System.Windows.Forms.Label();
            this.btnStockEdit = new System.Windows.Forms.Button();
            this.btnStockAdd = new System.Windows.Forms.Button();
            this.btnStockView = new System.Windows.Forms.Button();
            this.lblStockWelcome = new System.Windows.Forms.Label();
            this.pbManageStockHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageStockHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStockLDHelp
            // 
            this.btnStockLDHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStockLDHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockLDHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockLDHelp.Location = new System.Drawing.Point(12, 385);
            this.btnStockLDHelp.Name = "btnStockLDHelp";
            this.btnStockLDHelp.Size = new System.Drawing.Size(90, 45);
            this.btnStockLDHelp.TabIndex = 33;
            this.btnStockLDHelp.Text = "Help";
            this.btnStockLDHelp.UseVisualStyleBackColor = false;
            this.btnStockLDHelp.Click += new System.EventHandler(this.btnStockLDHelp_Click);
            // 
            // btnStockLDBack
            // 
            this.btnStockLDBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStockLDBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockLDBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockLDBack.Location = new System.Drawing.Point(717, 385);
            this.btnStockLDBack.Name = "btnStockLDBack";
            this.btnStockLDBack.Size = new System.Drawing.Size(90, 45);
            this.btnStockLDBack.TabIndex = 32;
            this.btnStockLDBack.Text = "BACK";
            this.btnStockLDBack.UseVisualStyleBackColor = false;
            this.btnStockLDBack.Click += new System.EventHandler(this.btnStockLDBack_Click);
            // 
            // lblStockView
            // 
            this.lblStockView.BackColor = System.Drawing.Color.DimGray;
            this.lblStockView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockView.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblStockView.Location = new System.Drawing.Point(47, 300);
            this.lblStockView.Name = "lblStockView";
            this.lblStockView.Size = new System.Drawing.Size(155, 30);
            this.lblStockView.TabIndex = 26;
            this.lblStockView.Text = "View";
            this.lblStockView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.BackColor = System.Drawing.Color.DimGray;
            this.lblStockUpdate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblStockUpdate.Location = new System.Drawing.Point(431, 300);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(155, 30);
            this.lblStockUpdate.TabIndex = 28;
            this.lblStockUpdate.Text = "Edit Stock";
            this.lblStockUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.BackColor = System.Drawing.Color.DimGray;
            this.lblStockAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblStockAdd.Location = new System.Drawing.Point(238, 300);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(155, 30);
            this.lblStockAdd.TabIndex = 27;
            this.lblStockAdd.Text = "Add";
            this.lblStockAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockDelete
            // 
            this.lblStockDelete.BackColor = System.Drawing.Color.DimGray;
            this.lblStockDelete.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblStockDelete.Location = new System.Drawing.Point(626, 300);
            this.lblStockDelete.Name = "lblStockDelete";
            this.lblStockDelete.Size = new System.Drawing.Size(155, 30);
            this.lblStockDelete.TabIndex = 35;
            this.lblStockDelete.Text = "Delete";
            this.lblStockDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStockDelete
            // 
            this.btnStockDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.DeleteUnselected;
            this.btnStockDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStockDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockDelete.Location = new System.Drawing.Point(626, 147);
            this.btnStockDelete.Name = "btnStockDelete";
            this.btnStockDelete.Size = new System.Drawing.Size(155, 155);
            this.btnStockDelete.TabIndex = 34;
            this.btnStockDelete.UseVisualStyleBackColor = true;
            this.btnStockDelete.Click += new System.EventHandler(this.btnStockDelete_Click);
            this.btnStockDelete.MouseLeave += new System.EventHandler(this.btnStockDelete_MouseLeave);
            this.btnStockDelete.MouseHover += new System.EventHandler(this.btnStockDelete_MouseHover);
            // 
            // lblStockLDHint1
            // 
            this.lblStockLDHint1.BackColor = System.Drawing.Color.Gray;
            this.lblStockLDHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockLDHint1.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblStockLDHint1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblStockLDHint1.Location = new System.Drawing.Point(51, 55);
            this.lblStockLDHint1.Name = "lblStockLDHint1";
            this.lblStockLDHint1.Size = new System.Drawing.Size(730, 34);
            this.lblStockLDHint1.TabIndex = 31;
            this.lblStockLDHint1.Text = "Please select one of the buttons below to proceed";
            this.lblStockLDHint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStockEdit
            // 
            this.btnStockEdit.BackgroundImage = global::Auction_Manager.Properties.Resources.EditUnselected;
            this.btnStockEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStockEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockEdit.Location = new System.Drawing.Point(431, 147);
            this.btnStockEdit.Name = "btnStockEdit";
            this.btnStockEdit.Size = new System.Drawing.Size(155, 155);
            this.btnStockEdit.TabIndex = 25;
            this.btnStockEdit.UseVisualStyleBackColor = true;
            this.btnStockEdit.Click += new System.EventHandler(this.btnStockEdit_Click);
            this.btnStockEdit.MouseLeave += new System.EventHandler(this.btnStockEdit_MouseLeave);
            this.btnStockEdit.MouseHover += new System.EventHandler(this.btnStockEdit_MouseHover);
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.BackgroundImage = global::Auction_Manager.Properties.Resources.AddUnselected;
            this.btnStockAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStockAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockAdd.ForeColor = System.Drawing.Color.Black;
            this.btnStockAdd.Location = new System.Drawing.Point(238, 147);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Size = new System.Drawing.Size(155, 155);
            this.btnStockAdd.TabIndex = 24;
            this.btnStockAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStockAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd.Click += new System.EventHandler(this.btnStockAdd_Click);
            this.btnStockAdd.MouseLeave += new System.EventHandler(this.btnStockAdd_MouseLeave);
            this.btnStockAdd.MouseHover += new System.EventHandler(this.btnStockAdd_MouseHover);
            // 
            // btnStockView
            // 
            this.btnStockView.BackgroundImage = global::Auction_Manager.Properties.Resources.ViewUnselected;
            this.btnStockView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStockView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockView.ForeColor = System.Drawing.Color.Black;
            this.btnStockView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStockView.Location = new System.Drawing.Point(47, 147);
            this.btnStockView.Name = "btnStockView";
            this.btnStockView.Size = new System.Drawing.Size(155, 155);
            this.btnStockView.TabIndex = 23;
            this.btnStockView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStockView.UseVisualStyleBackColor = true;
            this.btnStockView.Click += new System.EventHandler(this.btnStockView_Click);
            this.btnStockView.MouseLeave += new System.EventHandler(this.btnStockView_MouseLeave);
            this.btnStockView.MouseHover += new System.EventHandler(this.btnStockView_MouseHover);
            // 
            // lblStockWelcome
            // 
            this.lblStockWelcome.BackColor = System.Drawing.Color.Gray;
            this.lblStockWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWelcome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblStockWelcome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblStockWelcome.Location = new System.Drawing.Point(282, -8);
            this.lblStockWelcome.Name = "lblStockWelcome";
            this.lblStockWelcome.Size = new System.Drawing.Size(288, 53);
            this.lblStockWelcome.TabIndex = 21;
            this.lblStockWelcome.Text = "Manage Stock";
            this.lblStockWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbManageStockHome
            // 
            this.pbManageStockHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbManageStockHome.Location = new System.Drawing.Point(-3, -8);
            this.pbManageStockHome.Name = "pbManageStockHome";
            this.pbManageStockHome.Size = new System.Drawing.Size(840, 470);
            this.pbManageStockHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbManageStockHome.TabIndex = 29;
            this.pbManageStockHome.TabStop = false;
            this.pbManageStockHome.Click += new System.EventHandler(this.pbManageStockHome_Click);
            // 
            // frmManageStockLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblStockDelete);
            this.Controls.Add(this.btnStockDelete);
            this.Controls.Add(this.btnStockLDHelp);
            this.Controls.Add(this.btnStockLDBack);
            this.Controls.Add(this.lblStockView);
            this.Controls.Add(this.lblStockLDHint1);
            this.Controls.Add(this.lblStockUpdate);
            this.Controls.Add(this.lblStockAdd);
            this.Controls.Add(this.btnStockEdit);
            this.Controls.Add(this.btnStockAdd);
            this.Controls.Add(this.btnStockView);
            this.Controls.Add(this.lblStockWelcome);
            this.Controls.Add(this.pbManageStockHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "frmManageStockLanding";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.FrmManageStockLanding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageStockHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockLDHelp;
        private System.Windows.Forms.Button btnStockLDBack;
        private System.Windows.Forms.Label lblStockView;
        private System.Windows.Forms.Label lblStockLDHint1;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblStockAdd;
        private System.Windows.Forms.Button btnStockEdit;
        private System.Windows.Forms.Button btnStockAdd;
        private System.Windows.Forms.Button btnStockView;
        private System.Windows.Forms.Label lblStockWelcome;
        private System.Windows.Forms.PictureBox pbManageStockHome;
        private System.Windows.Forms.Label lblStockDelete;
        private System.Windows.Forms.Button btnStockDelete;
    }
}