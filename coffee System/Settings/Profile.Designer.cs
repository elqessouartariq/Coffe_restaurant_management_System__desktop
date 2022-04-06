namespace coffee_System.Settings
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.AdminPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.AdminName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPicture
            // 
            this.AdminPicture.AllowFocused = false;
            this.AdminPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminPicture.BackColor = System.Drawing.Color.White;
            this.AdminPicture.BorderRadius = 50;
            this.AdminPicture.Image = ((System.Drawing.Image)(resources.GetObject("AdminPicture.Image")));
            this.AdminPicture.IsCircle = true;
            this.AdminPicture.Location = new System.Drawing.Point(42, 3);
            this.AdminPicture.Name = "AdminPicture";
            this.AdminPicture.Size = new System.Drawing.Size(100, 100);
            this.AdminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminPicture.TabIndex = 5;
            this.AdminPicture.TabStop = false;
            this.AdminPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // AdminName
            // 
            this.AdminName.AutoEllipsis = false;
            this.AdminName.CursorType = null;
            this.AdminName.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.AdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.AdminName.Location = new System.Drawing.Point(52, 108);
            this.AdminName.Name = "AdminName";
            this.AdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminName.Size = new System.Drawing.Size(124, 27);
            this.AdminName.TabIndex = 1;
            this.AdminName.Text = "El QESSOUAR ";
            this.AdminName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AdminName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Fira Code", 8.249999F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(24, 142);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(143, 19);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Admin de ESTA Coffee";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(17, 108);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(36, 27);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Mr.";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.AdminPicture);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.AdminName);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(185, 177);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox AdminPicture;
        private Bunifu.UI.WinForms.BunifuLabel AdminName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
