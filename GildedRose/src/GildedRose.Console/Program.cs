using GildedRose.Entities;
using GildedRose.Service;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        IList<SpecialItem> Items;
        static IItemService service;

        static void Main(string[] args)
        {
            var app = new Program()
                          {
                              Items = new List<SpecialItem>
                                          {
                                              new SpecialItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new AgedBrie {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new SpecialItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new BackstagePass
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Conjured {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };       

            service= new ItemService();
            var updatedItems= service.UpdateQuality(app.Items);

            System.Console.ReadKey();
        }
    }
}
