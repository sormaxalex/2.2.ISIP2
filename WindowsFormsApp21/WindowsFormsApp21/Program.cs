using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    static class Program
    {
        public static Form1 f1 = new Form1();
        public static Form2 f2 = new Form2();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(f1);
        }
    }
}
