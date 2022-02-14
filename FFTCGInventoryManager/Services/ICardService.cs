using FFTCGInventoryManager.Entities;
using System.Collections.Generic;

namespace FFTCGInventoryManager.Services
{
    public interface ICardService
    {
        List<Card> GetCards();
        Card GetCard(string cardId);
    }
}
