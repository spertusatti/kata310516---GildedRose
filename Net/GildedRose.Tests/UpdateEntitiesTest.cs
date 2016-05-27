using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.Entities.Commands;
using GildedRose.Entities.Entitites;

namespace GildedRose.Tests
{
    [TestClass]
    public class UpdateEntitiesTest
    {
        #region AgedBrie
        [TestMethod]
        public void AgedBrieQualityIncreased()
        {
            var item = new AgedBrie(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }
        [TestMethod]
        public void AgedBrieSellinDecreased()
        {
            var item = new AgedBrie(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 98);
        }

        [TestMethod]
        public void AgedBrieSellin0AndQualityIncreasedTwice()
        {
            var item = new AgedBrie(0, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 2);
        }
        #endregion AgedBrie

        #region BackStage
        [TestMethod]
        public void BackStageQualityIncreased()
        {
            var item = new BackstagePasses(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }
        [TestMethod]
        public void BackStageQualityIncreasedTwice()
        {
            var item = new BackstagePasses(8, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 2);
        }

        [TestMethod]
        public void BackStageQualityIncreased3()
        {
            var item = new BackstagePasses(2, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 3);
        }
        [TestMethod]
        public void BackStageSellinDecreased()
        {
            var item = new BackstagePasses(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 98);
        }

        [TestMethod]
        public void BackStageSellin0AndQualityReset()
        {
            var item = new BackstagePasses(0, 0);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        #endregion BackStage


        #region ConjuredManaCake
        [TestMethod]
        public void ConjuredManaCakeQualityDecreased()
        {
            var item = new ConjuredManaCake(99, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        [TestMethod]
        public void ConjuredManaCakeSellinDecreased()
        {
            var item = new ConjuredManaCake(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 98);
        }

        [TestMethod]
        public void ConjuredManaCakeSellin0AndQualityDecreased()
        {
            var item = new ConjuredManaCake(0, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        #endregion ConjuredManaCake
        #region ElixirOfTheMongoose
        [TestMethod]
        public void ElixirOfTheMongooseQualityDecreased()
        {
            var item = new ElixirOfTheMongoose(99, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        [TestMethod]
        public void ElixirOfTheMongooseSellinDecreased()
        {
            var item = new ElixirOfTheMongoose(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 98);
        }

        [TestMethod]
        public void ElixirOfTheMongooseSellin0AndQualityDecreased()
        {
            var item = new ElixirOfTheMongoose(0, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        #endregion ElixirOfTheMongoose

        #region Plus5Dexterity
        [TestMethod]
        public void Plus5DexterityQualityDecreased()
        {
            var item = new Plus5Dexterity(99, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        [TestMethod]
        public void Plus5DexteritySellinDecreased()
        {
            var item = new Plus5Dexterity(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 98);
        }

        [TestMethod]
        public void Plus5DexteritySellin0AndQualityDecreased()
        {
            var item = new Plus5Dexterity(0, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 0);
        }
        #endregion Plus5Dexterity

        #region Sulfuras
        [TestMethod]
        public void SulfurasQualityInmuted()
        {
            var item = new Sulfuras(99, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }
        [TestMethod]
        public void SulfurasSellinNotDecreased()
        {
            var item = new Sulfuras(99, 0);
            item.updateQuality();

            Assert.AreEqual(item.SellIn, 99);
        }

        [TestMethod]
        public void SulfurasSellin0AndQualityNotDecreased()
        {
            var item = new Sulfuras(0, 1);
            item.updateQuality();

            Assert.AreEqual(item.Quality, 1);
        }
        #endregion Sulfuras




    }
}
