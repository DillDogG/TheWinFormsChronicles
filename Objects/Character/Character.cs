using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.Objects.Character
{
    internal class Character /*: ICharacter */
    {
        // general characteristics
        string name;
        // stats
        private int constitution;
        private int dexterity;
        private int weaponSkill;
        private int forcePower;
        private int blasterSkill;

        

        // stateful characteristics/derived characteristics
        int health;
        int reflexSave;
        int fortitudeSave;
        int willSave;
        int forceSave;

        public Character() {
            constitution = 8;
            dexterity = 8;
            weaponSkill = 8;
            forcePower = 8;
            blasterSkill = 8;
        }

        

        // equiped items

        // behavior for equiping items

        public void move()
        {

        }

        public virtual bool attemptAttack(int difficulty)
        {
            // randomize hit using specific skill
            return false;
        }

        public int performAttack()
        {
            return weaponSkill * 5;
        }

        public void defend(int incomingDamage)
        {
            health -= incomingDamage - (dexterity * (forceSave + 1));
        }
    }
}
