using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Shared;

namespace HQT
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
            ApplicationSetting.Load(ConfigurationManager.AppSettings);
            DependencyResolution.Start();
            Application.Run(new LoginForm());
        }
    }
}
