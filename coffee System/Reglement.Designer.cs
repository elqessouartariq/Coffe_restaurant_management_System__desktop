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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglement));
            this.ReglementDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iDregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUSERWORKSERVERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUSERWORKADMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSERWORKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUSERWORKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reglementMoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTD_CoffeeManagement = new coffee_System.DBTD_CoffeeManagement();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Servercombobox = new System.Windows.Forms.ComboBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cancelreglementbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Reglementdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.CancelReglementFilterbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReglementFilterbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reglement_MoreTableAdapter = new coffee_System.DBTD_CoffeeManagementTableAdapters.Reglement_MoreTableAdapter();
            this.Datecheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Servercheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reglementMoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTD_CoffeeManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // ReglementDatagrid
            // 
            this.ReglementDatagrid.AllowCustomTheming = false;
            this.ReglementDatagrid.AllowUserToAddRows = false;
            this.ReglementDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ReglementDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReglementDatagrid.AutoGenerateColumns = false;
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
            this.iDregDataGridViewTextBoxColumn,
            this.idUSERWORKSERVERDataGridViewTextBoxColumn,
            this.idUSERWORKADMINDataGridViewTextBoxColumn,
            this.iDUSERWORKDataGridViewTextBoxColumn,
            this.dateregDataGridViewTextBoxColumn,
            this.montantregDataGridViewTextBoxColumn,
            this.nomUSERWORKDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn});
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
            this.ReglementDatagrid.DataSource = this.reglementMoreBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReglementDatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReglementDatagrid.EnableHeadersVisualStyles = false;
            this.ReglementDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.ReglementDatagrid.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.ReglementDatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.ReglementDatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.ReglementDatagrid.Location = new System.Drawing.Point(32, 136);
            this.ReglementDatagrid.Name = "ReglementDatagrid";
            this.ReglementDatagrid.ReadOnly = true;
            this.ReglementDatagrid.RowHeadersVisible = false;
            this.ReglementDatagrid.RowTemplate.Height = 40;
            this.ReglementDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReglementDatagrid.Size = new System.Drawing.Size(1267, 512);
            this.ReglementDatagrid.TabIndex = 36;
            this.ReglementDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            this.ReglementDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReglementDatagrid_CellClick);
            // 
            // iDregDataGridViewTextBoxColumn
            // 
            this.iDregDataGridViewTextBoxColumn.DataPropertyName = "ID_reg";
            this.iDregDataGridViewTextBoxColumn.HeaderText = "ID_reg";
            this.iDregDataGridViewTextBoxColumn.Name = "iDregDataGridViewTextBoxColumn";
            this.iDregDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDregDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUSERWORKSERVERDataGridViewTextBoxColumn
            // 
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.DataPropertyName = "id_USER_WORK_SERVER";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.HeaderText = "id_USER_WORK_SERVER";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.Name = "idUSERWORKSERVERDataGridViewTextBoxColumn";
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUSERWORKSERVERDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUSERWORKADMINDataGridViewTextBoxColumn
            // 
            this.idUSERWORKADMINDataGridViewTextBoxColumn.DataPropertyName = "id_USER_WORK_ADMIN";
            this.idUSERWORKADMINDataGridViewTextBoxColumn.HeaderText = "id_USER_WORK_ADMIN";
            this.idUSERWORKADMINDataGridViewTextBoxColumn.Name = "idUSERWORKADMINDataGridViewTextBoxColumn";
            this.idUSERWORKADMINDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUSERWORKADMINDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDUSERWORKDataGridViewTextBoxColumn
            // 
            this.iDUSERWORKDataGridViewTextBoxColumn.DataPropertyName = "ID_USER_WORK";
            this.iDUSERWORKDataGridViewTextBoxColumn.HeaderText = "ID_USER_WORK";
            this.iDUSERWORKDataGridViewTextBoxColumn.Name = "iDUSERWORKDataGridViewTextBoxColumn";
            this.iDUSERWORKDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUSERWORKDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateregDataGridViewTextBoxColumn
            // 
            this.dateregDataGridViewTextBoxColumn.DataPropertyName = "Date_reg";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateregDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateregDataGridViewTextBoxColumn.HeaderText = "Date Reglement";
            this.dateregDataGridViewTextBoxColumn.Name = "dateregDataGridViewTextBoxColumn";
            this.dateregDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantregDataGridViewTextBoxColumn
            // 
            this.montantregDataGridViewTextBoxColumn.DataPropertyName = "Montant_reg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.montantregDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.montantregDataGridViewTextBoxColumn.HeaderText = "Montant Reglement";
            this.montantregDataGridViewTextBoxColumn.Name = "montantregDataGridViewTextBoxColumn";
            this.montantregDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomUSERWORKDataGridViewTextBoxColumn
            // 
            this.nomUSERWORKDataGridViewTextBoxColumn.DataPropertyName = "Nom_USER_WORK";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomUSERWORKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.nomUSERWORKDataGridViewTextBoxColumn.HeaderText = "Server Name";
            this.nomUSERWORKDataGridViewTextBoxColumn.Name = "nomUSERWORKDataGridViewTextBoxColumn";
            this.nomUSERWORKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "Statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            this.statutDataGridViewTextBoxColumn.ReadOnly = true;
            this.statutDataGridViewTextBoxColumn.Visible = false;
            // 
            // reglementMoreBindingSource
            // 
            this.reglementMoreBindingSource.DataMember = "Reglement_More";
            this.reglementMoreBindingSource.DataSource = this.dBTD_CoffeeManagement;
            // 
            // dBTD_CoffeeManagement
            // 
            this.dBTD_CoffeeManagement.DataSetName = "DBTD_CoffeeManagement";
            this.dBTD_CoffeeManagement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Servercombobox.Location = new System.Drawing.Point(848, 57);
            this.Servercombobox.Name = "Servercombobox";
            this.Servercombobox.Size = new System.Drawing.Size(157, 21);
            this.Servercombobox.TabIndex = 34;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(795, 56);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(476, 56);
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
            this.cancelreglementbtn.Location = new System.Drawing.Point(1127, 87);
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
            this.Reglementdate.Location = new System.Drawing.Point(521, 51);
            this.Reglementdate.MinimumSize = new System.Drawing.Size(217, 32);
            this.Reglementdate.Name = "Reglementdate";
            this.Reglementdate.Size = new System.Drawing.Size(217, 32);
            this.Reglementdate.TabIndex = 31;
            // 
            // CancelReglementFilterbtn
            // 
            this.CancelReglementFilterbtn.Active = false;
            this.CancelReglementFilterbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.CancelReglementFilterbtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelReglementFilterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelReglementFilterbtn.BorderRadius = 0;
            this.CancelReglementFilterbtn.ButtonText = "Annuler";
            this.CancelReglementFilterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelReglementFilterbtn.DisabledColor = System.Drawing.Color.Gray;
            this.CancelReglementFilterbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CancelReglementFilterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.CancelReglementFilterbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CancelReglementFilterbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_cancel_32;
            this.CancelReglementFilterbtn.Iconimage_right = null;
            this.CancelReglementFilterbtn.Iconimage_right_Selected = null;
            this.CancelReglementFilterbtn.Iconimage_Selected = null;
            this.CancelReglementFilterbtn.IconMarginLeft = 0;
            this.CancelReglementFilterbtn.IconMarginRight = 0;
            this.CancelReglementFilterbtn.IconRightVisible = true;
            this.CancelReglementFilterbtn.IconRightZoom = 0D;
            this.CancelReglementFilterbtn.IconVisible = true;
            this.CancelReglementFilterbtn.IconZoom = 40D;
            this.CancelReglementFilterbtn.IsTab = false;
            this.CancelReglementFilterbtn.Location = new System.Drawing.Point(1186, 51);
            this.CancelReglementFilterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelReglementFilterbtn.Name = "CancelReglementFilterbtn";
            this.CancelReglementFilterbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.CancelReglementFilterbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CancelReglementFilterbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.CancelReglementFilterbtn.selected = false;
            this.CancelReglementFilterbtn.Size = new System.Drawing.Size(111, 27);
            this.CancelReglementFilterbtn.TabIndex = 43;
            this.CancelReglementFilterbtn.Text = "Annuler";
            this.CancelReglementFilterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelReglementFilterbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.CancelReglementFilterbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.CancelReglementFilterbtn.Click += new System.EventHandler(this.CancelReglementFilterbtn_Click);
            // 
            // ReglementFilterbtn
            // 
            this.ReglementFilterbtn.Active = false;
            this.ReglementFilterbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.ReglementFilterbtn.BackColor = System.Drawing.Color.Transparent;
            this.ReglementFilterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReglementFilterbtn.BorderRadius = 0;
            this.ReglementFilterbtn.ButtonText = "filtrer";
            this.ReglementFilterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReglementFilterbtn.DisabledColor = System.Drawing.Color.Gray;
            this.ReglementFilterbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ReglementFilterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.ReglementFilterbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ReglementFilterbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_filter_24;
            this.ReglementFilterbtn.Iconimage_right = null;
            this.ReglementFilterbtn.Iconimage_right_Selected = null;
            this.ReglementFilterbtn.Iconimage_Selected = null;
            this.ReglementFilterbtn.IconMarginLeft = 0;
            this.ReglementFilterbtn.IconMarginRight = 0;
            this.ReglementFilterbtn.IconRightVisible = true;
            this.ReglementFilterbtn.IconRightZoom = 0D;
            this.ReglementFilterbtn.IconVisible = true;
            this.ReglementFilterbtn.IconZoom = 40D;
            this.ReglementFilterbtn.IsTab = false;
            this.ReglementFilterbtn.Location = new System.Drawing.Point(1067, 51);
            this.ReglementFilterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReglementFilterbtn.Name = "ReglementFilterbtn";
            this.ReglementFilterbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ReglementFilterbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ReglementFilterbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.ReglementFilterbtn.selected = false;
            this.ReglementFilterbtn.Size = new System.Drawing.Size(111, 27);
            this.ReglementFilterbtn.TabIndex = 44;
            this.ReglementFilterbtn.Text = "filtrer";
            this.ReglementFilterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReglementFilterbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.ReglementFilterbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.ReglementFilterbtn.Click += new System.EventHandler(this.ReglementFilterbtn_Click);
            // 
            // reglement_MoreTableAdapter
            // 
            this.reglement_MoreTableAdapter.ClearBeforeFill = true;
            // 
            // Datecheckbox
            // 
            this.Datecheckbox.AllowBindingControlAnimation = true;
            this.Datecheckbox.AllowBindingControlColorChanges = false;
            this.Datecheckbox.AllowBindingControlLocation = true;
            this.Datecheckbox.AllowCheckBoxAnimation = false;
            this.Datecheckbox.AllowCheckmarkAnimation = true;
            this.Datecheckbox.AllowOnHoverStates = true;
            this.Datecheckbox.AutoCheck = true;
            this.Datecheckbox.BackColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Datecheckbox.BackgroundImage")));
            this.Datecheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Datecheckbox.BindingControl = null;
            this.Datecheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Datecheckbox.Checked = false;
            this.Datecheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Datecheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Datecheckbox.CustomCheckmarkImage = null;
            this.Datecheckbox.Location = new System.Drawing.Point(747, 56);
            this.Datecheckbox.MinimumSize = new System.Drawing.Size(17, 17);
            this.Datecheckbox.Name = "Datecheckbox";
            this.Datecheckbox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnCheck.BorderRadius = 2;
            this.Datecheckbox.OnCheck.BorderThickness = 2;
            this.Datecheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Datecheckbox.OnCheck.CheckmarkThickness = 2;
            this.Datecheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Datecheckbox.OnDisable.BorderRadius = 2;
            this.Datecheckbox.OnDisable.BorderThickness = 2;
            this.Datecheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Datecheckbox.OnDisable.CheckmarkThickness = 2;
            this.Datecheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverChecked.BorderRadius = 2;
            this.Datecheckbox.OnHoverChecked.BorderThickness = 2;
            this.Datecheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Datecheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.Datecheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Datecheckbox.OnHoverUnchecked.BorderRadius = 2;
            this.Datecheckbox.OnHoverUnchecked.BorderThickness = 2;
            this.Datecheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Datecheckbox.OnUncheck.BorderRadius = 2;
            this.Datecheckbox.OnUncheck.BorderThickness = 2;
            this.Datecheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Datecheckbox.Size = new System.Drawing.Size(21, 21);
            this.Datecheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.Datecheckbox.TabIndex = 45;
            this.Datecheckbox.ThreeState = false;
            this.Datecheckbox.ToolTipText = null;
            // 
            // Servercheckbox
            // 
            this.Servercheckbox.AllowBindingControlAnimation = true;
            this.Servercheckbox.AllowBindingControlColorChanges = false;
            this.Servercheckbox.AllowBindingControlLocation = true;
            this.Servercheckbox.AllowCheckBoxAnimation = false;
            this.Servercheckbox.AllowCheckmarkAnimation = true;
            this.Servercheckbox.AllowOnHoverStates = true;
            this.Servercheckbox.AutoCheck = true;
            this.Servercheckbox.BackColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Servercheckbox.BackgroundImage")));
            this.Servercheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Servercheckbox.BindingControl = null;
            this.Servercheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Servercheckbox.Checked = false;
            this.Servercheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Servercheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servercheckbox.CustomCheckmarkImage = null;
            this.Servercheckbox.Location = new System.Drawing.Point(1011, 56);
            this.Servercheckbox.MinimumSize = new System.Drawing.Size(17, 17);
            this.Servercheckbox.Name = "Servercheckbox";
            this.Servercheckbox.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnCheck.BorderRadius = 2;
            this.Servercheckbox.OnCheck.BorderThickness = 2;
            this.Servercheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Servercheckbox.OnCheck.CheckmarkThickness = 2;
            this.Servercheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Servercheckbox.OnDisable.BorderRadius = 2;
            this.Servercheckbox.OnDisable.BorderThickness = 2;
            this.Servercheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Servercheckbox.OnDisable.CheckmarkThickness = 2;
            this.Servercheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverChecked.BorderRadius = 2;
            this.Servercheckbox.OnHoverChecked.BorderThickness = 2;
            this.Servercheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Servercheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.Servercheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.Servercheckbox.OnHoverUnchecked.BorderRadius = 2;
            this.Servercheckbox.OnHoverUnchecked.BorderThickness = 2;
            this.Servercheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.Servercheckbox.OnUncheck.BorderRadius = 2;
            this.Servercheckbox.OnUncheck.BorderThickness = 2;
            this.Servercheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Servercheckbox.Size = new System.Drawing.Size(21, 21);
            this.Servercheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.Servercheckbox.TabIndex = 46;
            this.Servercheckbox.ThreeState = false;
            this.Servercheckbox.ToolTipText = null;
            // 
            // Reglement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 660);
            this.Controls.Add(this.Servercheckbox);
            this.Controls.Add(this.Datecheckbox);
            this.Controls.Add(this.CancelReglementFilterbtn);
            this.Controls.Add(this.ReglementFilterbtn);
            this.Controls.Add(this.cancelreglementbtn);
            this.Controls.Add(this.ReglementDatagrid);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.Servercombobox);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.Reglementdate);
            this.Name = "Reglement";
            this.Text = "Reglement";
            this.Load += new System.EventHandler(this.Reglement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReglementDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reglementMoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTD_CoffeeManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelreglementbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView ReglementDatagrid;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.ComboBox Servercombobox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker Reglementdate;
        private Bunifu.Framework.UI.BunifuFlatButton CancelReglementFilterbtn;
        private Bunifu.Framework.UI.BunifuFlatButton ReglementFilterbtn;
        private DBTD_CoffeeManagement dBTD_CoffeeManagement;
        private System.Windows.Forms.BindingSource reglementMoreBindingSource;
        private DBTD_CoffeeManagementTableAdapters.Reglement_MoreTableAdapter reglement_MoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUSERWORKSERVERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUSERWORKADMINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSERWORKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUSERWORKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuCheckBox Datecheckbox;
        private Bunifu.UI.WinForms.BunifuCheckBox Servercheckbox;
    }
}