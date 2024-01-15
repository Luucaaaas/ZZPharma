using System;
using System.Windows.Forms;

namespace ZZinventory
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instancie et affiche la page de connexion
            Application.Run(new LoginPage());
        }
    }
}