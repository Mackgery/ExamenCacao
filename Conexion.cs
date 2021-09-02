﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Conexion
    {
        public static MySqlConnection GetConnection()
        {
            string servidor = "localhost";
            string puerto = "3310";
            string usuario = "root";
            string password = "";
            string bd = "monosabios";

            string CadenaConexion = "server=" + servidor + "; port=" + puerto + "; user=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conect = new MySqlConnection(CadenaConexion);

            return conect;

        }
    }
}
