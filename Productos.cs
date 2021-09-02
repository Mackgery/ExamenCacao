using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Productos
    {
        int precio;
        string ID_producto, descripcion, categoria;

        public int Precio { get => precio; set => precio = value; }
        public string ID_producto1 { get => ID_producto; set => ID_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
