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
        static public Credit cr;
        static public Settings_form settings; 
        static public Login2 login2;
        static public Login1 login1;
        static public Form2 user;
        static public long idUser;
        static public string statut;

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
            login2= new Login2();
            login1 = new Login1();
            cr = new Credit();
            settings = new Settings_form();
            user = new Form2();
            Application.Run(login1);

        }
    }
}
