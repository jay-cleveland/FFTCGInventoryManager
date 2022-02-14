using System;
using System.Collections.Generic;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.DBConnectors
{
    public class MySQLConnectionProvider : IDbConnectionProvider
    {
        private readonly string _username = Environment.GetEnvironmentVariable("DB_ACCESS_USERNAME");
        private readonly string _secret = Environment.GetEnvironmentVariable("DB_ACCESS_SECRET");

        public DbConnection GetConnection()
        {
            var connectionString = $"Server=localhost; Port=3306; Database=fftcg_inventory; Uid={_username}; Pwd={_secret};";
            return new MySqlConnection(connectionString);
        }
    }
}
