//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Phones_and_abonents
{
    internal class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-K8TL1AD\SQLEXPRESS;Initial Catalog=PHONE;Integrated Security = True");
      
        public void openconect()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
               sqlConnection.Open();
        }
        public void closenconect()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
       
    }
}
