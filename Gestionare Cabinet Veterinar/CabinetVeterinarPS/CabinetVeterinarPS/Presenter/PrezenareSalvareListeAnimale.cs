using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Asistent;

namespace CabinetVeterinarPS.Presenter
{
    class PrezenareSalvareListeAnimale
    {
        IVizualizareSalvareListeAnimale viz;
        PersistentaFisaMedicala persistenta;

        public PrezenareSalvareListeAnimale(IVizualizareSalvareListeAnimale viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaFisaMedicala();
        }
        public void CSV()
        {
            persistenta.FisierCSV();
        }
        public void JSON()
        {
            persistenta.FisierJSON();
        }

    }
}
