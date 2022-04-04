using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Asistent;
using CabinetVeterinarPS.View.Medic;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareFiltrareAnimaleMedic
    {
        IVizualizareFiltrareAnimaleMedic viz;
        PersistentaFisaMedicala persistenta;

        public PrezentareFiltrareAnimaleMedic(IVizualizareFiltrareAnimaleMedic viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaFisaMedicala();
        }


        public void Lista()
        {
            List<string[]> listaFiseMedicale = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                listaFiseMedicale.Add(u.ConversieFisa());
            }
            this.viz.ListaAnimale = listaFiseMedicale;
        }

        public void CautareDiagnostic()
        {
            List<string[]> listaFise = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                if (this.viz.Diagnostic == u.Consult.Diagnostic)
                {
                    listaFise.Add(u.ConversieFisa());
                }
            }
            this.viz.ListaAnimale = listaFise;
        }

        public void CautareTratament()
        {
            List<string[]> listaFise = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                if (this.viz.Tratament == u.Consult.Tratament)
                {
                    listaFise.Add(u.ConversieFisa());
                }
            }
            this.viz.ListaAnimale = listaFise;
        }
    }
}
