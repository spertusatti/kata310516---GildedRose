using Xunit;
using GildedRose.Entities.Entitites.Core;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Commands;

namespace GildedRose.Tests
{
    public class CommandsTest
    {
        [Fact]
        public void IncreaseQualityIncreasesQuality()
        {
            var item = new ItemCore();
            item.Quality = 0;
            var command = new IncreaseQualityCommand(item);
            item.InitialModification = command;
            item.updateQuality();
            Assert.Equal(item.Quality, 1);
        }
    }
}