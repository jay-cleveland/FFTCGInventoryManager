using FFTCGInventoryManager.DBConnectors;
using FFTCGInventoryManager.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories
{
    public class MySQLCardRepository : ICardRepository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public MySQLCardRepository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public List<Card> GetCards()
        {
            List<Card> cardList = new List<Card>();
            var query = "SELECT * FROM cards";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                cardList.Add(new Card(dataReader["card_id"] + "", 
                    dataReader["name"] + "",
                    dataReader["rarity"] + "",
                    dataReader["image"] + ""));
            }

            dataReader.Close();
            connection.Close();
            return cardList;
        }
    }
}
