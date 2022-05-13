using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.ViewModel.Commands.ComenziFiseMed;

namespace Tema2PS.ViewModel
{
    class VMFisaMedicala
    {
        VMMedic medicc;
        VMAnimal animm;
        //fisa
        private int nrCrtF;
        //animal
        private int cipAnimF;
        private string specieAnimF;
        public DataTable AnimaleleF;
        //medic
        private int idUtilF;
        private string rolUtilF;
        private string emailUtilF;
        private string parolaUtilF;
        private int oraStartMedF;
        private int oraStopMedF;
        public DataTable MediciF;
        //fisa
        private string ziuaF;
        private int oraF;
        private string simptomF;
        private string diagnosticF;
        private string tratamentF;
        public DataTable FiseF;
        public IComanda CreareFisaC;
        public IComanda VizualizareFisaC;

        public VMFisaMedicala()
        {
            medicc = new VMMedic();
            animm = new VMAnimal();
            this.nrCrtF = 0;
            this.cipAnimF = 0;
            this.specieAnimF = "";
            this.AnimaleleF = new DataTable();
            this.idUtilF = 0;
            this.rolUtilF = "";
            this.emailUtilF = "";
            this.parolaUtilF = "";
            this.oraStartMedF = 0;
            this.oraStopMedF = 0;
            this.ziuaF = "";
            this.oraF = 0;
            this.simptomF = "-";
            this.diagnosticF = "-";
            this.tratamentF = "-";
            this.MediciF = new DataTable();
            this.FiseF = new DataTable();
            this.CreareFisaC = new ComandaCreareFisa(this);
            this.VizualizareFisaC = new ComandaVizualizareFise(this);
        }

        public int NrCrtF
        {
            get
            {
                return this.nrCrtF;
            }
            set
            {
                this.nrCrtF = value;
            }
        }
        public int CipAnimF
        {
            get
            {
                return this.cipAnimF;
            }
            set
            {
                this.cipAnimF = value;
            }
        }
        public string SpecieAnimF
        {
            get
            {
                return this.specieAnimF;
            }
            set
            {
                this.specieAnimF = value;
            }
        }

        public int IdUtilF
        {
            get
            {
                return this.idUtilF;
            }
            set
            {
                this.idUtilF = value;
            }
        }
        public string RolUtilF
        {
            get
            {
                return this.rolUtilF;
            }
            set
            {
                this.rolUtilF = value;
            }
        }

        public string EmailUtilF
        {
            get
            {
                return this.emailUtilF;
            }
            set
            {
                this.emailUtilF = value;
            }
        }

        public string ParolaUtilF
        {
            get
            {
                return this.parolaUtilF;
            }
            set
            {
                this.parolaUtilF = value;
            }
        }
        public int OraStartMedF
        {
            get
            {
                return this.oraStartMedF;
            }
            set
            {
                this.oraStartMedF = value;
            }
        }
        public int OraStopMedF
        {
            get
            {
                return this.oraStopMedF;
            }
            set
            {
                this.oraStopMedF= value;
            }
        }

        public string ZiuaF
        {
            get
            {
                return this.ziuaF;
            }
            set
            {
                this.ziuaF = value;
            }
        }
        public int OraF
        {
            get
            {
                return this.oraF;
            }
            set
            {
                this.oraF = value;
            }
        }

        public string SimptomF
        {
            get
            {
                return this.simptomF;
            }
            set
            {
                this.simptomF = value;
            }
        }

        public string DiagnosticF
        {
            get
            {
                return this.diagnosticF;
            }
            set
            {
                this.diagnosticF = value;
            }
        }

        public string TratamentF
        {
            get
            {
                return this.tratamentF;
            }
            set
            {
                this.tratamentF = value;
            }
        }



    }
}
