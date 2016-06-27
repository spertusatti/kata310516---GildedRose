using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class BackstagePass : SpecialItem
    {
        
        public override int UpdateItemQuality()
        {
            var updatedQuality = base.Quality;

            if (base.SellIn <= 0) updatedQuality = 0;
            else if (base.SellIn <= 5) updatedQuality += 3;
            else if (base.SellIn <= 10) updatedQuality += 2;
            else updatedQuality += 1;            

            return updatedQuality > 50 ? 50 : updatedQuality;
        }
    }
}
