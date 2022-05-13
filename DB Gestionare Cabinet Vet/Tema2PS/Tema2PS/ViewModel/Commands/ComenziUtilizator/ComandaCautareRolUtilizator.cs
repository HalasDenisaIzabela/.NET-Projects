using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziUtilizator
{
    class ComandaCautareRolUtilizator : IComanda
    {
        private VMUtilizator vmUtil;

        public ComandaCautareRolUtilizator(VMUtilizator vm)
        {
            this.vmUtil = vm;
        }
        public void Executa()
        {
            this.vmUtil.Utilizatori.Rows.Clear();
            PersistentaUtilizator utilPersistenta = new PersistentaUtilizator();
            if (this.vmUtil.Utilizatori.Columns.Count < 4)
            {
                this.vmUtil.Utilizatori.Columns.Add("ID", typeof(string));
                this.vmUtil.Utilizatori.Columns.Add("Rol", typeof(string));
                this.vmUtil.Utilizatori.Columns.Add("Email", typeof(string));
                this.vmUtil.Utilizatori.Columns.Add("Parola", typeof(string));
            }
            List<Utilizator> lista = utilPersistenta.ListaUtilizatori();
            foreach (Utilizator p in lista)
                this.vmUtil.Utilizatori.Rows.Add(p.Id, p.Rol, p.Email, p.Parola);
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
