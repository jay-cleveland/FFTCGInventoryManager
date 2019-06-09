using FFTCGInventoryManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories
{
    public class DictInventoryRepository : IInventoryRepository
    {
        public Dictionary<string, List<string>> Inventories = new Dictionary<string, List<string>>();

        public void CreateNewInventory()
        {
            List<string> cardList = new List<string>();
            Console.WriteLine("New Inventory ID: " + Inventories.Count());
            Inventories.Add(Inventories.Count().ToString(), cardList);
            Console.WriteLine("Created new inventory. Count: " + Inventories.Count());
        }
        
        public void AddCard(string inventoryId, string cardId)
        {
            Inventories[inventoryId].Add(cardId);
            Console.WriteLine("Added. Cards in inventory: " + Inventories[inventoryId].Count());
        }

        public void RemoveCard(string inventoryId, string cardId)
        {
            Inventories[inventoryId].Remove(cardId);
            Console.WriteLine("Removed. Cards in inventory: " + Inventories[inventoryId].Count());
        }

        public Inventory GetInventory(string InventoryId)
        {
            if (Inventories.ContainsKey(InventoryId))
                return new Inventory(InventoryId, Inventories[InventoryId]
                    .Select(id => new Card(id))
                    .ToList());

            return null;
        }


    }
}