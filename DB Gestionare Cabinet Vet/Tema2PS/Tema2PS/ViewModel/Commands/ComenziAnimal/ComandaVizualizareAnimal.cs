using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.ViewModel.Commands.ComenziAnimal
{
    class ComandaVizualizareAnimal : IComanda
    {
        private VMAnimal vmAnim;

        public ComandaVizualizareAnimal(VMAnimal vm)
        {
            this.vmAnim = vm;
        }
        public void Executa()
        {
            this.vmAnim.Animalele.Rows.Clear();
            PersistentaAnimal utilPersistenta = new PersistentaAnimal();
            if (this.vmAnim.Animalele.Columns.Count < 2)
            {
                this.vmAnim.Animalele.Columns.Add("CIP", typeof(string));
                this.vmAnim.Animalele.Columns.Add("Specie", typeof(string));
            }
            List<Animal> lista = utilPersistenta.ListaAnimale();
            foreach (Animal p in lista)
                this.vmAnim.Animalele.Rows.Add(p.Cip, p.Specie);
        }

        public bool Executa2()
        {
            throw new NotImplementedException();
        }
    }
}
