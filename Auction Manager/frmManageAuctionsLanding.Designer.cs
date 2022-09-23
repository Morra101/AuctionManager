
namespace Auction_Manager
{
    partial class frmManageAuctionsLanding
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
            this.lblAuctionWelcome = new System.Windows.Forms.Label();
            this.pbManageBuyHome = new System.Windows.Forms.PictureBox();
            this.lblHint1_Auction = new System.Windows.Forms.Label();
            this.btnAuctionView = new System.Windows.Forms.Button();
            this.btnAuctionAdd = new System.Windows.Forms.Button();
            this.btnAuctionEdit = new System.Windows.Forms.Button();
            this.btnAuctionDelete = new System.Windows.Forms.Button();
            this.lblAuctionView = new System.Windows.Forms.Label();
            this.lblAuctionAdd = new System.Windows.Forms.Label();
            this.lblAuctionUpdate = new System.Windows.Forms.Label();
            this.lblAuctionDelete = new System.Windows.Forms.Label();
            this.btnAuctionHelp = new System.Windows.Forms.Button();
            this.btnAuctionBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuctionBids = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageBuyHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuctionWelcome
            // 
            this.lblAuctionWelcome.BackColor = System.Drawing.Color.Gray;
            this.lblAuctionWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionWelcome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblAuctionWelcome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAuctionWelcome.Location = new System.Drawing.Point(236, 0);
            this.lblAuctionWelcome.Name = "lblAuctionWelcome";
            this.lblAuctionWelcome.Size = new System.Drawing.Size(319, 53);
            this.lblAuctionWelcome.TabIndex = 53;
            this.lblAuctionWelcome.Text = "Manage Auction";
            this.lblAuctionWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbManageBuyHome
            // 
            this.pbManageBuyHome.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.pbManageBuyHome.Location = new System.Drawing.Point(-20, -10);
            this.pbManageBuyHome.Name = "pbManageBuyHome";
            this.pbManageBuyHome.Size = new System.Drawing.Size(840, 597);
            this.pbManageBuyHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbManageBuyHome.TabIndex = 52;
            this.pbManageBuyHome.TabStop = false;
            // 
            // lblHint1_Auction
            // 
            this.lblHint1_Auction.BackColor = System.Drawing.Color.Gray;
            this.lblHint1_Auction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint1_Auction.Image = global::Auction_Manager.Properties.Resources.Background3;
            this.lblHint1_Auction.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHint1_Auction.Location = new System.Drawing.Point(31, 53);
            this.lblHint1_Auction.Name = "lblHint1_Auction";
            this.lblHint1_Auction.Size = new System.Drawing.Size(730, 34);
            this.lblHint1_Auction.TabIndex = 54;
            this.lblHint1_Auction.Text = "Please select one of the buttons below to proceed";
            this.lblHint1_Auction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuctionView
            // 
            this.btnAuctionView.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuctionView.BackgroundImage = global::Auction_Manager.Properties.Resources.ViewUnselected;
            this.btnAuctionView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuctionView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuctionView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionView.ForeColor = System.Drawing.Color.Black;
            this.btnAuctionView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuctionView.Location = new System.Drawing.Point(34, 90);
            this.btnAuctionView.Name = "btnAuctionView";
            this.btnAuctionView.Size = new System.Drawing.Size(131, 130);
            this.btnAuctionView.TabIndex = 55;
            this.btnAuctionView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAuctionView.UseVisualStyleBackColor = false;
            this.btnAuctionView.Click += new System.EventHandler(this.BtnAuctionView_Click);
            this.btnAuctionView.MouseLeave += new System.EventHandler(this.BtnAuctionView_MouseLeave);
            this.btnAuctionView.MouseHover += new System.EventHandler(this.BtnAuctionView_MouseHover);
            // 
            // btnAuctionAdd
            // 
            this.btnAuctionAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuctionAdd.BackgroundImage = global::Auction_Manager.Properties.Resources.AddUnselected;
            this.btnAuctionAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuctionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuctionAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAuctionAdd.Location = new System.Drawing.Point(181, 90);
            this.btnAuctionAdd.Name = "btnAuctionAdd";
            this.btnAuctionAdd.Size = new System.Drawing.Size(131, 130);
            this.btnAuctionAdd.TabIndex = 56;
            this.btnAuctionAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuctionAdd.UseVisualStyleBackColor = false;
            this.btnAuctionAdd.Click += new System.EventHandler(this.BtnAuctionAdd_Click);
            this.btnAuctionAdd.Leave += new System.EventHandler(this.BtnAuctionAdd_Leave);
            this.btnAuctionAdd.MouseHover += new System.EventHandler(this.BtnAuctionAdd_MouseHover);
            // 
            // btnAuctionEdit
            // 
            this.btnAuctionEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuctionEdit.BackgroundImage = global::Auction_Manager.Properties.Resources.EditUnselected;
            this.btnAuctionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuctionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuctionEdit.Location = new System.Drawing.Point(328, 90);
            this.btnAuctionEdit.Name = "btnAuctionEdit";
            this.btnAuctionEdit.Size = new System.Drawing.Size(131, 130);
            this.btnAuctionEdit.TabIndex = 57;
            this.btnAuctionEdit.UseVisualStyleBackColor = false;
            this.btnAuctionEdit.Click += new System.EventHandler(this.BtnAuctionEdit_Click);
            this.btnAuctionEdit.MouseLeave += new System.EventHandler(this.BtnAuctionEdit_MouseLeave);
            this.btnAuctionEdit.MouseHover += new System.EventHandler(this.BtnAuctionEdit_MouseHover);
            // 
            // btnAuctionDelete
            // 
            this.btnAuctionDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuctionDelete.BackgroundImage = global::Auction_Manager.Properties.Resources.DeleteUnselected;
            this.btnAuctionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuctionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuctionDelete.Location = new System.Drawing.Point(480, 90);
            this.btnAuctionDelete.Name = "btnAuctionDelete";
            this.btnAuctionDelete.Size = new System.Drawing.Size(131, 130);
            this.btnAuctionDelete.TabIndex = 58;
            this.btnAuctionDelete.UseVisualStyleBackColor = false;
            this.btnAuctionDelete.Click += new System.EventHandler(this.BtnAuctionDelete_Click);
            this.btnAuctionDelete.MouseLeave += new System.EventHandler(this.BtnAuctionDelete_MouseLeave);
            this.btnAuctionDelete.MouseHover += new System.EventHandler(this.BtnAuctionDelete_MouseHover);
            // 
            // lblAuctionView
            // 
            this.lblAuctionView.BackColor = System.Drawing.Color.DimGray;
            this.lblAuctionView.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionView.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAuctionView.Location = new System.Drawing.Point(34, 214);
            this.lblAuctionView.Name = "lblAuctionView";
            this.lblAuctionView.Size = new System.Drawing.Size(131, 30);
            this.lblAuctionView.TabIndex = 59;
            this.lblAuctionView.Text = "View";
            this.lblAuctionView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuctionAdd
            // 
            this.lblAuctionAdd.BackColor = System.Drawing.Color.DimGray;
            this.lblAuctionAdd.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAuctionAdd.Location = new System.Drawing.Point(181, 214);
            this.lblAuctionAdd.Name = "lblAuctionAdd";
            this.lblAuctionAdd.Size = new System.Drawing.Size(131, 29);
            this.lblAuctionAdd.TabIndex = 60;
            this.lblAuctionAdd.Text = "Add";
            this.lblAuctionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuctionUpdate
            // 
            this.lblAuctionUpdate.BackColor = System.Drawing.Color.DimGray;
            this.lblAuctionUpdate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAuctionUpdate.Location = new System.Drawing.Point(328, 214);
            this.lblAuctionUpdate.Name = "lblAuctionUpdate";
            this.lblAuctionUpdate.Size = new System.Drawing.Size(131, 30);
            this.lblAuctionUpdate.TabIndex = 61;
            this.lblAuctionUpdate.Text = "Edit Auctions";
            this.lblAuctionUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuctionDelete
            // 
            this.lblAuctionDelete.BackColor = System.Drawing.Color.DimGray;
            this.lblAuctionDelete.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuctionDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAuctionDelete.Location = new System.Drawing.Point(480, 214);
            this.lblAuctionDelete.Name = "lblAuctionDelete";
            this.lblAuctionDelete.Size = new System.Drawing.Size(131, 30);
            this.lblAuctionDelete.TabIndex = 62;
            this.lblAuctionDelete.Text = "Delete";
            this.lblAuctionDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuctionHelp
            // 
            this.btnAuctionHelp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionHelp.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionHelp.Location = new System.Drawing.Point(34, 293);
            this.btnAuctionHelp.Name = "btnAuctionHelp";
            this.btnAuctionHelp.Size = new System.Drawing.Size(90, 45);
            this.btnAuctionHelp.TabIndex = 63;
            this.btnAuctionHelp.Text = "Help";
            this.btnAuctionHelp.UseVisualStyleBackColor = false;
            this.btnAuctionHelp.Click += new System.EventHandler(this.BtnAuctionHelp_Click);
            // 
            // btnAuctionBack
            // 
            this.btnAuctionBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAuctionBack.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuctionBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuctionBack.Location = new System.Drawing.Point(621, 293);
            this.btnAuctionBack.Name = "btnAuctionBack";
            this.btnAuctionBack.Size = new System.Drawing.Size(90, 45);
            this.btnAuctionBack.TabIndex = 64;
            this.btnAuctionBack.Text = "BACK";
            this.btnAuctionBack.UseVisualStyleBackColor = false;
            this.btnAuctionBack.Click += new System.EventHandler(this.btnAuctionBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(631, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Recieve Bids";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuctionBids
            // 
            this.btnAuctionBids.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuctionBids.BackgroundImage = global::Auction_Manager.Properties.Resources.AddUnselected;
            this.btnAuctionBids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuctionBids.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuctionBids.ForeColor = System.Drawing.Color.Black;
            this.btnAuctionBids.Location = new System.Drawing.Point(631, 90);
            this.btnAuctionBids.Name = "btnAuctionBids";
            this.btnAuctionBids.Size = new System.Drawing.Size(131, 130);
            this.btnAuctionBids.TabIndex = 65;
            this.btnAuctionBids.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuctionBids.UseVisualStyleBackColor = false;
            this.btnAuctionBids.Click += new System.EventHandler(this.BtnAuctionBids_Click);
            this.btnAuctionBids.MouseLeave += new System.EventHandler(this.BtnAuctionBids_MouseLeave);
            this.btnAuctionBids.MouseHover += new System.EventHandler(this.BtnAuctionBids_MouseHover);
            // 
            // frmManageAuctionsLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAuctionBids);
            this.Controls.Add(this.btnAuctionBack);
            this.Controls.Add(this.btnAuctionHelp);
            this.Controls.Add(this.lblAuctionDelete);
            this.Controls.Add(this.lblAuctionUpdate);
            this.Controls.Add(this.lblAuctionAdd);
            this.Controls.Add(this.lblAuctionView);
            this.Controls.Add(this.btnAuctionDelete);
            this.Controls.Add(this.btnAuctionEdit);
            this.Controls.Add(this.btnAuctionAdd);
            this.Controls.Add(this.btnAuctionView);
            this.Controls.Add(this.lblHint1_Auction);
            this.Controls.Add(this.lblAuctionWelcome);
            this.Controls.Add(this.pbManageBuyHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 399);
            this.MinimumSize = new System.Drawing.Size(816, 399);
            this.Name = "frmManageAuctionsLanding";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Auctions";
            ((System.ComponentModel.ISupportInitialize)(this.pbManageBuyHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManageBuyHome;
        private System.Windows.Forms.Label lblAuctionWelcome;
        private System.Windows.Forms.Label lblHint1_Auction;
        private System.Windows.Forms.Button btnAuctionView;
        private System.Windows.Forms.Button btnAuctionAdd;
        private System.Windows.Forms.Button btnAuctionEdit;
        private System.Windows.Forms.Button btnAuctionDelete;
        private System.Windows.Forms.Label lblAuctionView;
        private System.Windows.Forms.Label lblAuctionAdd;
        private System.Windows.Forms.Label lblAuctionUpdate;
        private System.Windows.Forms.Label lblAuctionDelete;
        private System.Windows.Forms.Button btnAuctionHelp;
        private System.Windows.Forms.Button btnAuctionBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuctionBids;
    }
}