namespace projetfs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cr�ez d'abord MainForm


            // Passez-le � FRM_Menu
            Application.Run(new FRM_Menu());
        }

    }
}