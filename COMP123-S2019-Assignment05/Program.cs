using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment05
{
    static class Program
    {
        public static Dictionary<string, Form> Forms;
        public static string FileName { get; set; }

        public static string BeginTag { get; set; }
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<string, Form>();
            Forms.Add("SplashScreen", new SplashScreen());
            Forms.Add("StartForm", new StartForm());
            Forms.Add("SelectForm", new SelectForm());
            Forms.Add("ProductInfoForm", new ProductInfoForm());
            Forms.Add("OrderForm", new OrderForm());

            Application.Run(Forms[FormName.SplashScreen.ToString()]);
        }
    }
}
