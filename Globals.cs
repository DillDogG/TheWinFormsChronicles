using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.GameLogic.Character;
using GameLogic.GameLogic.Force;
using GameLogic.GameLogic.Weapon;
using GameLogic.UI;

namespace GameLogic
{
    static class Globals
    {
        public static PlayerCharacter player = new PlayerCharacter();
        public static uCharacter u_player = new uCharacter();
        public static FormManager formManager = new FormManager();
        public static StunningStrike stunningStrike = new StunningStrike();
        public static Boomerang boomerang = new Boomerang();
        public static PushPull pushPull = new PushPull();
        public static Choke choke = new Choke();
    }
}
