using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "INSERT INTO login (correo, contrasenia) VALUES (@correo, @password)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", usuario.Correo);
            comando.Parameters.AddWithValue("@password", usuario.Password);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int registroprod (Productos producto)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "INSERT INTO productos (ID_producto, descripcion, precio, categoria) VALUES (@ID_producto, @descripcion, @precio, @categoria)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID_producto", producto.ID_producto1);
            comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@precio", producto.Precio);
            comando.Parameters.AddWithValue("@categoria", producto.Categoria);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int registrociu (Ciudad ciudad)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "INSERT INTO ciudades (nombre, tamanio, ind_RA, ing_PMC) VALUES (@nombre, @tamanio, @ind_RA, @ing_PMC)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", ciudad.Nombre);
            comando.Parameters.AddWithValue("@tamanio", ciudad.Tamanio);
            comando.Parameters.AddWithValue("@ind_RA", ciudad.Ind_ra);
            comando.Parameters.AddWithValue("@ing_PMC", ciudad.Ing_PMC);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_log FROM login where correo LIKE @correo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool existeproducto (string producto)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT descripcion FROM productos where ID_producto LIKE @ID_producto";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID_producto", producto);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool existeciudad (string ciudad)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_ciudad FROM ciudades where nombre LIKE @nombre";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", ciudad);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Usuarios PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT ID_log, correo, contrasenia FROM login where correo LIKE @correo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@correo", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["ID_log"].ToString());
                usr.Password = reader["correo"].ToString();
                usr.Password = reader["contrasenia"].ToString();
            }
            return usr;
        }
    }
}