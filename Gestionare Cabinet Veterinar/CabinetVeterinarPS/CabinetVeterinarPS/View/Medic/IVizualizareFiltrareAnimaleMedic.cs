using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.View.Medic
{
    interface IVizualizareFiltrareAnimaleMedic
    {
        string Diagnostic { get; set; }
        string Tratament { get; set; }

        List<string[]> ListaAnimale { set; }

        string Selectie { get; }
    }
}
