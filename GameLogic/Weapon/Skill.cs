using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.GameLogic.Weapon
{
    internal class Skill
    {
        public int performSkill(int bonus)
        {
            Random rnd = new Random();
            return bonus + rnd.Next(1, 21);
        }

        
    }
}
