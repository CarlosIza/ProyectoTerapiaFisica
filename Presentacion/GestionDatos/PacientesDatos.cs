using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionEntidades;
using System.Data;

namespace GestionDatos
{
    public class PacientesDatos
    {
        public static Paciente GuardarPacienteDatos(Paciente paciente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Paciente]
                                                           ([cedula]
                                                           ,[primerNombre]
                                                           ,[segundoNombre]
                                                           ,[apellidoPaterno]
                                                           ,[apellidoMaterno]
                                                           ,[fechaNacimiento]
                                                           ,[genero]
                                                           ,[fechaIngreso]
                                                           ,[telefono]
                                                           ,[direccion]
                                                           ,[estado])
                                                     VALUES
                                                           (@cedula,@primerNombre,@segundoNombre,@apellidoPaterno,@apellidoMaterno,@fechaNacimiento,@genero,@fechaIngreso,@telefono,@direccion,1)";


                cmd.Parameters.AddWithValue("@cedula", paciente.cedula);
                cmd.Parameters.AddWithValue("@primerNombre", paciente.nombre1);
                cmd.Parameters.AddWithValue("@segundoNombre", paciente.nombre2);
                cmd.Parameters.AddWithValue("@apellidoPaterno", paciente.apellido1);
                cmd.Parameters.AddWithValue("@apellidoMaterno", paciente.apellido2);
                cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.fechaNacimiento);
                cmd.Parameters.AddWithValue("@genero", paciente.genero);
                cmd.Parameters.AddWithValue("@fechaIngreso", paciente.fechaIngreso);
                cmd.Parameters.AddWithValue("@telefono", paciente.telefono);
                cmd.Parameters.AddWithValue("@direccion", paciente.direccion);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //        public static List<Paciente> DevolverListadoPacientesDatosCedula(string cedulaPaciente)
        //        {
        //            try
        //            {
        //                List<Paciente> listaPacientes = new List<Paciente>();
        //                Conexion c = new Conexion();
        //                MySqlDataReader reader = null;
        //                string query = @"SELECT `CED_PAC`, `APE1_PAC`, `APE2_PAC`, `NOM1_PAC`, `NOM2_PAC`, `FEC_NAC_PAC`, `GEN_PAC`, `FEC_ING_PAC`, `TEL_PAC`, `DIR_PAC`,
        //`MOTIVO_CONSULTA`, `ANTESC_PATOLOG_PERSO`, `ANTESC_PATOLOG_FAMIL`, `DIAGNOSTICO`, `TRATAMIENTO` FROM `pacientes` WHERE `CED_PAC` Like '%" + cedulaPaciente + "%'";
        //                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
        //                reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    Paciente paciente = new Paciente();
        //                    paciente.cedula = reader["CED_PAC"].ToString();
        //                    paciente.apellido1 = reader["APE1_PAC"].ToString();
        //                    paciente.apellido2 = reader["APE2_PAC"].ToString();
        //                    paciente.nombre1 = reader["NOM1_PAC"].ToString();
        //                    paciente.nombre2 = reader["NOM2_PAC"].ToString();
        //                    paciente.fechaNacimiento = Convert.ToDateTime(reader["FEC_NAC_PAC"].ToString());
        //                    paciente.genero = Convert.ToChar(reader["GEN_PAC"].ToString());
        //                    paciente.fechaIngreso =Convert.ToDateTime(reader["FEC_ING_PAC"].ToString());
        //                    paciente.telefono = reader["TEL_PAC`"].ToString();
        //                    paciente.direccion = reader["DIR_PAC"].ToString();
        //                    listaPacientes.Add(paciente);
        //                }
        //                return listaPacientes;
        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }
        //        }

        public static List<Paciente> DevolverListadoPacientesDatos()
        {
            try
            {
                List<Paciente> listaPacientes = new List<Paciente>();
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                cmd.CommandText = @"SELECT [id]
                                          ,[cedula]
                                          ,[primerNombre]
                                          ,[segundoNombre]
                                          ,[apellidoPaterno]
                                          ,[apellidoMaterno]
                                          ,[fechaNacimiento]
                                          ,[genero]
                                          ,[fechaIngreso]
                                          ,[telefono]
                                          ,[direccion]
                                      FROM [dbo].[Paciente]
                                           WHERE estado=1";
                cmd.CommandType = CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Paciente paciente = new Paciente();
                        paciente.id = Convert.ToInt32(reader["id"].ToString());
                        paciente.cedula = reader["cedula"].ToString();
                        paciente.apellido1 = reader["apellidoPaterno"].ToString();
                        paciente.apellido2 = reader["apellidoMaterno"].ToString();
                        paciente.nombre1 = reader["primerNombre"].ToString();
                        paciente.nombre2 = reader["segundoNombre"].ToString();
                        paciente.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"].ToString());
                        paciente.genero = reader["genero"].ToString();
                        paciente.fechaIngreso = Convert.ToDateTime(reader["fechaIngreso"].ToString());
                        paciente.telefono = reader["telefono"].ToString();
                        paciente.direccion = reader["direccion"].ToString();
                        listaPacientes.Add(paciente);
                    }
                }
                conexion.Close();
                return listaPacientes;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Paciente ModificarPacienteDatos(Paciente paciente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Paciente]
                                           SET [cedula] = @cedula
                                              ,[primerNombre] = @primerNombre
                                              ,[segundoNombre] = @segundoNombre
                                              ,[apellidoPaterno] = @apellidoPaterno
                                              ,[apellidoMaterno] = @apellidoMaterno
                                              ,[fechaNacimiento] = @fechaNacimiento
                                              ,[genero] = @genero
                                              ,[fechaIngreso] = @fechaIngreso
                                              ,[telefono] = @telefono
                                              ,[direccion] = @direccion
                                              ,[estado] = 1
                                         WHERE id=@id";

                cmd.Parameters.AddWithValue("@id", paciente.id);
                cmd.Parameters.AddWithValue("@cedula", paciente.cedula);
                cmd.Parameters.AddWithValue("@primerNombre", paciente.nombre1);
                cmd.Parameters.AddWithValue("@segundoNombre", paciente.nombre2);
                cmd.Parameters.AddWithValue("@apellidoPaterno", paciente.apellido1);
                cmd.Parameters.AddWithValue("@apellidoMaterno", paciente.apellido2);
                cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.fechaNacimiento);
                cmd.Parameters.AddWithValue("@genero", paciente.genero);
                cmd.Parameters.AddWithValue("@fechaIngreso", paciente.fechaIngreso);
                cmd.Parameters.AddWithValue("@telefono", paciente.telefono);
                cmd.Parameters.AddWithValue("@direccion", paciente.direccion);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                conexion.Close();
                return paciente;

            }
            catch (Exception)
            {

                throw;
            }
        }
            public static Paciente EliminarPacienteDatos(Paciente paciente, int idEiminar)
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"UPDATE [dbo].[Paciente]
                                           SET [estado] = 0
                                         WHERE id= "+idEiminar;

                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    return paciente;

                }
                catch (Exception)
                {

                    throw;
                }
            }
    }
}
    

