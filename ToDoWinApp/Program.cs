using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoWinApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ToDoView view = new ToDoView();
            IList<ToDoItem> items = new List<ToDoItem>();
            ToDoController controller = new ToDoController(view, items);
            controller.LoadView();
            Application.Run(view);
        }
    }
}
