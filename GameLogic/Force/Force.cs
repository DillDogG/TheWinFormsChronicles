using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWinFormsChronicles.GameLogic.Weapon;

namespace TheWinFormsChronicles.GameLogic.Force
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
