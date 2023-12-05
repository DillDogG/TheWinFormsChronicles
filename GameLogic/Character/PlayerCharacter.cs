using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWinFormsChronicles.GameLogic.Blaster;
using TheWinFormsChronicles.GameLogic.Weapon;

namespace TheWinFormsChronicles.GameLogic.Character
{
    internal class PlayerCharacter : Character
    {
        public PlayerCharacter() { }
        public void createCharacter(int constitution, int dexterity, int charisma, int weaponSkill, int forcePower, int blasterSkill)
        {
            level = 1;
            this.constitution = constitution;
            this.dexterity = dexterity;
            this.charisma = charisma;
            this.weaponSkill = weaponSkill;
            this.forcePower = forcePower;
            this.blasterSkill = blasterSkill;
            if (weaponSkill > 13) currentWeapon = new LightSaber();
            else if (weaponSkill > 10) currentWeapon = new CracklingBaton();
            else currentWeapon = new Baton();
            if (blasterSkill > 13) currentBlaster = new RapidBlaster();
            else if (blasterSkill > 10) currentBlaster = new NewBlaster();
            else currentBlaster = new OldBlaster();
            setStatefuls();
        }

        public void levelUp()
        {
            level++;
            Globals.formManager.OpenLevelUp();
            //setStatefuls();
        }
    }
}
