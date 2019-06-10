﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Services;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Get()
        {
            List<Card> cardList = Service.GetCards();
            foreach (var card in cardList)
            {
                Console.WriteLine("Card id is: {0}", card.Id);
            }

            return Ok(cardList);
        }
    }
}