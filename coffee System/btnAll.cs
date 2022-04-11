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
    public partial class btnAll : UserControl
    {
        bool isarticle;
        public btnAll(bool isArticle)
        {
            InitializeComponent();
            isarticle = isArticle;
        }

        private void btncoffee_Click(object sender, EventArgs e)
        {
            if(isarticle==true)
            Program.art.remplirLayoutProduct();
            else
                Program.tabbord.remplirLayoutProduct(); 
        }
    }
}
