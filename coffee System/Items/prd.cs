using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System.Items
{
    public partial class prd : UserControl
    {
         double pr=0;
         long idP = 0;
         long idCashier = Program.idUser;//from login page
        bool isArticle;
        long idCategorie;
       public  string desc;
      public  bool firstTime = true;
        public prd(long id,string desc,double prix,Image img,bool isArticle,long idCtg)
        {
            InitializeComponent();
            this.desc = desc;
            this.isArticle = isArticle;
            pr = prix;
            idP= id;
            this.idCategorie = idCtg;
            idProduct.Text = id.ToString();
            picproduct.Image = img;
            designationproduct.Text = desc;
            price.Text=prix.ToString()+" DH";
            if (isArticle == false)
            {
                int qte = Operations.getQteProductQuantityProduct(idP);
                if (qte == 0)
                {
                    nonStock.Visible = true;
                    this.Enabled = false;
                }
                picdelete.Visible = false;
                picupdate.Visible = false;
            }
            if(isArticle == true)
            {
                picdelete.Visible = true;
                picupdate.Visible = true;
            }
        }
 
        private void ajouterPanier()
        {
            if (this.isArticle == false)
            {
                if (Operations.articlIsexistinPanier(idP,idCashier) == false)
                {
                    Operations.insertPanier(idP, 1, pr, idCashier);
                }
                else
                {
                    int qte = Operations.getQteProPanier(idP, idCashier);
                    qte++;
                    Operations.updatePanier(idP, qte, pr, idCashier);
                }
                Program.tabbord.remplirLayoutfacture();
            }
        }
        private void prd_Click(object sender, EventArgs e)
        {
            ajouterPanier();
        }

        private void picupdate_Click(object sender, EventArgs e)
        {
            string prix = price.Text;
            
            double p=double.Parse(prix.Replace(" DH", string.Empty));
            int qte = Operations.getQteProduct(this.idP);
            Program.art.remplirTextFields(idP,designationproduct.Text, picproduct.Image,qte ,p,idCategorie);
        }

        private void picdelete_Click(object sender, EventArgs e)
        {
            long idPro = this.idP;
            DialogResult result=MessageBox.Show("Do you want to delete this Product ??", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Operations.deleteArticle(idPro);
                Program.art.remplirLayoutProduct();
                Program.art.ClearTextFields();
            }

            

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void picproduct_Click(object sender, EventArgs e)
        {
            ajouterPanier();
            int qte=-5;
            if (Operations.getQteProductPanier(idP, idCashier)!=-1)
                qte = Operations.getQteProductQuantityProduct(idP) - Operations.getQteProductPanier(idP,idCashier);
            if (qte<10 && qte != -5 && firstTime==true)
            {
                MessageBox.Show("You have less than 9 pieces of " + desc + " in stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstTime = false;
            }
            if (qte == 0)
            {
                nonStock.Visible = true;
                this.Enabled = false;
            }
            else
            {
                nonStock.Visible = false ;
                this.Enabled = true;
            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {
            ajouterPanier();
        }
    }
}
