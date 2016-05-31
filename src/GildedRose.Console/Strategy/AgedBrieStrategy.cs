using System;
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
            item.IncreaseQuality();
            item.DecreaseSellin();
            if (item.SellIn < 0)
                item.IncreaseQuality();
        }
    }
}
