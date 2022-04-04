using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
    public class Animal
    {
        public string Cip { get; set; }
        public string Specie { get; set; }
        

        public Animal()
        {
            this.Cip = "";
            this.Specie = "";
        }

        public Animal(string cip, string specie)
        {
            this.Cip = cip;
            this.Specie = specie;
        }
        public Animal(string cip)
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
            date[0] = this.Cip;
            date[1] = this.Specie;
            return date;
        }
    }
}
