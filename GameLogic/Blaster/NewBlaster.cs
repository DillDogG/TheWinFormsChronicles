using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Blaster
{
    internal class NewBlaster : Blaster
    {
        public NewBlaster()
        {
            minDamage = 1;
            maxDamage = 6;
            shotCount = 2;
        }
    }
}
