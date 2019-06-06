using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FFTCGInventoryManager.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FFTCGInventoryManager.Controllers
{
    [Produces("application/json")]
    [Route("api/inventory")]
    public class InventoryController : Controller
    {
        [HttpPost("card")]
        public void Post([FromBody] AddCardRequest request)
        {
            InventoryService.AddCard(request.InventoryId, request.CardId);
            Console.WriteLine(InventoryRepository.Inventories.Count());
        }

        [HttpPost]
        public void Post([FromBody] CreateInventoryRequest request)
        {
            InventoryRepository.CreateNewInventory(request.InventoryId);
            Console.WriteLine(InventoryRepository.Inventories.Count());
        }


    }
}