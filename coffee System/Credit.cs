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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void Reglerbtn_Click(object sender, EventArgs e)
        {
            Reglement rg =new Reglement();
            rg.Visible = true;
        }
    }
}
