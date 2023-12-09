using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.GameLogic.Blaster
{
    internal class OldBlaster : Blaster
    {
        public OldBlaster() 
        {
            minDamage = 1;
            maxDamage = 4;
            shotCount = 1;
        }
    }
}
