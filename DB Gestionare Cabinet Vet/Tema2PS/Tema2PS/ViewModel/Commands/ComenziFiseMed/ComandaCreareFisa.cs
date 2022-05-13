using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziFiseMed
{
    class ComandaCreareFisa : IComanda
    {
        private VMFisaMedicala vmFisa;

        public ComandaCreareFisa(VMFisaMedicala vm)
        {
            this.vmFisa = vm;
        }
        public void Executa()
        {
            PersistentaFisaMed pers = new PersistentaFisaMed();

            if (this.vmFisa.NrCrtF != null && this.vmFisa.CipAnimF != null && this.vmFisa.SpecieAnimF != null && this.vmFisa.IdUtilF != null)
            {

                FisaMedicala fis = new FisaMedicala(this.vmFisa.NrCrtF, this.vmFisa.CipAnimF, 
                   this.vmFisa.SpecieAnimF,
                   this.vmFisa.IdUtilF, this.vmFisa.ZiuaF, 
                   this.vmFisa.OraF, this.vmFisa.SimptomF, 
                   this.vmFisa.DiagnosticF,
                   this.vmFisa.TratamentF);
                pers.AdaugareFisa(fis);
            }
            else
            {
                MessageBox.Show("EROARE LA ADAUGARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
