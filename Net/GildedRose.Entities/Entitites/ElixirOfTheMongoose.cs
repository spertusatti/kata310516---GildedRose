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
    public class ElixirOfTheMongoose : ItemCore
    {
        public ElixirOfTheMongoose() : this(5, 7)
        {
        }
        public ElixirOfTheMongoose(int sellIn, int quality) : this(Constants.ElixirOfTheMongoose, sellIn, quality)
        {
        }
        public ElixirOfTheMongoose(string name, int sellIn, int quality)
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
