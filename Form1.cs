namespace TheWinFormsChronicles;

public partial class Form1 : Form
{
    UI.Character playerCharacter;
    public Form1()
    {
        InitializeComponent();
        GameLogic.Character.Character gameCharacter = new GameLogic.Character.Character();
        playerCharacter = new UI.Character();
        playerCharacter.Constitution = gameCharacter.constitution;

        initializeCharacterComponents();

    }
    private void initializeCharacterComponents()
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    private void charCreate_Click(object sender, EventArgs e)
    {

    }

    private void constitution_ValueChanged(object sender, EventArgs e)
    {

    }
}
