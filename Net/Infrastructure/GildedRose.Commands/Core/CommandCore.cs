using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities;

namespace GildedRose.Commands.Core
{
    public class CommandCore : ICommandCore
    {
        #region atributtes
        protected Item parent;
        #endregion atributtes

        #region ctor
        public CommandCore(Item item)
        {
            this.parent = item;
        }
        #endregion ctor

        #region functions
        public virtual void Execute()
        {
            throw new NotImplementedException();
        }

        #endregion functions

    }
}
