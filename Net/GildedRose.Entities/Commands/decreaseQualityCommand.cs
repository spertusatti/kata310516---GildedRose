using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands
{
    public class DecreaseQualityCommand : CommandCore, ICommandCore
    {
        public DecreaseQualityCommand(ItemCore item) : base(item)
        {
        }
        public override void Execute()
        {
            var value = this.parent.Quality;

            value--;
            if (value < 0) value = 0;

            this.parent.Quality = value;

        }

    }
}
