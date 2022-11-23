using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_Tester
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EIS_LED_TESTER());
        }
        public static string übergabe = "";
        public static string speicherung = "n";
        public static int green = 0;
        public static int red = 0;
        public static int yellow = 0;
        public static int blue = 0;

    }

}
