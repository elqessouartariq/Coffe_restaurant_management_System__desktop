namespace coffee_System
{
    partial class DepenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepenseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libelletxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.descriptiontxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pricetxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.printbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updatebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deletebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addnewbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filterbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.enddatedepenese = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.startdatedepense = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.depensedate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Depensedatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Libellecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptioncl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datedepensecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montantcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Depensedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // libelletxtbox
            // 
            this.libelletxtbox.BorderColorFocused = System.Drawing.Color.Linen;
            this.libelletxtbox.BorderColorIdle = System.Drawing.SystemColors.ControlLight;
            this.libelletxtbox.BorderColorMouseHover = System.Drawing.Color.Linen;
            this.libelletxtbox.BorderThickness = 3;
            this.libelletxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.libelletxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.libelletxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.libelletxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.libelletxtbox.isPassword = false;
            this.libelletxtbox.Location = new System.Drawing.Point(13, 34);
            this.libelletxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.libelletxtbox.MaxLength = 32767;
            this.libelletxtbox.Name = "libelletxtbox";
            this.libelletxtbox.Size = new System.Drawing.Size(363, 44);
            this.libelletxtbox.TabIndex = 0;
            this.libelletxtbox.TabStop = false;
            this.libelletxtbox.Text = "    Libellé...";
            this.libelletxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descriptiontxtbox
            // 
            this.descriptiontxtbox.BorderColorFocused = System.Drawing.Color.Linen;
            this.descriptiontxtbox.BorderColorIdle = System.Drawing.SystemColors.ControlLight;
            this.descriptiontxtbox.BorderColorMouseHover = System.Drawing.Color.Linen;
            this.descriptiontxtbox.BorderThickness = 3;
            this.descriptiontxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descriptiontxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptiontxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.descriptiontxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptiontxtbox.isPassword = false;
            this.descriptiontxtbox.Location = new System.Drawing.Point(13, 86);
            this.descriptiontxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptiontxtbox.MaxLength = 32767;
            this.descriptiontxtbox.Name = "descriptiontxtbox";
            this.descriptiontxtbox.Size = new System.Drawing.Size(363, 55);
            this.descriptiontxtbox.TabIndex = 11;
            this.descriptiontxtbox.Text = "   Description...";
            this.descriptiontxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pricetxtbox
            // 
            this.pricetxtbox.BorderColorFocused = System.Drawing.Color.Linen;
            this.pricetxtbox.BorderColorIdle = System.Drawing.SystemColors.ControlLight;
            this.pricetxtbox.BorderColorMouseHover = System.Drawing.Color.Linen;
            this.pricetxtbox.BorderThickness = 3;
            this.pricetxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pricetxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricetxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pricetxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricetxtbox.isPassword = false;
            this.pricetxtbox.Location = new System.Drawing.Point(13, 187);
            this.pricetxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.pricetxtbox.MaxLength = 32767;
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(363, 44);
            this.pricetxtbox.TabIndex = 12;
            this.pricetxtbox.Text = "   Montant...";
            this.pricetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuLabel1.Location = new System.Drawing.Point(26, 155);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(35, 19);
            this.bunifuLabel1.TabIndex = 13;
            this.bunifuLabel1.Text = "Date ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(404, 150);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(68, 23);
            this.bunifuLabel2.TabIndex = 15;
            this.bunifuLabel2.Text = "Date Début";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(725, 150);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(51, 23);
            this.bunifuLabel3.TabIndex = 17;
            this.bunifuLabel3.Text = "Date Fin";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(408, 34);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(601, 33);
            this.bunifuMaterialTextbox1.TabIndex = 19;
            this.bunifuMaterialTextbox1.Text = "Search Here...";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // printbtn
            // 
            this.printbtn.Active = false;
            this.printbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.printbtn.BackColor = System.Drawing.Color.Transparent;
            this.printbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printbtn.BorderRadius = 0;
            this.printbtn.ButtonText = "Print";
            this.printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printbtn.DisabledColor = System.Drawing.Color.Gray;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.printbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.printbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.printbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_print_50;
            this.printbtn.Iconimage_right = null;
            this.printbtn.Iconimage_right_Selected = null;
            this.printbtn.Iconimage_Selected = null;
            this.printbtn.IconMarginLeft = 0;
            this.printbtn.IconMarginRight = 0;
            this.printbtn.IconRightVisible = true;
            this.printbtn.IconRightZoom = 0D;
            this.printbtn.IconVisible = true;
            this.printbtn.IconZoom = 40D;
            this.printbtn.IsTab = false;
            this.printbtn.Location = new System.Drawing.Point(898, 86);
            this.printbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printbtn.Name = "printbtn";
            this.printbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.printbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.printbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.printbtn.selected = false;
            this.printbtn.Size = new System.Drawing.Size(104, 35);
            this.printbtn.TabIndex = 44;
            this.printbtn.Text = "Print";
            this.printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.printbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // updatebtn
            // 
            this.updatebtn.Active = false;
            this.updatebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatebtn.BorderRadius = 0;
            this.updatebtn.ButtonText = "Update";
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.DisabledColor = System.Drawing.Color.Gray;
            this.updatebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.updatebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updatebtn.Iconimage = global::coffee_System.Properties.Resources.icons8_edit_32;
            this.updatebtn.Iconimage_right = null;
            this.updatebtn.Iconimage_right_Selected = null;
            this.updatebtn.Iconimage_Selected = null;
            this.updatebtn.IconMarginLeft = 0;
            this.updatebtn.IconMarginRight = 0;
            this.updatebtn.IconRightVisible = true;
            this.updatebtn.IconRightZoom = 0D;
            this.updatebtn.IconVisible = true;
            this.updatebtn.IconZoom = 40D;
            this.updatebtn.IsTab = false;
            this.updatebtn.Location = new System.Drawing.Point(635, 86);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.updatebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.updatebtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.updatebtn.selected = false;
            this.updatebtn.Size = new System.Drawing.Size(110, 35);
            this.updatebtn.TabIndex = 43;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.updatebtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // deletebtn
            // 
            this.deletebtn.Active = false;
            this.deletebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtn.BorderRadius = 0;
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.deletebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebtn.Iconimage = global::coffee_System.Properties.Resources.icons8_delete_30;
            this.deletebtn.Iconimage_right = null;
            this.deletebtn.Iconimage_right_Selected = null;
            this.deletebtn.Iconimage_Selected = null;
            this.deletebtn.IconMarginLeft = 0;
            this.deletebtn.IconMarginRight = 0;
            this.deletebtn.IconRightVisible = true;
            this.deletebtn.IconRightZoom = 0D;
            this.deletebtn.IconVisible = true;
            this.deletebtn.IconZoom = 40D;
            this.deletebtn.IsTab = false;
            this.deletebtn.Location = new System.Drawing.Point(770, 86);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.deletebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.deletebtn.selected = false;
            this.deletebtn.Size = new System.Drawing.Size(104, 35);
            this.deletebtn.TabIndex = 42;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.deletebtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // addnewbtn
            // 
            this.addnewbtn.Active = false;
            this.addnewbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.addnewbtn.BackColor = System.Drawing.Color.Transparent;
            this.addnewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addnewbtn.BorderRadius = 0;
            this.addnewbtn.ButtonText = "Add new ";
            this.addnewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addnewbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addnewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.addnewbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addnewbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_add_32;
            this.addnewbtn.Iconimage_right = null;
            this.addnewbtn.Iconimage_right_Selected = null;
            this.addnewbtn.Iconimage_Selected = null;
            this.addnewbtn.IconMarginLeft = 0;
            this.addnewbtn.IconMarginRight = 0;
            this.addnewbtn.IconRightVisible = true;
            this.addnewbtn.IconRightZoom = 0D;
            this.addnewbtn.IconVisible = true;
            this.addnewbtn.IconZoom = 40D;
            this.addnewbtn.IsTab = false;
            this.addnewbtn.Location = new System.Drawing.Point(516, 86);
            this.addnewbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.addnewbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.addnewbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.addnewbtn.selected = false;
            this.addnewbtn.Size = new System.Drawing.Size(111, 35);
            this.addnewbtn.TabIndex = 41;
            this.addnewbtn.Text = "Add new ";
            this.addnewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addnewbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.addnewbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Active = false;
            this.cancelbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbtn.BorderRadius = 0;
            this.cancelbtn.ButtonText = "Annuler";
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.DisabledColor = System.Drawing.Color.Gray;
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cancelbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.cancelbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_cancel_32;
            this.cancelbtn.Iconimage_right = null;
            this.cancelbtn.Iconimage_right_Selected = null;
            this.cancelbtn.Iconimage_Selected = null;
            this.cancelbtn.IconMarginLeft = 0;
            this.cancelbtn.IconMarginRight = 0;
            this.cancelbtn.IconRightVisible = true;
            this.cancelbtn.IconRightZoom = 0D;
            this.cancelbtn.IconVisible = true;
            this.cancelbtn.IconZoom = 40D;
            this.cancelbtn.IsTab = false;
            this.cancelbtn.Location = new System.Drawing.Point(898, 196);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.cancelbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.cancelbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.cancelbtn.selected = false;
            this.cancelbtn.Size = new System.Drawing.Size(111, 35);
            this.cancelbtn.TabIndex = 21;
            this.cancelbtn.Text = "Annuler";
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.cancelbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // filterbtn
            // 
            this.filterbtn.Active = false;
            this.filterbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.filterbtn.BackColor = System.Drawing.Color.Transparent;
            this.filterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterbtn.BorderRadius = 0;
            this.filterbtn.ButtonText = "filtrer";
            this.filterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterbtn.DisabledColor = System.Drawing.Color.Gray;
            this.filterbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filterbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(81)))), ((int)(((byte)(189)))));
            this.filterbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.filterbtn.Iconimage = global::coffee_System.Properties.Resources.icons8_filter_24;
            this.filterbtn.Iconimage_right = null;
            this.filterbtn.Iconimage_right_Selected = null;
            this.filterbtn.Iconimage_Selected = null;
            this.filterbtn.IconMarginLeft = 0;
            this.filterbtn.IconMarginRight = 0;
            this.filterbtn.IconRightVisible = true;
            this.filterbtn.IconRightZoom = 0D;
            this.filterbtn.IconVisible = true;
            this.filterbtn.IconZoom = 40D;
            this.filterbtn.IsTab = false;
            this.filterbtn.Location = new System.Drawing.Point(779, 196);
            this.filterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.filterbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.filterbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.filterbtn.selected = false;
            this.filterbtn.Size = new System.Drawing.Size(111, 35);
            this.filterbtn.TabIndex = 40;
            this.filterbtn.Text = "filtrer";
            this.filterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterbtn.Textcolor = System.Drawing.SystemColors.WindowFrame;
            this.filterbtn.TextFont = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            // 
            // enddatedepenese
            // 
            this.enddatedepenese.BackColor = System.Drawing.Color.Transparent;
            this.enddatedepenese.BorderRadius = 1;
            this.enddatedepenese.Color = System.Drawing.SystemColors.ControlLight;
            this.enddatedepenese.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.enddatedepenese.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.enddatedepenese.DisabledColor = System.Drawing.Color.Gray;
            this.enddatedepenese.DisplayWeekNumbers = false;
            this.enddatedepenese.DPHeight = 0;
            this.enddatedepenese.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.enddatedepenese.FillDatePicker = false;
            this.enddatedepenese.ForeColor = System.Drawing.Color.DarkViolet;
            this.enddatedepenese.Icon = ((System.Drawing.Image)(resources.GetObject("enddatedepenese.Icon")));
            this.enddatedepenese.IconColor = System.Drawing.Color.DarkViolet;
            this.enddatedepenese.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.enddatedepenese.Location = new System.Drawing.Point(792, 142);
            this.enddatedepenese.MinimumSize = new System.Drawing.Size(217, 32);
            this.enddatedepenese.Name = "enddatedepenese";
            this.enddatedepenese.Size = new System.Drawing.Size(217, 32);
            this.enddatedepenese.TabIndex = 16;
            // 
            // startdatedepense
            // 
            this.startdatedepense.BackColor = System.Drawing.Color.Transparent;
            this.startdatedepense.BorderRadius = 1;
            this.startdatedepense.Color = System.Drawing.SystemColors.ControlLight;
            this.startdatedepense.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.startdatedepense.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.startdatedepense.DisabledColor = System.Drawing.Color.Gray;
            this.startdatedepense.DisplayWeekNumbers = false;
            this.startdatedepense.DPHeight = 0;
            this.startdatedepense.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startdatedepense.FillDatePicker = false;
            this.startdatedepense.ForeColor = System.Drawing.Color.DarkViolet;
            this.startdatedepense.Icon = ((System.Drawing.Image)(resources.GetObject("startdatedepense.Icon")));
            this.startdatedepense.IconColor = System.Drawing.Color.DarkViolet;
            this.startdatedepense.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.startdatedepense.Location = new System.Drawing.Point(482, 146);
            this.startdatedepense.MinimumSize = new System.Drawing.Size(217, 32);
            this.startdatedepense.Name = "startdatedepense";
            this.startdatedepense.Size = new System.Drawing.Size(217, 32);
            this.startdatedepense.TabIndex = 14;
            // 
            // depensedate
            // 
            this.depensedate.BackColor = System.Drawing.Color.Transparent;
            this.depensedate.BorderRadius = 1;
            this.depensedate.Color = System.Drawing.SystemColors.ControlLight;
            this.depensedate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.depensedate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.depensedate.DisabledColor = System.Drawing.Color.Gray;
            this.depensedate.DisplayWeekNumbers = false;
            this.depensedate.DPHeight = 0;
            this.depensedate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.depensedate.FillDatePicker = false;
            this.depensedate.ForeColor = System.Drawing.Color.DarkViolet;
            this.depensedate.Icon = ((System.Drawing.Image)(resources.GetObject("depensedate.Icon")));
            this.depensedate.IconColor = System.Drawing.Color.DarkViolet;
            this.depensedate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.depensedate.Location = new System.Drawing.Point(81, 148);
            this.depensedate.MinimumSize = new System.Drawing.Size(295, 32);
            this.depensedate.Name = "depensedate";
            this.depensedate.Size = new System.Drawing.Size(295, 32);
            this.depensedate.TabIndex = 10;
            // 
            // Depensedatagrid
            // 
            this.Depensedatagrid.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Depensedatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Depensedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Depensedatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.Depensedatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Depensedatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Depensedatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Depensedatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Depensedatagrid.ColumnHeadersHeight = 40;
            this.Depensedatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libellecl,
            this.Descriptioncl,
            this.Datedepensecl,
            this.Montantcl});
            this.Depensedatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.Depensedatagrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Depensedatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Depensedatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.Depensedatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Depensedatagrid.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.Depensedatagrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.Depensedatagrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.Depensedatagrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Depensedatagrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Depensedatagrid.CurrentTheme.Name = null;
            this.Depensedatagrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.Depensedatagrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Depensedatagrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Depensedatagrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.Depensedatagrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Depensedatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Depensedatagrid.EnableHeadersVisualStyles = false;
            this.Depensedatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.Depensedatagrid.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.Depensedatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.Depensedatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.Depensedatagrid.Location = new System.Drawing.Point(13, 254);
            this.Depensedatagrid.Name = "Depensedatagrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Depensedatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Depensedatagrid.RowHeadersVisible = false;
            this.Depensedatagrid.RowTemplate.Height = 40;
            this.Depensedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Depensedatagrid.Size = new System.Drawing.Size(989, 357);
            this.Depensedatagrid.TabIndex = 45;
            this.Depensedatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            // 
            // Libellecl
            // 
            this.Libellecl.HeaderText = "Libelle";
            this.Libellecl.Name = "Libellecl";
            // 
            // Descriptioncl
            // 
            this.Descriptioncl.HeaderText = "Description";
            this.Descriptioncl.Name = "Descriptioncl";
            // 
            // Datedepensecl
            // 
            this.Datedepensecl.HeaderText = "Date Depense";
            this.Datedepensecl.Name = "Datedepensecl";
            // 
            // Montantcl
            // 
            this.Montantcl.HeaderText = "Montant";
            this.Montantcl.Name = "Montantcl";
            // 
            // DepenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1018, 623);
            this.Controls.Add(this.Depensedatagrid);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addnewbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.filterbtn);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.enddatedepenese);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.startdatedepense);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pricetxtbox);
            this.Controls.Add(this.descriptiontxtbox);
            this.Controls.Add(this.depensedate);
            this.Controls.Add(this.libelletxtbox);
            this.Name = "DepenseForm";
            this.Text = "DepenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.Depensedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox libelletxtbox;
        private Bunifu.UI.WinForms.BunifuDatePicker depensedate;
        private Bunifu.Framework.UI.BunifuMetroTextbox descriptiontxtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox pricetxtbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker startdatedepense;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDatePicker enddatedepenese;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton filterbtn;
        private Bunifu.Framework.UI.BunifuFlatButton cancelbtn;
        private Bunifu.Framework.UI.BunifuFlatButton addnewbtn;
        private Bunifu.Framework.UI.BunifuFlatButton deletebtn;
        private Bunifu.Framework.UI.BunifuFlatButton updatebtn;
        private Bunifu.Framework.UI.BunifuFlatButton printbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView Depensedatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptioncl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datedepensecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montantcl;
    }
}