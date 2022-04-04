using FFTCGInventoryManager.DBConnectors;
using FFTCGInventoryManager.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories.CardRepository
{
    public class MySQLCardRepository : ICardRepository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public MySQLCardRepository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<List<Card>> GetCards()
        {
            List<Card> cardList = new List<Card>();
            var query = "SELECT * FROM card";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = (MySqlDataReader)await command.ExecuteReaderAsync();

            while(dataReader.Read())
            {
                cardList.Add(new Card(dataReader["card_id"] as string, 
                    dataReader["name"] as string,
                    dataReader["rarity"] as string,
                    dataReader["image"] as string,
                    dataReader["job"] as string,
                    dataReader["element"] as string,
                    dataReader["type"] as string,
                    dataReader["power"] as string,
                    dataReader["category"] as string));
            }

            dataReader.Close();
            connection.Close();
            return cardList;
        }

        public async Task<Card> GetCard(string cardId)
        {
            var query = $"SELECT * FROM card WHERE id = {cardId}";
            var connection = _connectionProvider.GetConnection();
            connection.Open();

            MySqlCommand command = new(query, (MySqlConnection)connection);
            MySqlDataReader dataReader = (MySqlDataReader)await command.ExecuteReaderAsync();
            dataReader.Read();

            return new Card(dataReader["card_id"] as string,
                            dataReader["name"] as string,
                            dataReader["rarity"] as string,
                            dataReader["image"] as string,
                            dataReader["job"] as string,
                            dataReader["element"] as string,
                            dataReader["type"] as string,
                            dataReader["power"] as string,
                            dataReader["category"] as string);
            
        }
    }
}
