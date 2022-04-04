using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
     public class Medic : Utilizator
    {
        public int Id { get; set; }
        //public Orar Orarul { get; set; }
        public ProgramZi Luni { get; set; }
        public ProgramZi Marti { get; set; }
        public ProgramZi Miercuri { get; set; }
        public ProgramZi Joi { get; set; }
        public ProgramZi Vineri { get; set; }


        public Medic()
        {
            this.Id = 0;
            //this.Orarul = new Orar();
            this.Luni = new ProgramZi();
            this.Marti = new ProgramZi();
            this.Miercuri = new ProgramZi();
            this.Joi = new ProgramZi();
            this.Vineri = new ProgramZi();
        }

        public Medic(int id, ProgramZi luni, ProgramZi marti, ProgramZi miercuri, ProgramZi joi, ProgramZi vineri )
        {
            this.Id = id;
            //this.Orarul = orar;
            this.Luni = luni;
            this.Marti = marti;
            this.Miercuri = miercuri;
            this.Joi = joi;
            this.Vineri = vineri;
        }
        
        public Medic(int id, string rol, string email, string parola)
        {
            this.Id = id;
            this.Rol = rol;
            this.Email = email;
            this.Parola = parola;
        }
        public Medic(Medic medic)
        {
            this.Id = medic.Id;
            this.Luni = medic.Luni;
            this.Marti = medic.Marti;
            this.Miercuri = medic.Miercuri;
            this.Joi = medic.Joi;
            this.Vineri = medic.Vineri;
        }
        public string[] ConversieMed()
        {
            string[] date = new string[11];
            date[0] = this.Id.ToString();
            date[1] = this.Luni.OraStart.ToString();
            date[2] = this.Luni.OraStop.ToString();
            date[3] = this.Marti.OraStart.ToString();
            date[4] = this.Marti.OraStop.ToString();
            date[5] = this.Miercuri.OraStart.ToString();
            date[6] = this.Miercuri.OraStop.ToString();
            date[7] = this.Joi.OraStart.ToString();
            date[8] = this.Joi.OraStop.ToString();
            date[9] = this.Vineri.OraStart.ToString();
            date[10] = this.Vineri.OraStop.ToString();
            return date;
        }
    }
}
