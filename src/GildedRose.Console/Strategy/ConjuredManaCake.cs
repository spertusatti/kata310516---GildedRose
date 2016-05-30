using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Strategy
{
    public class ConjuredManaCake : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
                item.Quality--;
            item.SellIn--;
            if (item.SellIn < 0 && item.Quality > 0)
                item.Quality--;
        }
    }
}
