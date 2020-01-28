using ClientRest.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("settings"))
            {
                int x;
                using (FileStream stream = new FileStream("settings", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        x = reader.ReadInt32();
                    }
                }
                if (x == 1)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Run(new LoginForm());
                }
            }     
        }
    }
}
