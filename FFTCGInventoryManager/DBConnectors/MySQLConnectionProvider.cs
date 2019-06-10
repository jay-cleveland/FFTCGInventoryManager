﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.DBConnectors
{
    public class MySQLConnectionProvider : IDbConnectionProvider
    {
        public DbConnection GetConnection()
        {
            var connectionString = "Server=localhost; Port=3306; Database=fftcg_database; Uid=admin; Pwd=Kittyk8%$!;";
            return new MySqlConnection(connectionString);
        }
    }
}