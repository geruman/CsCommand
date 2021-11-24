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
    public class DamageCommandTests
    {
        private Player player;
        private DamageCommand command;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            command = new DamageCommand(player);
        }
        [TestCleanup()]
        public void Cleanup()
        {
            command = null;
            player = null;
        }
        

        [TestMethod()]
        public void ExecuteTest()
        {
            command.Execute();
            Assert.AreEqual(85, player.GetLife());
            command.Execute();
            Assert.AreEqual(70, player.GetLife());
            command.Execute();
            Assert.AreEqual(55, player.GetLife());
            command.Execute();
            Assert.AreEqual(40, player.GetLife());
            command.Execute();
            Assert.AreEqual(25, player.GetLife());
            command.Execute();
            Assert.AreEqual(10, player.GetLife());
            command.Execute();
            Assert.AreEqual(-5, player.GetLife());
            command.Execute();
            Assert.AreEqual(-20, player.GetLife());
        }
    }
}