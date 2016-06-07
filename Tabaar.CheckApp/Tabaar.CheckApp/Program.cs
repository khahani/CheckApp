using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
//using Tabaar.CheckApp.Model;
using System.Data.Entity;
using T = Tabaar.CheckApp.Model;

namespace Tabaar.CheckApp
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

            //Database.SetInitializer<T.CheckDatabase>(new T.DatabaseInitializer());

            Application.Run(new CheckListUI());
        }
    }
}
