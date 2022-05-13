using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziAnimal
{
    class ComandaSalvareXML : IComanda
    {
        private VMAnimal vmAnimal;

        public ComandaSalvareXML(VMAnimal vm)
        {
            this.vmAnimal = vm;
        }

        public void Executa()
        {
            PersistentaAnimal persistentaProduse = new PersistentaAnimal();

            persistentaProduse.ScriereXML();
            MessageBox.Show("RAPORT SALVAT CU SUCCES!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
