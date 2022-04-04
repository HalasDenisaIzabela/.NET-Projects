using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
    public class ProgramZi
    {
        public int OraStart { get; set; }
        public int OraStop { get; set; }

        public ProgramZi()
        {
            this.OraStart = 8;
            this.OraStop = 20;
        }

        public ProgramZi(int oraStart, int oraStop)
        {
            this.OraStart = oraStart;
            this.OraStop = oraStop;
        }
        public ProgramZi(ProgramZi programZi)
        {
            this.OraStart = programZi.OraStart;
            this.OraStop = programZi.OraStop;
        }
    }
}
