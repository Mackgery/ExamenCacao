using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Clientes
    {
        int ID_cliente, telefono, ID_ciudad, ID_producto;
        string NIT, Nombres, Apellidos, direccion, fecha_nac;

        public int ID_cliente1 { get => ID_cliente; set => ID_cliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int ID_ciudad1 { get => ID_ciudad; set => ID_ciudad = value; }
        public int ID_producto1 { get => ID_producto; set => ID_producto = value; }
        public string NIT1 { get => NIT; set => NIT = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
    }
}
