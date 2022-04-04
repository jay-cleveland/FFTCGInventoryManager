using System.Collections.Generic;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Repositories.CardRepository;

namespace FFTCGInventoryManager.Services
{
    public class CardService : ICardService
    {
        public ICardRepository Repository { get; }

        public CardService(ICardRepository cardRepository)
        {
            Repository = cardRepository;
        }

        public async Task<List<Card>> GetCards()
        {
            return await Repository.GetCards();
        }

        public async Task<Card> GetCard(string cardId)
        {
            return await Repository.GetCard(cardId);
        }
    }
}
