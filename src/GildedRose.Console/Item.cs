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
