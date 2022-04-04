using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.View.Asistent
{
    interface IVizualizarePlanificareConsultatii
    {
        int NrCrt { get; set; }
        int AnimalCIP { get; set; }
        int MedCons { get; set; }
        string ZiuaCons { get; set; }
        int OraCons { get; set; }
        List<string[]> ListaFiseMedicale { set; }

        string Selectie { get; }
    }
}
