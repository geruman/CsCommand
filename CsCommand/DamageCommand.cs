using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public class DamageCommand : AbstractCommand
    {
        public DamageCommand(Player player) : base(player)
        {

        }
        public override void Execute()
        {
            player.Damage(15);
        }
    }
}
