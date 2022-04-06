using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using System.Data.SqlClient;
using System.IO.MemoryMappedFiles;


namespace coffee_System
{
    public partial class tableaubord : Form
    {
        int mov;
        int movX;
        int movY;
        long idCashier=1;//from login page
        public tableaubord()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            lblusername.Text = Operations.getNameUser(idCashier);

        }
        //---Functions
        
        //remplir flow layout panel Facture
        public void remplirLayoutfacture()
        {
            pnlFacture.Controls.Clear();
            DataTable dt = Operations.getPanier(idCashier);
            long idP;
            String descr;
            int qte;
            double total;
            double prix;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                idP = (long)dt.Rows[i][0];
                descr = dt.Rows[i][1].ToString();
                qte= (int)dt.Rows[i][2];
                total = double.Parse(dt.Rows[i][3].ToString());
                prix = total / qte;
                
                Panier pro = new Panier(idP, descr, qte,prix);
                pnlFacture.Controls.Add(pro);
            }
        }

        //---------Remplir layout of product------------
        private void remplirLayoutProduct()

        {
            layoutproduct.Controls.Clear();
            DataTable dt = Operations.getAllArticl();
            PictureBox pic = new PictureBox();
            pic.Image = null;
            long idP;
            String descr;
            double prix;
            long idcategorie;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                    idP = (long)dt.Rows[i][0];
                    descr = dt.Rows[i][2].ToString();
                    prix = double.Parse(dt.Rows[i][3].ToString());
                idcategorie= (long)dt.Rows[i][4]; 
                //byte[] img = (byte[])(dt.Rows[i][1]);
                if (dt.Rows[i][1] != null)
                {
                    byte[] img = (byte[])(dt.Rows[i][1]);
                    if (img == null)
                        pic.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pic.Image = Image.FromStream(ms);

                    }
                }
                    Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, false, idcategorie);
                    layoutproduct.Controls.Add(pro);
                
            }

        }
        //remolir grid facture
        
        
        //remplir le combobox de serveurs
        private void remplircmbServer()
        {
            DataTable dt = Operations.getAllServer();
            cmbserver.DataSource = dt;
            cmbserver.DisplayMember = "name";
            cmbserver.ValueMember = "ID_USER_WORK";

        }
        //remplir layout for categorie
        private void remplirLayoutCategorie()

        {
            layoutcategorie.Controls.Clear();
            DataTable dt = Operations.getAllCategorie();
            PictureBox pic = new PictureBox();
            pic.Image = null;
            String descr;
            long idCateg = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idCateg = long.Parse(dt.Rows[i][0].ToString());
                descr = dt.Rows[i][1].ToString();
              
                byte[] img = (byte[])(dt.Rows[i][2]);
                if (img == null)
                    pic.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic.Image = Image.FromStream(ms);

                }
                btnCategorit btn = new btnCategorit(idCateg,descr,pic.Image,false);
                layoutcategorie.Controls.Add(btn);
            }

        }

        //search for product 
        private void searchforProduct(string desc)

        {
            layoutproduct.Controls.Clear();
            DataTable dt = Operations.getSearchArticle(desc);
            PictureBox pic = new PictureBox();
            pic.Image = null;
            long idP;
            String descr;
            double prix;
            long idcategorie;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idP = (long)dt.Rows[i][0];
                descr = dt.Rows[i][2].ToString();
                prix = double.Parse(dt.Rows[i][3].ToString());
                idcategorie= (long)dt.Rows[i][4];
                byte[] img = (byte[])(dt.Rows[i][1]);
                if (img == null)
                    pic.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic.Image = Image.FromStream(ms);

                }
                Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, false, idcategorie);
                layoutproduct.Controls.Add(pro);
            }

        }
        private void reduite_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void tableaubord_Load(object sender, EventArgs e)
        {

            //fill panel facture
            remplirLayoutfacture();
            //fill layout of Product 
             remplirLayoutProduct();
            //fill layout of categorie
            //remplirLayoutCategorie();
            //fill combobox of server
            remplircmbServer();
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            Operations.deletePanier(idCashier);
            remplirLayoutfacture();
           
        }

       

        private void gridfacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtsearch_TextChange(object sender, EventArgs e)
        {
            if(txtsearch.Text == "")
            {
               remplirLayoutProduct();
            }
            else
            {
                searchforProduct(txtsearch.Text);
            }
        }
      

        private void minimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_OnIconLeftClick(object sender, EventArgs e)
        {
          
        }

        private void txtsearch_OnIconRightClick(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("Do you want pass the Commande ?","Commande",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res==DialogResult.Yes)
            {
                long idserver = long.Parse(cmbserver.SelectedValue.ToString());
                double total=double.Parse(lbltotal.Text.Replace(" DH",string.Empty));
                Operations.insertCommande(total,idserver,idCashier);
                MessageBox.Show("Commande Add", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                print();
            }
        }

        private void cmbserver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnallitem_Click(object sender, EventArgs e)
        {
            remplirLayoutProduct();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
           
        }
        public void print()
        {
            PrintForm prf = new PrintForm(Operations.CommandeBill(), lbltotal.Text, cmbserver.Text);
            prf.Visible = true;
            Operations.deletePanier(idCashier);
            pnlFacture.Controls.Clear();
           
        }

        private void wifi_Click(object sender, EventArgs e)
        {
            wifiFrom fr = new wifiFrom();
            fr.ShowDialog();
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
