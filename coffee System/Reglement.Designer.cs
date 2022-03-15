namespace coffee_System
{
    partial class Reglement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglement));
            this.TotalReglementbtn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ReglementDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Servercombobox = new System.Windows.Forms.ComboBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cancelreglementbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reglementdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.datecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montantcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serveurcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashiercl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedcl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalReglementbtn
            // 
            this.TotalReglementbtn.BorderColorFocused = System.Drawing.Color.Blue;
            this.TotalReglementbtn.BorderColorIdle = System.Drawing.Color.DarkBlue;
            this.TotalReglementbtn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TotalReglementbtn.BorderThickness = 3;
            this.TotalReglementbtn.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TotalReglementbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalReglementbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalReglementbtn.ForeColor = System.Drawing.Color.Blue;
            this.TotalReglementbtn.isPassword = false;
            this.TotalReglementbtn.Location = new System.Drawing.Point(810, 505);
            this.TotalReglementbtn.Margin = new System.Windows.Forms.Padding(4);
            this.TotalReglementbtn.MaxLength = 32767;
            this.TotalReglementbtn.Name = "TotalReglementbtn";
            this.TotalReglementbtn.Size = new System.Drawing.Size(232, 44);
            this.TotalReglementbtn.TabIndex = 37;
            this.TotalReglementbtn.Text = "Total :  0.00 DH           ";
            this.TotalReglementbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReglementDatagrid
            // 
            this.ReglementDatagrid.AllowCustomTheming = false;
            this.ReglementDatagrid.AllowUserToAddRows = false;
            this.ReglementDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ReglementDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReglementDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReglementDatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.ReglementDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReglementDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReglementDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReglementDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReglementDatagrid.ColumnHeadersHeight = 40;
            this.ReglementDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datecl,
            this.Montantcl,
            this.Serveurcl,
            this.Cashiercl,
            this.selectedcl});
            this.ReglementDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.ReglementDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReglementDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ReglementDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.ReglementDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ReglementDatagrid.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.ReglementDatagrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.ReglementDatagrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.ReglementDatagrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ReglementDatagrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReglementDatagrid.CurrentTheme.Name = null;
            this.ReglementDatagrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.ReglementDatagrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReglementDatagrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ReglementDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.ReglementDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReglementDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReglementDatagrid.EnableHeadersVisualStyles = false;
            this.ReglementDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.ReglementDatagrid.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.ReglementDatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.ReglementDatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.ReglementDatagrid.Location = new System.Drawing.Point(52, 122);
            this.ReglementDatagrid.Name = "ReglementDatagrid";
            this.ReglementDatagrid.ReadOnly = true;
            this.ReglementDatagrid.RowHeadersVisible = false;
            this.ReglementDatagrid.RowTemplate.Height = 40;
            this.ReglementDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReglementDatagrid.Size = new System.Drawing.Size(990, 376);
            this.ReglementDatagrid.TabIndex = 36;
            this.ReglementDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuLabel4.Location = new System.Drawing.Point(21, 86);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(127, 28);
            this.bunifuLabel4.TabIndex = 35;
            this.bunifuLabel4.Text = "List Reglement :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Servercombobox
            // 
            this.Servercombobox.FormattingEnabled = true;
            this.Servercombobox.Location = new System.Drawing.Point(588, 42);
            this.Servercombobox.Name = "Servercombobox";
            this.Servercombobox.Size = new System.Drawing.Size(157, 21);
            this.Servercombobox.TabIndex = 34;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(535, 41);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(46, 23);
            this.bunifuLabel3.TabIndex = 33;
            this.bunifuLabel3.Text = "Serveur";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(257, 41);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(30, 23);
            this.bunifuLabel2.TabIndex = 32;
            this.bunifuLabel2.Text = "Date";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cancelreglementbtn
            // 
            this.cancelreglementbtn.ActiveBorderThickness = 1;
            this.cancelreglementbtn.ActiveCornerRadius = 20;
            this.cancelreglementbtn.ActiveFillColor = System.Drawing.Color.Red;
            this.cancelreglementbtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelreglementbtn.ActiveLineColor = System.Drawing.Color.Red;
            this.cancelreglementbtn.BackColor = System.Drawing.SystemColors.Control;
            this.cancelreglementbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelreglementbtn.BackgroundImage")));
            this.cancelreglementbtn.ButtonText = "Annuler Reglement";
            this.cancelreglementbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelreglementbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelreglementbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelreglementbtn.IdleBorderThickness = 1;
            this.cancelreglementbtn.IdleCornerRadius = 20;
            this.cancelreglementbtn.IdleFillColor = System.Drawing.Color.White;
            this.cancelreglementbtn.IdleForecolor = System.Drawing.Color.Red;
            this.cancelreglementbtn.IdleLineColor = System.Drawing.Color.Red;
            this.cancelreglementbtn.Location = new System.Drawing.Point(871, 73);
            this.cancelreglementbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelreglementbtn.Name = "cancelreglementbtn";
            this.cancelreglementbtn.Size = new System.Drawing.Size(171, 41);
            this.cancelreglementbtn.TabIndex = 39;
            this.cancelreglementbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelreglementbtn.Click += new System.EventHandler(this.cancelreglementbtn_Click);
            // 
            // Reglementdate
            // 
            this.Reglementdate.BackColor = System.Drawing.Color.Transparent;
            this.Reglementdate.BorderRadius = 1;
            this.Reglementdate.Color = System.Drawing.SystemColors.ControlLight;
            this.Reglementdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.Reglementdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Reglementdate.DisabledColor = System.Drawing.Color.Gray;
            this.Reglementdate.DisplayWeekNumbers = false;
            this.Reglementdate.DPHeight = 0;
            this.Reglementdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Reglementdate.FillDatePicker = false;
            this.Reglementdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.Reglementdate.Icon = ((System.Drawing.Image)(resources.GetObject("Reglementdate.Icon")));
            this.Reglementdate.IconColor = System.Drawing.Color.DarkViolet;
            this.Reglementdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Reglementdate.Location = new System.Drawing.Point(302, 36);
            this.Reglementdate.MinimumSize = new System.Drawing.Size(217, 32);
            this.Reglementdate.Name = "Reglementdate";
            this.Reglementdate.Size = new System.Drawing.Size(217, 32);
            this.Reglementdate.TabIndex = 31;
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
            // Reglement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 561);
            this.Controls.Add(this.cancelreglementbtn);
            this.Controls.Add(this.TotalReglementbtn);
            this.Controls.Add(this.ReglementDatagrid);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.Servercombobox);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.Reglementdate);
            this.Name = "Reglement";
            this.Text = "Reglement";
            ((System.ComponentModel.ISupportInitialize)(this.ReglementDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelreglementbtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox TotalReglementbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView ReglementDatagrid;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.ComboBox Servercombobox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker Reglementdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montantcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serveurcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashiercl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedcl;
    }
}