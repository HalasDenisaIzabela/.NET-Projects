using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
    public class FisaMedicala
    {
        public int NrCrt { get; set; }
        public Animal Anim { get; set; }
        public Consultatie Consult { get; set; }


        public FisaMedicala()
        {
            this.NrCrt = 0;
            this.Anim = null;
            this.Consult = null;
        }
        public FisaMedicala(int nrCrt, Animal animal, Consultatie consultatie)
        {
            this.NrCrt = nrCrt;
            this.Anim = animal;
            this.Consult = consultatie;
        }
        public FisaMedicala(Animal animal, Consultatie consultatie)
        {
            this.Anim = animal;
            this.Consult = consultatie;
        }
        public FisaMedicala(FisaMedicala fisaMedicala)
        {
            this.NrCrt = fisaMedicala.NrCrt;
            this.Anim = fisaMedicala.Anim;
            this.Consult = fisaMedicala.Consult;
        }

        public string[] ConversieFisa()
        {
            string[] date = new string[10];
            date[0] = this.NrCrt.ToString();
            date[1] = this.Anim.Cip;
            date[2] = this.Consult.Medic.ToString();
            date[3] = this.Consult.Ziua;
            date[4] = this.Consult.Ora.ToString();
            date[5] = this.Consult.Simptome;
            date[6] = this.Consult.Diagnostic;
            date[7] = this.Consult.Tratament;
            return date;
        }
    }
}
