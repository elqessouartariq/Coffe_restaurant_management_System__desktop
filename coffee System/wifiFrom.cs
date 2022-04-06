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
    public partial class wifiFrom : Form
    {
        public wifiFrom()
        {
            InitializeComponent();
        }

        private void wifiFrom_Load(object sender, EventArgs e)
        {
            DataTable dt = Operations.infoWifi();

            txtNameWifi.Text = dt.Rows[0][0].ToString();
            txtPassWifi.Text= dt.Rows[0][1].ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Operations.updateWifi(txtNameWifi.Text, txtPassWifi.Text);
        }
    }
}
