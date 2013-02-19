using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace RealityCP
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
            if (Config.hostMySQL == "")
            {
                Application.Run(new sqlinfo());
            }
            else
            {
                Application.Run(new menu());
            }
        }

    }
    public class Config
    {
        public static string hostMySQL = ConfigurationManager.AppSettings["host"];
        public static string portMySQL = ConfigurationManager.AppSettings["port"];
        public static string userMySQL = ConfigurationManager.AppSettings["user"];
        public static string passMySQL = ConfigurationManager.AppSettings["pass"];
        public static string nameMySQL = ConfigurationManager.AppSettings["name"];
    }
    public class Updates
    {
        public static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void cmdLine(string command)
        {
            System.Diagnostics.Process.Start("CMD.exe", command + " & pause");
        }
    }

}
