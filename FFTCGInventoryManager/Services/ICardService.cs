using FFTCGInventoryManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Services
{
    public interface ICardService
    {
        List<Card> GetCards();
    }
}
