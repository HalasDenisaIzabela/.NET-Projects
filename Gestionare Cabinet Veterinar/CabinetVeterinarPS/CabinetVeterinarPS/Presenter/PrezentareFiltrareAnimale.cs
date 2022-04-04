using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Asistent;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareFiltrareAnimale
    {
        IVizualizareFiltrareAnimale viz;
        PersistentaFisaMedicala persistenta;

        public PrezentareFiltrareAnimale(IVizualizareFiltrareAnimale viz)
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
        
        public void CautareMedic()
        {
            List<string[]> listaFise = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                if (this.viz.Medic == u.Consult.Medic)
                {
                    listaFise.Add(u.ConversieFisa());
                }
            }
            this.viz.ListaAnimale = listaFise;
        }

        public void CautareDupaDiagnostic()
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
