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
        public static long ID;
        public static long id_admin;
        public static int id_server ;
        public static string montant;
        public static string status;
        public static bool filter = false;
        private void Reglerbtn_Click(object sender, EventArgs e)    
        {
            if (montant != "" && id_admin != 0 && id_server != 0 && ID != 0)
            {
             Operation_tariq.insertreglement(montant, id_admin, id_server,ID);
             this.cREDIT_DGINFOTableAdapter.Fill(this.dBTD_CoffeeManagement.CREDIT_DGINFO);
            }
        }
        private void Credit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTD_CoffeeManagement.CREDIT_DGINFO' table. You can move, or remove it, as needed.
            this.cREDIT_DGINFOTableAdapter.Fill(this.dBTD_CoffeeManagement.CREDIT_DGINFO);
           
            id_admin = Program.idUser;
            status = Program.statut;
            filter = false;
            //lblusername.Text = Operations.getNameUser(Program.idUser);
            //load servers combobox
            Servercombobox.DataSource = Operation_tariq.GetAllservers();
            Servercombobox.DisplayMember = "Nom_USER_WORK";
            Servercombobox.ValueMember = "Nom_USER_WORK";
        }
        private void CreditDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(CreditDatagrid.Rows[CreditDatagrid.CurrentRow.Index].Cells[0].Value);
            montant = CreditDatagrid.Rows[CreditDatagrid.CurrentRow.Index].Cells[5].Value.ToString();
            id_server = Convert.ToInt32(CreditDatagrid.Rows[CreditDatagrid.CurrentRow.Index].Cells[1].Value);
        }
        private void Afficherreglementbtn_Click(object sender, EventArgs e)
        {
            Reglement rg = new Reglement();
            rg.Visible = true;
        }
        private void CancelCreditFilterbtn_Click(object sender, EventArgs e)
        {
            cREDITDGINFOBindingSource.Filter = string.Empty;

            Servercheckbox.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)CheckState.Checked;

            Datecheckbox.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)CheckState.Checked;
        }
        private void CreditFilterbtn_Click(object sender, EventArgs e)
        {
            filter = true;
            if (Servercheckbox.CheckState.ToString() == "Checked" && Datecheckbox.CheckState.ToString() == "Unchecked")
            {
                filterByServer();
            }
            if (Datecheckbox.CheckState.ToString() == "Checked" && Servercheckbox.CheckState.ToString() == "Unchecked")
            {
                filterBydate();
            }
            if (Datecheckbox.CheckState.ToString() == "Checked" && Servercheckbox.CheckState.ToString() == "Checked")
            {
                filterBoth();
            }
        }
        public void filterByServer()
        {
            if (filter = false)
            {
                cREDITDGINFOBindingSource.Filter = string.Empty;
            }
            else
            {
                cREDITDGINFOBindingSource.Filter = string.Format("Nom_USER_WORK like '*{0}*'", Servercombobox.Text);
            }
        }
        public void filterBydate()
        {
            if (filter = false)
            {
                cREDITDGINFOBindingSource.Filter = string.Empty;
            }
            else
            {
                String Date = Creditdate.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                cREDITDGINFOBindingSource.Filter = string.Format("Date_cre = #" + Date + "# ");
            }
        }
        public void filterBoth()
        {
            if (filter = false)
            {
                cREDITDGINFOBindingSource.Filter = string.Empty;
            }
            else
            {
                String Date = Creditdate.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                cREDITDGINFOBindingSource.Filter = string.Format("Nom_USER_WORK like '*{0}*' AND Date_cre = #" + Date + "# ", Servercombobox.Text);
            }
        }
        public void refreshCredit()
        {
            this.cREDIT_DGINFOTableAdapter.Fill(this.dBTD_CoffeeManagement.CREDIT_DGINFO);
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreditDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
