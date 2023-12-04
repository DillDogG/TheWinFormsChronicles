using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Weapon
{
    internal class Weapon
    {
        public int minDamage;
        public int maxDamage;

        public Weapon() { }
        public Weapon(int min, int max)
        {
            minDamage = min;
            maxDamage = max;
        }

        public int attemptAttack()
        {
            Random rnd = new Random();
            int damage = rnd.Next(minDamage, maxDamage + 1);
            return damage;
        }
    }
}
