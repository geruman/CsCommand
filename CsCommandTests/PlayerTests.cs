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
    public class PlayerTests
    {
        private Player player;
        [TestInitialize()]
        public void Initialize()
        {
            player = new Player();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            player = null;
        }
        [TestMethod()]
        public void GetLifeTest()
        {
            Assert.AreEqual(100, player.GetLife());
        }
        [TestMethod()]
        public void GetMagicTest()
        {
            Assert.AreEqual(100, player.GetMagic());
        }
        [TestMethod()]
        public void HealTest()
        {
            player.Damage(10);
            player.Heal(10);
            Assert.AreEqual(100, player.GetLife());
            player.Damage(90);
            player.Heal(1000);
            Assert.AreEqual(100, player.GetLife());
        }

        [TestMethod()]
        public void DamageTest()
        {
            player.Damage(10);
            Assert.AreEqual(90, player.GetLife());
            player.Damage(9999);
            Assert.AreEqual(-9909, player.GetLife());
        }

        [TestMethod()]
        public void SpendMagicTest()
        {
            player.SpendMagic(10);
            Assert.AreEqual(90, player.GetMagic());
            player.SpendMagic(1000);
            Assert.AreEqual(0, player.GetMagic());
        }

        [TestMethod()]
        public void GainMagicTest()
        {
            player.GainMagic(199);
            Assert.AreEqual(100, player.GetMagic());
            player.SpendMagic(10);
            player.GainMagic(10);
            Assert.AreEqual(100, player.GetMagic());
        }

        
    }
}