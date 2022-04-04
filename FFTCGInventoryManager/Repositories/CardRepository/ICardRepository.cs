using FFTCGInventoryManager.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories.CardRepository
{
    public interface ICardRepository
    {
        Task<List<Card>> GetCards();
        Task<Card> GetCard(string cardId);
    }
}
