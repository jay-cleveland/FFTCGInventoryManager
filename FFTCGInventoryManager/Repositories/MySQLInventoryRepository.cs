using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.DBConnectors;
using FFTCGInventoryManager.Entities;

namespace FFTCGInventoryManager.Repositories
{
    public class MySQLInventoryRepository : IInventoryRepository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public MySQLInventoryRepository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public void AddCard(string inventoryId, string cardId)
        {
            throw new NotImplementedException();
        }

        public void CreateNewInventory()
        {
            List<Card> cardList = new List<Card>();
            
        }

        public void DeleteInventory(string InventoryId)
        {
            throw new NotImplementedException();
        }

        public Inventory GetInventory(string InventoryId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard(string inventoryId, string cardId)
        {
            throw new NotImplementedException();
        }
    }
}
