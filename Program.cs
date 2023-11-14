using TheWinFormsChronicles.Objects.Character;

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

        StormTrooper notRex = new StormTrooper();
        notRex.attemptAttack(3);
    }    
}