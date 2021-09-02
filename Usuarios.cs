using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Usuarios
    {
        int id;
        string correo, password, conpassword;

        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public string Conpassword { get => conpassword; set => conpassword = value; }
        public int Id { get => id; set => id = value; }
    }
}
