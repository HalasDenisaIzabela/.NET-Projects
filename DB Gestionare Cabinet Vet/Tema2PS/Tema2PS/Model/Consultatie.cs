using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model
{
    class Consultatie
    {
        public string Simptome { get; set; }
        public string Diagnostic { get; set; }
        public string Tratament { get; set; }
        public int Medic { get; set; }
        public string Ziua { get; set; }
        public int Ora { get; set; }

        public Consultatie()
        {
            this.Simptome = "";
            this.Diagnostic = "";
            this.Tratament = "";
            this.Medic = 0;
            this.Ziua = "";
            this.Ora = 0;
        }

        public Consultatie(string simptome, string diagnostic, string tratament, int medic, string ziua, int ora)
        {
            this.Simptome = simptome;
            this.Diagnostic = diagnostic;
            this.Tratament = tratament;
            this.Medic = medic;
            this.Ziua = ziua;
            this.Ora = ora;
        }
        public Consultatie(int medic, string ziua, int ora)
        {
            this.Medic = medic;
            this.Ziua = ziua;
            this.Ora = ora;
            this.Simptome = "";
            this.Diagnostic = "";
            this.Tratament = "";
        }
        public Consultatie(string simptome, string diagnostic, string tratament)
        {
            this.Simptome = simptome;
            this.Diagnostic = diagnostic;
            this.Tratament = tratament;
        }
        public Consultatie(Consultatie consultatie)
        {
            this.Simptome = consultatie.Simptome;
            this.Diagnostic = consultatie.Diagnostic;
            this.Tratament = consultatie.Tratament;
            this.Medic = consultatie.Medic;
            this.Ziua = consultatie.Ziua;
            this.Ora = consultatie.Ora;
        }
    }
}
