namespace Forms.DeltaE2000
{
    internal static class Program
    { 
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}