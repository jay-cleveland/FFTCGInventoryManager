using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Services
{
    public interface IInventoryService
    {
        void AddCard(string InventoryId, string CardId);
        void RemoveCard(string InventoryId, string CardId);
        void CreateNewInventory();
    }
}
