using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziAnimal
{
    class ComandaStergereAnimal : IComanda
    {
        private VMAnimal vmAnimal;

        public ComandaStergereAnimal(VMAnimal vm)
        {
            this.vmAnimal = vm;
        }
        public void Executa()
        {
            PersistentaAnimal persistentaAnimale = new PersistentaAnimal();

            if (this.vmAnimal.CipAnim != null && this.vmAnimal.SpecieAnim != null )
            {

                Animal animal = new Animal(this.vmAnimal.CipAnim, this.vmAnimal.SpecieAnim);
                persistentaAnimale.StergereAnimal(animal);
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
