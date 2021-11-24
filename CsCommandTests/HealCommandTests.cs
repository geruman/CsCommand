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
    public class HealCommandTests
    {
        private Player player;
        private HealCommand command;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            player.Damage(100);
            command = new HealCommand(player);
        }

        [TestMethod()]
        public void ExecuteTest()
        {
            command.Execute();
            Assert.AreEqual(10, player.GetLife());
            command.Execute();
            Assert.AreEqual(20, player.GetLife());
            command.Execute();
            Assert.AreEqual(30, player.GetLife());
            command.Execute();
            Assert.AreEqual(40, player.GetLife());
            command.Execute();
            Assert.AreEqual(50, player.GetLife());
            command.Execute();
            Assert.AreEqual(60, player.GetLife());
            command.Execute();
            Assert.AreEqual(70, player.GetLife());
            command.Execute();
            Assert.AreEqual(80, player.GetLife());
            command.Execute();
            Assert.AreEqual(90, player.GetLife());
            command.Execute();
            Assert.AreEqual(100, player.GetLife());
            command.Execute();
            Assert.AreEqual(100, player.GetLife());
            command.Execute();
            Assert.AreEqual(100, player.GetLife());

        }
    }
}