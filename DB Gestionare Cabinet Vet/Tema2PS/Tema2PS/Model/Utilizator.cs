using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PS.Model
{
    class Utilizator
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }

        public Utilizator()
        {
            this.Id = 0;
            this.Rol = "";
            this.Email = "";
            this.Parola = "";
        }

        public Utilizator(int id, string rol, string email, string parola)
        {
            this.Id = id;
            this.Rol = rol;
            this.Email = email;
            this.Parola = parola;
        }

        public Utilizator(Utilizator utilizator)
        {
            this.Id = utilizator.Id;
            this.Rol = utilizator.Rol;
            this.Email = utilizator.Email;
            this.Parola = utilizator.Parola;
        }
        public string[] Conversie()
        {
            string[] date = new string[4];
            date[0] = this.Id.ToString();
            date[1] = this.Rol;
            date[2] = this.Email;
            date[3] = this.Parola;
            return date;
        }
    }
}
