using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class StandardItem : Item, IUpdatableItem
    {
        //TODO actualizar propiedades normalmente (Sellin decrece 1, Quality decrece 1)
        public void UpdateProperties()
        {
            this.SellIn--;

            if (this.SellIn <= 0)
                this.Quality -= 2;
            else
                this.Quality--;

            if (this.Quality < 0)
                this.Quality = 0;

            if (this.Quality > 50)
                this.Quality = 50;
        }
    }
}
