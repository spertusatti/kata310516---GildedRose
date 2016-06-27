using GildedRose.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Service
{
    public interface IItemService
    {
        IList<SpecialItem> UpdateQuality(IList<SpecialItem> itemList);
    }
}
