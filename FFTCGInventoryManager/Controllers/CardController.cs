using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace FFTCGInventoryManager.Controllers
{
    [Produces("application/json")]
    [Route("api/card")]
    public class CardController : Controller
    {

        public ICardService Service { get; set; }

        public CardController(ICardService cardService)
        {
            Service = cardService;
        }

        [HttpGet("all")]
        public async Task<List<Card>> Get()
        {
            List<Card> cardList = await Service.GetCards();

            return cardList;
        }
    }
}