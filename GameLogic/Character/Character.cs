using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic.GameLogic.Weapon;

namespace GameLogic.GameLogic.Character
{
    public class Character : ICharacter {
        // general characteristics
        //string name;
        // stats
        public int constitution { get; set; }
        public int dexterity { get; set; }
        public int charisma { get; set; }
        public int weaponSkill { get; set; }
        public int forcePower { get; set; }
        public int blasterSkill { get; set; }
        public Weapon.Weapon currentWeapon { get; set; }
        public Blaster.Blaster currentBlaster { get; set; }
        //public Force.Force currentForce { get; set; }
        //public Weapon.Skill currentSkill { get; set; }
        public bool hasStunningStrike { get; set; }
        public bool hasBoomerang { get; set; }
        public bool hasForcePush { get; set; }
        public bool hasForceChoke { get; set; }

        

        // stateful characteristics/derived characteristics
        public int health;
        public int currHealth;
        public bool defending = false;
        public bool stunned = false;
        protected int level;
        public int reflexSave;
        public int fortitudeSave;
        public int willSave;
        public int forceSave;
        int weapHitBonus;
        int blastHitBonus;

        public Character() {
            constitution = 8;
            dexterity = 8;
            charisma = 8;
            weaponSkill = 8;
            forcePower = 8;
            blasterSkill = 8;
        }

        public Character(int constitution, int dexterity, int charisma, int weaponSkill, int forcePower, int blasterSkill, int level)
        {
            this.level = level;
            this.constitution = constitution;
            this.dexterity = dexterity;
            this.charisma = charisma;
            this.weaponSkill = weaponSkill;
            this.forcePower = forcePower;
            this.blasterSkill = blasterSkill;
        }

        public int makeBonus(int stat)
        {
            return (int)Math.Round((decimal)(stat - 10) / 2, MidpointRounding.ToZero);
        }

        public void setStatefuls()
        {
            health = (constitution + 5) * level;
            currHealth = (constitution + 5) * level;
            forceSave = makeBonus(forcePower);
            reflexSave = makeBonus(dexterity) + forceSave;
            fortitudeSave = makeBonus(constitution);
            willSave = makeBonus(charisma);
            weapHitBonus = makeBonus(weaponSkill) + makeBonus(dexterity);
            blastHitBonus = makeBonus(blasterSkill);
            if (weaponSkill > 13) { hasBoomerang = true; hasStunningStrike = true; }
            else if (weaponSkill > 10) { hasBoomerang = false; hasStunningStrike = true; }
            else { hasBoomerang = false; hasStunningStrike= false; }
            if (forcePower > 13) { hasForceChoke = true; hasForcePush = true; }
            else if (forcePower > 10) { hasForceChoke = false; hasForcePush = true; }
            else { hasForceChoke = false; hasForcePush = false; }

        }

        public int performAttack()
        {
            Random rnd = new Random();
            return weapHitBonus +  + rnd.Next(1, 21);
        }

        public int performShot()
        {
            Random rnd = new Random();
            return blastHitBonus + rnd.Next(1, 21);
        }

        public bool checkHit(int attack, int defend)
        {
            if (attack <= defend) return false;
            return true;
        }

        public void defend(int incomingDamage)
        {
            if ((incomingDamage - (reflexSave + fortitudeSave)) > 0) currHealth -= incomingDamage - (reflexSave + fortitudeSave);
        }

        public int rollStat(int stat)
        {
            Random rnd = new Random();
            return stat + rnd.Next(1, 21);
        }

        public virtual int enemyAction(Form3 form) { return 0; }
        public virtual int enemyActionDistance(Form3 form) { return 0; }
    }
}
