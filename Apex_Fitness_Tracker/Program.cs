using Apex_Fitness_Tracker.Features;
using Apex_Fitness_Tracker.Features.Manager;
using Apex_Fitness_Tracker.Features.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_Fitness_Tracker
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
            Application.Run(new frmFirstIntro());
        }
    }
}
