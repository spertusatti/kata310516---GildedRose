﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console.Strategy
{
    public class AgedBrieStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
                item.Quality++;

            item.SellIn--;
            if (item.SellIn < 0 && item.Quality < 50)
                item.Quality++;
        }
    }
}
