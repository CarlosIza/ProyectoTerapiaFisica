using GestionEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionEntidades;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace GestionDatos
{
    public class EmpleadosDatos
    {




        public static List<Empleado> DevolverListadoDoctoresDatos()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;


                List<Empleado> listaEmpleados = new List<Empleado>();


                cmd.CommandText = @"SELECT * FROM `empleados`";


                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empleado medico = new Empleado();
                        medico.Cedula = dr["CED_EMP"].ToString();
                        medico.Apellido1 = dr["APE1_EMP"].ToString();
                        medico.Apellido2 = dr["APE2_EMP"].ToString();
                        medico.Nombre1 = dr["NOM1_EMP"].ToString();
                        medico.Nombre2 = dr["NOM2_EMP"].ToString();
                        medico.Especialidad = dr["ESP_EMP"].ToString();
                        medico.Telefono = dr["TEL_EMP"].ToString();
                        medico.Direccion = dr["DIR_EMP"].ToString();
                        medico.Email = dr["EMAIL_EMP"].ToString();

                        listaEmpleados.Add(medico);
                    }
                }
                conexion.Close();
                return listaEmpleados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarEmpleado(string cedula)
        {
            Conexion c = new Conexion();
            try
            {
                string query = ("DELETE FROM `empleados` WHERE CED_EMP='"+cedula+"'");
                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                cmd.Parameters.AddWithValue("?cedula", cedula);               
                cmd.ExecuteNonQuery();            
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Empleado ActualizarEmpleadoDatos(Empleado medico)
        {
            Conexion c = new Conexion();
            try
            {




                string query = @"UPDATE `empleados` SET `APE1_EMP`=?apellido1,`APE2_EMP`=?apellido2,`NOM1_EMP`=?nombre1,`NOM2_EMP`=?nombre2,`ESP_EMP`=?espe,`DIR_EMP`=?direccion,`TEL_EMP`=?telefono,`EMAIL_EMP`=?correo where CED_EMP=?cedula";
                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                cmd.Parameters.AddWithValue("?cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("?apellido1", medico.Apellido1);
                cmd.Parameters.AddWithValue("?apellido2", medico.Apellido2);
                cmd.Parameters.AddWithValue("?nombre1", medico.Nombre1);
                cmd.Parameters.AddWithValue("?nombre2", medico.Nombre2);
                cmd.Parameters.AddWithValue("?espe", medico.Especialidad);
                cmd.Parameters.AddWithValue("?telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("?direccion", medico.Direccion);
                cmd.Parameters.AddWithValue("?correo", medico.Email);
                cmd.ExecuteNonQuery();
                return medico;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Empleado GuardarEmpleadoDatos(Empleado medico)
        {
            Conexion c = new Conexion();
            try
            {
                string query = @"INSERT INTO `empleados`(`CED_EMP`, `APE1_EMP`, `APE2_EMP`, `NOM1_EMP`, `NOM2_EMP`, `ESP_EMP`, `DIR_EMP`, `TEL_EMP`, `EMAIL_EMP`) 
                                                         VALUES (?cedula,?apellido1,?apellido2,?nombre1,?nombre2,?espe,?direccion,?telefono,?correo)";
                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                cmd.Parameters.AddWithValue("?cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("?apellido1", medico.Apellido1);
                cmd.Parameters.AddWithValue("?apellido2", medico.Apellido2);
                cmd.Parameters.AddWithValue("?nombre1", medico.Nombre1);
                cmd.Parameters.AddWithValue("?nombre2", medico.Nombre2);
                cmd.Parameters.AddWithValue("?espe", medico.Especialidad);
                cmd.Parameters.AddWithValue("?telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("?direccion", medico.Direccion);
                cmd.Parameters.AddWithValue("?correo", medico.Email);
                cmd.ExecuteNonQuery();
                return medico;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
