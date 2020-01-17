using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDatos
{
    class Conexion
    {
        public MySqlConnection obtenerconexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=mysql5018.site4now.net ;database=db_a53fcd_terapia ;user=a53fcd_terapia; password=bendiciones1234");
            conexion.Open();
            return conexion;
            //Console.WriteLine("Se conecto");
        }
    }
}

