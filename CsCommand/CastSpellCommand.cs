using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public class CastSpellCommand : AbstractCommand
    {
        public CastSpellCommand(Player player) : base(player)
        {

        }
        public override void Execute()
        {
            player.SpendMagic(10);
        }
    }
}
