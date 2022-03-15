namespace coffee_System.Items
{
    partial class prd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prd));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.price = new System.Windows.Forms.Label();
            this.designationproduct = new System.Windows.Forms.Label();
            this.picproduct = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.price);
            this.bunifuGradientPanel1.Controls.Add(this.designationproduct);
            this.bunifuGradientPanel1.Controls.Add(this.picproduct);
            this.bunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(8, 8);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(185, 122);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(170)))), ((int)(((byte)(46)))));
            this.price.Location = new System.Drawing.Point(113, 95);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(69, 21);
            this.price.TabIndex = 2;
            this.price.Text = "5.99 DH";
            // 
            // designationproduct
            // 
            this.designationproduct.AutoSize = true;
            this.designationproduct.BackColor = System.Drawing.Color.Transparent;
            this.designationproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationproduct.Location = new System.Drawing.Point(3, 97);
            this.designationproduct.Name = "designationproduct";
            this.designationproduct.Size = new System.Drawing.Size(91, 17);
            this.designationproduct.TabIndex = 1;
            this.designationproduct.Text = "Croissant Fori";
            // 
            // picproduct
            // 
            this.picproduct.BackColor = System.Drawing.Color.Transparent;
            this.picproduct.Image = ((System.Drawing.Image)(resources.GetObject("picproduct.Image")));
            this.picproduct.Location = new System.Drawing.Point(3, 3);
            this.picproduct.Name = "picproduct";
            this.picproduct.Size = new System.Drawing.Size(179, 84);
            this.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picproduct.TabIndex = 0;
            this.picproduct.TabStop = false;
            // 
            // prd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "prd";
            this.Size = new System.Drawing.Size(200, 138);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label designationproduct;
        private System.Windows.Forms.PictureBox picproduct;
    }
}
