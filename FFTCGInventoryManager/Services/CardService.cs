using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Repositories;

namespace FFTCGInventoryManager.Services
{
    public class CardService : ICardService
    {
        public ICardRepository Repository { get; }

        public CardService(ICardRepository cardRepository)
        {
            Repository = cardRepository;
        }

        public List<Card> GetCards()
        {
            return Repository.GetCards();
        }

        public Card GetCard(string cardId)
        {
            return Repository.GetCard(cardId);
        }
    }
}
