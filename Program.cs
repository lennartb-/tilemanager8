using System;
using System.Windows.Forms;

namespace TileManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>       
        /// <param name="args">Program arguments.</param>
        [STAThread]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if ((args.Length == 1) && args[0].Equals("loaddb")) {
                Application.Run(new MainForm(true));
            }
            else {
                Application.Run(new MainForm(false));
            }
        }
    }
}
