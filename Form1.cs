namespace TheWinFormsChronicles;

public partial class Character : Form
{
    UI.uCharacter playerCharacter;
    GameLogic.Character.PlayerCharacter pChar;
    public Character()
    {
        InitializeComponent();
        //GameLogic.Character.Character gameCharacter = new GameLogic.Character.Character();
        playerCharacter = new UI.uCharacter();
        //playerCharacter.Constitution = gameCharacter.constitution;

        initializeCharacterComponents();

    }
    private void initializeCharacterComponents()
    {
        constitutionDisp.DataBindings.Add("Text", playerCharacter, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
        dexterityDisp.DataBindings.Add("Text", playerCharacter, "dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
        charismaDisp.DataBindings.Add("Text", playerCharacter, "charisma", false, DataSourceUpdateMode.OnPropertyChanged);
        weaponSkillDisp.DataBindings.Add("Text", playerCharacter, "weaponSkill", false, DataSourceUpdateMode.OnPropertyChanged);
        forcePowerDisp.DataBindings.Add("Text", playerCharacter, "forcePower", false, DataSourceUpdateMode.OnPropertyChanged);
        blasterSkillDisp.DataBindings.Add("Text", playerCharacter, "blasterSkill", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    private void charCreate_Click(object sender, EventArgs e)
    {
        if (playerCharacter.CreationPoints > 0)
        {
            pointsLeft.Text = "Can't create character, still have " + playerCharacter.CreationPoints + " points left.";
        }
        else if (playerCharacter.CreationPoints < 0)
        {
            pointsLeft.Text = "Can't create character, spent too many points.";
        }
        else
        {
            pChar = new GameLogic.Character.PlayerCharacter(playerCharacter.Constitution, playerCharacter.Dexterity, playerCharacter.Charisma, playerCharacter.WeaponSkill, playerCharacter.ForcePower, playerCharacter.BlasterSkill);
            charCreate.Enabled = false;
            constitutionDisp.Enabled = false;
            constitutionDisp.Maximum = 20;
        }
    }

    private void constitutionDisp_ValueChanged(object sender, EventArgs e)
    {
        int constititionToAdd = (int)constitutionDisp.Value;
        if (constititionToAdd > playerCharacter.Constitution)
        {
            if (playerCharacter.Constitution >= 13) playerCharacter.CreationPoints -= 2;
            else playerCharacter.CreationPoints -= 1;
        }
        else if (constititionToAdd < playerCharacter.Constitution)
        {
            if (playerCharacter.Constitution > 13) playerCharacter.CreationPoints += 2;
            else playerCharacter.CreationPoints += 1;
        }
        playerCharacter.Constitution = constititionToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        hpDisp.Text = "Health: " + (playerCharacter.Constitution + 5);

    }

    private void dexterityDisp_ValueChanged(object sender, EventArgs e)
    {
        int dexterityToAdd = (int)dexterityDisp.Value;
        if (dexterityToAdd > playerCharacter.Dexterity)
        {
            if (playerCharacter.Dexterity >= 13) playerCharacter.CreationPoints -= 2;
            else playerCharacter.CreationPoints -= 1;
        }
        else if (dexterityToAdd < playerCharacter.Dexterity)
        {
            if (playerCharacter.Dexterity > 13) playerCharacter.CreationPoints += 2;
            else playerCharacter.CreationPoints += 1;
        }
        playerCharacter.Dexterity = dexterityToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
    }

    private void charismaDisp_ValueChanged(object sender, EventArgs e)
    {
        int charismaToAdd = (int)charismaDisp.Value;
        if (charismaToAdd > playerCharacter.Charisma)
        {
            if (playerCharacter.Charisma >= 13) playerCharacter.CreationPoints -= 2;
            else playerCharacter.CreationPoints -= 1;
        }
        else if (charismaToAdd < playerCharacter.Charisma)
        {
            if (playerCharacter.Charisma > 13) playerCharacter.CreationPoints += 2;
            else playerCharacter.CreationPoints += 1;
        }
        playerCharacter.Charisma = charismaToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
    }

    private void weaponSkillDisp_ValueChanged(object sender, EventArgs e)
    {
        int weaponSkillToAdd = (int)weaponSkillDisp.Value;
        if (weaponSkillToAdd > playerCharacter.WeaponSkill)
        {
            if (playerCharacter.WeaponSkill >= 13)
            {
                playerCharacter.CreationPoints -= 2;
                currWeapon.Text = "Weapon: Light Saber";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike, Boomerang";
            }
            else if (playerCharacter.WeaponSkill >= 10)
            {
                playerCharacter.CreationPoints -= 1;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else
            {
                playerCharacter.CreationPoints -= 1;
                currWeapon.Text = "Weapon: Baton";
                currWeapAbilities.Text = "Weapon Abilities: ";
            }
        }
        else if (weaponSkillToAdd < playerCharacter.WeaponSkill)
        {
            if (playerCharacter.WeaponSkill > 14)
            {
                playerCharacter.CreationPoints += 2;
                currWeapon.Text = "Weapon: Light Saber";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike, Boomerang";
            }
            else if (playerCharacter.WeaponSkill > 13)
            {
                playerCharacter.CreationPoints += 2;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else if (playerCharacter.WeaponSkill > 11)
            {
                playerCharacter.CreationPoints += 1;
                currWeapon.Text = "Weapon: Crackling Baton";
                currWeapAbilities.Text = "Weapon Abilities: Stunning Strike";
            }
            else
            {
                playerCharacter.CreationPoints += 1;
                currWeapon.Text = "Weapon: Baton";
                currWeapAbilities.Text = "Weapon Abilities: ";
            }
        }
        playerCharacter.WeaponSkill = weaponSkillToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
    }

    private void forcePowerDisp_ValueChanged(object sender, EventArgs e)
    {
        int forcePowerToAdd = (int)forcePowerDisp.Value;
        if (forcePowerToAdd > playerCharacter.ForcePower)
        {
            if (playerCharacter.ForcePower >= 13)
            {
                playerCharacter.CreationPoints -= 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull, Choke";
            }
            else if (playerCharacter.ForcePower >= 10)
            {
                playerCharacter.CreationPoints -= 1;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else
            {
                playerCharacter.CreationPoints -= 1;
                currForceAbilities.Text = "Force Abilities: Grab Object";
            }
        }
        else if (forcePowerToAdd < playerCharacter.ForcePower)
        {
            if (playerCharacter.ForcePower > 14)
            {
                playerCharacter.CreationPoints += 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull, Choke";
            }
            else if (playerCharacter.ForcePower > 13)
            {
                playerCharacter.CreationPoints += 2;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else if (playerCharacter.ForcePower > 11)
            {
                playerCharacter.CreationPoints += 1;
                currForceAbilities.Text = "Force Abilities: Push/Pull";
            }
            else
            {
                playerCharacter.CreationPoints += 1;
                currForceAbilities.Text = "Force Abilities: Grab Object";
            }
        }
        playerCharacter.ForcePower = forcePowerToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
    }

    private void blasterSkillDisp_ValueChanged(object sender, EventArgs e)
    {
        int blasterPowerToAdd = (int)blasterSkillDisp.Value;
        if (blasterPowerToAdd > playerCharacter.BlasterSkill)
        {
            if (playerCharacter.BlasterSkill >= 13)
            {
                playerCharacter.CreationPoints -= 2;
                currBlast.Text = "Blaster: Rapid Blaster";
            }
            else if (playerCharacter.BlasterSkill >= 10)
            {
                playerCharacter.CreationPoints -= 1;
                currBlast.Text = "Blaster: New Blaster";
            }
            else
            {
                playerCharacter.CreationPoints -= 1;
                currBlast.Text = "Blaster: Old Blaster";
            }
        }
        else if (blasterPowerToAdd < playerCharacter.BlasterSkill)
        {
            if (playerCharacter.BlasterSkill > 14)
            {
                playerCharacter.CreationPoints += 2;
                currBlast.Text = "Blaster: Rapid Blaster";
            }
            else if (playerCharacter.BlasterSkill > 13)
            {
                playerCharacter.CreationPoints += 2;
                currBlast.Text = "Blaster: New Blaster";
            }
            else if (playerCharacter.BlasterSkill > 11)
            {
                playerCharacter.CreationPoints += 1;
                currBlast.Text = "Blaster: New Blaster";
            }
            else
            {
                playerCharacter.CreationPoints += 1;
                currBlast.Text = "Blaster: Old Blaster";
            }
        }
        playerCharacter.BlasterSkill = blasterPowerToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
    }
}