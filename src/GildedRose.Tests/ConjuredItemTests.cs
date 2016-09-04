using GildedRose.Entities;
using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredItemTests
    {
        //TODO check how to implement Tear Up and Tear Down Test Fact functions in XUnit

        [Fact]
        public void TestConjuredItemUpdateProperties()
        {
            ConjuredItem item = new ConjuredItem { Name = "Conjured Item", SellIn = 5, Quality = 5 }; 

            //Call UpdateProperties Method once
            item.UpdateProperties();

            //Check wether its SellIn and QualityProperties have been decreased in one unit, as expected to do so.
            Assert.True(item.SellIn == 4, "SellIn should decrease in 1 unit");
            Assert.True(item.Quality == 3, "Quality should decrease in 2 units");
        }

        [Fact]
        public void TestConjuredItemUpdatePropertiesSellInDownLimit()
        {
            ConjuredItem item = new ConjuredItem { Name = "Conjured Item", SellIn = 0 }; 

            item.UpdateProperties();

            Assert.True(item.SellIn == -1, "SellIn value should continue decreasing.");
        }   

        [Fact]
        public void TestConjuredItemUpdatePropertiesQualityDoubleDegradation()
        {
            ConjuredItem item = new ConjuredItem { Name = "Conjured Item", SellIn = 0, Quality = 5 }; 

            item.UpdateProperties();

            Assert.True(item.Quality == 3, "Quality shall always decrease in 2 units.");            
        }

        [Fact]
        public void TestConjuredItemUpdatePropertiesQualityDegradationLimit()
        {
            ConjuredItem item = new ConjuredItem { Name = "Conjured Item", Quality = 1 };

            item.UpdateProperties();

            Assert.True(item.Quality == 0, "Quality can't be negative.");
        }

        [Fact]
        public void TestConjuredItemUpdatePropertiesQualityUpperLimit()
        {
            ConjuredItem item = new ConjuredItem { Name = "Conjured Item", Quality = 54 };

            item.UpdateProperties();

            Assert.True(item.Quality == 50, "Quality can't be greater than 50.");
        }
    }
}