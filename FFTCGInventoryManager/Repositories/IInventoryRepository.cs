using FFTCGInventoryManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories
{
    public interface IInventoryRepository
    {
        void CreateNewInventory();
        void AddCard(string inventoryId, string cardId);
        void RemoveCard(string inventoryId, string cardId);
        Inventory GetInventory(string InventoryId);
        void DeleteInventory(string InventoryId);
    }
}
