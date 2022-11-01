using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_товаров
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    static public class Daata
    {
        public static string data1;
        public static string data2;
        public static string data3;
        public static int n = 1;
        public static DataGridView dat1;
        public static DataGridView dat2;
        public static int i = 0;
    }
}
