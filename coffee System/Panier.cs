using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    public partial class Panier : UserControl
    {
        long idCashier=1;
        long idProduit;
        double prix;
        string desc;

       

        public Panier(long idPro,string desc,int qte,double prix)
        {
            InitializeComponent();
            this.prix = prix;
            this.desc = desc;   
            idProduit = idPro;
            lbldesc.Text = desc;
            txtqte.Text=qte.ToString();
            double Total=prix*qte;
            lbltotal.Text = Total.ToString()+" dh";
            prixunitaire.Text = prix + " dh / 1 unité";
        }

        private void incremente_Click(object sender, EventArgs e)
        {
            int qte = int.Parse(txtqte.Text);
            qte++;
            txtqte.Text = qte.ToString();
            double total=prix*qte;
            lbltotal.Text = total.ToString() + " dh";
            Operations.updatePanier(idProduit, qte, prix, idCashier);
        }

        private void decremante_Click(object sender, EventArgs e)
        {
            int qte = int.Parse(txtqte.Text);
            if (qte > 1)
            {
                qte--;
                txtqte.Text = qte.ToString();
                double total = prix * qte;
                lbltotal.Text = total.ToString() + " dh";
                
            }
            else
            {
                qte = 1;
                txtqte.Text ="1";
                double total = prix ;
                lbltotal.Text = total.ToString() + " dh";
            }
            Operations.updatePanier(idProduit, qte, prix, idCashier);
        }

        private void picsupprimer_Click(object sender, EventArgs e)
        {
            txtqte.Text = "0";
            Operations.deletePanier(idCashier,idProduit);
            Program.tabbord.remplirLayoutfacture();
        }

        private void txtqte_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();


            if (int.TryParse(txtqte.Text, out int a))
            {
            int qte;

            if (Operations.getQteProductQuantityProduct(idProduit) != -1)
            {
                int qte1;
                qte1 = Operations.getQteProductQuantityProduct(idProduit) - int.Parse(txtqte.Text);
                if (qte1 < 0)
                {
                    MessageBox.Show("you have exceeded the quantity in stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtqte.Text = Operations.getQteProductQuantityProduct(idProduit) + "";
                    return;
                }
                    Items.prd p=new Items.prd(1,"asda",1,null,false,2);
                    foreach (Items.prd pro in Program.tabbord.layoutproduct.Controls)
                    {
                        if (pro.desc == this.desc)
                        {

                            p = pro;
                        }
                    }
                    if (qte1 < 10 && p.firstTime == true)
                    {
                        MessageBox.Show("You have less than 9 pieces of " + desc + " in stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        p.firstTime = false;
                    }
                    if (qte1 == 0)
                    {

                        p.nonStock.Visible = true;
                        p.Enabled = false;


                    }
                    else
                    {
                        p.nonStock.Visible = false;
                        p.Enabled = true;
                    }
                }
            if (txtqte.Text != "")
            {
                qte = int.Parse(txtqte.Text);
                double total = prix * qte;
                lbltotal.Text = total.ToString() + " dh";


            }
            else
            {
                qte = 1;
                txtqte.Text = "1";
                double total = prix * qte;
                lbltotal.Text = total.ToString() + " dh";
            }

            Operations.updatePanier(idProduit, qte, prix, idCashier);
        }
            else
            {
                errorProvider.SetError(txtqte, "Must you insert Numeric Value!");
            }
        }
    }
}
