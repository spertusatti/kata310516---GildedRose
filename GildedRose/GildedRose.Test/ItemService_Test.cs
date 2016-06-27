using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.Service;
using System.Collections.Generic;
using GildedRose.Entities;

namespace GildedRose.Test
{
    [TestClass]
    public class ItemService_Test
    {
        public IItemService service;

        public ItemService GetService()
        {
            return new ItemService();
        }

        #region AgedBrie
        [TestMethod]
        public void AgedBrieIncreasesQuality_Test()
        {
            //Arraange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new AgedBrie(){Name = "Aged Brie", SellIn = 2, Quality = 0}
            };
            
            //Act
            var updatedList = service.UpdateQuality(list);
            
            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 1 && updatedList[0].Quality == 1);
        }

        [TestMethod]
        public void AgedBrieQuality50_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new AgedBrie(){Name = "Aged Brie", SellIn = 2, Quality = 50}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 1 && updatedList[0].Quality == 50);
        }

        #endregion

        #region Backstagepass

        [TestMethod]
        public void BackstagePassSellIn10_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new BackstagePass(){Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 10 && updatedList[0].Quality == 12);
        }

        [TestMethod]
        public void BackstagePassSellIn5_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new BackstagePass(){Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 5 && updatedList[0].Quality == 13);
        }
        
        [TestMethod]
        public void BackstagePassSellIn0_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new BackstagePass(){Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 0 && updatedList[0].Quality == 0);
        }

        [TestMethod]
        public void BackstagePassSellIn20_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new BackstagePass(){Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 21, Quality = 10}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 20 && updatedList[0].Quality == 11);
        }

        #endregion

        #region Sulfuras
        [TestMethod]
        public void Sulfuras_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new Sulfuras(){Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 9 && updatedList[0].Quality == 80);
        }

        #endregion 

        #region Conjured

        [TestMethod]
        public void ConjuredSellIn10_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new Conjured(){Name = "Conjured Mana Cake", SellIn = 10, Quality = 60}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 9 && updatedList[0].Quality == 58);
        }

        [TestMethod]
        public void ConjuredSellInExpired_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new Conjured(){Name = "Conjured Mana Cake", SellIn = 0, Quality = 60}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == -1 && updatedList[0].Quality == 56);
        }

        #endregion

        #region NormalItem

        [TestMethod]
        public void NormalItemNotExpired_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new SpecialItem(){Name = "+5 Dexterity Vest", SellIn = 5, Quality = 20}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == 4 && updatedList[0].Quality == 19);
        }

        [TestMethod]
        public void NormalItemExpired_Test()
        {
            //Arrange
            service = GetService();
            IList<SpecialItem> list = new List<SpecialItem>()
            {
                new SpecialItem(){Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20}
            };

            //Act
            var updatedList = service.UpdateQuality(list);

            //Assert
            Assert.IsTrue(updatedList[0].SellIn == -1 && updatedList[0].Quality == 18);
        }

        #endregion
    }
}
