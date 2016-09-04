using GildedRose.Entities;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassItemTests
    {
        //TODO check how to implement Tear Up and Tear Down Test Fact functions in XUnit

        [Fact]
        public void TestBackstagePassItemUpdateProperties()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 12, Quality = 10 }; 

            //Call UpdateProperties Method once
            item.UpdateProperties();

            //Check wether its SellIn and QualityProperties have been decreased in one unit, as expected to do so.
            Assert.True(item.SellIn == 11, "SellIn should decrease in one unit");
            Assert.True(item.Quality == 11, "Quality should increase in one unit");
        }

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesSellInDownLimit()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 0 }; 

            item.UpdateProperties();

            Assert.True(item.SellIn == -1, "SellIn value should continue decreasing.");
        }   

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesQualityDoubleIncrease()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 10, Quality = 5 }; 

            item.UpdateProperties();

            Assert.True(item.Quality == 7, "Quality shall continue increasing in 2 units until SellIn value is between 5 and 10.");            
        }

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesQualityTripleIncrease()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 5, Quality = 5 };

            item.UpdateProperties();

            Assert.True(item.Quality == 8, "Quality shall continue increasing in 3 units until SellIn value is between 0 and 5.");
        }

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesQualityTotalDecrease()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 0, Quality = 5 };

            item.UpdateProperties();

            Assert.True(item.Quality == 0, "Quality shall inmediately decrease to 0 in case SellIn value is 0 or less.");
        }

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesQualityDegradationLimit()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", Quality = -2 };

            item.UpdateProperties();

            Assert.True(item.Quality == 0, "Quality can't be negative.");
        }

        [Fact]
        public void TestBackstagePassItemUpdatePropertiesQualityUpperLimit()
        {
            BackstagePassItem item = new BackstagePassItem { Name = "Backstage Pass Item", SellIn = 10, Quality = 50 };

            item.UpdateProperties();

            Assert.True(item.Quality == 50, "Quality can't be greater than 50.");
        }
    }
}