using System.Collections.Generic;

namespace FFTCGInventoryManager.Entities;

public record Inventory(string Id, List<Card> CardList);