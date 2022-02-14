using System;
using FFTCGInventoryManager.Repositories.CardRepository;
using FFTCGInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace FFTCGInventoryManager.Controllers
{
    [Produces("application/json")]
    [Route("api/inventory")]
    public class InventoryController : Controller
    {
        public IInventoryService Service { get; set; }

        public InventoryController(IInventoryService inventoryService)
        {
            Service = inventoryService;
        }

        [HttpPost("card/add")]
        public void Post([FromBody] AddCardRequest request)
        {
            Console.WriteLine("Request - User: " + request.InventoryId + " Card: " + request.CardId);
            //Service.AddCard(request.InventoryId, request.CardId);
        }

        [HttpPost("card/remove")]
        public void Post([FromBody] RemoveCardRequest request)
        {
            Service.RemoveCard(request.InventoryId, request.CardId);
        }

        [HttpPost("create")]
        public void Post()
        {
            Service.CreateNewInventory();
        }


    }
}