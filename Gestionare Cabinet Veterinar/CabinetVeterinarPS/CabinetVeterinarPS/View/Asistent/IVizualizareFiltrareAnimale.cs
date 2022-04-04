using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.View.Asistent
{
    public interface IVizualizareFiltrareAnimale
    {
        int Medic { get; set; }
        string Diagnostic { get; set; }

        List<string[]> ListaAnimale { set; }

        string Selectie { get; }
    }
}
