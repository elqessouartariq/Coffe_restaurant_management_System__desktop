namespace coffee_System
{
    partial class billProduct
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
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(3, 6);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(181, 21);
            this.lblproduct.TabIndex = 0;
            this.lblproduct.Text = "Cappoccino italiano";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQte.Location = new System.Drawing.Point(203, 6);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(16, 18);
            this.lblQte.TabIndex = 0;
            this.lblQte.Text = "2";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(308, 6);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(48, 18);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "30.00";
            // 
            // billProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblproduct);
            this.Name = "billProduct";
            this.Size = new System.Drawing.Size(380, 31);
            this.Load += new System.EventHandler(this.billProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblMontant;
    }
}
