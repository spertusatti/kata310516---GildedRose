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
    public class Sulfuras : ItemCore
    {
        public Sulfuras() : this(0, 80)
        {
        }

        public Sulfuras(int sellIn,int quality) : this(Constants.Sulfuras, sellIn, quality)
        {
        }
        public Sulfuras(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;

            this.InitialModification = null;
            this.DecreaseSellIn = null;
            this.QualityModificationWhenExpire = null;
        }
     

    }
}
