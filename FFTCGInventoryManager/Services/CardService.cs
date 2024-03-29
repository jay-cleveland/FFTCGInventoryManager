﻿using System.Collections.Generic;
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
