﻿using System;
using System.Windows.Forms;
using Ninject;
using ScienceManager.Module;

namespace ScienceManager {
    static class Program {
        public static StandardKernel Kernel;

        /// <summary>
        /// Основная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            ScienceManagerModule module = new ScienceManagerModule();
            Kernel = new StandardKernel(module);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Kernel.Get<WorkWithDataBaseWindow>());
        }
    }
}