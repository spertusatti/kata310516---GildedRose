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
    public class Plus5Dexterity : ItemCore
    {
        public Plus5Dexterity() : this(10, 20)
        {
        }
        public Plus5Dexterity(int sellIn, int quality) : this(Constants.DexterityVestPlus5, sellIn, quality)
        {
        }
        public Plus5Dexterity(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
            this.InitialModification = new DecreaseQualityCommand(this); 
            this.DecreaseSellIn = new DecreaseSellInCommand(this);
            this.QualityModificationWhenExpire = new DecreaseQualityCommand(this);
        }

    }
}
