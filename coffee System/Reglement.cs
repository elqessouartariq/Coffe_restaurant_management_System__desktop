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
    public partial class Reglement : Form
    {
        public Reglement()
        {
            InitializeComponent();
        }

        private void cancelreglementbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
