using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionEntidades;


namespace GestionDatos
{
    public class EnfermedadesDatos
    {
        public static List<Enfermedad> DevolverListadoenfermedadsDatos()
        {
            try
            {
                List<Enfermedad> listaEnfermedades = new List<Enfermedad>();
                SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                cmd.CommandText = @"SELECT [id]
                                  ,[codInfo]
                                  ,[enfermedad]
                              FROM [dbo].[Enfermedad]";
                cmd.CommandType = CommandType.Text;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Enfermedad enfermedad = new Enfermedad();
                        enfermedad.Id = Convert.ToInt32(reader["id"].ToString());
                        enfermedad.Codigo = reader["codInfo"].ToString();
                        enfermedad.enfermedades = reader["enfermedad"].ToString();


                        listaEnfermedades.Add(enfermedad);
                    }
                }
                conexion.Close();
                return listaEnfermedades;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
