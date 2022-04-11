using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    public partial class Categorie : Form
    {
        private string imagelocation;

        public object ConfigurationManger { get; private set; }

        public Categorie()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-63TK96G\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeManagement_dbDataSet1.CATEGORIE_PRODUCT' table. You can move, or remove it, as needed.
            this.cATEGORIE_PRODUCTTableAdapter1.Fill(this.coffeeManagement_dbDataSet1.CATEGORIE_PRODUCT);



        }

        //Affichage des infos dans le tableau

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCat.Text = DataCat.CurrentRow.Cells[0].Value.ToString();
            TxtCatname.Text=DataCat.CurrentRow.Cells[1].Value.ToString();
            MemoryStream ms = new MemoryStream((byte [])DataCat.CurrentRow.Cells[2].Value);  
            PicCat.Image = Image.FromStream(ms);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //importation d'image
        private void Import_pic_cat_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName.ToString();
                    PicCat.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
           
        //convertir image en byte

        private static byte[] ImageToByteArray(Image img)
        {
            throw new NotImplementedException();
        }
        // Ajouts des infos
        private void AddCat_Click(object sender, EventArgs e)
        {
            Image img = PicCat.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            
            arr = (byte[])converter.ConvertTo(img,typeof(byte[]));
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CATEGORIE_PRODUCT (Categorie,Categorie_Icon) VALUES (@Categorie,@Icon)", con);
            cmd.Parameters.AddWithValue("@Categorie",TxtCatname.Text);
            cmd.Parameters.AddWithValue("@Icon", arr);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Categorie Saved");

            SqlCommand cmd2 = new SqlCommand("Select * from CATEGORIE_PRODUCT",con);
            DataTable dt =new DataTable();
            dt.Load(cmd2.ExecuteReader());
            DataCat.DataSource = dt;  
            con.Close();    

        }
        //Modification des infos
        private void UpdateCat_Click(object sender, EventArgs e)
        {
            Image img = PicCat.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            con.Open();
            SqlCommand cmd = new SqlCommand("Update  CATEGORIE_PRODUCT Set Categorie=@Categorie,Categorie_Icon=@Icon Where ID_cat=@id_cat",con);
            cmd.Parameters.AddWithValue("@Categorie", TxtCatname.Text);
            cmd.Parameters.AddWithValue("@Icon", arr);
            cmd.Parameters.AddWithValue("@id_cat", IdCat.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("Select * from CATEGORIE_PRODUCT", con);
            DataTable dt = new DataTable();
            dt.Load(cmd2.ExecuteReader());
            DataCat.DataSource = dt;
            con.Close();
        }
        //Suppression des infos
        private void DeleteCat_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from CATEGORIE_PRODUCT  Where ID_cat=@id_cat ", con);
            cmd.Parameters.AddWithValue("@id_cat", IdCat.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("Select * from CATEGORIE_PRODUCT", con);
            DataTable dt = new DataTable();
            dt.Load(cmd2.ExecuteReader());
            DataCat.DataSource = dt;
            con.Close();
            PicCat.Image = null;
            TxtCatname.Text = "";
            IdCat.Text = "";
        }
        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
    }
    }



