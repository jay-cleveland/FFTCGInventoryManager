using FFTCGInventoryManager.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Services
{
    public interface ICardService
    {
        Task<List<Card>> GetCards();
        Task<Card> GetCard(string cardId);
    }
}
