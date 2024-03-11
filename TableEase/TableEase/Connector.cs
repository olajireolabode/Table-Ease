using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableEase
{
    public class Connector
    {

        private static SqlConnection connection = null;
        private static readonly object lockObject = new object();

        private Connector() { }

        public static SqlConnection GetConnection()
        {
            if (connection == null || connection.ConnectionString == "")
            {
                lock (lockObject)
                {
                    if (connection == null || connection.ConnectionString == "")
                    {
                        //Get Connection String for database
                        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Olajire\\Downloads\\tableeasefinalGUI (1)\\tableeasefinalGUI\\tableeasefinalGUI\\TableEase_2\\TableEase\\TableEase\\TableEase\\Database.mdf\";Integrated Security=True";
                        connection = new SqlConnection(connectionString);
                    }
                }
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
