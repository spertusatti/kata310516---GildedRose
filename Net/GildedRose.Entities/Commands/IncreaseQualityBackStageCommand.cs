using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands
{
    public class IncreaseQualityBackStageCommand : CommandCore, ICommandCore
    {
        public IncreaseQualityBackStageCommand(ItemCore item) : base(item)
        {
        }
        public override void Execute()
        {
            var value = this.parent.Quality;

            value++;
            if (this.parent.SellIn < 10) value++;
            if (this.parent.SellIn < 5) value++;
            if (value > 50) value = 50;

            this.parent.Quality = value;

        }

    }
}
