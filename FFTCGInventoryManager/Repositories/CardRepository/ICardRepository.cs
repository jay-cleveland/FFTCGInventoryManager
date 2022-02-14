using FFTCGInventoryManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories.CardRepository
{
    public interface ICardRepository
    {
        List<Card> GetCards();
        Card GetCard(string cardId);
    }
}
