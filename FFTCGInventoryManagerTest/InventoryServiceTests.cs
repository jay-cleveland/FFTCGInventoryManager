using FFTCGInventoryManager.Repositories;
using FFTCGInventoryManager.Services;
using FFTCGInventoryManager.Entities;
using Moq;
using System;
using Xunit;
using System.Collections.Generic;

namespace FFTCGInventoryManagerTest
{
    public class InventoryServiceTests
    {
        [Fact]
        public void CardShouldGetAdded()
        {
            //arrange
            var inventoryId = Guid.NewGuid().ToString();
            const string CardId = "1-001";
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns(new Inventory(inventoryId, new List<Card>()));

            //act
            var inventoryService = new InventoryService(repository.Object);
            inventoryService.AddCard(inventoryId, CardId);

            //assert 
            repository.Verify(r => r.AddCard(inventoryId, CardId), Times.Once);
        }

        [Fact]
        public void WhenInventoryDoesNotExistException()
        {
            //arrange
            const string CardId = "1-001";
            var inventoryId = Guid.NewGuid().ToString();
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns((Inventory)null);

            //act
            var inventoryService = new InventoryService(repository.Object);

            //assert 
            Assert.Throws<Exception>(() => inventoryService.AddCard(inventoryId, CardId));
            repository.Verify(r => r.AddCard(inventoryId, CardId), Times.Never);
        }
    }
}
