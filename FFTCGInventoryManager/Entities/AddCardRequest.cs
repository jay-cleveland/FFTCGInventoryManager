﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Entities
{
    public class AddCardRequest
    {
        public string InventoryId { get; set; }
        public string CardId { get; set; }
    }
}
