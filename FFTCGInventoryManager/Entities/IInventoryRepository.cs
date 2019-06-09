using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public interface IInventoryRepository
    {
        void CreateNewInventory(string InventoryId);
        void AddCard(string inventoryId, string cardId);
        void RemoveCard(string inventoryId, string cardId);
        Inventory GetInventory(string InventoryId);
    }
}
