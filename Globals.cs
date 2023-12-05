using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWinFormsChronicles.GameLogic.Character;
using TheWinFormsChronicles.GameLogic.Force;
using TheWinFormsChronicles.GameLogic.Weapon;
using TheWinFormsChronicles.UI;

namespace TheWinFormsChronicles
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
