using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public class HealCommand : AbstractCommand
    {
        public HealCommand(Player player):base(player){

        }
        public override void Execute()
        {
            player.Heal(10);
        }
    }
}
