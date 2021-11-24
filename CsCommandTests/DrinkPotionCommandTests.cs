using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand.Tests
{
    [TestClass()]
    public class DrinkPotionCommandTests
    {
        private Player player;
        private DrinkPotionCommand command;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            command = new DrinkPotionCommand(player);
        }

        [TestMethod()]
        public void ExecuteTest()
        {
            player.SpendMagic(100);
            Assert.AreEqual(0, player.GetMagic());
            command.Execute();
            Assert.AreEqual(7, player.GetMagic());
            command.Execute();
            Assert.AreEqual(14, player.GetMagic());
            command.Execute();
            Assert.AreEqual(21, player.GetMagic());
            command.Execute();
            Assert.AreEqual(28, player.GetMagic());
            command.Execute();
            Assert.AreEqual(35, player.GetMagic());
            command.Execute();
            Assert.AreEqual(42, player.GetMagic());
            command.Execute();
            Assert.AreEqual(49, player.GetMagic());
            command.Execute();
            Assert.AreEqual(56, player.GetMagic());
            command.Execute();
            Assert.AreEqual(63, player.GetMagic());
            command.Execute();
            Assert.AreEqual(70, player.GetMagic());
            command.Execute();
            Assert.AreEqual(77, player.GetMagic());
            command.Execute();
            Assert.AreEqual(84, player.GetMagic());
            command.Execute();
            Assert.AreEqual(91, player.GetMagic());
            command.Execute();
            Assert.AreEqual(98, player.GetMagic());
            command.Execute();
            Assert.AreEqual(100, player.GetMagic());
        }
    }
}