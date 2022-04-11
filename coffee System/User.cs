using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    public partial class Form2 : Form
    {
        int mov;
        int movX;
        int movY;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-63TK96G\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True");
        private string imagelocation;

        public Form2()
        {
            InitializeComponent();
        }
        public void ClearTextFields()
        {
            Txtfirst.Text = "";
            TxtLast.Text = "";
            TxtCin.Text = "";
            TxtEmail.Text = "";
            TxtTele.Text = "";
            TxtPass.Text = "";
            Statut_combo.SelectedIndex = 0;
        }
        public void remplirTextFields( long id,string first, string last, string cin, string email, string tele, string pass, Image img,string statut)
        {
            this.LblidUser.Text = id+"";
            Txtfirst.Text = first;
            TxtLast.Text = last;
            TxtCin.Text = cin;
            TxtEmail.Text = email;
            TxtTele.Text = tele;
            TxtPass.Text = pass;
            PicUser.Image = img;
            string sta=statut.ToLower();
            switch (sta)
            {
                case "admin": Statut_combo.SelectedIndex = 0; break;
                case "server": Statut_combo.SelectedIndex = 1; break;
                case "cashier": Statut_combo.SelectedIndex = 2; break;
                case "other...": Statut_combo.SelectedIndex = 3; break;
            }
            
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statut_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Statut_combo.SelectedItem == "Server" || Statut_combo.SelectedItem == "Other...")
            {
                Username.Enabled = false;
                TxtPass.Enabled = false;
            }
            else
            {
                Username.Enabled = true;
                TxtPass.Enabled = true;
            }
        }
        //importation d'image
        private void Importbut_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName.ToString();
                    PicUser.ImageLocation = imagelocation;
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
        //ajout d'infos
        private void Addbut_Click(object sender, EventArgs e)
        {
            Image img = PicUser.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();

            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO USER_WORK (Nom_USER_WORK,Prenom_USER_WORK,username_USER_WORK,CIN_USER_WORK,Email_USER_WORK, Phone_USER_WORK,Statut,Password_USER_WORK,imageUser) VALUES (@Nom_USER_WORK,@Prenom_USER_WORK,@username_USER_WORK,@CIN_USER_WORK,@Email_USER_WORK,@Phone_USER_WORK,@Statut,@Password_USER_WORK,@imageUser)", con);
            cmd.Parameters.AddWithValue("@Nom_USER_WORK", TxtLast.Text);
            cmd.Parameters.AddWithValue("@Prenom_USER_WORK",Txtfirst.Text);
            cmd.Parameters.AddWithValue("@username_USER_WORK", Username.Text);
            cmd.Parameters.AddWithValue("@CIN_USER_WORK", TxtCin.Text);
            cmd.Parameters.AddWithValue("@Email_USER_WORK",TxtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone_USER_WORK", TxtTele.Text);
            cmd.Parameters.AddWithValue("@Statut", Statut_combo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Password_USER_WORK", TxtPass.Text);
            cmd.Parameters.AddWithValue("@imageUser", arr);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Saved");

            remplirLayoutProduct();

            con.Close();
        }
        //Mise à jour des infos

        private void Updatebut_Click(object sender, EventArgs e)
        {
            string statu=Statut_combo.SelectedItem.ToString();
            Image img = PicUser.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            con.Open();
            SqlCommand cmd = new SqlCommand("Update  USER_WORK Set Nom_USER_WORK=@Nom_USER_WORK,Prenom_USER_WORK=@Prenom_USER_WORK,username_USER_WORK=@username_USER_WORK ,CIN_USER_WORK=@CIN_USER_WORK ,Email_USER_WORK=@Email_USER_WORK , Phone_USER_WORK=@Phone_USER_WORK ,Password_USER_WORK=@Password_USER_WORK ,imageUser=@imageUser ,Statut=@Statut  Where ID_USER_WORK=@ID_USER_WORK", con);
            cmd.Parameters.AddWithValue("@Nom_USER_WORK", TxtLast.Text);
            cmd.Parameters.AddWithValue("@Prenom_USER_WORK", Txtfirst.Text);
            cmd.Parameters.AddWithValue("@username_USER_WORK", Username.Text);
            cmd.Parameters.AddWithValue("@CIN_USER_WORK", TxtCin.Text);
            cmd.Parameters.AddWithValue("@Email_USER_WORK", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone_USER_WORK", TxtTele.Text);
            cmd.Parameters.AddWithValue("@Statut",statu);
            cmd.Parameters.AddWithValue("@Password_USER_WORK", TxtPass.Text);
            cmd.Parameters.AddWithValue("@imageUser", arr);
            cmd.Parameters.AddWithValue("@ID_USER_WORK", LblidUser.Text);
            cmd.ExecuteNonQuery();
            
            remplirLayoutProduct();

            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            remplirLayoutProduct();
            ClearTextFields();
            WindowState = FormWindowState.Maximized;
        }
        //Remplir layout
        private void remplirLayoutProduct()
        {
            Users_Panel.Controls.Clear();
            DataTable dt = Operations_reda.getAllUsers();
            PictureBox pic = new PictureBox();
            pic.Image = null;
            

            String LUname= Txtfirst.Text.Trim();
            String Funame=TxtLast.Text.Trim();
            String username = Username.Text.Trim();
            String Ustatut=Statut_combo.Text.Trim();
            String Ucin=TxtCin.Text.Trim();
            String Utele=TxtTele.Text.Trim();
            String Uemail=TxtEmail.Text.Trim();
            String Upassword=TxtPass.Text.Trim();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LUname = dt.Rows[i][1].ToString();
                Funame = dt.Rows[i][2].ToString();
                Ucin = dt.Rows[i][4].ToString();
                Uemail = dt.Rows[i][5].ToString();
                Utele = dt.Rows[i][6].ToString();
                Ustatut = dt.Rows[i][7].ToString();
                Upassword = dt.Rows[i][8].ToString();
                username = dt.Rows[i][3].ToString();


                byte[] img = (byte[])(dt.Rows[i][9]);
                if (img == null)
                    pic.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic.Image = Image.FromStream(ms);

                }

                Components.Serveur controle_user = new Components.Serveur(LUname, Funame, username,Ustatut, Ucin,Utele, Uemail, Upassword, pic);
                Users_Panel.Controls.Add(controle_user);
            }
        }
        //Supprimer les infos
        private void DeleteBut_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from USER_WORK  Where ID_USER_WORK=@ID_USER_WORK ", con);
            cmd.Parameters.AddWithValue("@ID_USER_WORK", LblidUser.Text);
            cmd.ExecuteNonQuery();
            PicUser.Image = null;
            TxtLast.Text = "";
            Txtfirst.Text = "";
            Username.Text = "";
            TxtEmail.Text = "";
            TxtTele.Text = "";
            Statut_combo.Text = "";
            TxtPass.Text = "";

            LblidUser.Text = "";

            con.Close();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void bunifuGradientPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void bunifuGradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
