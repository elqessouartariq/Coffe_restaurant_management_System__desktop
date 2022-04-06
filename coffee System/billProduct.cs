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
    public partial class billProduct : UserControl
    {
        public billProduct(string namePro,int qte,double mnt)
        {
            InitializeComponent();
            lblproduct.Text = namePro;
            lblMontant.Text = mnt + "";
            lblQte.Text = qte + "";
        }

        private void billProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
