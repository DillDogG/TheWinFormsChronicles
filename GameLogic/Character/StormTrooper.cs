using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.GameLogic.Character
{
    internal class StormTrooper : Character
    {
        public StormTrooper(int level)
        {
            this.level = level;
            constitution = 10 + level;
            dexterity = 13 + level;
            charisma = 10 + (level / 3);
            weaponSkill = 8;
            forcePower = 8;
            blasterSkill = 15 + level;
            currentBlaster = new Blaster.RapidBlaster();
            setStatefuls();
        }

        public override int enemyAction(Form3 form)
        {
            Random rnd = new Random();
            int choice = rnd.Next(2);
            switch (choice)
            {
                case 0:
                    choice = 5;
                    form.moveUnit(false, 1);
                    form.moveUnit(true, 0);
                    break;
                case 1:
                    choice = 0;
                    if (checkHit(Globals.player.performShot(), Globals.player.rollStat(Globals.player.reflexSave)))
                    {
                        if (!Globals.player.defending) Globals.player.currHealth -= currentBlaster.attack();
                        else Globals.player.defend(currentBlaster.attack());
                    }
                    break;
            }
            return choice;
        }

        public override int enemyActionDistance(Form3 form)
        {
            Random rnd = new Random();
            int choice = rnd.Next(7);
            switch (choice)
            {
                case 0:
                    form.moveUnit(false, -1);
                    break;
                default:
                    choice = 1;
                    if (checkHit(Globals.player.performShot(), Globals.player.rollStat(Globals.player.reflexSave)))
                    {
                        if (!Globals.player.defending) Globals.player.currHealth -= currentBlaster.attack();
                        else Globals.player.defend(currentBlaster.attack());
                    }
                    break;
            }
            return choice;
        }
    }
}
