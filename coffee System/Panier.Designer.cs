namespace coffee_System
{
    partial class Panier
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panier));
            this.lbldesc = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.picsupprimer = new System.Windows.Forms.PictureBox();
            this.prixunitaire = new System.Windows.Forms.Label();
            this.incremente = new System.Windows.Forms.PictureBox();
            this.decremante = new System.Windows.Forms.PictureBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picsupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incremente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decremante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(3, 15);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(153, 21);
            this.lbldesc.TabIndex = 0;
            this.lbldesc.Text = "Croissante chocolat";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(225, 12);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(64, 30);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "16 dh";
            // 
            // picsupprimer
            // 
            this.picsupprimer.Image = ((System.Drawing.Image)(resources.GetObject("picsupprimer.Image")));
            this.picsupprimer.Location = new System.Drawing.Point(306, 8);
            this.picsupprimer.Name = "picsupprimer";
            this.picsupprimer.Size = new System.Drawing.Size(33, 39);
            this.picsupprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsupprimer.TabIndex = 3;
            this.picsupprimer.TabStop = false;
            this.picsupprimer.Click += new System.EventHandler(this.picsupprimer_Click);
            // 
            // prixunitaire
            // 
            this.prixunitaire.AutoSize = true;
            this.prixunitaire.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixunitaire.Location = new System.Drawing.Point(35, 36);
            this.prixunitaire.Name = "prixunitaire";
            this.prixunitaire.Size = new System.Drawing.Size(80, 15);
            this.prixunitaire.TabIndex = 4;
            this.prixunitaire.Text = "4 dh / 1 unité";
            // 
            // incremente
            // 
            this.incremente.BackColor = System.Drawing.Color.Transparent;
            this.incremente.Image = ((System.Drawing.Image)(resources.GetObject("incremente.Image")));
            this.incremente.Location = new System.Drawing.Point(188, -5);
            this.incremente.Name = "incremente";
            this.incremente.Size = new System.Drawing.Size(15, 32);
            this.incremente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incremente.TabIndex = 5;
            this.incremente.TabStop = false;
            this.incremente.Click += new System.EventHandler(this.incremente_Click);
            // 
            // decremante
            // 
            this.decremante.BackColor = System.Drawing.Color.Transparent;
            this.decremante.Image = ((System.Drawing.Image)(resources.GetObject("decremante.Image")));
            this.decremante.Location = new System.Drawing.Point(188, 33);
            this.decremante.Name = "decremante";
            this.decremante.Size = new System.Drawing.Size(15, 32);
            this.decremante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decremante.TabIndex = 7;
            this.decremante.TabStop = false;
            this.decremante.Click += new System.EventHandler(this.decremante_Click);
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(180, 20);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(32, 20);
            this.txtqte.TabIndex = 8;
            this.txtqte.TextChanged += new System.EventHandler(this.txtqte_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Panier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtqte);
            this.Controls.Add(this.decremante);
            this.Controls.Add(this.incremente);
            this.Controls.Add(this.prixunitaire);
            this.Controls.Add(this.picsupprimer);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldesc);
            this.Name = "Panier";
            this.Size = new System.Drawing.Size(348, 60);
            ((System.ComponentModel.ISupportInitialize)(this.picsupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incremente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decremante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.PictureBox picsupprimer;
        private System.Windows.Forms.Label prixunitaire;
        private System.Windows.Forms.PictureBox incremente;
        private System.Windows.Forms.PictureBox decremante;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
