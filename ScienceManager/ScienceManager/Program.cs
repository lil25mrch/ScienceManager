using System;
using System.Windows.Forms;
using Ninject;
using ScienceManager.Options;

namespace ScienceManager {
    static class Program {
        public static StandardKernel Kernel;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ScienceManagerModule module = new ScienceManagerModule();
            Kernel = new StandardKernel(module);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Kernel.Get<ManagerWindow>());
        }
    }
}