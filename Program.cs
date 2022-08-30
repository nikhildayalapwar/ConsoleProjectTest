using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            Application.Run(new Form1());
                        
            int i = 0;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);

            //C obj = new C();
            //obj.method1();
        }
    }
   
        public static class IntExtension
        {
            public static bool IsGreaterThan(this int i, int value)
            {
              return true;
            }
        }
    
}
