using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class BackstagePassItem : Item, IUpdatableItem
    {
        //TODO actualizar propiedades normalmente (Sellin--, 
        //Quality[ Sellin > 5 && <= 10 +=2, Sellin > 0 && <= 5 +=3, Sellin <= 0 =0 ])
        public void UpdateProperties()
        {
            this.SellIn--;

            if (this.SellIn > 10)
                this.Quality++;
            else if (this.SellIn > 5 && this.SellIn <= 10)
                this.Quality += 2;
            else if (this.SellIn > 0 && this.SellIn <= 5)
                this.Quality += 3;
            else
                this.Quality = 0;

            if (this.Quality < 0)
                this.Quality = 0;

            if (this.Quality > 50)
                this.Quality = 50;
        }
    }
}
