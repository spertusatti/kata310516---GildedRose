using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class SulfurasItem : Item, IUpdatableItem 
    {
        //TODO actualizar propiedades normalmente (Sellin--, Quality = 80)
        public void UpdateProperties()
        {
            this.SellIn = 0;
            this.Quality = 80;
        }
    }
}
