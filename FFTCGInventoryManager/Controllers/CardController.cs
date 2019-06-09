using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FFTCGInventoryManager.Controllers
{
    [Produces("application/json")]
    [Route("api/card")]
    public class CardController : Controller
    {

        public ICardRepository Repository { get; set; }

        public CardController(ICardRepository cardRepository)
        {
            Repository = cardRepository;
        }

        [HttpGet("get_cards")]
        public void Get()
        {
            List<Card> cardList = Repository.GetCards();
            foreach (var card in cardList)
            {
                Console.WriteLine("Card id is: {0}", card.Id);
            }
        }
    }
}