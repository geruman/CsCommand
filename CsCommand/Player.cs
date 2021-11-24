using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCommand
{
    public class Player
    {
        private int life;
        private int magic;
        public void Heal(int value)
        {
            this.life += value;
            if (life > 100)
            {
                life = 100;
            }
        }
        public void Damage(int value)
        {
            this.life -= value;
        }
        public void SpendMagic(int value)
        {
            magic -= value;
            if (magic < 0)
            {
                magic = 0;
            }
        }
        public void GainMagic(int value)
        {
            magic += value;
            if (magic > 100)
            {
                magic = 100;
            }
        }
        public int GetLife()
        {
            return life;
        }
        public int GetMagic()
        {
            return magic;
        }
        public Player()
        {
            life = 100;
            magic = 100;
        }
    }
}
