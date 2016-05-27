using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands;
using GildedRose.Entities.Entitites.Core;
using GildedRose.Utilities;

namespace GildedRose.Entities.Entitites
{
    public class AgedBrie : ItemCore
    {
        public AgedBrie() : this(20, 0)
        {
        }
        public AgedBrie(int sellIn, int quality) : this(Constants.AgedBrie, sellIn, quality)
        {
        }
        public AgedBrie(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
            this.InitialModification = new IncreaseQualityCommand(this);
            this.DecreaseSellIn = new DecreaseSellInCommand(this);
            this.QualityModificationWhenExpire = new IncreaseQualityCommand(this);
        }

    }
}
