using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace coffee_System.Components
{
    public partial class Serveur : UserControl
    {
        public long idUser;
        public Serveur(String luname,String funame,String username,String ustatut,String ucin,String utele,String uemail,String upassword ,PictureBox image)
        {
            InitializeComponent();
            LblLast.Text=luname;
            LblFirst.Text=funame;
            LblUser.Text=username;
            LblStatut.Text=ustatut;
            LblCin.Text=ucin;
            LblTele.Text=utele;
            LblEmail.Text=uemail;
            LblPass.Text=upassword;
            User_Pic.Image = image.Image;
            idUser=Operations.getIDUser(LblLast.Text,LblFirst.Text);
        }
        public void remplirTextFields()
        {
            Program.user.ClearTextFields();
            Program.user.remplirTextFields(idUser,LblFirst.Text, LblLast.Text, LblCin.Text, LblEmail.Text, LblTele.Text, LblPass.Text,User_Pic.Image,LblStatut.Text) ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            remplirTextFields();
        }

        private void bunifuShadowPanel1_Click(object sender, EventArgs e)
        {
            remplirTextFields();
        }

        private void Serveur_Click(object sender, EventArgs e)
        {
            remplirTextFields();
        }
    }
}
