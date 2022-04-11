using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.IO;

namespace coffee_System
{
    public partial class Article : Form
    {
        int mov;
        int movX;
        int movY;
        long idAdmin = Program.idUser;
        long idProduitUpdate = 0;
        public Article()
        {
            InitializeComponent();
        }

        //Clear TextField
        public void ClearTextFields()
        {
            txtdesignation.Text = "";
            txtprice.Text = "";
            txtqte.Text = "";
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            picproduct.Image = Properties.Resources.def;
            errorProvider.Clear();
            errorNumeric.Clear();
        }
        //--remplir les champs de produit
        public void remplirTextFields(long id,string Desc,Image img,int qte,double prix,long idcategorie)
        {
            this.idProduitUpdate = id;
            txtdesignation.Text = Desc;
            txtprice.Text=prix.ToString();
            txtqte.Text=qte.ToString();
            picproduct.Image = img;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            cmbcategorie.SelectedValue = idcategorie;
        }
        //Search for product 
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
                Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, true,idcategorie);
                layoutproduct.Controls.Add(pro);
            }

        }
        //Check La quantiy
        public void EnableQuantity()
        {
            if (radnotquantity.Checked == true)
            {
                txtqte.Enabled = false;
            }
            if(radquantity.Checked == true)
            {
                txtqte.Enabled = true;
            }
        }
        //remplir combobox categorie
        public void remplirCategorie()
        {
            DataTable dt = Operations.getAllCategorie();
            cmbcategorie.DataSource = dt;
            cmbcategorie.DisplayMember = "Categorie";
            cmbcategorie.ValueMember = "ID_cat";
        }
        //---------Remplir layout of product------------
         public void remplirLayoutProduct()

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
                      idcategorie= (long)(dt.Rows[i][4]);
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
                      Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, true, idcategorie);
                      layoutproduct.Controls.Add(pro);

              }

          }

        //remplir layout Categorie
        private void remplirLayoutCategorie()

        {
            layoutcategorie.Controls.Clear();
            btnAll btn1 = new btnAll(true);
            layoutcategorie.Controls.Add(btn1);
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
                btnCategorit btn = new btnCategorit(idCateg, descr, pic.Image,true);
                layoutcategorie.Controls.Add(btn);
            }

        }
        private void reduite_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

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

        private void btnimport_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dialog.FileName.ToString();
                picproduct.ImageLocation = imagelocation;
            }
        }

        private void Article_Load(object sender, EventArgs e)
        {
            lblusername.Text = Operations.getNameUser(idAdmin);
            radnotquantity.Checked = true;
            radquantity.Checked = false;
            //fill layout Product
            remplirLayoutProduct();
            //fill combobox Categorie
            remplirCategorie();
            //fill Layout categorie
            remplirLayoutCategorie();
            //focus on NotQuantity
            EnableQuantity();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string descr = txtdesignation.Text;
            double prix = Convert.ToDouble(txtprice.Text.Replace(".", ","));// double.Parse(txtprice.Text); 
            int idCat = int.Parse(cmbcategorie.SelectedValue.ToString());
            int qte = 0;
            if (txtqte.Text != "") {
                qte = int.Parse(txtqte.Text);        
             }
            Operations.insertArticle(descr, prix, idCat, idAdmin, picproduct.Image, qte);
            remplirLayoutProduct();
            ClearTextFields();

        }

        private void radquantity_CheckedChanged(object sender, EventArgs e)
        {
            EnableQuantity();
        }
        
        private void radnotquantity_CheckedChanged(object sender, EventArgs e)
        {
            EnableQuantity();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                 remplirLayoutProduct();
            }
            else
            {
                searchforProduct(txtsearch.Text);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            string descr = txtdesignation.Text;
            double prix = double.Parse(txtprice.Text.Replace(".", ","));
            int idCat = int.Parse(cmbcategorie.SelectedValue.ToString());
            int qte = int.Parse(txtqte.Text);
            Operations.updateArticle(idProduitUpdate,descr, prix, idCat, idAdmin, picproduct.Image, qte);
            remplirLayoutProduct();
            ClearTextFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearch_OnIconRightClick(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void cmbcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            errorNumeric.Clear();
            if (double.TryParse(txtprice.Text, out double a))
            {
                btnadd.Enabled = true;

            }
            else
            {
                errorNumeric.SetError(txtprice, "Must you insert Numeric Value!");
                btnadd.Enabled = false;
            }
        }

        private void txtqte_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
                

            if (int.TryParse(txtqte.Text, out int a))
            {
                btnadd.Enabled = true;

            }
            else
            {
                errorProvider.SetError(txtqte, "Must you insert Numeric Value!");
                btnadd.Enabled = false;
            }
        }

        private void btnallitem_Click(object sender, EventArgs e)
        {
            remplirLayoutProduct();
        }

        private void btnallitem_Click_1(object sender, EventArgs e)
        {
            remplirLayoutProduct();
        }

        private void layoutcategorie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
