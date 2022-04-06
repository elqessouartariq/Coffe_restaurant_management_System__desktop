using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    public partial class PrintForm : Form
    {
        public DataTable ProductBillData;
        public string total;
        public string server;
        public string date;
        public string time;
        public PrintForm(DataTable dt,string Total,string waiter)
        {
            InitializeComponent();
            this.ProductBillData = dt;
            this.total= Total;
            server = waiter;
            date = DateTime.Now.ToString("dd/MM/yyyy");
            time = DateTime.Now.ToString("HH:mm");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblServeur_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void layoutBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void billProduct1_Load(object sender, EventArgs e)
        {

        }

        private void billProduct2_Load(object sender, EventArgs e)
        {

        }

        private void billProduct4_Load(object sender, EventArgs e)
        {

        }

        private void billProduct3_Load(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PrintForm_Load(object sender, EventArgs e)

        {
            DataTable dt = Operations.infoWifi();
            lblnomwifi.Text= dt.Rows[0][0].ToString();
            lblpassword.Text= dt.Rows[0][1].ToString();
            layoutBill.Size = new System.Drawing.Size(layoutBill.Width, 0);
           
            foreach (DataRow row in ProductBillData.Rows)
            {
                layoutBill.Size = new System.Drawing.Size(layoutBill.Width, layoutBill.Height + 40);
                billProduct pro = new billProduct(row[0].ToString(),int.Parse(row[1].ToString()),double.Parse(row[2].ToString()));
                layoutBill.Controls.Add(pro);
            }
            lbltotal.Text = this.total;
            lblServeur.Text = server;
            lbldate.Text = date;
            lbltime.Text = time;
            panel2.Location = new System.Drawing.Point(panel2.Location.X, layoutBill.Location.Y + layoutBill.Height + 20);

        }
        
        private void Print(Panel pnl) {
                    btnPrint.Visible = false;
                     PrinterSettings ps = new PrinterSettings();
                     panel1 = pnl;
                     getprintarea(pnl);
                     printPreviewDialog1.Document = printDocument1;
                     printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                     printDocument1.DefaultPageSettings.PaperSize=new System.Drawing.Printing.PaperSize("panel1",panel1.Width, panel1.Height);
                     printPreviewDialog1.ShowDialog();    
                }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea =e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2),panel1.Location.Y);
        }

        private Bitmap memoryimg; 
        
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
    

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(panel1);
        }
    }
}
