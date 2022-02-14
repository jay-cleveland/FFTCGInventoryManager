using FFTCGInventoryManager.DBConnectors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories.UserRepository
{
    public class MySQLUserRepository : IUserRepository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public MySQLUserRepository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public void CreateUser(string email)
        {
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            var query = $"INSERT INTO users (`email`) VALUES ({email})";

            MySqlCommand command = new MySqlCommand(query, (MySqlConnection)connection);
            command.ExecuteNonQuery();

        }

        public void GetUser(int user_id)
        {
            var query = $"SELECT * FROM users WHERE user_id = {user_id}";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();


        }
    }
}
