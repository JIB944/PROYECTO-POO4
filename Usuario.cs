using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    class Usuario
    {

        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }

        public Usuario(string Nombre, string Email, int Edad, int DNI)
        {
            this.Nombre = Nombre;
            this.Email = Email;
            this.Edad = Edad;
            this.DNI = DNI;
        }
    }


}
