using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Image { get; set; }

        public Card(string id, string name, string rarity, string image)
        {
            Id = id;
            Name = name;
            Rarity = rarity;
            Image = image;
        }

        
    }
}
