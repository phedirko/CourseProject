using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    static class Program
    {
        public static ItemCollection Items = new ItemCollection();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);
            Application.Run(new Form1(Items));
        
        }
        


        public static void OnApplicationExit(object sender, EventArgs e)
        {
            Items.Save();
        }
    }       
}

