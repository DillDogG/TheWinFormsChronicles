using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.GameLogic.Weapon
{
    internal class StunningStrike : Skill
    {
        public bool checkEffect(int attack, int defend)
        {
            if (attack > defend) return true;
            return false;
        }
    }
}
