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
        public void AddCard_ValidInputs_CardAddedSuccessfully()
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
        public void AddCard_InvalidInventory_Throws()
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

        [Fact]
        public void RemoveCard_ValidInputs_CardRemovedSuccessfully()
        {
            //arrange
            var inventoryId = Guid.NewGuid().ToString();
            const string CardId = "1-001";
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns(new Inventory(inventoryId, new List<Card>()));

            //act
            var inventoryService = new InventoryService(repository.Object);
            inventoryService.RemoveCard(inventoryId, CardId);

            //assert
            repository.Verify(r => r.RemoveCard(inventoryId, CardId), Times.Once);
        }

        [Fact]
        public void RemoveCard_InvalidInputs_Throws()
        {
            //arrange
            var inventoryId = Guid.NewGuid().ToString();
            const string CardId = "1-001";
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns((Inventory)null);

            //act
            var inventoryService = new InventoryService(repository.Object);

            //assert
            Assert.Throws<Exception>(() => inventoryService.RemoveCard(inventoryId, CardId));
            repository.Verify(r => r.RemoveCard(inventoryId, CardId), Times.Never);
        }

        [Fact]
        public void CreateNewInventory_Successful()
        {
            //arrange
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.CreateNewInventory());

            //act
            var inventoryService = new InventoryService(repository.Object);
            inventoryService.CreateNewInventory();

            //assert
            repository.Verify(r => r.CreateNewInventory(), Times.Once);
        }

        [Fact]
        public void DeleteInventory_InvalidInputs_Throws()
        {
            //arrange
            var inventoryId = Guid.NewGuid().ToString();
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns((Inventory)null);

            //act
            var inventoryService = new InventoryService(repository.Object);

            //assert
            Assert.Throws<Exception>(() => inventoryService.DeleteInventory(inventoryId));
            repository.Verify(r => r.DeleteInventory(inventoryId), Times.Never);
        }

        [Fact]
        public void DeleteInventory_ValidInputs_Successful()
        {
            //arrange
            var inventoryId = Guid.NewGuid().ToString();
            var repository = new Mock<IInventoryRepository>();
            repository.Setup(r => r.GetInventory(inventoryId)).Returns(new Inventory(inventoryId, new List<Card>()));

            //act
            var inventoryService = new InventoryService(repository.Object);
            inventoryService.DeleteInventory(inventoryId);

            //assert
            repository.Verify(r => r.DeleteInventory(inventoryId), Times.Once);
        }
    }
}
