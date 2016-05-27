using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Commands.Core;

namespace GildedRose.Commands
{
    public class IncreaseQuality : CommandCore, ICommandCore
    {
        public override int Execute(int value)
        {
            value++;
            if (value > 50) value = 50;

            return value;
        }
    }
}
