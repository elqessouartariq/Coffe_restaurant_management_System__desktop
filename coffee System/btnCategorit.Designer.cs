namespace coffee_System
{
    partial class btnCategorit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnCategorit));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btncoffee = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // btncoffee
            // 
            this.btncoffee.AllowToggling = false;
            this.btncoffee.AnimationSpeed = 200;
            this.btncoffee.AutoGenerateColors = false;
            this.btncoffee.BackColor = System.Drawing.Color.Transparent;
            this.btncoffee.BackColor1 = System.Drawing.Color.Transparent;
            this.btncoffee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoffee.BackgroundImage")));
            this.btncoffee.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btncoffee.ButtonText = "Coffee";
            this.btncoffee.ButtonTextMarginLeft = 0;
            this.btncoffee.ColorContrastOnClick = 45;
            this.btncoffee.ColorContrastOnHover = 45;
            this.btncoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btncoffee.CustomizableEdges = borderEdges1;
            this.btncoffee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncoffee.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btncoffee.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btncoffee.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btncoffee.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btncoffee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btncoffee.ForeColor = System.Drawing.Color.White;
            this.btncoffee.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btncoffee.IconMarginLeft = 11;
            this.btncoffee.IconPadding = 10;
            this.btncoffee.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btncoffee.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btncoffee.IdleBorderRadius = 3;
            this.btncoffee.IdleBorderThickness = 1;
            this.btncoffee.IdleFillColor = System.Drawing.Color.Transparent;
            this.btncoffee.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btncoffee.IdleIconLeftImage")));
            this.btncoffee.IdleIconRightImage = null;
            this.btncoffee.IndicateFocus = true;
            this.btncoffee.Location = new System.Drawing.Point(0, 0);
            this.btncoffee.Name = "btncoffee";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(170)))), ((int)(((byte)(46)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btncoffee.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(170)))), ((int)(((byte)(46)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btncoffee.OnPressedState = stateProperties2;
            this.btncoffee.Size = new System.Drawing.Size(154, 45);
            this.btncoffee.TabIndex = 41;
            this.btncoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncoffee.TextMarginLeft = 0;
            this.btncoffee.UseDefaultRadiusAndThickness = true;
            this.btncoffee.Click += new System.EventHandler(this.btncoffee_Click);
            // 
            // btnCategorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncoffee);
            this.Name = "btnCategorit";
            this.Size = new System.Drawing.Size(154, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btncoffee;
    }
}
