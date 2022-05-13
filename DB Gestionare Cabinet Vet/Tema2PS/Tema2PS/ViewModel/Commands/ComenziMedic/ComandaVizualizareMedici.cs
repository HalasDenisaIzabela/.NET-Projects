using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziMedic
{
    class ComandaVizualizareMedici : IComanda
    {
        private VMMedic vmMed;

        public ComandaVizualizareMedici(VMMedic vm)
        {
            this.vmMed = vm;
        }
        public void Executa()
        {
            this.vmMed.Medici.Rows.Clear();
            ParsistentaMedic medPersistenta = new ParsistentaMedic();
            if (this.vmMed.Medici.Columns.Count < 6)
            {
                this.vmMed.Medici.Columns.Add("ID", typeof(string));
                this.vmMed.Medici.Columns.Add("Rol", typeof(string));
                this.vmMed.Medici.Columns.Add("Email", typeof(string));
                this.vmMed.Medici.Columns.Add("Parola", typeof(string));
                this.vmMed.Medici.Columns.Add("OraStart", typeof(string));
                this.vmMed.Medici.Columns.Add("OraStop", typeof(string));

            }
            List<Medic> lista = medPersistenta.ListaMedici();
            foreach (Medic p in lista)
                this.vmMed.Medici.Rows.Add(p.Id, p.Rol, p.Email, p.Parola, p.oraStart, p.oraStop);
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
