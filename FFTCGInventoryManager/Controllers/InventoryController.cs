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
        public IInventoryService Service { get; set; }

        public InventoryController(IInventoryService inventoryService)
        {
            Service = inventoryService;
        }

        [HttpPost("card/add")]
        public void Post([FromBody] AddCardRequest request)
        {
            Service.AddCard(request.InventoryId, request.CardId);
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