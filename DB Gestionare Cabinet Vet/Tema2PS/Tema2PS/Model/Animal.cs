using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model
{
    public class Animal
    {
        public int Cip { get; set; }
        public string Specie { get; set; }


        public Animal()
        {
            this.Cip = 0;
            this.Specie = "";
        }

        public Animal(int cip, string specie)
        {
            this.Cip = cip;
            this.Specie = specie;
        }
        public Animal(int cip)
        {
            this.Cip = cip;
        }

        public Animal(Animal animal)
        {
            this.Cip = animal.Cip;
            this.Specie = animal.Specie;
        }
        public string[] Conversie()
        {
            string[] date = new string[2];
            date[0] = this.Cip.ToString();
            date[1] = this.Specie;
            return date;
        }
    }
}
