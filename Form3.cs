using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWinFormsChronicles.GameLogic.Force;

namespace TheWinFormsChronicles
{
    public partial class Form3 : Form
    {
        int playerLocation;
        int enemyLocation;
        string pastText;
        Image enemyImage;
        GameLogic.Character.Character enemy;
        public Form3()
        {
            InitializeComponent();
            playerLocation = 1;
            enemyLocation = 6;
            phpDisp.Text = "Player Health: " + Globals.player.currHealth + "/" + Globals.player.health;
            if (!Globals.player.hasForcePush) { forcePull.Enabled = false; forcePush.Enabled = false; }
            else { forcePull.Enabled = true; forcePush.Enabled = true; }
            if (!Globals.player.hasForceChoke) fChoke.Enabled = false;
            else fChoke.Enabled = true;
            if (!Globals.player.hasStunningStrike) WeapSkill.Enabled = false;
            else WeapSkill.Enabled = true;
        }

        public void makeEnemy(int level, bool sith)
        {
            if (sith)
            {
                enemy = new GameLogic.Character.Sith(level);
                enemyImage = Properties.Resources.PlayerCharacterWinFormChronicles;
            }
            else
            {
                enemy = new GameLogic.Character.StormTrooper(level);
                enemyImage = Properties.Resources.CloneTrooperWinFormChronicles;
            }
            pictureBox6.BackgroundImage = enemyImage;
            ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
        }

        public void enemyAction()
        {
            Globals.player.stunned = false;
            if (enemy.currHealth < 0)
            {
                endBattle(true);
                return;
            }
            if (enemy.stunned) { enemy.stunned = false; return; }
            if (playerLocation == (enemyLocation - 1))
            {
                switch (enemy.enemyAction(this))
                {
                    case 0:
                        description.Text = pastText + "\nThe enemy attacked you.";
                        pastText = "";
                        break;
                    case 1:
                        description.Text = pastText + "\nThe enemy attempted stunning strike. It didn't stun.";
                        pastText = "";
                        break;
                    case 2:
                        description.Text = pastText + "\nThe enemy attempted force choke. It failed.";
                        pastText = "";
                        break;
                    case 3:
                        pastText += "The enemy attempted stunning strike. It stunned you. ";
                        break;
                    case 4:
                        pastText += "The enemy attempted force choke. It worked. ";
                        break;
                    case 5:
                        description.Text = pastText;
                        pastText = "";
                        break;
                }
            }
            else
            {
                switch (enemy.enemyActionDistance(this))
                {
                    case 0:
                        description.Text = pastText;
                        pastText = "";
                        break;
                    case 1:
                        description.Text = pastText + "The enemy threw their weapon at you.";
                        pastText = "";
                        break;
                    case 2:
                        description.Text = pastText + "\nThe enemy attempted force choke. It failed.";
                        pastText = "";
                        break;
                    case 3:
                        pastText += "The enemy attempted force choke. It worked. ";
                        break;
                    case 4:
                        description.Text = pastText + "\nThe enemy attempted force pull. It failed.";
                        pastText = "";
                        break;
                    case 5:
                        description.Text = pastText + "\nThe enemy attempted force pull. It worked.";
                        pastText = "";
                        break;

                }
            }
            Globals.player.defending = false;
            phpDisp.Text = "Player Health: " + Globals.player.currHealth + "/" + Globals.player.health;
            if (Globals.player.currHealth < 0) endBattle(false);
            if (Globals.player.stunned) enemyAction();
        }

        public void moveUnit(bool player, int distance)
        {
            if (player)
            {
                switch (playerLocation)
                {
                    case 1:
                        pictureBox1.BackgroundImage = null;
                        break;
                    case 2:
                        pictureBox2.BackgroundImage = null;
                        break;
                    case 3:
                        pictureBox3.BackgroundImage = null;
                        break;
                    case 4:
                        pictureBox4.BackgroundImage = null;
                        break;
                    case 5:
                        pictureBox5.BackgroundImage = null;
                        break;
                }
                playerLocation += distance;
                if (playerLocation < 1) playerLocation = 1;
                else if (playerLocation > 5) playerLocation = 5;
                switch (playerLocation)
                {
                    case 1:
                        Move1.Enabled = false;
                        Move2.Enabled = true;
                        Move3.Enabled = false;
                        Move4.Enabled = false;
                        Move5.Enabled = false;
                        pictureBox1.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
                        break;
                    case 2:
                        Move1.Enabled = true;
                        Move2.Enabled = false;
                        Move3.Enabled = true;
                        Move4.Enabled = false;
                        Move5.Enabled = false;
                        pictureBox2.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
                        break;
                    case 3:
                        Move1.Enabled = false;
                        Move2.Enabled = true;
                        Move3.Enabled = false;
                        Move4.Enabled = true;
                        Move5.Enabled = false;
                        pictureBox3.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
                        break;
                    case 4:
                        Move1.Enabled = false;
                        Move2.Enabled = false;
                        Move3.Enabled = true;
                        Move4.Enabled = false;
                        Move5.Enabled = true;
                        pictureBox4.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
                        break;
                    case 5:
                        Move1.Enabled = false;
                        Move2.Enabled = false;
                        Move3.Enabled = false;
                        Move4.Enabled = true;
                        Move5.Enabled = false;
                        pictureBox5.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
                        break;
                }
            }
            else
            {
                switch (enemyLocation)
                {
                    case 2:
                        pictureBox2.BackgroundImage = null;
                        break;
                    case 3:
                        pictureBox3.BackgroundImage = null;
                        break;
                    case 4:
                        pictureBox4.BackgroundImage = null;
                        break;
                    case 5:
                        pictureBox5.BackgroundImage = null;
                        break;
                    case 6:
                        pictureBox6.BackgroundImage = null;
                        break;
                }
                enemyLocation += distance;
                if (enemyLocation < 2) enemyLocation = 2;
                else if (enemyLocation > 6) enemyLocation = 6;
                if (enemyLocation == playerLocation) enemyLocation++;
            }
            switch (enemyLocation)
            {
                case 2:
                    Move2.Enabled = false;
                    pictureBox2.BackgroundImage = enemyImage;
                    break;
                case 3:
                    Move3.Enabled = false;
                    pictureBox3.BackgroundImage = enemyImage;
                    break;
                case 4:
                    Move4.Enabled = false;
                    pictureBox4.BackgroundImage = enemyImage;
                    break;
                case 5:
                    Move5.Enabled = false;
                    pictureBox5.BackgroundImage = enemyImage;
                    break;
                case 6:
                    Move6.Enabled = false;
                    pictureBox6.BackgroundImage = enemyImage;
                    break;
            }
        }

        public void endBattle(bool player)
        {
            if (player)
            {
                Globals.formManager.OpenLevelUp();
                Globals.formManager.OpenDialogue();
                Close();
            }
            else Close();
        }

        private void charDisp_Click(object sender, EventArgs e)
        {
            Globals.formManager.OpenCharacterStats(false);
        }

        private void Defend_Click(object sender, EventArgs e)
        {
            Globals.player.defending = true;
            enemyAction();
        }

        private void Move1_Click(object sender, EventArgs e)
        {
            if (playerLocation > 1) moveUnit(true, -1);
            else if (playerLocation < 1) moveUnit(true, 1);
            enemyAction();
        }

        private void Move2_Click(object sender, EventArgs e)
        {
            if (playerLocation > 2) moveUnit(true, -1);
            else if (playerLocation < 2) moveUnit(true, 1);
            enemyAction();
        }

        private void Move3_Click(object sender, EventArgs e)
        {
            if (playerLocation > 3) moveUnit(true, -1);
            else if (playerLocation < 3) moveUnit(true, 1);
            enemyAction();
        }

        private void Move4_Click(object sender, EventArgs e)
        {
            if (playerLocation > 4) moveUnit(true, -1);
            else if (playerLocation < 4) moveUnit(true, 1);
            enemyAction();
        }

        private void Move5_Click(object sender, EventArgs e)
        {
            if (playerLocation > 5) moveUnit(true, -1);
            else if (playerLocation < 5) moveUnit(true, 1);
            enemyAction();
        }

        private void Move6_Click(object sender, EventArgs e)
        {
            if (playerLocation > 6) moveUnit(true, -1);
            else if (playerLocation < 6) moveUnit(true, 1);
            enemyAction();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (playerLocation != (enemyLocation - 1) && !Globals.player.hasBoomerang) return;
            if (playerLocation != (enemyLocation - 1) && Globals.player.checkHit(Globals.boomerang.performSkill(Globals.player.makeBonus(Globals.player.weaponSkill)), enemy.reflexSave))
            {
                enemy.currHealth -= Globals.player.currentWeapon.attack();
                ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
                pastText += "You threw your weapon, hitting the enemy. The weapon returned to you. ";
            }
            else if (Globals.player.checkHit(Globals.player.performAttack(), enemy.rollStat(enemy.reflexSave)))
            {
                enemy.currHealth -= Globals.player.currentWeapon.attack();
                ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
                pastText += "You hit the enemy. ";
            }
            else pastText += "You missed the enemy. ";
            enemyAction();
        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            if (Globals.player.checkHit(Globals.player.performShot(), enemy.rollStat(enemy.reflexSave)))
            {
                enemy.currHealth -= Globals.player.currentBlaster.attack();
                ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
                pastText += "You hit the enemy. ";
            }
            else pastText += "You missed the enemy.";
            enemyAction();
        }

        private void fChoke_Click(object sender, EventArgs e)
        {
            if (Globals.choke.performForce(Globals.player.forceSave, enemy.forceSave))
            {
                enemy.currHealth -= Globals.choke.chokeTarget();
                ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
                description.Text = pastText + "You attempted force choke. It worked. ";
                pastText = "";
                enemy.stunned = true;
            }
            else pastText += "You attempted force choke. It failed. ";
            enemyAction();
        }

        private void forcePush_Click(object sender, EventArgs e)
        {
            if (Globals.pushPull.performForce(Globals.player.forceSave, enemy.forceSave))
            {
                Globals.pushPull.pushPull(1, false, this);
                pastText += "You pushed the enemy away. ";
                moveUnit(true, 0);
            }
            else pastText += "You were unable to push the enemy. ";
            enemyAction();
        }

        private void forcePull_Click(object sender, EventArgs e)
        {
            if (Globals.pushPull.performForce(Globals.player.forceSave, enemy.forceSave))
            {
                Globals.pushPull.pushPull(-1, false, this);
                pastText += "You pulled the enemy closer. ";
            }
            else pastText += "You were unable to pull the enemy. ";
            enemyAction();
        }

        private void WeapSkill_Click(object sender, EventArgs e)
        {
            if (playerLocation != (enemyLocation - 1)) return;
            if (Globals.player.checkHit(Globals.stunningStrike.performSkill(Globals.player.makeBonus(Globals.player.weaponSkill)), enemy.reflexSave))
            {
                enemy.currHealth -= Globals.player.currentWeapon.attack();
                if (Globals.stunningStrike.checkEffect(Globals.player.rollStat(Globals.player.makeBonus(Globals.player.weaponSkill)), enemy.fortitudeSave))
                {
                    enemy.stunned = true;
                    description.Text = pastText + "You stunned the enemy. ";
                    pastText = "";
                }
                else pastText += "You hit the enemy, but didn't stun. ";
                ehpDisp.Text = "Enemy Health: " + enemy.currHealth + "/" + enemy.health;
            }
            else pastText += "You missed the enemy. ";
            enemyAction();
        }
    }
}