using FFTCGInventoryManager.Entities;
using System.Collections.Generic;

namespace FFTCGInventoryManager.Repositories.CardRepository
{
    public interface ICardRepository
    {
        List<Card> GetCards();
        Card GetCard(string cardId);
    }
}
