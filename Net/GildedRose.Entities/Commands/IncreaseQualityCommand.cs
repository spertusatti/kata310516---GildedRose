using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands
{
    public class IncreaseQualityCommand : CommandCore, ICommandCore
    {
        public IncreaseQualityCommand(ItemCore item) : base(item)
        {
        }
        public override void Execute()
        {
            var value = this.parent.Quality;

            value++;
            if (value > 50) value = 50;

            this.parent.Quality = value;

        }

    }
}
