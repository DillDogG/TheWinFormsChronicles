using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace TheWinFormsChronicles.GameLogic.Force
{
    internal class Choke : Force
    {
        public int chokeTarget()
        {
            Random rnd = new Random();
            return rnd.Next(5, 40);
        }
    }
}
