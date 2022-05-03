using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    class Banco
    {
        private static Banco intance;

        private List<Usuario> Usuarios = new List<Usuario>();
        private Banco() { }

        public Banco getIntance()
        {
            if(intance == null)
            {
                intance = new Banco();
            }
            return intance;
        }

        public List<Usuario> getUsuarios()
        {
            return Usuarios;
        }
    }
}
