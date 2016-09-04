using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class ConjuredItem : Item, IUpdatableItem
    {
        //TODO actualizar propiedades normalmente (Sellin--, Quality -= 2)
        public void UpdateProperties()
        {
            this.SellIn--;
            this.Quality -= 2;

            if (this.Quality < 0)
                this.Quality = 0;

            if (this.Quality > 50)
                this.Quality = 50;
        }
    }
}
