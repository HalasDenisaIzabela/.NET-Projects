using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziFiseMed
{
    class ComandaVizualizareFise : IComanda
    {
        private VMFisaMedicala vmFisa;

        public ComandaVizualizareFise(VMFisaMedicala vm)
        {
            this.vmFisa = vm;
        }
        public void Executa()
        {
            this.vmFisa.FiseF.Rows.Clear();
            PersistentaFisaMed utilPersistenta = new PersistentaFisaMed();
            if (this.vmFisa.FiseF.Columns.Count < 9)
            {
                this.vmFisa.FiseF.Columns.Add("NrCrt", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Cip", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Specie", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Medic", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Ziua", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Ora", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Simptom", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Diagnostic", typeof(string));
                this.vmFisa.FiseF.Columns.Add("Tratament", typeof(string));
            }
            List<FisaMedicala> lista = utilPersistenta.LisaFise();
            foreach (FisaMedicala p in lista)
                this.vmFisa.FiseF.Rows.Add(p.NrCrt, p.Cip, p.Specie, p.Medic, p.Ziua, p.Ora, p.Simptome, p.Diagnostic, p.Tratament);
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
