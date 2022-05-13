using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model.Persistenta
{
    class CabinetVetContext
    {
        //SINGLETON
        private CabinetVetContext() { }
        private static CabinetVetContext instance = null;
        public static CabinetVetContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CabinetVetContext();
                }
                return instance;
            }
        }


    }
}
