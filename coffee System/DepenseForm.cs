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
    public partial class DepenseForm : Form
    {
        public DepenseForm()
        {
            InitializeComponent();
            
        }
        public static int ID_Depense;
        public static String stats = "admin";//to check if it was an admin /cashier...or not --notice need to do it in login forme
        public static long ID = 3;//id admin in need 
        public static bool filter = false;
        private void add_Depensebtn_Click(object sender, EventArgs e)
        {
            if(stats == "admin")
            {
            //need to add id_user admin tracabilites
            String libelle= libelletxtbox.Text;
            String descreption=descriptiontxtbox.Text;
            String depensedate = depensedatepicker.Value.ToString("yyyy-MM-dd");
            String pricedepense = pricedepensetxt.Text;

            Operation_tariq.insertdepense(libelle, descreption, depensedate, pricedepense,ID);
                //Fill_DataGridView();
                refresh_depense_form();
            }
            
        }
        private void update_depensebtn_Click(object sender, EventArgs e)
        {
            if (stats == "admin")
            {
                String libelle = libelletxtbox.Text;
                String descreption = descriptiontxtbox.Text;
                String depensedate = depensedatepicker.Value.ToString("yyyy-MM-dd");
                String pricedepense = pricedepensetxt.Text;
                Operation_tariq.updatedepense(ID_Depense,libelle, descreption, depensedate, pricedepense, ID);
                //Fill_DataGridView();
                refresh_depense_form();
            }
        }
        private void DepenseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTD_CoffeeManagement.Depense' table. You can move, or remove it, as needed.
            this.depenseTableAdapter.Fill(this.dBTD_CoffeeManagement.Depense);
            //Fill_DataGridView();
          
        }
        private void libelletxtbox_Click(object sender, EventArgs e)
        {
            libelletxtbox.Text = String.Empty;
        }
        private void descriptiontxtbox_Click(object sender, EventArgs e)
        {
            descriptiontxtbox.Text = String.Empty;  
        }
        private void pricedepensetxt_Click(object sender, EventArgs e)
        {
            pricedepensetxt.Text = String.Empty;
        }
        private void Depensedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Depense  = Convert.ToInt32(Depensedatagrid.Rows[Depensedatagrid.CurrentRow.Index].Cells[0].Value);
            libelletxtbox.Text= Depensedatagrid.Rows[Depensedatagrid.CurrentRow.Index].Cells[1].Value.ToString();
            descriptiontxtbox.Text = Depensedatagrid.Rows[Depensedatagrid.CurrentRow.Index].Cells[2].Value.ToString();
            depensedatepicker.Value = ((DateTime)Depensedatagrid.Rows[Depensedatagrid.CurrentRow.Index].Cells[3].Value);
            pricedepensetxt.Text = Depensedatagrid.Rows[Depensedatagrid.CurrentRow.Index].Cells[4].Value.ToString(); 
        }
        public  void Fill_DataGridView()
        {
            DataTable dt = Operation_tariq.Display_Depenses();
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Depensedatagrid.Rows.Add();
                Depensedatagrid.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                Depensedatagrid.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[3];
                Depensedatagrid.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[4];
                Depensedatagrid.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[1];
                Depensedatagrid.Rows[i].Cells[4].Value = dt.Rows[i].ItemArray[2];
            }
        }
        private void delete_Depensebtn_Click(object sender, EventArgs e)
        {
            if (stats == "admin")
            {
                Operation_tariq.deletedepense(ID_Depense);
                refresh_depense_form();
            }
        }
        public  void refresh_depense_form()
        {
            this.depenseTableAdapter.Fill(this.dBTD_CoffeeManagement.Depense);
        }
        private void CanceldepenseFilterbtn_Click(object sender, EventArgs e)
        {
            filter = false;
            depenseBindingSource.Filter = string.Empty;
        }
        private void Depensesearchtxt_TextChange(object sender, EventArgs e)
        {
            if (filter == false)
            {
                depense_search();
            }
            else
            {
                String start = startdatedepense.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                String end = enddatedepenese.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                depense_search(start,end);
            }  
        }
        public void depense_search(String start ="", String end ="")
        {
            if(start == "" ||  end == "")
            {
                if (string.IsNullOrEmpty(Depensesearchtxt.Text))
                depenseBindingSource.Filter = string.Empty;
                else
                {
                depenseBindingSource.Filter = string.Format(" Libelle like '*{0}*'  or  (Convert(dep_Date, 'System.String')) like '*{0}*' or (Convert(Montant, 'System.String')) like '*{0}*' or dep_description like '*{0}*' ", Depensesearchtxt.Text.ToString());
                }
            }
            else
            {
               if(string.IsNullOrEmpty(Depensesearchtxt.Text))
               depenseBindingSource.Filter = string.Format("dep_Date <= #" + end +"# AND  dep_Date >= #" + start + "#");
                else
                {
                depenseBindingSource.Filter = string.Format(" (Libelle like '*{0}*'  or  (Convert(dep_Date, 'System.String')) like '*{0}*' or (Convert(Montant, 'System.String')) like '*{0}*' or dep_description like '*{0}*' ) And (dep_Date <= #" + end + "# AND dep_Date >= #" + start + "#)", Depensesearchtxt.Text.ToString());
                }
            }   
            
        }
        private void DepenseFilterbtn_Click(object sender, EventArgs e)
        {
            filter = true;
            check_dates();
            String start = startdatedepense.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            String end = enddatedepenese.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            depense_search(start, end);
        }
        public void check_dates()
        {
            if (startdatedepense.Value.Date.CompareTo(enddatedepenese.Value.Date)>0)
            {
                filter=false;
                MessageBox.Show("END Date should Be GREATER OR EQUAL TO START DATE !!!", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
