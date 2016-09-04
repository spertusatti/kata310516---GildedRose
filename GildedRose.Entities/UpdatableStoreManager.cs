using GildedRose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Entities
{
    public class UpdatableStoreManager : IUpdatableStore
    {
        IList<IUpdatableItem> Items;

        public UpdatableStoreManager()
        {
            Items = new List<IUpdatableItem>
                {
                    new StandardItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new AgedBrieItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new StandardItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new BackstagePassItem
                        {
                            Name = "Backstage passes to a TAFKAL80ETC concert",
                            SellIn = 15,
                            Quality = 20
                        },
                    new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                Items[i].UpdateProperties();                
            }
        }
    }
}
