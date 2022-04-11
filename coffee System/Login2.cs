using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    public partial class Login2 : Form
    {
        public long iduser=2;
        public string status="";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-63TK96G\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True");
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Login2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicLog_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "if('" + TxtUser.Text.Trim() + "' in (select username_USER_WORK from USER_WORK where Password_USER_WORK='" + TxtPass.Text.Trim() + "')) select 1 else select 0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr=cmd.ExecuteReader();
            dr.Read();
            int m=int.Parse(dr[0].ToString());
            if (TxtUser.Text == "" || TxtPass.Text == "")
            {
                MessageBox.Show("Require Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            else if (m == 0)
            {
                MessageBox.Show("Either your Username or Passwordis false", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }else if (m == 1)   {
                Program.idUser = Operations.getIDUser(TxtUser.Text);  
                this.iduser = Program.idUser;
               // Program.statut = Operations.getStatusUser(iduser);
                Program.statut = Operations.getStatusUser(Program.idUser);
                if (Program.statut.ToLower() == "admin")
                {
                    Program.settings = new Settings_form();
                    Program.settings.Show();
                }
                else {
                    Program.tabbord = new tableaubord();
                    Program.tabbord.Show();
                }
               
                this.Hide();

            }
            con.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtPass.isPassword = false;
            }
            else
                TxtPass.isPassword = true;

        }
    }
}
