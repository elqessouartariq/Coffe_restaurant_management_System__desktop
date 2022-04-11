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
        public static bool filter = false;
        public static long ID;
        public static long id_perssone_reglement = Program.login2.iduser;
   
        public static int id_server;
        public static string montant;
        private void cancelreglementbtn_Click(object sender, EventArgs e)
        {
            if (montant != "" && id_perssone_reglement != 0 && id_server != 0 && ID != 0 )
            {
                Operation_tariq.insertcredit(montant, id_perssone_reglement, id_server, ID);
                this.reglement_MoreTableAdapter.Fill(this.dBTD_CoffeeManagement.Reglement_More);
                Program.cr.refreshCredit();
            }
        }
        private void Reglement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTD_CoffeeManagement.Reglement_More' table. You can move, or remove it, as needed.
            this.reglement_MoreTableAdapter.Fill(this.dBTD_CoffeeManagement.Reglement_More);
            lblusername.Text = Operations.getNameUser(id_perssone_reglement);
            filter = false;
            Servercombobox.DataSource = Operation_tariq.GetAllservers();
            Servercombobox.DisplayMember = "Nom_USER_WORK";
            Servercombobox.ValueMember = "Nom_USER_WORK";
        }
        private void ReglementFilterbtn_Click(object sender, EventArgs e)
        {
            filter = true;
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
                reglementMoreBindingSource.Filter = string.Empty;
            }  
            else
            {
                reglementMoreBindingSource.Filter = string.Format("Nom_USER_WORK like '*{0}*'", Servercombobox.Text);
            }
        }
        public void filterBydate()
        {
            if (filter = false)
            {
                reglementMoreBindingSource.Filter = string.Empty;
            }
            else
            {
                String Date = Reglementdate.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                reglementMoreBindingSource.Filter = string.Format("Date_reg = #" + Date + "# ");
            }
        }
        public void filterBoth()
        {
            if (filter = false)
            {
                reglementMoreBindingSource.Filter = string.Empty;
            }
            else
            {
                String Date = Reglementdate.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                reglementMoreBindingSource.Filter = string.Format("Nom_USER_WORK like '*{0}*' AND Date_reg = #" + Date + "# ", Servercombobox.Text);
            }
        }
        private void CancelReglementFilterbtn_Click(object sender, EventArgs e)
        {
            reglementMoreBindingSource.Filter = string.Empty;

            Servercheckbox.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)CheckState.Checked;
            
            Datecheckbox.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)CheckState.Checked;
        }
        private void ReglementDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(ReglementDatagrid.Rows[ReglementDatagrid.CurrentRow.Index].Cells[0].Value);
            montant = ReglementDatagrid.Rows[ReglementDatagrid.CurrentRow.Index].Cells[5].Value.ToString();
            id_server = Convert.ToInt32(ReglementDatagrid.Rows[ReglementDatagrid.CurrentRow.Index].Cells[1].Value);
            //id_admin = Convert.ToInt32(ReglementDatagrid.Rows[ReglementDatagrid.CurrentRow.Index].Cells[2].Value);

        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
