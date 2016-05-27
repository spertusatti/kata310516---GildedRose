using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Entities.Entitites.Core;

namespace GildedRose.Entities.Commands.Core
{
    public class CommandCore : ICommandCore
    {
        #region atributtes
        protected ItemCore parent;
        #endregion atributtes

        #region ctor
        public CommandCore(ItemCore item)
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
