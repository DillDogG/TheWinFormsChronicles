using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Blaster
{
    internal class Blaster
    {
        public int minDamage;
        public int maxDamage;
        public int shotCount;

        public Blaster() { }
        public Blaster(int min, int max, int shots)
        {
            minDamage = min;
            maxDamage = max;
            shotCount = shots;
        }

        public int attack()
        {
            Random rnd = new Random();
            int damage = 0;
            for (int i = 0; i < shotCount; i++)
            {
                damage += rnd.Next(minDamage, maxDamage + 1);
            }
            return damage;
        }
    }
}
