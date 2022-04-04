using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;

namespace CabinetVeterinarPS
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
            Application.Run(new VizualizareAutentificare());
          
        }
    }
}
