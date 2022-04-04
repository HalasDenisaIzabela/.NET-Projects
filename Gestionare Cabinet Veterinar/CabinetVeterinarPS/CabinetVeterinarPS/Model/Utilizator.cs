using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetVeterinarPS.Model
{
    public class Utilizator
    {
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }

        public Utilizator()
        {
            this.Rol = "";
            this.Email = "";
            this.Parola = "";
        }

        public Utilizator(string rol, string email, string parola)
        {
            this.Rol = rol;
            this.Email = email;
            this.Parola = parola;
        }

        public Utilizator(Utilizator utilizator)
        {
            this.Rol = utilizator.Rol;
            this.Email = utilizator.Email;
            this.Parola = utilizator.Parola;
        }
        public string[] Conversie()
        {
            string[] date = new string[3];
            date[0] = this.Rol;
            date[1] = this.Email;
            date[2] = this.Parola;
            return date;
        }
    }
}
