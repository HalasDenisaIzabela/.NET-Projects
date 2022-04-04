using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.View.Medic
{
    interface IVizualizareGestionareProgram
    {
        int LuniOraStart { get; set; }
        int LuniOraSop { get; set; }
        int MartiOraStart { get; set; }
        int MartiOraSop { get; set; }
        int MiercuriOraStart { get; set; }
        int MiercuriOraSop { get; set; }
        int JoiOraStart { get; set; }
        int JoiOraSop { get; set; }
        int VineriOraStart { get; set; }
        int VineriOraSop { get; set; }
        //int Id { get; set; }
        List<string[]> ListaMedici { set; }

        string Selectie { get; }
    }
}
