using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public class Inventory
    {
        public List<Card> CardList { get; set; }
        public string Id { get; set; }

        public Inventory(string id, List<Card> cardList)
        {
            Id = id;
            CardList = cardList;
        }
    }
}
