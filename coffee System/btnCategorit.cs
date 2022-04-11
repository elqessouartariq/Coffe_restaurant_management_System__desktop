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

namespace coffee_System
{
    public partial class btnCategorit : UserControl
    {
        long idCategorie;
        bool isArticle;
        public btnCategorit(long idc,string desc,Image icon,bool isArticle)
        {
            InitializeComponent();
            this.isArticle= isArticle;
            this.idCategorie = idc;
            btncoffee.IdleIconLeftImage = icon;
            btncoffee.Text = desc;
        }
        private void searchforProductArticle()
        {
            Program.art.layoutproduct.Controls.Clear();
            DataTable dt = Operations.getSearchArticleCategorie(this.idCategorie);
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
                Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, this.isArticle, idcategorie);
                Program.art.layoutproduct.Controls.Add(pro);
            }

        }
        private void searchforProductTableauBoard()
        {
            Program.tabbord.layoutproduct.Controls.Clear();
            DataTable dt = Operations.getSearchArticleCategorie(this.idCategorie);
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
                Items.prd pro = new Items.prd(idP, descr, prix, pic.Image, this.isArticle, idcategorie);
                Program.tabbord.layoutproduct.Controls.Add(pro);
            }

        }
        public void searchArticle()
        {
            if (this.isArticle == true)
            {
                searchforProductArticle();
            }
            else
                searchforProductTableauBoard();
        }
        private void btncoffee_Click(object sender, EventArgs e)
        {
            searchArticle();
        }
    }
}
