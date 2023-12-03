using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Character
{
    internal class PlayerCharacter : Character
    {
        public int level = 1;
        public PlayerCharacter(int constitution, int dexterity, int charisma, int weaponSkill, int forcePower, int blasterSkill)
        {
            this.constitution = constitution;
            this.dexterity = dexterity;
            this.charisma = charisma;
            this.weaponSkill = weaponSkill;
            this.forcePower = forcePower;
            this.blasterSkill = blasterSkill;
        }


    }
}
