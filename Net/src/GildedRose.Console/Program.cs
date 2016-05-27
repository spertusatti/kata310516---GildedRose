using System.Collections.Generic;
using GildedRose.Entities.Entitites;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Console
{

    class Program
    {
        IList<ItemCore> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<ItemCore>
                {
                    new Plus5Dexterity(10,20),
                    new AgedBrie(2,0),
                    new ElixirOfTheMongoose(5,7),
                    new Sulfuras(0,80),
                    new BackstagePasses(15,20),
                    new ConjuredManaCake(15,20)
                }
            };

            System.Console.WriteLine("before update");
            app.printList();
            
            app.UpdateQuality();

            System.Console.WriteLine("after update");
            app.printList();

            System.Console.ReadKey();

        }

        public void printList()
        {
            var len = this.Items.Count;
            if (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    System.Console.WriteLine(this.Items[i].ToString());
                }
            }
        }

        public void UpdateQuality()
        {
            var len = this.Items.Count;
            if (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    this.Items[i].updateQuality();
                }
            }
        }

    }

}
