using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLogic
{
    public partial class Form4 : Form
    {
        int pointsLeft;
        public Form4()
        {
            InitializeComponent();
            pointsLeft = 2;
            conDisp.Text = "Constitution: " + Globals.player.constitution;
            dexDisp.Text = "Dexterity: " + Globals.player.dexterity;
            charDisp.Text = "Charisma: " + Globals.player.charisma;
            weapDisp.Text = "Weapon Skill: " + Globals.player.weaponSkill;
            forceDisp.Text = "Force Power: " + Globals.player.forcePower;
            blastDisp.Text = "Blaster Skill: " + Globals.player.blasterSkill;
        }

        private void conUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.constitution < 20)
            {
                Globals.player.constitution++;
                Globals.u_player.Constitution++;
                conDisp.Text = "Constitution: " + Globals.player.constitution;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }

        private void dexUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.dexterity < 20)
            {
                Globals.player.dexterity++;
                Globals.u_player.Dexterity++;
                dexDisp.Text = "Dexterity: " + Globals.player.dexterity;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }

        private void charUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.charisma < 20)
            {
                Globals.player.charisma++;
                Globals.u_player.Charisma++;
                charDisp.Text = "Charisma: " + Globals.player.charisma;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }

        private void weapUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.weaponSkill < 20)
            {
                Globals.player.weaponSkill++;
                Globals.u_player.WeaponSkill++;
                weapDisp.Text = "Weapon Skill: " + Globals.player.weaponSkill;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }

        private void forUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.forcePower < 20)
            {
                Globals.player.forcePower++;
                Globals.u_player.ForcePower++;
                forceDisp.Text = "Force Power: " + Globals.player.forcePower;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }

        private void blastUp_Click(object sender, EventArgs e)
        {
            if (pointsLeft > 0 && Globals.player.blasterSkill < 20)
            {
                Globals.player.blasterSkill++;
                Globals.u_player.BlasterSkill++;
                blastDisp.Text = "Blaster Skill: " + Globals.player.blasterSkill;
                pointsLeft--;
            }
            if (pointsLeft <= 0)
            {
                Globals.player.setStatefuls();
                Close();
            }
        }
    }
}
