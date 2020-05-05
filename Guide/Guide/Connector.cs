using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide
{
    class Connector
    {
        public static MySqlConnection
                GetDBConnection()
        {
            string connStr = "server=localhost;user=root;database=shoes;password=darya3112;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }
    }
}
