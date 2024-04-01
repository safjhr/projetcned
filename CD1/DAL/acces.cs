using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD1.DAL
{
    class acces
    {
        private static readonly string connectionString = "server=localhost;user id=root;database=projetcned";

        public static IDbConnection GetConnection()
        {
            IDbConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
