using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionEntidades;
using System.Data;
using System.Windows.Forms;

namespace GestionDatos
{
    public class RepresentanteDatos
    {
        public static Representante GuardarRepresentanteDatos(Representante representante, int idPaciente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Representante]
                                                       ([cedula]
                                                       ,[apellido]
                                                       ,[nombre]
                                                       ,[telefono]
                                                       ,[direccion]
                                                       ,[parentesco]
                                                       ,[email]
                                                       ,[pacienteP]
                                                       ,[estado])
                                                 VALUES
                                                       (@cedula,@apellido,@nombre,@telefono,@direccion,@parentesco,@email," + idPaciente + ",1)";


                cmd.Parameters.AddWithValue("@cedula", representante.cedula);
                cmd.Parameters.AddWithValue("@apellido", representante.apellido);
                cmd.Parameters.AddWithValue("@nombre", representante.nombre);
                cmd.Parameters.AddWithValue("@telefono", representante.telefono);
                cmd.Parameters.AddWithValue("@direccion", representante.direccion);
                cmd.Parameters.AddWithValue("@parentesco", representante.parentezco);
                cmd.Parameters.AddWithValue("@email", representante.email);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                conexion.Close();
                return representante;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static Representante ModificarRepresentanteDatosDatos(Representante representante, int idPaciente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Representante]
                                                   SET [cedula] = @cedula
                                                      ,[apellido] = @apellido
                                                      ,[nombre] = @nombre
                                                      ,[telefono] = @telefono
                                                      ,[direccion] = @direccion
                                                      ,[parentesco] = @parentesco
                                                      ,[email] = @email
                                                      ,[pacienteP] = " + idPaciente + ", [estado] = 1 WHERE id=@id";

                cmd.Parameters.AddWithValue("@id", representante.id);
                cmd.Parameters.AddWithValue("@cedula", representante.cedula);
                cmd.Parameters.AddWithValue("@apellido", representante.apellido);
                cmd.Parameters.AddWithValue("@nombre", representante.nombre);
                cmd.Parameters.AddWithValue("@telefono", representante.telefono);
                cmd.Parameters.AddWithValue("@direccion", representante.direccion);
                cmd.Parameters.AddWithValue("@parentesco", representante.parentezco);
                cmd.Parameters.AddWithValue("@email", representante.email);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                conexion.Close();
                return representante;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DevolverListadoRepresentanteDatos(int idPaciente, TextBox id, TextBox cedula, 
                                                            TextBox apellido, TextBox nombre, TextBox telefono, TextBox direccion,
                                                             ComboBox parentesco, TextBox email)
        {
            try
            {
                List<Representante> listaRepresentante = new List<Representante>();
                SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionFreddy);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                cmd.CommandText = @"SELECT [id]
                                              ,[cedula]
                                              ,[apellido]
                                              ,[nombre]
                                              ,[telefono]
                                              ,[direccion]
                                              ,[parentesco]
                                              ,[email]
                                              ,[pacienteP]
                                              ,[estado]
                                          FROM [dbo].[Representante]
                                           WHERE estado=1
                                            AND pacienteP=" + idPaciente;
                cmd.CommandType = CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       
                       id.Text = Convert.ToInt32(reader["id"].ToString()).ToString();
                       cedula.Text = reader["cedula"].ToString();
                       apellido.Text = reader["apellido"].ToString();
                       nombre.Text = reader["nombre"].ToString();
                       telefono.Text = reader["telefono"].ToString();
                       direccion.Text = reader["direccion"].ToString();
                       parentesco.Text = reader["parentesco"].ToString();
                       email.Text = reader["email"].ToString();
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
