namespace WinForms_Demo;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        // use this to quickly launch a test Form while developing
        if (true && Environment.MachineName == "TED-PC")
        {
            Demos.DraggableCallout window = new() { StartPosition = FormStartPosition.CenterScreen };
            Application.Run(window);
            Application.Run(new MainMenuForm());
        }
        else
        {
            Application.Run(new MainMenuForm());
        }
    }
}