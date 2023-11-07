using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.Objects.Character
{
    internal class StormTrooper : Character, ICanAttack
    {
        public bool attemptAttack(int difficulty)
        {
            return false;
        }
    }
}
