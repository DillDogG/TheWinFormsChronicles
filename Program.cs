using TheWinFormsChronicles.GameLogic.Character;
using TheWinFormsChronicles.GameLogic.dialogue;

namespace TheWinFormsChronicles;

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
        FormManager formManager = new FormManager();
        Application.Run(FormManager.Current);

        Character myCharacter = new Character();
        NonPlayerCharacter generalGrevious = new NonPlayerCharacter();
        generalGrevious.dialogue = new Dialogue();

        // romance tree
        Response romanceContinuation = new Response();
        Response romanceSpurned = new Response();
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

        Response startOfDialogue = new Response();
        startOfDialogue.responseText = "General Kenobi!";
        startOfDialogue.dialogueOptions.Add(
            "How've you been",
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
        currentResponse = currentResponse.dialogueOptions["How've you been"];
        // show the player the next set of dialogue options
        string[] playerOptions = currentResponse.dialogueOptions.Keys.ToArray();
        // the player chooses violence
        currentResponse = currentResponse.dialogueOptions["PSYCH!!"];
        playerOptions = currentResponse.dialogueOptions.Keys.ToArray();
        if (playerOptions.Length == 0) {
            // dialogue has ended
        }
    }    
}