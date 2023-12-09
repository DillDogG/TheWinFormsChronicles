using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.GameLogic.Weapon;

namespace GameLogic.GameLogic.Force
{
    internal class Force
    {
        public bool performForce(int attack, int defend)
        {
            Random rnd = new Random();
            return (attack + rnd.Next(1, 21)) > (defend + rnd.Next(1, 21));
        }
    }
}
