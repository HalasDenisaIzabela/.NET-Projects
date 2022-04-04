using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabinetVeterinarPS.Model;

namespace CabinetVeterinarPS.View.Admin
{
    interface IVizualizareAdmin
    {
         string Rol { get; set; }
         string Email { get; set; }
         string Parola { get; set; }
         int Id { get; set; }

        List<string[]> ListaUtilizatori { set; }

         string Selectie { get; }
    }
}
