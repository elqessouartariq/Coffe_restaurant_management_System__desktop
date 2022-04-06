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
    public partial class add_into_db_users : Form
    {
        public add_into_db_users()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dialog.FileName.ToString();
                user_pic.ImageLocation = imagelocation;
            }


        }

        private void insert_user_Click(object sender, EventArgs e)
        {
            byte[] images = Operation_tariq.ImageToByteArray(user_pic.Image);
            String Nomuser = nom.Text.Trim();
            String Prenom = prenom.Text.Trim();
            String user = username.Text.Trim();
            String Cin = cin.Text.Trim();
            String Email = email.Text.Trim();
            String Phone = phone.Text.Trim();
            String Status = status.Text.Trim();
            String Pass = passwd.Text.Trim();

            Operation_tariq.insertuser(Nomuser,Prenom,user,Cin,Email,Phone,Status,Pass,images);
        }

        private void add_into_db_users_Load(object sender, EventArgs e)
        {

        }
    }
}
