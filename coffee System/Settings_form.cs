using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public static String stats="admin";//to check if it was an admin /cashier...or not --notice need to do it in login forme
        public static long ID = 3;//id admin in need 

        private void Creditbtn_Click(object sender, EventArgs e)
        {
            //instansiate Credit obj
           
            Program.cr.Visible = true;
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

        private void Settings_form_Load(object sender, EventArgs e)
        {
            if (stats == "admin")
            {
                Add_Profile_into_Panel(ID);
                count_earning_day();
                count_earning_month();
                count_earning_year();
                showstatistics(int.Parse(statisticsdatepicker.Text));
            }
            
        }
        public void showstatistics(int date)
        {
           
            //Diagramme columns
           // EarningPerMonth.ChartAreas[0].AxisX.Maximum = 12;
            
            EarningPerMonth.DataSource = Operation_tariq.statistique(date);
            EarningPerMonth.Series["Months"].XValueMember = "month";
            EarningPerMonth.Series["Months"].XValueType =System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            EarningPerMonth.Series["Months"].YValueMembers = "total";
            EarningPerMonth.Series["Months"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //EarningPerMonthPie
            EarningPerMonthPie.DataSource = Operation_tariq.statistiquepie(date);
            EarningPerMonthPie.Series["Series1"].XValueMember = "ServerName"; 
            EarningPerMonthPie.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            EarningPerMonthPie.Series["Series1"].YValueMembers = "Total";
            EarningPerMonthPie.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //earninglinechart
            earninglinechart.DataSource = Operation_tariq.statistiqueTopSales(date);
           // earninglinechart.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            earninglinechart.Series["Products"].XValueMember = "Product";
            earninglinechart.Series["Products"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            earninglinechart.Series["Products"].YValueMembers = "total";
            earninglinechart.Series["Products"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

        }
        private void Add_Profile_into_Panel(long ID)

        {
            Profile_Panel.Controls.Clear();
            DataTable dt = Operation_tariq.GetProfile(ID);
           
            PictureBox pic = new PictureBox();
            pic.Image = null;
            
            
            
            String Name;
            
                
                Name = dt.Rows[0][1].ToString();
                byte[] img = (byte[])(dt.Rows[0][9]);
                if (img == null)
                    pic.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic.Image = Image.FromStream(ms);

                }
            adminnamelbl.Text = Name;
            Settings.Profile profile_Controle = new Settings.Profile(Name, pic);
                
                Profile_Panel.Controls.Add(profile_Controle);
        }
        private void count_earning_day()
        {
            String Earning_day=Operation_tariq.Getearning_day();
            Total_earning_counter_day.Text = Earning_day;
        }
        private void count_earning_month()
        {
            String Earning_month = Operation_tariq.Getearning_month();
            Total_earning_counter_month.Text = Earning_month;
        }
        private void count_earning_year()
        {
            String Earning_year = Operation_tariq.Getearning_year();
            Total_earning_counter_year.Text = Earning_year;
        }
        private void statisticsdatepicker_ValueChanged(object sender, EventArgs e)
        {
            showstatistics(int.Parse(statisticsdatepicker.Text));
        }

    }
}
