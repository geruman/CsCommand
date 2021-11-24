using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public class DrinkPotionCommand : AbstractCommand
    {
        public DrinkPotionCommand(Player player) : base(player)
        {

        }
        public override void Execute()
        {
            player.GainMagic(7);
        }
    }
}
