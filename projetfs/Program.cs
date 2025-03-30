namespace projetfs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Créez d'abord MainForm


            // Passez-le à FRM_Menu
            Application.Run(new FRM_Menu());
        }

    }
}