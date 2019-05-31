﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public class InventoryService
    {
        public void AddCard(string inventoryId, string cardId)
        {
            if (!InventoryRepository.Inventories.TryGetValue(inventoryId, out var cards))
                throw new ArgumentException('Inventory ID does not exist.');

            InventoryRepository.AddCard(inventoryId, cardId);
        }

        public void RemoveCard(string inventoryId, string cardId)
        {
            if (!InventoryRepository.Inventories.Try)
        }
    }
}
