namespace FFTCGInventoryManager.Services
{
    public interface IInventoryService
    {
        void AddCard(string InventoryId, string CardId);
        void RemoveCard(string InventoryId, string CardId);
        void CreateNewInventory();
        void DeleteInventory(string InventoryId);
    }
}
