using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2PS.ViewModel.Commands;
using Tema2PS.ViewModel.Commands.ComenziUtilizator;

namespace Tema2PS.ViewModel
{
    public class VMUtilizator
    {
        private int idUtil;
        private string rolUtil;
        private string emailUtil;
        private string parolaUtil;
        private string cautareUtil;
        private string emlLog;
        private string parLog;
        public DataTable Utilizatori;
        public IComanda CreareC;
        public IComanda VizualizareC;
        public IComanda StergereC;
        public IComanda CautareC;
        public IComanda LogareC;



        public VMUtilizator()
        {
            this.idUtil = 0;
            this.rolUtil = "";
            this.emailUtil = "";
            this.parolaUtil = "";
            this.cautareUtil = "";
            this.emlLog = "";
            this.parLog = "";
            this.Utilizatori = new DataTable();
            this.CreareC = new ComandaCreareUtilizator(this);
            this.VizualizareC = new ComandaVizualizareUtilizatori(this);
            this.StergereC = new ComandaStergereUtilizator(this);
            this.CautareC = new ComandaCautareRolUtilizator(this);
            this.LogareC = new ComandaLogareUtilizator(this);

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
        public string CautareUtil
        {
            get
            {
                return this.cautareUtil;
            }
            set
            {
                this.cautareUtil = value;
            }
        }
        public string EmlLog
        {
            get
            {
                return this.emlLog;
            }
            set
            {
                this.emlLog = value;
            }
        }
        public string ParLog
        {
            get
            {
                return this.parLog;
            }
            set
            {
                this.parLog = value;
            }
        }
    }
}
