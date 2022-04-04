using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.View.Asistent
{
    interface IVizualizareGestionareAnimale
    {
        string Cip { get; set; }
        string Specie { get; set; }

        List<string[]> ListaAnimale { set; }

        string Selectie { get; }
    }
}
