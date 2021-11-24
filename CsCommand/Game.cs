using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    class Game
    {
        private List<AbstractCommand> commands;
        public Game()
        {
            commands = new List<AbstractCommand>();
        }
        public void AddCommand(AbstractCommand command)
        {
            commands.Add(command);
        }
        public void ExecuteCommands()
        {
            foreach(AbstractCommand command in commands)
            {
                command.Execute();
            }
        }
    }
}
