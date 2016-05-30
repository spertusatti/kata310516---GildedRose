using GildedRose.Console.Strategy;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20, Type = ItemType.DexterityVest},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0, Type = ItemType.AgedBrie},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7, Type = ItemType.Elixir},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, Type = ItemType.Sulfuras},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20,
                                                      Type = ItemType.BackStagePass
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, Type = ItemType.ConjuredManaCake}
                                          }

                          };

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            var context = new Dictionary<ItemType, IItemStrategy>
            {
                { ItemType.AgedBrie, new AgedBrieStrategy() },
                { ItemType.BackStagePass, new BackStagePassStrategy() },
                { ItemType.ConjuredManaCake, new ConjuredManaCake() },
                { ItemType.DexterityVest, new DexterityVestStrategy() },
                { ItemType.Elixir, new ElixirStrategy() }
            };
            for (var i = 0; i < Items.Count; i++)
            {
                var strategy = context[Items[i].Type];
                strategy.UpdateQuality(Items[i]);
            }
        }

    }

}
