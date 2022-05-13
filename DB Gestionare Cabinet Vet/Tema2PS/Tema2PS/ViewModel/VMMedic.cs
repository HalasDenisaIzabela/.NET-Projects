using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.ViewModel.Commands.ComenziMedic;

namespace Tema2PS.ViewModel
{
    class VMMedic
    {
        private int idUtil;
        private string rolUtil;
        private string emailUtil;
        private string parolaUtil;
        private int oraStartMed;
        private int oraStopMed;
        public DataTable Medici;
        public IComanda CreareProgramC;
        public IComanda VizualizareProgramC;


        public VMMedic()
        {
            this.idUtil = 0;
            this.rolUtil = "";
            this.emailUtil = "";
            this.parolaUtil = "";
            this.oraStartMed = 0;
            this.oraStopMed = 0;
            this.Medici = new DataTable();
            this.CreareProgramC = new ComandaCreareProgramMedic(this);
            this.VizualizareProgramC = new ComandaVizualizareMedici(this);
        }

        public int IdUtil
        {
            get
            {
                return this.idUtil;
            }
            set
            {
                this.idUtil = value;
            }
        }
        public string RolUtil
        {
            get
            {
                return this.rolUtil;
            }
            set
            {
                this.rolUtil = value;
            }
        }

        public string EmailUtil
        {
            get
            {
                return this.emailUtil;
            }
            set
            {
                this.emailUtil = value;
            }
        }

        public string ParolaUtil
        {
            get
            {
                return this.parolaUtil;
            }
            set
            {
                this.parolaUtil = value;
            }
        }
        public int OraStartMed
        {
            get
            {
                return this.oraStartMed;
            }
            set
            {
                this.oraStartMed = value;
            }
        }
        public int OraStopMed
        {
            get
            {
                return this.oraStopMed;
            }
            set
            {
                this.oraStopMed = value;
            }
        }
    }
}
