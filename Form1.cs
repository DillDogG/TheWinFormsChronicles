using TheWinFormsChronicles.UI;

namespace TheWinFormsChronicles;

public partial class Form1 : Form
{
    //GameLogic.Character.PlayerCharacter pChar;
    public Form1()
    {
        InitializeComponent();

        initializeCharacterComponents();

    }

    public void setCharacter()
    {
        //playerCharacter = pCharacter;
        charCreate.Enabled = false;
        constitutionDisp.Enabled = false;
        constitutionDisp.Maximum = 20;
        constitutionDisp.Value = Globals.u_player.Constitution;
        dexterityDisp.Enabled = false;
        dexterityDisp.Maximum = 20;
        dexterityDisp.Value = Globals.u_player.Dexterity;
        charismaDisp.Enabled = false;
        charismaDisp.Maximum = 20;
        charismaDisp.Value = Globals.u_player.Charisma;
        weaponSkillDisp.Enabled = false;
        weaponSkillDisp.Maximum = 20;
        weaponSkillDisp.Value = Globals.u_player.WeaponSkill;
        forcePowerDisp.Enabled = false;
        forcePowerDisp.Maximum = 20;
        forcePowerDisp.Value = Globals.u_player.ForcePower;
        blasterSkillDisp.Enabled = false;
        blasterSkillDisp.Maximum = 20;
        blasterSkillDisp.Value = Globals.u_player.BlasterSkill;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
        hpDisp.Text = "Health: " + (Globals.u_player.Constitution + 5);
        if (Globals.u_player.WeaponSkill >= 13)
        {
            currWeapon.Text = "Weapon: Light Saber";
            currWeapAbilities.Text = "Weapon Abilities: Stunning Strike, Boomerang";
        }
        else if (Globals.u_player.WeaponSkill >= 10)
        {
            currWeapon.Text = "Weapon: Crackling Baton";
            currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
        }
        else
        {
            currWeapon.Text = "Weapon: Baton";
            currWeapAbilities.Text = "Weapon Abilities: ";
        }
        if (Globals.u_player.ForcePower >= 13) currForceAbilities.Text = "Force Abilities: Push/Pull, Choke";
        else if (Globals.u_player.ForcePower >= 10) currForceAbilities.Text = "Force Abilities: Push/Pull";
        else currForceAbilities.Text = "Force Abilities: ";
        if (Globals.u_player.BlasterSkill >= 13) currBlast.Text = "Blaster: Rapid Blaster";
        else if (Globals.u_player.BlasterSkill >= 10) currBlast.Text = "Blaster: New Blaster";
        else currBlast.Text = "Blaster: Old Blaster";
    }

    private void initializeCharacterComponents()
    {
        constitutionDisp.DataBindings.Add("Text", Globals.u_player, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
        dexterityDisp.DataBindings.Add("Text", Globals.u_player, "dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
        charismaDisp.DataBindings.Add("Text", Globals.u_player, "charisma", false, DataSourceUpdateMode.OnPropertyChanged);
        weaponSkillDisp.DataBindings.Add("Text", Globals.u_player, "weaponSkill", false, DataSourceUpdateMode.OnPropertyChanged);
        forcePowerDisp.DataBindings.Add("Text", Globals.u_player, "forcePower", false, DataSourceUpdateMode.OnPropertyChanged);
        blasterSkillDisp.DataBindings.Add("Text", Globals.u_player, "blasterSkill", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    private void charCreate_Click(object sender, EventArgs e)
    {
        if (Globals.u_player.CreationPoints > 0)
        {
            pointsLeft.Text = "Can't create character, still have " + Globals.u_player.CreationPoints + " points left.";
        }
        else if (Globals.u_player.CreationPoints < 0)
        {
            pointsLeft.Text = "Can't create character, spent too many points.";
        }
        else
        {
            Globals.player.createCharacter(Globals.u_player.Constitution, Globals.u_player.Dexterity, Globals.u_player.Charisma, Globals.u_player.WeaponSkill, Globals.u_player.ForcePower, Globals.u_player.BlasterSkill);
            charCreate.Enabled = false;
            constitutionDisp.Enabled = false;
            constitutionDisp.Maximum = 20;
            dexterityDisp.Enabled = false;
            dexterityDisp.Maximum = 20;
            charismaDisp.Enabled = false;
            charismaDisp.Maximum = 20;
            weaponSkillDisp.Enabled = false;
            weaponSkillDisp.Maximum = 20;
            forcePowerDisp.Enabled = false;
            forcePowerDisp.Maximum = 20;
            blasterSkillDisp.Enabled = false;
            blasterSkillDisp.Maximum = 20;
            Globals.formManager.OpenBattlePage(1, false);
        }
    }

    private void constitutionDisp_ValueChanged(object sender, EventArgs e)
    {
        int constititionToAdd = (int)constitutionDisp.Value;
        if (constititionToAdd > Globals.u_player.Constitution)
        {
            if (Globals.u_player.Constitution >= 13) Globals.u_player.CreationPoints -= 2;
            else Globals.u_player.CreationPoints -= 1;
        }
        else if (constititionToAdd < Globals.u_player.Constitution)
        {
            if (Globals.u_player.Constitution > 13) Globals.u_player.CreationPoints += 2;
            else Globals.u_player.CreationPoints += 1;
        }
        Globals.u_player.Constitution = constititionToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
        hpDisp.Text = "Health: " + (Globals.u_player.Constitution + 5);

    }

    private void dexterityDisp_ValueChanged(object sender, EventArgs e)
    {
        int dexterityToAdd = (int)dexterityDisp.Value;
        if (dexterityToAdd > Globals.u_player.Dexterity)
        {
            if (Globals.u_player.Dexterity >= 13) Globals.u_player.CreationPoints -= 2;
            else Globals.u_player.CreationPoints -= 1;
        }
        else if (dexterityToAdd < Globals.u_player.Dexterity)
        {
            if (Globals.u_player.Dexterity > 13) Globals.u_player.CreationPoints += 2;
            else Globals.u_player.CreationPoints += 1;
        }
        Globals.u_player.Dexterity = dexterityToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
    }

    private void charismaDisp_ValueChanged(object sender, EventArgs e)
    {
        int charismaToAdd = (int)charismaDisp.Value;
        if (charismaToAdd > Globals.u_player.Charisma)
        {
            if (Globals.u_player.Charisma >= 13) Globals.u_player.CreationPoints -= 2;
            else Globals.u_player.CreationPoints -= 1;
        }
        else if (charismaToAdd < Globals.u_player.Charisma)
        {
            if (Globals.u_player.Charisma > 13) Globals.u_player.CreationPoints += 2;
            else Globals.u_player.CreationPoints += 1;
        }
        Globals.u_player.Charisma = charismaToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
    }

    private void weaponSkillDisp_ValueChanged(object sender, EventArgs e)
    {
        int weaponSkillToAdd = (int)weaponSkillDisp.Value;
        if (weaponSkillToAdd > Globals.u_player.WeaponSkill)
        {
            if (Globals.u_player.WeaponSkill >= 13)
            {
                Globals.u_player.CreationPoints -= 2;
                currWeapon.Text = "Weapon: Light Saber";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike, Boomerang";
            }
            else if (Globals.u_player.WeaponSkill >= 10)
            {
                Globals.u_player.CreationPoints -= 1;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else
            {
                Globals.u_player.CreationPoints -= 1;
                currWeapon.Text = "Weapon: Baton";
                currWeapAbilities.Text = "Weapon Abilities: ";
            }
        }
        else if (weaponSkillToAdd < Globals.u_player.WeaponSkill)
        {
            if (Globals.u_player.WeaponSkill > 14)
            {
                Globals.u_player.CreationPoints += 2;
                currWeapon.Text = "Weapon: Light Saber";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike, Boomerang";
            }
            else if (Globals.u_player.WeaponSkill > 13)
            {
                Globals.u_player.CreationPoints += 2;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else if (Globals.u_player.WeaponSkill > 11)
            {
                Globals.u_player.CreationPoints += 1;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else
            {
                Globals.u_player.CreationPoints += 1;
                currWeapon.Text = "Weapon: Baton";
                currWeapAbilities.Text = "Weapon Abilities: ";
            }
        }
        Globals.u_player.WeaponSkill = weaponSkillToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
    }

    private void forcePowerDisp_ValueChanged(object sender, EventArgs e)
    {
        int forcePowerToAdd = (int)forcePowerDisp.Value;
        if (forcePowerToAdd > Globals.u_player.ForcePower)
        {
            if (Globals.u_player.ForcePower >= 13)
            {
                Globals.u_player.CreationPoints -= 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull, Choke";
            }
            else if (Globals.u_player.ForcePower >= 10)
            {
                Globals.u_player.CreationPoints -= 1;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else
            {
                Globals.u_player.CreationPoints -= 1;
                currForceAbilities.Text = "Force Abilities: ";
            }
        }
        else if (forcePowerToAdd < Globals.u_player.ForcePower)
        {
            if (Globals.u_player.ForcePower > 14)
            {
                Globals.u_player.CreationPoints += 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull, Choke";
            }
            else if (Globals.u_player.ForcePower > 13)
            {
                Globals.u_player.CreationPoints += 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else if (Globals.u_player.ForcePower > 11)
            {
                Globals.u_player.CreationPoints += 1;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else
            {
                Globals.u_player.CreationPoints += 1;
                currForceAbilities.Text = "Force Abilities: ";
            }
        }
        Globals.u_player.ForcePower = forcePowerToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
    }

    private void blasterSkillDisp_ValueChanged(object sender, EventArgs e)
    {
        int blasterPowerToAdd = (int)blasterSkillDisp.Value;
        if (blasterPowerToAdd > Globals.u_player.BlasterSkill)
        {
            if (Globals.u_player.BlasterSkill >= 13)
            {
                Globals.u_player.CreationPoints -= 2;
                currBlast.Text = "Blaster: Rapid Blaster";
            }
            else if (Globals.u_player.BlasterSkill >= 10)
            {
                Globals.u_player.CreationPoints -= 1;
                currBlast.Text = "Blaster: New Blaster";
            }
            else
            {
                Globals.u_player.CreationPoints -= 1;
                currBlast.Text = "Blaster: Old Blaster";
            }
        }
        else if (blasterPowerToAdd < Globals.u_player.BlasterSkill)
        {
            if (Globals.u_player.BlasterSkill > 14)
            {
                Globals.u_player.CreationPoints += 2;
                currBlast.Text = "Blaster: Rapid Blaster";
            }
            else if (Globals.u_player.BlasterSkill > 13)
            {
                Globals.u_player.CreationPoints += 2;
                currBlast.Text = "Blaster: New Blaster";
            }
            else if (Globals.u_player.BlasterSkill > 11)
            {
                Globals.u_player.CreationPoints += 1;
                currBlast.Text = "Blaster: New Blaster";
            }
            else
            {
                Globals.u_player.CreationPoints += 1;
                currBlast.Text = "Blaster: Old Blaster";
            }
        }
        Globals.u_player.BlasterSkill = blasterPowerToAdd;
        pointsLeft.Text = "Points Left: " + Globals.u_player.CreationPoints;
    }
}