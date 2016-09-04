using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class AgedBrieItem : Item, IUpdatableItem
    {
        public AgedBrieItem()
        {
            this.Name = "Aged Brie Item";
        }
        
        public void UpdateProperties()
        {
            this.SellIn--;
            this.Quality++;

            if (this.Quality < 0)
                this.Quality = 0;

            if (this.Quality > 50)
                this.Quality = 50;
        }
    }
}
