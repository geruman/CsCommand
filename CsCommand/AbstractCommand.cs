using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public abstract class AbstractCommand
    {
        protected Player player;
        public AbstractCommand(Player player)
        {
            this.player = player; 
        }
        public abstract void Execute();
    }
}
