namespace coffee_System
{
    partial class Credit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Servercombobox = new System.Windows.Forms.ComboBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CreditDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.TotalCreditbtn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Afficherreglementbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reglerbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Creditdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.datecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montantcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serveurcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashiercl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedcl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(485, 52);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(46, 23);
            this.bunifuLabel3.TabIndex = 21;
            this.bunifuLabel3.Text = "Serveur";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(207, 52);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(30, 23);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Date";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Servercombobox
            // 
            this.Servercombobox.FormattingEnabled = true;
            this.Servercombobox.Location = new System.Drawing.Point(538, 53);
            this.Servercombobox.Name = "Servercombobox";
            this.Servercombobox.Size = new System.Drawing.Size(148, 21);
            this.Servercombobox.TabIndex = 22;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuLabel4.Location = new System.Drawing.Point(14, 99);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(102, 32);
            this.bunifuLabel4.TabIndex = 24;
            this.bunifuLabel4.Text = "Credit List :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CreditDatagrid
            // 
            this.CreditDatagrid.AllowCustomTheming = false;
            this.CreditDatagrid.AllowUserToAddRows = false;
            this.CreditDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CreditDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CreditDatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.CreditDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreditDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CreditDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CreditDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CreditDatagrid.ColumnHeadersHeight = 40;
            this.CreditDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datecl,
            this.Montantcl,
            this.Serveurcl,
            this.Cashiercl,
            this.selectedcl});
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.CreditDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.CreditDatagrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.CreditDatagrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.CreditDatagrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.CurrentTheme.Name = null;
            this.CreditDatagrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.CreditDatagrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CreditDatagrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CreditDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.CreditDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CreditDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreditDatagrid.EnableHeadersVisualStyles = false;
            this.CreditDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.CreditDatagrid.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.CreditDatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.CreditDatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.CreditDatagrid.Location = new System.Drawing.Point(45, 134);
            this.CreditDatagrid.Name = "CreditDatagrid";
            this.CreditDatagrid.ReadOnly = true;
            this.CreditDatagrid.RowHeadersVisible = false;
            this.CreditDatagrid.RowTemplate.Height = 40;
            this.CreditDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CreditDatagrid.Size = new System.Drawing.Size(990, 367);
            this.CreditDatagrid.TabIndex = 25;
            this.CreditDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            // 
            // TotalCreditbtn
            // 
            this.TotalCreditbtn.BorderColorFocused = System.Drawing.Color.Blue;
            this.TotalCreditbtn.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.TotalCreditbtn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TotalCreditbtn.BorderThickness = 3;
            this.TotalCreditbtn.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TotalCreditbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalCreditbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalCreditbtn.ForeColor = System.Drawing.Color.Blue;
            this.TotalCreditbtn.isPassword = false;
            this.TotalCreditbtn.Location = new System.Drawing.Point(801, 512);
            this.TotalCreditbtn.Margin = new System.Windows.Forms.Padding(4);
            this.TotalCreditbtn.MaxLength = 32767;
            this.TotalCreditbtn.Name = "TotalCreditbtn";
            this.TotalCreditbtn.Size = new System.Drawing.Size(232, 44);
            this.TotalCreditbtn.TabIndex = 26;
            this.TotalCreditbtn.Text = "Total :  0.00 DH           ";
            this.TotalCreditbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Afficherreglementbtn
            // 
            this.Afficherreglementbtn.ActiveBorderThickness = 1;
            this.Afficherreglementbtn.ActiveCornerRadius = 20;
            this.Afficherreglementbtn.ActiveFillColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Afficherreglementbtn.ActiveLineColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Afficherreglementbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Afficherreglementbtn.BackgroundImage")));
            this.Afficherreglementbtn.ButtonText = "Afficher  Reglement";
            this.Afficherreglementbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Afficherreglementbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficherreglementbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Afficherreglementbtn.IdleBorderThickness = 1;
            this.Afficherreglementbtn.IdleCornerRadius = 20;
            this.Afficherreglementbtn.IdleFillColor = System.Drawing.Color.White;
            this.Afficherreglementbtn.IdleForecolor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.IdleLineColor = System.Drawing.Color.Violet;
            this.Afficherreglementbtn.Location = new System.Drawing.Point(720, 85);
            this.Afficherreglementbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Afficherreglementbtn.Name = "Afficherreglementbtn";
            this.Afficherreglementbtn.Size = new System.Drawing.Size(171, 41);
            this.Afficherreglementbtn.TabIndex = 30;
            this.Afficherreglementbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reglerbtn
            // 
            this.Reglerbtn.ActiveBorderThickness = 1;
            this.Reglerbtn.ActiveCornerRadius = 20;
            this.Reglerbtn.ActiveFillColor = System.Drawing.Color.Violet;
            this.Reglerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Reglerbtn.ActiveLineColor = System.Drawing.Color.Violet;
            this.Reglerbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Reglerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reglerbtn.BackgroundImage")));
            this.Reglerbtn.ButtonText = "Regler";
            this.Reglerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reglerbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reglerbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Reglerbtn.IdleBorderThickness = 1;
            this.Reglerbtn.IdleCornerRadius = 20;
            this.Reglerbtn.IdleFillColor = System.Drawing.Color.White;
            this.Reglerbtn.IdleForecolor = System.Drawing.Color.Violet;
            this.Reglerbtn.IdleLineColor = System.Drawing.Color.Violet;
            this.Reglerbtn.Location = new System.Drawing.Point(901, 85);
            this.Reglerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Reglerbtn.Name = "Reglerbtn";
            this.Reglerbtn.Size = new System.Drawing.Size(121, 41);
            this.Reglerbtn.TabIndex = 29;
            this.Reglerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reglerbtn.Click += new System.EventHandler(this.Reglerbtn_Click);
            // 
            // Creditdate
            // 
            this.Creditdate.BackColor = System.Drawing.Color.Transparent;
            this.Creditdate.BorderRadius = 1;
            this.Creditdate.Color = System.Drawing.SystemColors.ControlLight;
            this.Creditdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.Creditdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Creditdate.DisabledColor = System.Drawing.Color.Gray;
            this.Creditdate.DisplayWeekNumbers = false;
            this.Creditdate.DPHeight = 0;
            this.Creditdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Creditdate.FillDatePicker = false;
            this.Creditdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.Creditdate.Icon = ((System.Drawing.Image)(resources.GetObject("Creditdate.Icon")));
            this.Creditdate.IconColor = System.Drawing.Color.DarkViolet;
            this.Creditdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Creditdate.Location = new System.Drawing.Point(252, 47);
            this.Creditdate.MinimumSize = new System.Drawing.Size(217, 32);
            this.Creditdate.Name = "Creditdate";
            this.Creditdate.Size = new System.Drawing.Size(217, 32);
            this.Creditdate.TabIndex = 18;
            // 
            // datecl
            // 
            this.datecl.HeaderText = "Date";
            this.datecl.Name = "datecl";
            this.datecl.ReadOnly = true;
            // 
            // Montantcl
            // 
            this.Montantcl.HeaderText = "Montant";
            this.Montantcl.Name = "Montantcl";
            this.Montantcl.ReadOnly = true;
            // 
            // Serveurcl
            // 
            this.Serveurcl.HeaderText = "Serveur";
            this.Serveurcl.Name = "Serveurcl";
            this.Serveurcl.ReadOnly = true;
            // 
            // Cashiercl
            // 
            this.Cashiercl.HeaderText = "Cashier";
            this.Cashiercl.Name = "Cashiercl";
            this.Cashiercl.ReadOnly = true;
            // 
            // selectedcl
            // 
            this.selectedcl.HeaderText = "Selectionner";
            this.selectedcl.Name = "selectedcl";
            this.selectedcl.ReadOnly = true;
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 561);
            this.Controls.Add(this.Afficherreglementbtn);
            this.Controls.Add(this.Reglerbtn);
            this.Controls.Add(this.TotalCreditbtn);
            this.Controls.Add(this.CreditDatagrid);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.Servercombobox);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.Creditdate);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Credit";
            this.Text = "Credit";
            ((System.ComponentModel.ISupportInitialize)(this.CreditDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker Creditdate;
        private System.Windows.Forms.ComboBox Servercombobox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDataGridView CreditDatagrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox TotalCreditbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Reglerbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Afficherreglementbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montantcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serveurcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashiercl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedcl;
    }
}