using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model
{
    class Medic : Utilizator
    {
        public int oraStart { get; set; }
        public int oraStop { get; set; }

        public Medic(int id, int oraStart, int oraStop)
        {
            this.Id = id;
            this.oraStart = oraStart;
            this.oraStop = oraStop;
        }

        public Medic(int id, string rol, string email, string parola)
        {
            this.Id = id;
            this.Rol = rol;
            this.Email = email;
            this.Parola = parola;
        }
        public Medic(int id, string rol, string email, string parola, int oraStart, int oraStop)
        {
            this.Id = id;
            this.Rol = rol;
            this.Email = email;
            this.Parola = parola;
            this.oraStart = oraStart;
            this.oraStop = oraStop;
        }
        public Medic(Medic medic)
        {
            this.Id = medic.Id;
            this.oraStart = medic.oraStart;
            this.oraStop = oraStop;
        }
        public string[] ConversieMed()
        {
            string[] date = new string[3];
            date[0] = this.Id.ToString();
            date[1] = this.oraStart.ToString();
            date[2] = this.oraStop.ToString();
            return date;
        }
    }
}
