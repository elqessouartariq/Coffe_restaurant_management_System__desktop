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
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        private void Creditbtn_Click(object sender, EventArgs e)
        {
            //instansiate Credit obj
            Credit cd =new Credit();
            cd.Visible = true;
        }

        private void depensebtn_Click(object sender, EventArgs e)
        {
            DepenseForm dp =new DepenseForm();
            dp.Visible = true;
            
        }

        private void recipebtn_Click(object sender, EventArgs e)
        {
            Recipe rp =new Recipe();
            rp.Visible = true;
        }

        private void articlebtn_Click(object sender, EventArgs e)
        {
            Article ar =new Article();
            ar.Visible = true;
        }
    }
}
