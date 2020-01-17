using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionDatos
{
    public class LoginDatos
    {
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public bool LoginUsuarioDatosSQL(string user, string pass)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"SELECT [id]
                                  ,[usuario]
                                  ,[contrasenia]
                                  ,[estado]
                              FROM [dbo].[Usuario]
                              where usuario =@user and  contrasenia = @pass and estado = " + 1;
            cmd.Parameters.AddWithValue("@user", user);
            string password = Encriptar(pass);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.CommandType = System.Data.CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            conexion.Close();

        }

        public string datosUsuarioNombreApelldio(string cedula)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"SELECT [apellidoPaterno]
                              ,[primerNombre]
                          FROM [dbo].[Empleado]
                           where cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.CommandType = System.Data.CommandType.Text;
            string nombre;
            string apellido;
            string nombresTotales = "";
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    nombre = dr["primerNombre"].ToString().Trim();
                    apellido = dr["apellidoPaterno"].ToString().Trim();
                    nombresTotales = nombre + " " + apellido;   
                }
            }
            conexion.Close();
            return nombresTotales;
        }

        public string CargoLoginUsuarioDatos(string user, string pass)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"SELECT [id]
                                  ,[usuario]
                                  ,[contrasenia]
                                  ,[cargo]
                                  ,[estado]
                              FROM [dbo].[Usuario]
                              where usuario =@user and  contrasenia = @pass and estado = " + 1;
            cmd.Parameters.AddWithValue("@user", user);
            string password = Encriptar(pass);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.CommandType = System.Data.CommandType.Text;
            string cargo = "";
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    cargo = dr["cargo"].ToString().Trim();
                }
            }
            conexion.Close();
            return cargo;
        }
        //public bool LoginUsuarioDatos(string user, string pass)
        //{
        //    SqlConnection conexion = new SqlConnection(Settings1.Default.cadenaConexion);
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexion;
        //    cmd.CommandText = @"select *from Users where LoginName=@user and Password=@pass";
        //    cmd.Parameters.AddWithValue("@user", user);
        //    cmd.Parameters.AddWithValue("@pass", pass);
        //    cmd.CommandType = System.Data.CommandType.Text;

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //    conexion.Close();

        //}

    }
}
