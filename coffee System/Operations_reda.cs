using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace coffee_System
{
    internal class Operations_reda
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-63TK96G\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True");
        public static DataTable getAllUsers()
        {
            DataTable dt = new DataTable();
            string desing = "select * from USER_WORK";
            SqlCommand cmd = new SqlCommand(desing, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            sd.Fill(dt);
            return dt;
        }
    }

}

