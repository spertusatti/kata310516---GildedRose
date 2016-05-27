using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.Entities.Commands;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Tests
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void IncreaseQualityAndQualityIncrease()
        {
            var item = new ItemCore();
            item.Quality = 0;
            item.InitialModification = new IncreaseQualityCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }
        [TestMethod]
        public void IncreaseQualityMore50andResultIs50()
        {
            var item = new ItemCore();
            item.Quality = 50;
            item.InitialModification = new IncreaseQualityCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 50);
        }

        [TestMethod]
        public void IncreaseQualityBackStageAndQualityIncrease1()
        {
            var item = new ItemCore();
            item.SellIn = 20;
            item.Quality = 0;
            item.InitialModification = new IncreaseQualityBackStageCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }

        [TestMethod]
        public void IncreaseQualityBackStageAndQualityIncrease2()
        {
            var item = new ItemCore();
            item.SellIn = 8;
            item.Quality = 0;
            item.InitialModification = new IncreaseQualityBackStageCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 2);
        }

        [TestMethod]
        public void IncreaseQualityBackStageAndQualityIncrease3()
        {
            var item = new ItemCore();
            item.SellIn = 2;
            item.Quality = 0;
            item.InitialModification = new IncreaseQualityBackStageCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 3);
        }

        [TestMethod]
        public void IncreaseQualityMore50BackStageAndQualityIncrease3AndResultIs50()
        {
            var item = new ItemCore();
            item.SellIn = 2;
            item.Quality = 55;
            item.InitialModification = new IncreaseQualityBackStageCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 50);
        }
        [TestMethod]
        public void DecreaseQualityAndQualityDecreased()
        {
            var item = new ItemCore();
            item.Quality = 1;
            item.InitialModification = new DecreaseQualityCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        [TestMethod]
        public void DecreaseQualityLessThan0AndResultIs0()
        {
            var item = new ItemCore();
            item.Quality = 1;
            item.InitialModification = new DecreaseQualityCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }

        [TestMethod]
        public void ResetQualityAndResultIs0()
        {
            var item = new ItemCore();
            item.Quality = 99;
            item.InitialModification = new ResetQualityCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }



        [TestMethod]
        public void DecreaseSellInAndSellInIsDecreased()
        {
            var item = new ItemCore();
            item.SellIn = 0;
            item.InitialModification = new DecreaseSellInCommand(item);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, -1);
        }
    }
}
