using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public static class InventoryService
    {
        public static void AddCard(string inventoryId, string cardId)
        {
            if (!InventoryRepository.Inventories.ContainsKey(inventoryId))
                throw new ArgumentException("Inventory ID does not exist.");

            InventoryRepository.AddCard(inventoryId, cardId);
        }

        public static void RemoveCard(string inventoryId, string cardId)
        {
            if (!InventoryRepository.Inventories.ContainsKey(inventoryId))
                throw new ArgumentException("Inventory ID does not exist.");

            InventoryRepository.RemoveCard(inventoryId, cardId);
        }
    }
}
