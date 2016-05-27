using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Commands.Core;

namespace GildedRose.Entities.Entitites.Core
{
    public class ItemCore
    {
        #region properties
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public ICommandCore InitialModification { get; set; }
        public ICommandCore DecreaseSellIn { get; set; }
        public ICommandCore QualityModificationWhenExpire { get; set; }
        #endregion properties

        #region ctor
        public ItemCore()
        {
        }
        public ItemCore(ICommandCore initialModificacion, ICommandCore decreaseSellIn, ICommandCore qualityModificationWhenExpire)
        {
            this.InitialModification = initialModificacion;
            this.DecreaseSellIn = decreaseSellIn;
            this.QualityModificationWhenExpire = qualityModificationWhenExpire;
        }
        #endregion ctor

        #region functions
        public virtual void updateQuality()
        {
            // Initial modification of the quality value
            if (this.InitialModification != null) this.InitialModification.Execute();

            // decrease sellIn 
            if (this.DecreaseSellIn != null) this.DecreaseSellIn.Execute();

            // if item expire, modify the quality
            if (this.SellIn < 0 && this.QualityModificationWhenExpire != null)
            {
                this.QualityModificationWhenExpire.Execute();
            }
        }

        public override string ToString()
        {
            var result = string.Format("Name: {0}, SellIn: {1}, Quality: {2}", this.Name, this.SellIn, this.Quality);
            return result;
        }

        #endregion functions

    }
}
