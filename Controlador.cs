using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Controlador
    {
        public string ctrlregistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.Correo) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.Conpassword))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if(usuario.Password == usuario.Conpassword)
                {
                    if (modelo.existeUsuario(usuario.Correo))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Password = generaSHA1(usuario.Password);
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";

                }
            }
            return respuesta;
        }

        public string ctrlregprod(Productos producto)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(producto.ID_producto1) || string.IsNullOrEmpty(producto.Descripcion) || string.IsNullOrEmpty(producto.Precio.ToString()) || string.IsNullOrEmpty(producto.Categoria))
            {
                respuesta = "Por favor llene todos los campos";
            }
            else
            {
                    if (modelo.existeproducto (producto.ID_producto1))
                    {
                        respuesta = "El producto ya esta registrado";
                    }
                    else
                    {
                        modelo.registroprod(producto);
                    }
            }
            return respuesta;
        }

        public string ctrlregciu(Ciudad ciudad)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(ciudad.Nombre) || string.IsNullOrEmpty(ciudad.Tamanio) || string.IsNullOrEmpty(ciudad.Ind_ra) || string.IsNullOrEmpty(ciudad.Ing_PMC))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                    if (modelo.existeciudad(ciudad.Nombre))
                    {
                        respuesta = "Esta ciudad ya existe";
                    }
                    else
                    {
                    modelo.registrociu(ciudad); 
                    }
                }
            return respuesta;
        }

        public string ctrllogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.PorUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }else
                {
                    if(datosUsuario.Password != generaSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                }
            }
            return respuesta;
        }
        
        private string generaSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
