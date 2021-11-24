using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Game game = new Game();
            Console.WriteLine("Player life " + player.GetLife());
            Console.WriteLine("Player magic " + player.GetMagic());
            Console.WriteLine("Generating commands");
            game.AddCommand(new DamageCommand(player));
            game.AddCommand(new CastSpellCommand(player));
            game.AddCommand(new CastSpellCommand(player));
            game.AddCommand(new DamageCommand(player));
            game.AddCommand(new HealCommand(player));
            game.AddCommand(new DamageCommand(player));
            game.AddCommand(new CastSpellCommand(player));
            game.AddCommand(new DrinkPotionCommand(player));
            game.AddCommand(new DamageCommand(player));
            game.ExecuteCommands();
            Console.WriteLine("After commands have been executed");
            Console.WriteLine("Player life " + player.GetLife());
            Console.WriteLine("Player magic " + player.GetMagic());
            Console.ReadKey();
        }
    }
}
