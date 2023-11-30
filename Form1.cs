namespace TheWinFormsChronicles;

public partial class Form1 : Form
{
    UI.uCharacter playerCharacter;
    public Form1()
    {
        InitializeComponent();
        GameLogic.Character.Character gameCharacter = new GameLogic.Character.Character();
        playerCharacter = new UI.uCharacter();
        playerCharacter.Constitution = gameCharacter.constitution;

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

    }

    private void constitution_ValueChanged(object sender, EventArgs e)
    {
        int constititionToAdd = (int)constitutionDisp.Value;
        if (constititionToAdd > playerCharacter.Constitution) playerCharacter.CreationPoints -= 1;
        else if (constititionToAdd < playerCharacter.Constitution) playerCharacter.CreationPoints += 1;
        playerCharacter.Constitution = constititionToAdd;
        //playerCharacter.CreationPoints -= constititionToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.Constitution + "";
    }

    private void dexterity_ValueChanged(object sender, EventArgs e)
    {
        int dexterityToAdd = (int)dexterityDisp.Value;
        if (dexterityToAdd > playerCharacter.Dexterity) playerCharacter.CreationPoints -= 1;
        else if (dexterityToAdd < playerCharacter.Dexterity) playerCharacter.CreationPoints += 1;
        playerCharacter.Dexterity = dexterityToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.Dexterity + "";
    }

    private void charisma_ValueChanged(object sender, EventArgs e)
    {
        int charismaToAdd = (int)charismaDisp.Value;
        if (charismaToAdd > playerCharacter.Charisma) playerCharacter.CreationPoints -= 1;
        else if (charismaToAdd < playerCharacter.Charisma) playerCharacter.CreationPoints += 1;
        playerCharacter.Charisma = charismaToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.Charisma + "";
    }

    private void weaponSkill_ValueChanged(object sender, EventArgs e)
    {
        int weaponSkillToAdd = (int)weaponSkillDisp.Value;
        if (weaponSkillToAdd > playerCharacter.WeaponSkill) playerCharacter.CreationPoints -= 1;
        else if (weaponSkillToAdd < playerCharacter.WeaponSkill) playerCharacter.CreationPoints += 1;
        playerCharacter.WeaponSkill = weaponSkillToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.WeaponSkill + "";
    }

    private void forcePower_ValueChanged(object sender, EventArgs e)
    {
        int forcePowerToAdd = (int)forcePowerDisp.Value;
        if (forcePowerToAdd > playerCharacter.ForcePower) playerCharacter.CreationPoints -= 1;
        else if (forcePowerToAdd < playerCharacter.ForcePower) playerCharacter.CreationPoints += 1;
        playerCharacter.ForcePower = forcePowerToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.ForcePower + "";
    }

    private void blasterPower_ValueChanged(object sender, EventArgs e)
    {
        int blasterPowerToAdd = (int)blasterSkillDisp.Value;
        if (blasterPowerToAdd > playerCharacter.BlasterSkill) playerCharacter.CreationPoints -= 1;
        else if (blasterPowerToAdd < playerCharacter.BlasterSkill) playerCharacter.CreationPoints += 1;
        playerCharacter.BlasterSkill = blasterPowerToAdd;
        pointsLeft.Text = "Points Left: " + playerCharacter.CreationPoints;
        test.Text = playerCharacter.BlasterSkill + "";
    }
}