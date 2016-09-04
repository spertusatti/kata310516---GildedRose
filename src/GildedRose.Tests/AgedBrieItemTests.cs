using GildedRose.Entities;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieItemTests
    {
        //TODO check how to implement Tear Up and Tear Down Test Fact functions in XUnit

        [Fact]
        public void TestAgedBrieItemUpdateProperties()
        {
            AgedBrieItem item = new AgedBrieItem { Name = "Aged Brie Item", SellIn = 5, Quality = 5 }; 

            //Call UpdateProperties Method once
            item.UpdateProperties();

            //Check wether its SellIn and QualityProperties have been decreased in one unit, as expected to do so.
            Assert.True(item.SellIn == 4, "SellIn should decrease in one unit");
            Assert.True(item.Quality == 6, "Quality should increase in one unit");
        }

        [Fact]
        public void TestAgedBrieItemUpdatePropertiesSellInDownLimit()
        {
            AgedBrieItem item = new AgedBrieItem { Name = "Aged Brie Item", SellIn = 0 }; 

            item.UpdateProperties();

            Assert.True(item.SellIn == -1, "SellIn value should continue decreasing.");
        }   

        [Fact]
        public void TestAgedBrieItemUpdatePropertiesQualityDoubleDegradation()
        {
            AgedBrieItem item = new AgedBrieItem { Name = "Aged Brie Item", SellIn = 0, Quality = 5 }; 

            item.UpdateProperties();

            Assert.True(item.Quality == 6, "Quality shall continue increasing in 1 unit no matter what SellIn value is");            
        }

        [Fact]
        public void TestAgedBrieItemUpdatePropertiesQualityDegradationLimit()
        {
            AgedBrieItem item = new AgedBrieItem { Name = "Aged Brie Item", Quality = -2 };

            item.UpdateProperties();

            Assert.True(item.Quality == 0, "Quality can't be negative.");
        }

        [Fact]
        public void TestAgedBrieItemUpdatePropertiesQualityUpperLimit()
        {
            AgedBrieItem item = new AgedBrieItem { Name = "Aged Brie Item", Quality = 50 };

            item.UpdateProperties();

            Assert.True(item.Quality == 50, "Quality can't be greater than 50.");
        }
    }
}