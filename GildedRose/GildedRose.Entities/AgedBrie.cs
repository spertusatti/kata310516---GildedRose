using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class AgedBrie : SpecialItem
    {
        public override int UpdateItemQuality()
        {
            var updatedQuality = base.Quality + 1;
            return updatedQuality > 50 ? 50 : updatedQuality;
        }
    }
}
