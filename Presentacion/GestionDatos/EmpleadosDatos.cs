using GestionEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionEntidades;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace GestionDatos
{
    public class EmpleadosDatos
    {




        public static List<Empleado> DevolverListadoDoctoresDatos()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionMorales);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;


                List<Empleado> listaEmpleados = new List<Empleado>();


                cmd.CommandText = @"select * from Empleado";


                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empleado medico = new Empleado();
                        medico.Id =dr["id"].ToString();
                        medico.Cedula = dr["cedula"].ToString();
                        medico.Apellido1 = dr["apellidoPaterno"].ToString();
                        medico.Apellido2 = dr["apellidoMaterno"].ToString();
                        medico.Nombre1 = dr["primerNombre"].ToString();
                        medico.Nombre2 = dr["segundoNombre"].ToString();
                        medico.Especialidad = dr["especialidad"].ToString();
                        medico.Telefono = dr["telefono"].ToString();
                        medico.Direccion = dr["direccion"].ToString();
                        medico.Email = dr["email"].ToString();

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
                cmd.Parameters.AddWithValue("@cedula", cedula);               
                cmd.ExecuteNonQuery();            
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Empleado ActualizarEmpleadoDatos(Empleado medico)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionMorales);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE[dbo].[Empleado]
   SET[cedula] = @cedula 
   ,[apellidoPaterno] = @ape1   
      ,[apellidoMaterno] =@ape2
      ,[primerNombre] = @nom1
      ,[segundoNombre] = @nom2
      ,[especialidad] = @espe
      ,[direccion] =@dir
      ,[telefono] = @tel
      ,[email] = @email
 WHERE id=@id";




                cmd.Parameters.AddWithValue("@cedula",medico.Cedula);
                cmd.Parameters.AddWithValue("@ape1", medico.Apellido1);
                cmd.Parameters.AddWithValue("@ape2", medico.Apellido2);
                cmd.Parameters.AddWithValue("@nom1",medico.Nombre1);
                cmd.Parameters.AddWithValue("@nom2", medico.Nombre2);
                cmd.Parameters.AddWithValue("@espe", medico.Especialidad);
                cmd.Parameters.AddWithValue("@dir", medico.Direccion);
                cmd.Parameters.AddWithValue("@tel", medico.Telefono);
                cmd.Parameters.AddWithValue("@id", medico.Id);
                cmd.Parameters.AddWithValue("@email", medico.Email);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexion.Close();
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
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionMorales);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText= @"INSERT INTO [dbo].[Empleado]
                                                   ([cedula]
                                                   ,[apellidoPaterno]
                                                   ,[apellidoMaterno]
                                                   ,[primerNombre]
                                                   ,[segundoNombre]
                                                   ,[especialidad]
                                                   ,[direccion]
                                                   ,[telefono]
                                                   ,[email])
                                             VALUES
                                                (@cedula,@apellido1,@apellido2,@nombre1,@nombre2,@espe,@direccion,@telefono,@correo)";
               
                cmd.Parameters.AddWithValue("@cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("@apellido1", medico.Apellido1);
                cmd.Parameters.AddWithValue("@apellido2", medico.Apellido2);
                cmd.Parameters.AddWithValue("@nombre1", medico.Nombre1);
                cmd.Parameters.AddWithValue("@nombre2", medico.Nombre2);
                cmd.Parameters.AddWithValue("@espe", medico.Especialidad);
                cmd.Parameters.AddWithValue("@telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("@direccion", medico.Direccion);
                cmd.Parameters.AddWithValue("@correo", medico.Email);
                cmd.CommandType = CommandType.Text;
                var idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                return medico;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
