using GameLogic.GameLogic.Character;
using GameLogic.GameLogic.dialogue;

namespace GameLogic;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Globals.formManager.OpenCharacterStats();
        //Globals.formManager.OpenBattlePage();
        Globals.formManager.OpenLevelUp();
        

        GameLogic.Character.Character myCharacter = new GameLogic.Character.Character();
        NonPlayerCharacter generalGrevious = new NonPlayerCharacter("General Grevious");
        generalGrevious.dialogue = new Dialogue();
        Response beg = new Response();

        Response end = new Response();
        end.responseText = "End Dialogue";
        
        // romance tree
        Response romanceContinuation = new Response();
        romanceContinuation.responseText = "Oh, really? Well, how've you been?";
        romanceContinuation.dialogueOptions.Add(
            "I've been good.",
            beg
            ) ;
        romanceContinuation.dialogueOptions.Add(
            "They haven't been that good.",
            end
            );
        Response romanceSpurned = new Response();
        romanceSpurned.responseText = "I knew it. You're dying for that sick joke.";
        romanceSpurned.dialogueOptions.Add(
            "Start fight",
            end
            );
        // romance start response
        Response romanceStart = new Response();
        romanceStart.responseText = "Oh Obi, I didn't know you cared so...";
        romanceStart.dialogueOptions.Add(
            "I've always cared.",
            romanceContinuation
            );
        romanceStart.dialogueOptions.Add(
            "PSYCH!!",
            romanceSpurned
            );

        // violence tree
        // violence start option
        Response violenceStart = new Response();
        violenceStart.responseText = "VIOLENCE!!!";
        violenceStart.dialogueOptions.Add(
            "Start fight small",
            end
            );

        Response startOfDialogue = new Response();
        startOfDialogue.responseText = "General Kenobi!";
        startOfDialogue.dialogueOptions.Add(
            "How've you been?",
            romanceStart
            );
        startOfDialogue.dialogueOptions.Add(
            "SARCASM!!!",
            violenceStart
            );

        generalGrevious.dialogue.dialogueStart = startOfDialogue;

        // show the player dialogue
        Response currentResponse = generalGrevious.dialogue.dialogueStart;

        // player has chosen romance
        currentResponse = currentResponse.dialogueOptions["How've you been?"];
        // show the player the next set of dialogue options
        string[] playerOptions = currentResponse.dialogueOptions.Keys.ToArray();
        // the player chooses violence
        currentResponse = currentResponse.dialogueOptions["PSYCH!!"];
        playerOptions = currentResponse.dialogueOptions.Keys.ToArray();
        if (playerOptions.Length == 0) {
            // dialogue has ended
        }
        Globals.formManager.OpenDialogue(generalGrevious);
        Application.Run(FormManager.Current);
    }    
}