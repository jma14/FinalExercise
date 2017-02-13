using FinalExercise.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExercise
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            MyContext context = new MyContext();
            foreach (var entity in context.Orders)
            {
                context.Orders.Remove(entity);
                
            }
            context.SaveChanges();
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Default());
        }
    }
}
