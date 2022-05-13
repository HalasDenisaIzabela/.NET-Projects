using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;
using Tema2PS.View;
using Tema2PS.ViewModel;
using Tema2PS.ViewModel.Commands.ComenziUtilizator;

namespace Tema2PS
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
            //Application.Run(new VUtilizator2());
            Application.Run(new Logare());
            //PersistentaUtilizator p = new PersistentaUtilizator();
            //p.citireDB();
            //Console.WriteLine(p.Logare("dr", "dr"));
            //VMUtilizator u = new VMUtilizator();
            //u.EmlLog = "dr";
            //u.ParLog = "dr";
            //ComandaLogareUtilizator c = new ComandaLogareUtilizator(u);
            //c.Executa();
            //PersistentaFisaMed p = new PersistentaFisaMed();
            //p.citireDB();
            //List<FisaMedicala> lista = p.LisaFise();
            //Console.WriteLine(lista);
            /*
            PersistentaFisaMed p = new PersistentaFisaMed();
            List<FisaMedicala> l = p.LisaFise();
            int index = 0;
            int[] nr = new int[10];
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i].Specie == "felina")
                    nr[0]++;
                else if (l[i].Specie == "canin")
                    nr[1]++;
                else if (l[i].Specie == "rozatoare")
                    nr[2]++;
                else if (l[i].Specie == "pasare")
                    nr[3]++;
                else if (l[i].Specie == "peste")
                    nr[4]++;
                else if (l[i].Specie == "reptila")
                    nr[5]++;
                else if (l[i].Specie == "paianjen")
                    nr[6]++;
                Console.WriteLine(l[i].Specie);
            }
            for (int i = 0; i < 7; i++)
                Console.WriteLine(nr[i]);
            */
        }
    }
}
