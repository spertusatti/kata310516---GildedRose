using System.Collections.Generic;
using GildedRose.Entities;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new UpdatableStoreManager();

            app.UpdateQuality();

            System.Console.ReadKey();

        }        
    }
}
