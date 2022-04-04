using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
    public class Orar
    {
        public ProgramZi[] Program { get; set; }

        public Orar()
        {
            this.Program = new ProgramZi[6];
            /*this.Program[0].Zi = "Luni";
            this.Program[1].Zi = "Marti";
            this.Program[2].Zi = "Miercuri";
            this.Program[3].Zi = "Joi";
            this.Program[4].Zi = "Vineri";
            for (int i = 0; i < 6; i++)
            {
                this.Program[i].OraStart = "8:00";
                this.Program[i].OraStop = "20:00";
            }*/
        }

        public Orar(ProgramZi[] program)
        {
            for (int i = 0; i < 6; i++)
            {
                this.Program[i].OraStart = program[i].OraStart;
                this.Program[i].OraStop = program[i].OraStop;
            }
        }

        public Orar(Orar orar)
        {
            for (int i = 0; i < 6; i++)
            {
                this.Program[i].OraStart = orar.Program[i].OraStart;
                this.Program[i].OraStop = orar.Program[i].OraStop;
            }
        }
    }
}
