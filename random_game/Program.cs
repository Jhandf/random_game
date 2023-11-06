using System;
using System.Windows.Forms;

namespace random_game {
    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        public static int volume = 10;

        public static int prevVolumeValue;

        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }
    }
}