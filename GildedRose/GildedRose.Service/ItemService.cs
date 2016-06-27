using GildedRose.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Service
{
    public class ItemService : IItemService
    {
        public IList<SpecialItem> UpdateQuality(IList<SpecialItem> itemList)
        {
            foreach (var item in itemList)
            {
                item.SellIn = item.UpdateItemSellIn();
                item.Quality = item.UpdateItemQuality();
            }

            return itemList;
        }
    }
}
