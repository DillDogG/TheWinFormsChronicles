using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Force
{
    internal class PushPull : Force
    {
        public void pushPull(int distance, bool player, Form3 form)
        {
            form.moveUnit(player, distance);
        }
    }
}
