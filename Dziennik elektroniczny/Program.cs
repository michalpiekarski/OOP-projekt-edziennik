using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mb = MessageBox.Show("Czy uruchomić w trybie jednego okna?", "Tryb wyświetlania", MessageBoxButtons.YesNo);
            if(mb == DialogResult.Yes)
            {
                Application.Run(new SingleWindow());
            }
            else
            {
                Application.Run(new MainNav());
            }
        }
    }
}
