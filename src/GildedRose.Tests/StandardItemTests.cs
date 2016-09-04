using GildedRose.Entities;
using Xunit;

namespace GildedRose.Tests
{
    public class StandardItemTests
    {
        //TODO check how to implement Tear Up and Tear Down Test Fact functions in XUnit

        [Fact]
        public void TestStandardItemUpdateProperties()
        {
            StandardItem item = new StandardItem { Name = "Standard Item", SellIn = 5, Quality = 5 }; 

            //Call UpdateProperties Method once
            item.UpdateProperties();

            //Check wether its SellIn and QualityProperties have been decreased in one unit, as expected to do so.
            Assert.True(item.SellIn == 4, "SellIn should decrease in one unit");
            Assert.True(item.Quality == 4, "Quality should decrease in one unit");
        }

        [Fact]
        public void TestStandardItemUpdatePropertiesSellInDownLimit()
        {
            StandardItem item = new StandardItem { Name = "Standard Item", SellIn = 0 }; 

            item.UpdateProperties();

            Assert.True(item.SellIn == -1, "SellIn value should continue decreasing.");
        }   

        [Fact]
        public void TestStandardItemUpdatePropertiesQualityDoubleDegradation()
        {
            StandardItem item = new StandardItem { Name = "Standard Item", SellIn = 0, Quality = 5 }; 

            item.UpdateProperties();

            Assert.True(item.Quality == 3, "Quality shall decrease in 2 units by the time SellIn is zero or less.");            
        }

        [Fact]
        public void TestStandardItemUpdatePropertiesQualityDegradationLimit()
        {
            StandardItem item = new StandardItem { Name = "Standard Item", Quality = 1 };

            item.UpdateProperties();

            Assert.True(item.Quality == 0, "Quality can't be negative.");
        }

        [Fact]
        public void TestStandardItemUpdatePropertiesQualityUpperLimit()
        {
            StandardItem item = new StandardItem { Name = "Standard Item", Quality = 52 };

            item.UpdateProperties();

            Assert.True(item.Quality == 50, "Quality can't be greater than 50.");
        }
    }
}