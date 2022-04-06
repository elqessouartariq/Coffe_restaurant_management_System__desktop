using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Bunifu.Framework.UI;
namespace coffee_System
{
    internal class Operations
    {
        static string stringConx = "Data Source=DESKTOP-VL8EQD6\\SQLEXPRESS;Initial Catalog=CoffeeManagement_db;Integrated Security=True";
        static  SqlConnection con = new SqlConnection(stringConx);
        public static int openConxDb()
        {
            
            try
            {
                con.Open();
                return 1;
            }
            catch (Exception ex)
            {
                con.Close();
                return 0;
            }
   
        }
        public static void closeConxDb()
        {
            con.Close();
        }
      
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public static string getNameUser(long idUser)
        {
            string nameUser = "Error Connexion database";
            //open connex
            if (openConxDb() == 0)
            {
                MessageBox.Show("Failed Connexion with database !","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string query= "select Nom_USER_WORK ,Prenom_USER_WORK from USER_WORK where ID_USER_WORK='"+idUser+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                nameUser = dr.GetString(0);
                nameUser += " "+dr.GetString(1);
            }
            closeConxDb();
            return nameUser;
        }
        
        public static void insertCommande(double total,long idServer,long idCashier)
        {
            int m=0;
            
            if (openConxDb()==1)
            {
                 string desing = "insertCommande";
               // string desing =" insert into COMMANDE(Total_com, Date_com, id_USER_WORK_CASHIER, id_USER_WORK_SERVER) values(@total, @date, @idUserCashier, @idUserServer)";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@idUserServer", idServer);
                cmd.Parameters.AddWithValue("@idUserCashier", idCashier);
                m = cmd.ExecuteNonQuery();
                if(m==0)
                    MessageBox.Show("Commande not insert !","Error ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database !","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
        }

        public static void insertArticle(string designation,double prix,int idcategory,long idUser,Image img,int qte=0)
        {
            int m=0;
            
            if (openConxDb()==1)
            {
                //Read image
                byte[] images=ImageToByteArray(img);

           


                string desing = "insertArticle";
               // string str = "insert into product(photo_pro,description_pro,prix_pro,ID_Categorie,Id_user_work) values("+ images + ",'"+ designation + "',"+prix+","+ idcategory + ","+ idUser + ")";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //@designation varchar(150),@price money,@idCategory bigint,@img image,@idUser bigint,@qte int

                cmd.Parameters.AddWithValue("@designation", designation);
                cmd.Parameters.AddWithValue("@price", prix);
                cmd.Parameters.AddWithValue("@idCategory", idcategory);
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@img", images);
                cmd.Parameters.AddWithValue("@qte", qte);
                
                m = cmd.ExecuteNonQuery();
                if(m==0)
                    MessageBox.Show("Product not insert !","Warning ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                     MessageBox.Show("Product insert with succeful !","Insertion ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 130!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
        }

        public static void updateArticle(long idPro,string designation,double prix,int idcategory,long idUser,Image img,int qte=0)
        {
            int m=0;
            
            if (openConxDb()==1)
            {
                //Read image
                byte[] images=ImageToByteArray(img);



                string desing = "updatePro";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               //@id_product bigint ,@designation varchar(150),@price money,@idCategory varchar(50),@img image,@idUser bigint,@qte int=null
                cmd.Parameters.AddWithValue("@id_product", idPro);
                cmd.Parameters.AddWithValue("@designation", designation);
                cmd.Parameters.AddWithValue("@price", prix);
                cmd.Parameters.AddWithValue("@idCategory", idcategory);
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@img", images);
                cmd.Parameters.AddWithValue("@qte", qte);
                 
                m = cmd.ExecuteNonQuery();
                if(m==0)
                    MessageBox.Show("Product not update !","Warning ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                     MessageBox.Show("Product update with succeful !","Insertion ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 170!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
    
        public static void deleteArticle(long idPro)
        {
             int m=0;
            
            if (openConxDb()==1)
            {

                string desing = "deleteArticle";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               //@id_product bigint 
                cmd.Parameters.AddWithValue("@id_product", idPro);                
                m = cmd.ExecuteNonQuery();
                if(m==0)
                    MessageBox.Show("Product not deleted !","Warning ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                     MessageBox.Show("Product deleted with succeful !","Insertion ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 195!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
   
        public static void insertPanier(long idPro, int qte , double prix, long idUser)
        {
            int m = 0;

            if (openConxDb() == 1)
            {
                //Read image
                string desing = "insertPanier";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //@idProduct bigint ,@qte int,@prix money,@idcashier bigint
                cmd.Parameters.AddWithValue("@idProduct", idPro);
                cmd.Parameters.AddWithValue("@qte", qte);
                cmd.Parameters.AddWithValue("@prix", prix);
                cmd.Parameters.AddWithValue("@idcashier", idUser);
                m = cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 219!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
       
        public static void updatePanier(long idPro,int qte,double prix,long idUser)
        {
            int m = 0;

            if (openConxDb() == 1)
            {
                //Read image
                string desing = "updatePanier";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //@idProduct bigint ,@qte int,@prix money,@idcashier bigint
                cmd.Parameters.AddWithValue("@idProduct", idPro);
                cmd.Parameters.AddWithValue("@qte", qte);
                cmd.Parameters.AddWithValue("@prix", prix);
                cmd.Parameters.AddWithValue("@idcashier", idUser);
                m = cmd.ExecuteNonQuery();
                closeConxDb();
                if (CashierExistPanier(idUser) == true)
                    Program.tabbord.lbltotal.Text = getTotalPanier(idUser) + " DH";
                else
                    Program.tabbord.lbltotal.Text ="0 DH";
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 143!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public static long getIDUser(string username)
        {
             long m=0;
            
            if (openConxDb()==1)
            {

                string desing = "select ID_USER_WORK from USER_WORK where username_USER_WORK='"+username+"'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr=cmd.ExecuteReader();
                dr.Read();
                m = (long)(dr[0]) ;
                if(m==0)
                    MessageBox.Show("User not found !","Warning ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 265!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
    
        public static void insertCredit(long idServer,long idCashier,double total)
        {
             int m=0;
            
            if (openConxDb()==1)
            {
             
                string desing = "insertCredit";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               //@idUserServer bigint ,@idUserCashier bigint,@date date,@total money
                cmd.Parameters.AddWithValue("@idUserServer", idServer);   
                cmd.Parameters.AddWithValue("@idUserCashier", idCashier);   
                cmd.Parameters.AddWithValue("@total", total);   
                m = cmd.ExecuteNonQuery();
                if(m==0)
                    MessageBox.Show("Credit not inserted !","Warning ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                     MessageBox.Show("Credit insert with succeful !","Insertion ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 294!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
        //select sum(Total_com) from COMMANDE where id_USER_WORK_SERVER=2 and Date_com BETWEEN '2022-01-01' AND '2022-03-03'
        public static double getTotalRecipe(string dateDeb,string dateFin,long idserver)
        {
            
            double m=0;
            
            if (openConxDb()==1)
            {

                string desing = "select sum(Total_com) from COMMANDE where id_USER_WORK_SERVER='"+idserver+"' and Date_com BETWEEN '"+dateDeb+"' AND '"+dateDeb+"'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr=cmd.ExecuteReader();
                dr.Read();
                m = (long)(dr[0]) ;
                  
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 316!","Error Connexion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
   
        public static DataTable getAllArticl()
        {
            DataTable dt = new DataTable();
            if (openConxDb() == 1)
            {
                string desing = "select * from Product";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
               
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 335!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
    
        public static bool articlIsexistinPanier(long idp,long idCashier)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if("+idp+ " in (select idPro from Panier where Id_User_Cashier="+ idCashier + ")) select 1 else select 0";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
                if (m != 0)
                {
                    closeConxDb();
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 358!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return false;
        } 
    
        public static int getQteProPanier(long idp,long idUser)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "select qte from Panier where idPro='"+idp+ "' and Id_User_Cashier='"+idUser+"' ";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 379!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
    
        public static DataTable getPanier(long idCashier)
        {
            DataTable dt = new DataTable();

            if (openConxDb() == 1)
            {
                string desing = "select ID_pro,Description_pro,qte,total from Panier,Product where  Panier.idPro=Product.ID_pro and Panier.Id_User_Cashier='" + idCashier+"'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 398!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
    
        public static void deletePanier(long idCashier,long idPro=0)
        {

            string desing = "";
            if (openConxDb() == 1)
            {
                if (idPro==0)
                 desing = "delete from Panier where Id_User_Cashier='"+idCashier+"' ";
                else
                 desing = "delete from Panier where Id_User_Cashier='" + idCashier + "' and idPro='"+idPro+"' ";
                SqlCommand cmd = new SqlCommand(desing, con);
                cmd.ExecuteNonQuery();
                closeConxDb();
                if (CashierExistPanier(idCashier) == true)
                    Program.tabbord.lbltotal.Text = getTotalPanier(idCashier) + " DH";
                else
                    Program.tabbord.lbltotal.Text = "0 DH";

            }
            else
            {
                MessageBox.Show("Error in Connexion with database 420!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
        public static DataTable getAllCategorie()
        {
            DataTable dt = new DataTable();
            if (openConxDb() == 1)
            {
                string desing = "select * from CATEGORIE_PRODUCT";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);

                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 437!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }

        public static DataTable getAllServer()
        {
            DataTable dt = new DataTable();
            if (openConxDb() == 1)
            {
                string desing = "select ID_USER_WORK,Nom_USER_WORK+' '+Prenom_USER_WORK as name from USER_WORK where statut='server'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 455!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();

            return dt;
        }
    
        public static DataTable getSearchArticle(string desc)
        {
            DataTable dt = new DataTable();

            if (openConxDb() == 1)
            {
                string desing = "select * from Product where Description_pro like '%"+desc+"%'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 474!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
        public static double getPriceProduct(long idPro)
        {
            double m = 0;

            if (openConxDb() == 1)
            {

                string desing = "select Prix_pro from product where ID_pro='"+idPro+"'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (double)(dr[0]);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 494!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
        public static int getQteProduct(long idPro)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if("+ idPro + " in (select idPro from QuantityProduct )) select qte from QuantityProduct where idPro="+ idPro + " else select  0;";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 494!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
        public static double getTotalPanier(long idCashier)
        {

            double m = 0;

            if (openConxDb() == 1)
            {

                string desing = "select SUM(total) from Panier where Id_User_Cashier="+idCashier+"";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = double.Parse((dr[0].ToString()));

            }
            else
            {
                MessageBox.Show("Error in Connexion with database 530!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
        public static bool CashierExistPanier(long idcashier)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if("+idcashier+"in (select Id_User_Cashier from Panier)) select 1 else select 0";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
                if (m != 0)
                {
                    closeConxDb();
                    return true;
                }
                   
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 553!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return false;
        }
        public static DataTable RecipeTable(DateTime dtStart,DateTime dtEnd,long idServer, long idcashier)
        {
           
            DataTable dt = new DataTable();
            if (openConxDb() == 1)
            {
                string desing = "select Description_pro as 'Product',Qte,Total,Date_com as 'Date',Nom_USER_WORK+' '+Prenom_USER_WORK as'Server' from DETAIL, Product, COMMANDE, USER_WORK where DETAIL.ID_com = COMMANDE.ID_com and DETAIL.ID_Product = Product.ID_pro and COMMANDE.id_USER_WORK_SERVER = USER_WORK.ID_USER_WORK and  COMMANDE.id_USER_WORK_SERVER='"+idServer+ "' and COMMANDE.id_USER_WORK_CASHIER='" + idcashier + "' and Date_com between '" + dtStart+"' and '"+dtEnd+"'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 585!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();

            return dt;


        }
        public static double getTotalRecipe(long idcashier,long idserver,DateTime startdate,DateTime enddate)
        {
            double m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if((select SUM(Total_com) from COMMANDE where id_USER_WORK_CASHIER ='" + idcashier + "' and id_USER_WORK_SERVER = '" + idserver + "' and Date_com between '" + startdate + "' and '" + enddate + "') is null) select 0 else select SUM(Total_com) from COMMANDE where id_USER_WORK_CASHIER ='" + idcashier + "' and id_USER_WORK_SERVER = '" + idserver + "' and Date_com between '" + startdate + "' and '" + enddate + "'";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = double.Parse((dr[0].ToString()));

            }
            else
            {
                MessageBox.Show("Error in Connexion with database 609!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
        public static DataTable getSearchArticleCategorie(long idcategorie)
        {
            DataTable dt = new DataTable();

            if (openConxDb() == 1)
            {
                string desing = "select * from Product where ID_Categorie ="+idcategorie+"";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 474!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
        public  static DataTable CommandeBill()
        {
            DataTable dt = new DataTable();

            if (openConxDb() == 1)
            {
                string desing = "select Description_pro,Qte,Total from DETAIL inner join Product on (Product.ID_pro=DETAIL.ID_Product) where ID_com=(select max(ID_com) from COMMANDE)";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 647!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
        public static void updateWifi(string nomWifi,string Password)
        {
            int m = 0;

            if (openConxDb() == 1)
            {
               



                string desing = "update wifi set Nom_Wifi = '"+nomWifi+"', Code_Wifi = '"+Password+"' ";
                SqlCommand cmd = new SqlCommand(desing, con);
                m = cmd.ExecuteNonQuery();
                if (m == 0)
                    MessageBox.Show("Wifi not update !", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Wifi update with succeful !", "Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 680!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
        }
        public static DataTable infoWifi()
        {
            DataTable dt = new DataTable();

            if (openConxDb() == 1)
            {
                string desing = "select * from wifi";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 686!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return dt;
        }
        public static int getQteProductPanier(long idPro,long idcashier)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if(" + idPro + " in (select idPro from QuantityProduct ) and " + idPro + " in (select idPro from Panier where Id_User_Cashier="+ idcashier + " ) ) select qte from Panier where idPro=" + idPro + " and Id_User_Cashier=" + idcashier + "  else select  -1;";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 706!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
        public static int getQteProductQuantityProduct(long idPro)
        {
            int m = 0;

            if (openConxDb() == 1)
            {

                string desing = "if(" + idPro + " in (select idPro from QuantityProduct )  ) select qte from QuantityProduct where idPro=" + idPro + "  else select  -1;";
                SqlCommand cmd = new SqlCommand(desing, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = (int)(dr[0]);
            }
            else
            {
                MessageBox.Show("Error in Connexion with database 726!", "Error Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            closeConxDb();
            return m;
        }
    }
}
