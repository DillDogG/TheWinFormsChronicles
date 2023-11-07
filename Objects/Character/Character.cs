using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.Objects.Character
{
    internal class Character
    {
        // general characteristics
        string name;
        // stats
        int constitution;
        int dexterity;
        int weaponSkill;
        int forcePower;
        int blasterPower;
        

        // stateful characteristics/derived characteristics
        int health;
        int reflexSave;
        int fortitudeSave;
        int willSave;
        int forceSave;

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
            health -= incomingDamage - dexterity;
        }
    }
}
