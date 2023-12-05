using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Blaster
{
    internal class RapidBlaster : Blaster
    {
        public RapidBlaster()
        {
            minDamage = 2;
            maxDamage = 5;
            shotCount = 4;
        }
    }
}
