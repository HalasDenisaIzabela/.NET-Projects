using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziMedic
{
    class ComandaCreareProgramMedic : IComanda
    {
        private VMMedic vmMedic;

        public ComandaCreareProgramMedic(VMMedic vm)
        {
            this.vmMedic = vm;
        }
        public void Executa()
        {
            ParsistentaMedic persistentaMedic = new ParsistentaMedic();

            if (this.vmMedic.OraStartMed != null && this.vmMedic.OraStopMed != null)
            {

                Medic medic = new Medic(this.vmMedic.IdUtil, this.vmMedic.RolUtil, this.vmMedic.EmailUtil, this.vmMedic.ParolaUtil,  this.vmMedic.OraStartMed, this.vmMedic.OraStopMed);
                persistentaMedic.ActualizareMedic(medic);
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
