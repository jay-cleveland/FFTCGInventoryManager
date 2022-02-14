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
            var query = "SELECT * FROM card";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                cardList.Add(new Card(dataReader["card_id"] as string, 
                    dataReader["name"] as string,
                    dataReader["rarity"] as string,
                    dataReader["image"] as string));
            }

            dataReader.Close();
            connection.Close();
            return cardList;
        }

        public Card GetCard(string cardId)
        {
            var query = $"SELECT * FROM card WHERE id = {cardId}";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            return new Card(dataReader["card_id"] + "", dataReader["name"] + "", dataReader["rarity"] + "", dataReader["image"] + "");
            
        }
    }
}
