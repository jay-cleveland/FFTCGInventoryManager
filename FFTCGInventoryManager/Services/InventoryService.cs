using FFTCGInventoryManager.Repositories;
using FFTCGInventoryManager.Repositories.InventoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Services
{
    public class InventoryService : IInventoryService
    {
        public IInventoryRepository Repository { get; }

        public InventoryService(IInventoryRepository repository)
        {
            Repository = repository;
        }

        public void AddCard(string inventoryId, string cardId)
        {
            CheckInventoryExists(inventoryId);
            Repository.AddCard(inventoryId, cardId);
        }

        public void RemoveCard(string inventoryId, string cardId)
        {
            CheckInventoryExists(inventoryId);
            Repository.RemoveCard(inventoryId, cardId);
        }

        public void CreateNewInventory()
        {
            Repository.CreateNewInventory();
        }

        private void CheckInventoryExists(string inventoryId)
        {
            if (Repository.GetInventory(inventoryId) == null) throw new Exception();
        }
    }
}
