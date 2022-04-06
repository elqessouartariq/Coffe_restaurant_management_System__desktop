using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_System
{
    internal static class Program
    {

        static public Article art;
        static public tableaubord tabbord;
        static public Recipe rcp;
        static public PrintForm prf;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            art = new Article();
            tabbord = new tableaubord();   
            rcp=new Recipe();
            Application.Run(tabbord);
        }
    }
}
