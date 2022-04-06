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
    public partial class Recipe : Form
    {
        int mov;
        int movX;
        int movY;
        public long  idcashier=1;
        public Recipe()
        {
            InitializeComponent();
            lblusername.Text = Operations.getNameUser(idcashier);
        }
        public void CalculCredit()
        {
            if (txtadvanceamount.Text != "" && txtserverpayment.Text != "")
            {
                double total;
                double rest = 0;
                double advanced;
                double paid;
                total = Operations.getTotalRecipe(idcashier, long.Parse(cmbserver.SelectedValue.ToString()), startdate.Value, enddate.Value);
                advanced = double.Parse(txtadvanceamount.Text);
                paid = double.Parse(txtserverpayment.Text);
                rest = total + advanced - paid;
                txttotal.Text = total.ToString();
                txtrest.Text = rest.ToString();
            }

        }
        private void remplircmbServer()
        {
            DataTable dt = Operations.getAllServer();
            cmbserver.DataSource = dt;
            cmbserver.DisplayMember = "name";
            cmbserver.ValueMember = "ID_USER_WORK";
        }
        private void checkDate()
        {
            DateTime dtend = enddate.Value;
            DateTime dtstart = startdate.Value;
            if (DateTime.Compare(dtend,dtstart) < 0)
            {
                MessageBox.Show("Start Date should be earlier than End date !!", "Warning Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startdate.Value = enddate.Value;
            }
            else
                remplirGridRecipe();
        }
        private void remplirGridRecipe()
        {
            CalculCredit();
            if (txttotal.Text != "0")
            {
                gridrecipe.Rows.Clear();
                gridrecipe.AutoGenerateColumns = false;
                long idserver = long.Parse(cmbserver.SelectedValue.ToString());
                DataTable dt = Operations.RecipeTable(startdate.Value, enddate.Value, idserver, idcashier);
                int i = 0;
                foreach (DataRow r in dt.Rows)
                {
                    gridrecipe.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
                }
            }
            else
            {
                gridrecipe.Rows.Clear();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*select Description_pro,Qte,Total,Date_com,Nom_USER_WORK+' '+Prenom_USER_WORK as'Server'
    from DETAIL,Product,COMMANDE,USER_WORK
    where DETAIL.ID_com=COMMANDE.ID_com and DETAIL.ID_Product=Product.ID_pro and COMMANDE.id_USER_WORK_SERVER=USER_WORK.ID_USER_WORK*/


        private void reduite_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Recipe_Load(object sender, EventArgs e)
        {
            //remplir combo server
            remplircmbServer();
          
            //initialiser les dates
            enddate.Value = DateTime.Now;
            startdate.Value = DateTime.Now.AddDays(-1);
            //remplirGridRecipe();


        }

        private void enddate_onValueChanged(object sender, EventArgs e)
        {
            checkDate();
        }

        private void startdate_onValueChanged(object sender, EventArgs e)
        {
            checkDate();
        }

        private void btnvalidated_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sure you want to add the credit ?","Credit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Operations.insertCredit(long.Parse(cmbserver.SelectedValue.ToString()),idcashier,double.Parse(txtrest.Text));
                txtadvanceamount.Text = "0";
                txtrest.Text = "0";
                txtserverpayment.Text = "0";
            }
        }

        private void txtadvanceamount_TextChanged(object sender, EventArgs e)
        {
            errnotNumeric.Clear();
            if (double.TryParse(txtadvanceamount.Text,out double a))
            {
                CalculCredit();
                btnvalidated.Enabled = true;
                
            }
            else
            {
                errnotNumeric.SetError(txtadvanceamount, "Must you insert Numeric Value!");
                btnvalidated.Enabled = false;
            }
            
        }

        private void txtserverpayment_TextChanged(object sender, EventArgs e)
        {
            errnotNumeric2.Clear();
            if (double.TryParse(txtserverpayment.Text, out double a))
            {
                CalculCredit();
                btnvalidated.Enabled = true;
            }
            else
            {
                errnotNumeric2.SetError(txtserverpayment, "Must you insert Numeric Value!");
                btnvalidated.Enabled = false;
            }
        }

        private void cmbserver_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txtrest_TextChanged(object sender, EventArgs e)
        {
            if (txtrest.Text == "0")
                btnvalidated.Enabled = false;
            else
                btnvalidated.Enabled = true;
        }

        private void cmbserver_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbserver_TextChanged(object sender, EventArgs e)
        {
           // remplirGridRecipe();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbserver_SelectionChangeCommitted(object sender, EventArgs e)
        {
            remplirGridRecipe();
        
        }
    }
}
