using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textSearch
{
    static class Program
    {
        //to use your own config file set useCFP to true and set your own configfilepath.
        public const bool useCFP = false;
        static string configfilepath = "";




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (useCFP)
                ;
            else if (Application.StartupPath.StartsWith("/"))
                configfilepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/text.search.config.file.config";
            else
                configfilepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\text.search.config.file.config";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static string addValue;
        public static string cutSpaces(string v)
        {
            while (v.StartsWith("	") || v.StartsWith(" "))
                v = v.Substring(1);
            while (v.EndsWith("	") || v.EndsWith(" "))
                v = v.Substring(0, v.Length - 1);
            return v;
        }
        public static string getConfigpath()
        {
            return configfilepath;
        }
    }
}
