using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public static class InventoryRepository
    {
        public static Dictionary<string, List<string>> Inventories = new Dictionary<string, List<string>>();
        
        public static void AddCard(string inventoryId, string cardId)
        {
            Inventories[inventoryId].Add(cardId);
        }

        public static void RemoveCard(string inventoryId, string cardId)
        {
            Inventories[inventoryId].Remove(cardId);
        }
    }
}