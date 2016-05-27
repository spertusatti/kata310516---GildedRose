using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands
{
    public class ResetQualityCommand : CommandCore, ICommandCore
    {
        public ResetQualityCommand(ItemCore item) : base(item)
        {
        }
        public override void Execute()
        {
            this.parent.Quality = 0;
        }

    }
}
