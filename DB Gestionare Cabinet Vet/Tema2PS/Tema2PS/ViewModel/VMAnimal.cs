using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.ViewModel.Commands;
using Tema2PS.ViewModel.Commands.ComenziAnimal;

namespace Tema2PS.ViewModel
{
    public class VMAnimal
    {
        private int cipAnim;
        private string specieAnim;
        private string cautareAnim;
        public DataTable Animalele;
        public IComanda CreareC;
        public IComanda VizualizareC;
        public IComanda StergereC;
        public IComanda CautareC;
        public IComanda SalvareCSVC;
        public IComanda SalvareJSONC;
        public IComanda SalvareXMLC;



        public VMAnimal()
        {
            this.cipAnim = 0;
            this.specieAnim = "";
            this.cautareAnim = "";
            this.Animalele = new DataTable();
            this.CreareC = new ComandaCreareAnimal(this);
            this.VizualizareC = new ComandaVizualizareAnimal(this);
            this.StergereC = new ComandaStergereAnimal(this);
            this.SalvareCSVC = new ComandaSalvareCSV(this);
            this.SalvareJSONC = new ComandaSalvareJSON(this);
            this.SalvareXMLC = new ComandaSalvareXML(this);


        }


        public int CipAnim
        {
            get
            {
                return this.cipAnim;
            }
            set
            {
                this.cipAnim = value;
            }
        }
        public string SpecieAnim
        {
            get
            {
                return this.specieAnim;
            }
            set
            {
                this.specieAnim = value;
            }
        }
        public string CautareAnim
        {
            get
            {
                return this.cautareAnim;
            }
            set
            {
                this.cautareAnim = value;
            }
        }
    }
}
