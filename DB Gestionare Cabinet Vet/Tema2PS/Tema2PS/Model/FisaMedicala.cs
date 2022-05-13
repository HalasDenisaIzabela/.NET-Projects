using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model
{
    class FisaMedicala
    {
        public int NrCrt { get; set; }
        public int Cip { get; set; }
        public string Specie { get; set; }
        public int Medic { get; set; }
        public string Ziua { get; set; }
        public int Ora { get; set; }
        public string Simptome { get; set; }
        public string Diagnostic { get; set; }
        public string Tratament { get; set; }
        

        public FisaMedicala()
        {
            this.NrCrt = 0;
            this.Cip = 0;
            this.Specie = "";
            this.Medic = 0;
            this.Ziua = "";
            this.Ora = 0;
            this.Simptome = "";
            this.Diagnostic = "";
            this.Tratament = "";
        }
        public FisaMedicala(int nrCrt, int cip, string specie, int medic, string ziua, int ora, string simptome, string diagnostic, string tratament)
        {
            this.NrCrt = nrCrt;
            this.Cip = cip;
            this.Specie = specie;
            this.Medic = medic;
            this.Ziua = ziua;
            this.Ora = ora;
            this.Simptome = simptome;
            this.Diagnostic = diagnostic;
            this.Tratament = tratament;
        }
        public FisaMedicala(FisaMedicala fisaMedicala)
        {
            this.NrCrt = fisaMedicala.NrCrt;
            this.Cip = fisaMedicala.Cip;
            this.Specie = fisaMedicala.Specie;
            this.Medic = fisaMedicala.Medic;
            this.Ziua = fisaMedicala.Ziua;
            this.Ora = fisaMedicala.Ora;
            this.Simptome = fisaMedicala.Simptome;
            this.Diagnostic = fisaMedicala.Diagnostic;
            this.Tratament = fisaMedicala.Tratament;
        }

        public string[] ConversieFisa()
        {
            string[] date = new string[10];
            date[0] = this.NrCrt.ToString();
            date[1] = this.Cip.ToString();
            date[2] = this.Specie;
            date[3] = this.Medic.ToString();
            date[4] = this.Ziua;
            date[5] = this.Ora.ToString();
            date[6] = this.Simptome;
            date[7] = this.Diagnostic;
            date[8] = this.Tratament;
            return date;
        }
    }
}
