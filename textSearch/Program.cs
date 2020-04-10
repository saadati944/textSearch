using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textSearch
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
    }
}
