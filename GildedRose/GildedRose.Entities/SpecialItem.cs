using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class SpecialItem : Item
    {
        public int qualityAmount = 1;
        public int qualityAmountExpired = 2;

        public virtual int UpdateItemQuality()
        {
            var updatedQuality = 0;

            if (base.SellIn <= 0)
            {
                updatedQuality = base.Quality - qualityAmountExpired;
            }
            else
            {
                updatedQuality = base.Quality - qualityAmount;
            }

            return updatedQuality < 0 ? 0 : updatedQuality;
        }

        public int UpdateItemSellIn()
        {
            return base.SellIn - 1;
        }
    }
}
