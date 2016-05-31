using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public ItemType Type { get; set; }

        public void IncreaseQuality()
        {
            if (this.Quality < 50)
                this.Quality++;
        }

        public void DecreaseQuality()
        {
            if (this.Quality > 0)
                this.Quality--;

        }

        public void ResetQuality()
        {
            this.Quality = 0;
        }

        public void DecreaseSellin()
        {
            this.SellIn--;
        }

    }

    public enum ItemType
    {
        AgedBrie,
        BackStagePass,
        ConjuredManaCake,
        DexterityVest,
        Elixir,
        Sulfuras
    }
}
