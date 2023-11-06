using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_game {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int volume = 100;
        public static int prevVolumeValue;
        [STAThread]

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }

    }
}