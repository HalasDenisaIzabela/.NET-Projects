using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model.Persistenta;
using Tema2PS.View;
using Tema2PS.View.ViewAsistent;
using Tema2PS.View.ViewMedic;

namespace Tema2PS.ViewModel.Commands.ComenziUtilizator
{
    class ComandaLogareUtilizator : IComanda
    {
        private VMUtilizator vmUtilizator;

        public ComandaLogareUtilizator(VMUtilizator vm)
        {
            this.vmUtilizator = vm;
        }
        public void Executa()
        {
            PersistentaUtilizator persistenta = new PersistentaUtilizator();

            string rol = persistenta.Logare(vmUtilizator.EmlLog, vmUtilizator.ParLog);

            if (rol == null)
                MessageBox.Show("DATE INCORECTE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (rol == "dr")
            {
                VUtilizator2 f = new VUtilizator2();
                Logare l = new Logare();
                l.Hide();
                f.Show();
            }

            if (rol == "admin")
            {
                VUtilizator2 f2 = new VUtilizator2();
                Logare l = new Logare();
                f2.Show();
                l.Hide();

            }
            if (rol == "asistent")
            {
                VUtilizator2 f2 = new VUtilizator2();
                Logare l = new Logare();
                f2.Show();
                l.Hide();

            }
        }

        public bool Executa2()
        {
            bool succes = false;
            PersistentaUtilizator persistenta = new PersistentaUtilizator();

            string rol = persistenta.Logare(vmUtilizator.EmlLog, vmUtilizator.ParLog);

            if (rol == null)
            {
                MessageBox.Show("DATE INCORECTE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                succes = false;
            }

            if (rol == "dr")
            {
                VMedic f = new VMedic();
                succes = true; 
                f.Show();
            }

            if (rol == "admin")
            {
                VUtilizator2 f2 = new VUtilizator2();
                succes = true;
                f2.Show();

            }

            if (rol == "asistent")
            {
                VAsistent f2 = new VAsistent();
                succes = true;
                f2.Show();

            }
            return succes;
        }
    }
}
