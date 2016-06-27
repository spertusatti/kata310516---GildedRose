using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class Conjured : SpecialItem
    {
        public override int UpdateItemQuality()
        {
            base.qualityAmount = base.qualityAmount * 2;
            base.qualityAmountExpired = base.qualityAmountExpired * 2;
            
            return base.UpdateItemQuality();
        }
    }
}
