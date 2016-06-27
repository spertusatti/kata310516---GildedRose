using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class Sulfuras : SpecialItem
    {
        public override int UpdateItemQuality()
        {
            return base.Quality;
        }
    }
}
