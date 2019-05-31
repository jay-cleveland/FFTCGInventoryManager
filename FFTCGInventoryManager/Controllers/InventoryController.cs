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
    [Route("api/Inventory")]
    public class InventoryController : Controller
    {

        public void Post([FromBody] AddCardRequest request)
        {
            InventoryManager.AddCard(request.InventoryId, request.CardId);
            Console.WriteLine(InventoryManager.Inventories.Count());
        }


    }
}