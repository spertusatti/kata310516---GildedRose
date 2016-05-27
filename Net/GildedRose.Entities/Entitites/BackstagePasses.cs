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
    public class BackstagePasses : ItemCore
    {
        public BackstagePasses() : this(15, 20)
        {
        }
        public BackstagePasses(int sellIn, int quality) : this(Constants.BackstagePasses, sellIn, quality)
        {
        }
        public BackstagePasses(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
            this.InitialModification = new IncreaseQualityBackStageCommand(this);
            this.DecreaseSellIn = new DecreaseSellInCommand(this);
            this.QualityModificationWhenExpire = new ResetQualityCommand(this);
        }

    }
}
