using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands
{
    public class DecreaseSellInCommand : CommandCore, ICommandCore
    {
        public DecreaseSellInCommand(ItemCore item) : base(item)
        {
        }
        public override void Execute()
        {
            var value = this.parent.SellIn;

            value--;

            this.parent.SellIn = value;

        }

    }
}
