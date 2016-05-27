using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Commands.Core;

namespace GildedRose.Commands
{
    public class increaseQualityBackstage : CommandCore, ICommandCore
    {
        public override int Execute(int value)
        {
            value++;
            functionalities.increaseQuality.call(that);

            if (that.sellIn < 10) functionalities.increaseQuality.call(that);
            if (that.sellIn < 5) functionalities.increaseQuality.call(that);
            if (value > 50) value = 50;

            return value;
        }
    }
}
