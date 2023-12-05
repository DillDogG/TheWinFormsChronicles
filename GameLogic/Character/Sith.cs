using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.GameLogic.Character
{
    internal class Sith : Character
    {
        public Sith(int level)
        {
            this.level = level;
            constitution = 13 + level;
            dexterity = 13 + level;
            charisma = 10 + (level / 3);
            weaponSkill = 15 + level;
            forcePower = 13 + level;
            blasterSkill = 8;
            currentWeapon = new Weapon.LightSaber();
            setStatefuls();
        }

        public override int enemyAction(Form3 form)
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);
            switch (choice)
            {
                case 0:
                    if (checkHit(performAttack(), Globals.player.reflexSave))
                    {
                        if (!Globals.player.defending) Globals.player.currHealth -= currentWeapon.attack();
                        else Globals.player.defend(currentWeapon.attack());
                    }
                    break;
                case 1:
                    if (checkHit(Globals.stunningStrike.performSkill(makeBonus(weaponSkill)), Globals.player.reflexSave))
                    {
                        if (!Globals.player.defending)
                        {
                            Globals.player.currHealth -= currentWeapon.attack();
                            if (Globals.stunningStrike.checkEffect(rollStat(makeBonus(weaponSkill)), Globals.player.fortitudeSave))
                            {
                                Globals.player.stunned = true;
                                choice = 3;
                            }
                        }
                        else Globals.player.defend(currentWeapon.attack());
                    }
                    break;
                case 2:
                    if (Globals.choke.performForce(forceSave, Globals.player.forceSave))
                    {
                        Globals.choke.chokeTarget();
                        choice = 4;
                        Globals.player.stunned = true;
                    }
                    break;
            }
            return choice;
        }

        public override int enemyActionDistance(Form3 form)
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);
            switch (choice)
            {
                case 0:
                    form.moveUnit(false, -1);
                    break;
                case 1:
                    if (checkHit(Globals.boomerang.performSkill(makeBonus(weaponSkill)), Globals.player.reflexSave))
                    {
                        if (!Globals.player.defending) Globals.player.currHealth -= currentWeapon.attack();
                        else Globals.player.defend(currentWeapon.attack());
                    }
                    break;
                case 2:
                    switch (rnd.Next(2))
                    {
                        case 0:
                            if (Globals.choke.performForce(forceSave, Globals.player.forceSave))
                            {
                                Globals.player.currHealth -= Globals.choke.chokeTarget();
                                choice = 3;
                                Globals.player.stunned = true;
                            }
                            break;
                        case 1:
                            choice = 4;
                            if (Globals.pushPull.performForce(forceSave, Globals.player.forceSave))
                            {
                                Globals.pushPull.pushPull(1, true, form);
                                choice = 5;
                            }
                            break;
                    }
                    break;
            }
            return choice;
        }
    }
}
