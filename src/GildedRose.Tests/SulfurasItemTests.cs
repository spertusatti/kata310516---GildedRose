using GildedRose.Entities;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasItemTests
    {
        //TODO check how to implement Tear Up and Tear Down Test Fact functions in XUnit

        [Fact]
        public void TestSulfurasItemUpdateProperties()
        {
            SulfurasItem item = new SulfurasItem { Name = "Sulfuras Item" }; 

            //Call UpdateProperties Method once
            item.UpdateProperties();

            //Check wether its SellIn and QualityProperties have been decreased in one unit, as expected to do so.
            Assert.True(item.SellIn == 0, "SellIn should be constantly 0");
            Assert.True(item.Quality == 80, "Quality should be constantly 80");
        }

        [Fact]
        public void TestSulfurasItemUpdatePropertiesSellInDownLimit()
        {
            SulfurasItem item = new SulfurasItem { Name = "Sulfuras Item", SellIn = 0 }; 

            item.UpdateProperties();

            Assert.True(item.SellIn == 0, "SellIn should be constantly 0");
        }   

        [Fact]
        public void TestSulfurasItemUpdatePropertiesQualityConstant()
        {
            SulfurasItem item = new SulfurasItem { Name = "Sulfuras Item", Quality = 5 }; 

            item.UpdateProperties();

            Assert.True(item.Quality == 80, "Quality should be constantly 80");
        }
        
        [Fact]
        public void TestSulfurasItemUpdatePropertiesQualityDegradationLimit()
        {
            SulfurasItem item = new SulfurasItem { Name = "Sulfuras Item", Quality = -2 };

            item.UpdateProperties();

            Assert.True(item.Quality == 80, "Quality should be constantly 80");
        }

        [Fact]
        public void TestSulfurasItemUpdatePropertiesQualityUpperLimit()
        {
            SulfurasItem item = new SulfurasItem { Name = "Sulfuras Item", Quality = 90 };

            item.UpdateProperties();

            Assert.True(item.Quality == 80, "Quality should be constantly 80");
        }
    }
}