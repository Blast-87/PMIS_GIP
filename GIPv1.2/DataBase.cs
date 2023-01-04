using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;



namespace GIPv1._2
{

    
    class DataBase//от CD
    {
        public static void ST()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\BD_GIP\");
            //AppDomain.CurrentDomain.SetData("DataDirectory", @"\LOCAL_VER\BD_GIP");

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-38K480J\MSSQLSERVER3; Initial Catalog = GIPvRTM2; Integrated Security = True");//Эта работает
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LOCAL_VER\BD_GIP\GIPvRTM2.mdf; Integrated Security=True"); 
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-38K480J\MSSQLSERVER3; Initial Catalog = GIPv1.17; Integrated Security = True");
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-38K480J\MSSQLSERVER3; Initial Catalog = GIPv1.7; Integrated Security = True");
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source = BLAST_PC\SQLEXPRESS; Initial Catalog = GIPv1.7; Integrated Security = True");
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\GIPv1.7.mdf;  Integrated Security = True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
