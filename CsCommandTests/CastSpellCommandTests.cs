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
    public class CastSpellCommandTests
    {
        private Player player;
        private CastSpellCommand command;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
            command = new CastSpellCommand(player);
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
            Assert.AreEqual(90, player.GetMagic());
            command.Execute();
            Assert.AreEqual(80, player.GetMagic());
            command.Execute();
            Assert.AreEqual(70, player.GetMagic());
            command.Execute();
            Assert.AreEqual(60, player.GetMagic());
            command.Execute();
            Assert.AreEqual(50, player.GetMagic());
            command.Execute();
            Assert.AreEqual(40, player.GetMagic());
            command.Execute();
            Assert.AreEqual(30, player.GetMagic());
            command.Execute();
            Assert.AreEqual(20, player.GetMagic());
            command.Execute();
            Assert.AreEqual(10, player.GetMagic());
            command.Execute();
            Assert.AreEqual(0, player.GetMagic());
            command.Execute();
            Assert.AreEqual(0, player.GetMagic());
            command.Execute();
            Assert.AreEqual(0, player.GetMagic());
        }
    }
}