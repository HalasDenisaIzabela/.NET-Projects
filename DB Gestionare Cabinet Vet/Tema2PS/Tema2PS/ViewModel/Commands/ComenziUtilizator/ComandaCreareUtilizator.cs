using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands
{
    class ComandaCreareUtilizator : IComanda
    {
        private VMUtilizator vmUtilizator;

        public ComandaCreareUtilizator(VMUtilizator vm)
        {
            this.vmUtilizator = vm;
        }
        public void Executa()
        {
            PersistentaUtilizator persistentaUtilizatori = new PersistentaUtilizator();

            if (this.vmUtilizator.RolUtil != null && this.vmUtilizator.EmailUtil != null && this.vmUtilizator.ParolaUtil != null)
            {

                Utilizator utilizator = new Utilizator(this.vmUtilizator.IdUtil, this.vmUtilizator.RolUtil, this.vmUtilizator.EmailUtil, this.vmUtilizator.ParolaUtil);
                persistentaUtilizatori.AdaugareUtilizator(utilizator);
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
