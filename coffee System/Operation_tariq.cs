using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace coffee_System
{
    internal class Operation_tariq
    {
        public static SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-63TK96G\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True");
        public static void testconnection()
        {
            try
            {
                conx.Open();
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message+"\nMake sure your Connection String is Correct !!");
            }
            finally
            {
                conx.Close();
            }

        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public static void insertuser(String Nomuser, String Prenom, String user, String Cin, String Email, String Phone, String Status, String Pass, byte[] images)
        {
            testconnection();

            int affected_rows = 0;
            
            conx.Open();
            
                string profile = "insertUser";
                SqlCommand cmd = new SqlCommand(profile, conx);
                cmd.CommandType = CommandType.StoredProcedure;
               //// @uname varchar(150),@pname varchar(150),@user varchar(150),@cin varchar(15),@email varchar(150),@phone varchar(13),@status varchar(50),@pass varchar(150),@image image


                cmd.Parameters.AddWithValue("@uname", Nomuser);
                cmd.Parameters.AddWithValue("@pname", Prenom);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@cin", Cin);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@status", Status);
                cmd.Parameters.AddWithValue("@pass", Pass);
                cmd.Parameters.AddWithValue("@image", images);

            
            affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows == 0)
                    MessageBox.Show("User not insert !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("User insert Successfully !", "Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            conx.Close();
        }
        public static DataTable GetProfile(long id)
        {
            testconnection();
            DataTable dt = new DataTable();
            string profile = "select * from USER_WORK where "+id+"=ID_USER_WORK";
            SqlCommand cmd = new SqlCommand(profile, conx);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            return dt;
        }
        public static String Getearning_day()
        {
            testconnection();

            String total_day;

            conx.Open();
            SqlCommand cmd = conx.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TotalearningParJour";

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            
            if(rdr[0] == DBNull.Value)
            {
                total_day = "0.00";
            }
            else
            {
               total_day = String.Format("{0:0.00}", rdr[0]);
            }

            rdr.Close();
            conx.Close();

            return total_day;
        }
        public static String Getearning_month()
        {
            testconnection();

            String total_month;

            conx.Open();
            SqlCommand cmd = conx.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TotalearningParMois";

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            if (rdr[0] == DBNull.Value)
            {
                total_month = "0.00";
            }
            else
            {
                total_month = String.Format("{0:0.00}", rdr[0]);
            }
                
            rdr.Close();
            conx.Close();

            return total_month;
        }
        public static String Getearning_year()
        {
            testconnection();

            String total_year;

            conx.Open();
            SqlCommand cmd = conx.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TotalearningParYear";

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();


            if (rdr[0] == DBNull.Value)
            {
                total_year = "0.00";
            }
            else
            {
            total_year = String.Format("{0:0.00}", rdr[0]);
            }

            rdr.Close();
            conx.Close();

            return total_year;
        }
        public static void insertdepense(String libelle,String descreption ,String depensedate ,String pricedepense,long id) 
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();

            string proc = "insertDepense";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;
            


            cmd.Parameters.AddWithValue("@dep_Date", depensedate);
            cmd.Parameters.AddWithValue("@Montant", pricedepense);
            cmd.Parameters.AddWithValue("@Libelle", libelle);
            cmd.Parameters.AddWithValue("@dep_description", descreption);
            cmd.Parameters.AddWithValue("@id_USER_WORK_ADMIN", id);
       


            affected_rows = cmd.ExecuteNonQuery();
            if (affected_rows == 0)
                MessageBox.Show("Depense not insert !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Depense insert Successfully !", "Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conx.Close();
        }
        public static void updatedepense(int ID_Depense,String libelle, String descreption, String depensedate, String pricedepense, long id)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();

            string proc = "updateDepense";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id_depense", ID_Depense);
            cmd.Parameters.AddWithValue("@dep_Date", depensedate);
            cmd.Parameters.AddWithValue("@Montant", pricedepense);
            cmd.Parameters.AddWithValue("@Libelle", libelle);
            cmd.Parameters.AddWithValue("@dep_description", descreption);
            cmd.Parameters.AddWithValue("@id_USER_WORK_ADMIN", id);



            affected_rows = cmd.ExecuteNonQuery();
            if (affected_rows == 0)
                MessageBox.Show("Depense not Updated !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Depense Updated Successfully !", "Updating ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conx.Close();
        }
        public static void deletedepense(int id)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();

            string proc = "deleteDepense";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_dep",id);
      
            affected_rows = cmd.ExecuteNonQuery();
            if (affected_rows == 0)
                MessageBox.Show("Depense Deleted Failed!", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Depense Deleted Successfully !", "Deleting ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conx.Close();
        }
        public static DataTable Display_Depenses()
        {
            testconnection();
            conx.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select *  from Depense", conx);
            adapt.Fill(dt);
            conx.Close();
            return dt;
        }
        public static DataTable Search_Depenses(String search)
        {
            testconnection();
            conx.Open();
            DataTable dt = new DataTable();
            String querry= "select *  from Depense where  Libelle like '%"+search+"%' or dep_Date like '%" + search + "%' or dep_description like '%" + search + "%' or Montant like '%" + search + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(querry, conx);
            adapt.Fill(dt);
            conx.Close();
            return dt;
        }
        public static void deletecredit(long id)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();
            string proc = "deletecredit";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id_credit", id);
        

            affected_rows = cmd.ExecuteNonQuery();
       
            if (affected_rows == 0)
                MessageBox.Show("Credit FIXED FAILED  !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Credit  FIXED  Successfully !", "Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conx.Close();
        }
        public static void deleteReglement(long id)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();
            string proc = "deletereglement";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id_reglement", id);


            affected_rows = cmd.ExecuteNonQuery();

            if (affected_rows == 0)
                MessageBox.Show("Reglement Canceled FAILED  !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Reglement Canceled  Successfully !", "Canceling ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conx.Close();
        }
        public static void insertreglement(String montant ,int id_admin, int id_server,long ID)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();

            string proc = "insertReglement";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;
            

            cmd.Parameters.AddWithValue("@idUserServer", id_server);
            cmd.Parameters.AddWithValue("@idUserAdmin", id_admin);
            cmd.Parameters.AddWithValue("@total", montant);
       
            affected_rows = cmd.ExecuteNonQuery();
            conx.Close();
            deletecredit(ID);
        }
        public static void insertcredit(String montant, int id_cashier, int id_server, long ID)
        {
            testconnection();

            int affected_rows = 0;

            conx.Open();

            string proc = "insertCredit";
            SqlCommand cmd = new SqlCommand(proc, conx);
            cmd.CommandType = CommandType.StoredProcedure;

            
            cmd.Parameters.AddWithValue("@idUserServer", id_server);
            cmd.Parameters.AddWithValue("@idUserCashier", id_cashier);
            cmd.Parameters.AddWithValue("@total", montant);

            affected_rows = cmd.ExecuteNonQuery();
            conx.Close();
            deleteReglement(ID);
        }
        public static DataTable statistique(int date = 2022)
        {
            testconnection();
            conx.Open();    
            string query = "select MONTH(Date_com) as 'month',sum(Total_com) as 'total' from COMMANDE where year(Date_com) = '"+date+"' group by MONTH(Date_com)";
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conx);
            adapt.Fill(dt);
            conx.Close();
            return dt;
        }
        public static DataTable statistiquepie(int date = 2022)
        {
            testconnection();
            conx.Open();
            string query = "select sum(Total_com) * 1.0 / (select sum(Total_com) from COMMANDE C inner join USER_WORK U on C.ID_com = U.ID_USER_WORK where YEAR(C.Date_com) ='" + date + "' ) as 'Total' ,U.Nom_USER_WORK as 'ServerName' from COMMANDE C inner join USER_WORK U on C.ID_com = U.ID_USER_WORK where YEAR(C.Date_com) ='" + date + "' Group by U.Nom_USER_WORK";

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conx);
            adapt.Fill(dt);
            conx.Close();
            return dt;
        }
        public static DataTable statistiqueTopSales(int date = 2022)//top 4 sales 
        {
            testconnection();
            conx.Open();
            string query = "select  top 4  sum (D.Total) as 'Total',  P.Description_pro as 'Product' from (COMMANDE C inner join DETAIL D on C.ID_com =D.ID_com ) inner join Product P on D.ID_Product = P.ID_pro where YEAR(C.Date_com)= YEAR('" + date + "') group by P.Description_pro order by sum (D.Total) desc";

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conx);
            adapt.Fill(dt);
            conx.Close();
            return dt;
        }
        public static DataTable GetAllservers()
        {
            testconnection();
            conx.Open();
            string query = "SELECT Nom_USER_WORK FROM USER_WORK ";
            SqlDataAdapter da = new SqlDataAdapter(query, conx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conx.Close();
         return dt;  
        }
    }
}
