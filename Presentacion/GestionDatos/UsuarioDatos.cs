using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEntidades;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionDatos
{
    public class UsuarioDatos
    {
    

        // Esta función "encripta" la cadena que le envíamos en el parámentro de entrada.
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        //////////////CON SQL SERVER:

        public static Usuarios GuardarUsuariosDatosSQL(Usuarios usuarios)
        {
            try
            {
                List<Usuarios> listaUsuarios = new List<Usuarios>();
                SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Usuario]
                                           ([usuario]
                                           ,[nombre]
                                           ,[contrasenia]
                                           ,[cargo]
                                           ,[estado])
                                     VALUES
                                    (@cedula, @nombre, @contrasenia, @cargo, 1)
                                         select scope_identity()";
                cmd.Parameters.AddWithValue("@cedula", usuarios.Cedula);
                cmd.Parameters.AddWithValue("@nombre", usuarios.Nombre);
                string contraseña = Encriptar(usuarios.Contraseña);
                cmd.Parameters.AddWithValue("@contrasenia", contraseña);
                cmd.Parameters.AddWithValue("@cargo", usuarios.Cargo);
                //cmd.Parameters.AddWithValue("@estado", usuarios.Estado);
                cmd.CommandType = CommandType.Text;

                //cmd.ExecuteNonQuery();
                var idusuarios = Convert.ToInt32(cmd.ExecuteScalar());
                usuarios.Id = idusuarios;
                // usuarios = DevolverusuariosPorIdusuarios(idusuarios);
                conexion.Close();

                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Listado De todos los usuarios insertados

        public static List<Usuarios> devolverListaUsuariosDatos()
        {
            try
            {
                List<Usuarios> listadoUsuarios = new List<Usuarios>();
                SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [id]
                              ,[usuario]
                              ,[nombre]
                              ,[contrasenia]
                              ,[cargo]
                          FROM [dbo].[Usuario]
                            where estado = " + 1;
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int Id = Convert.ToInt32(dr["id"].ToString());
                        string Cedula = dr["usuario"].ToString();
                        string Nombre = dr["nombre"].ToString();
                        string Contraseña = dr["contrasenia"].ToString();
                        string Cargo = dr["cargo"].ToString();
                       
                        Usuarios usuarios = new Usuarios(Id, Cedula, Nombre, Contraseña, Cargo);

                        listadoUsuarios.Add(usuarios);
                    }
                }
                conexion.Close();
                return listadoUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //ACTUALIZAR USUARIOS
 
        public static Usuarios ActualizarUsuariosDatos(Usuarios usuarios)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Usuario]
                       SET [usuario] = @cedula
                          ,[nombre] = @nombre
                          ,[contrasenia] = @contraseña
                          ,[cargo] = @cargo
                          ,[estado] = 1
                        WHERE id = @id";
                cmd.Parameters.AddWithValue("@cedula", usuarios.Cedula);
                cmd.Parameters.AddWithValue("@nombre", usuarios.Nombre);
                string contraseña = Encriptar(usuarios.Contraseña);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@cargo", usuarios.Cargo);
                //cmd.Parameters.AddWithValue("@estado", usuarios.Estado);
                //  ,[estado] = @estado
                cmd.Parameters.AddWithValue("@id", usuarios.Id);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuarios EliminarUsuarioDatos(Usuarios usuarios)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.conexionGuillermo);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Usuario]
                               SET [estado] = '" +0+"'  WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", usuarios.Id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }



        ////////////////////////////////////////////////////////


        //Metodo para modificar un Usuario
        public static Usuarios ActualizarUsuarios(Usuarios usuarios)
        {
            Conexion c = new Conexion();
            try
            {
                string query = @"UPDATE `usuarios` SET `CAR_USU`= ?cargo,`CON_USU`= ?contraseña,`CED_EMP_PER`= ?cedula WHERE ID_USU=?id";

                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                cmd.Parameters.AddWithValue("?id", usuarios.Id);
                cmd.Parameters.AddWithValue("?cargo", usuarios.Cargo);
                string contraseña = Encriptar(usuarios.Contraseña);
                cmd.Parameters.AddWithValue("?contraseña", contraseña);
                cmd.Parameters.AddWithValue("?cedula", usuarios.Cedula);
                cmd.ExecuteNonQuery();
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }



        //Metodo para devolver todos los usuarios que hay en la base
        public static List<Usuarios> devolverListaUsuarios()
        {
            try
            {
                List<Usuarios> listadoUsuarios = new List<Usuarios>();
                string resultado = "";
                Conexion c = new Conexion();
                MySqlDataReader reader = null;
                string query = "select ID_USU, CED_EMP_PER, CAR_USU, CON_USU from usuarios";
                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultado += reader.GetString(1) + "\n";
                    int id = Convert.ToInt32(reader["ID_USU"].ToString());
                    string cedula = reader["CED_EMP_PER"].ToString();
                    string cargo = reader["CAR_USU"].ToString();
                    string contraseña = reader["CON_USU"].ToString();
                    Usuarios usuarios = new Usuarios(id, cedula, contraseña, cargo);

                    listadoUsuarios.Add(usuarios);

                }
                return listadoUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Método para devovler la lista de empleados mas importantes tales como cedula nombre y apellido
        public static List<EmpleadoCedulas> devolverListadoEmpleados()
        {
            try
            {
                List<EmpleadoCedulas> listadoEmpleados = new List<EmpleadoCedulas>();
                string resultado = "";

                Conexion c = new Conexion();

                MySqlDataReader reader = null;
                string query = "select CED_EMP, NOM1_EMP, APE1_EMP, APE2_EMP from empleados";
                MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado += reader.GetString(1) + "\n";
                    EmpleadoCedulas medicos = new EmpleadoCedulas();
                    medicos.cedula = reader["CED_EMP"].ToString();
                    medicos.nombre = reader["NOM1_EMP"].ToString();
                    medicos.apellido = reader["APE1_EMP"].ToString();
                    medicos.apellido2 = reader["APE2_EMP"].ToString();
                    listadoEmpleados.Add(medicos);

                }
                return listadoEmpleados;
            }
            catch (Exception)
            {

                throw;
            }
        }
   
        //Metodo para filtrar por cédula:
        public static List<EmpleadoCedulas> filtroPorCedulaDatos(string cedula)
        {
           List<EmpleadoCedulas> listadoUsuarios = new List<EmpleadoCedulas>();

            string resultado = "";
            Conexion c = new Conexion();
            MySqlDataReader reader = null;

            string query = "select NOM1_EMP, APE1_EMP, APE2_EMP from empleados where CED_EMP = " + cedula;
            MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
            reader = cmd.ExecuteReader();
            EmpleadoCedulas empleado;
            while (reader.Read())
            {
                resultado += reader.GetString(1) + "\n";
                empleado = new EmpleadoCedulas();
                empleado.cedula = cedula;
                empleado.nombre = reader["NOM1_EMP"].ToString();
                empleado.apellido = reader["APE1_EMP"].ToString();
                empleado.apellido2 = reader["APE2_EMP"].ToString();

                listadoUsuarios.Add(empleado);
            }
            return listadoUsuarios;
        }

        //Metodo para filtrar por Nombre:
        public static List<EmpleadoCedulas> filtroPorNombreDatos(string nombre)
        {
            List<EmpleadoCedulas> listadoUsuarios = new List<EmpleadoCedulas>();

            string resultado = "";
            Conexion c = new Conexion();
            MySqlDataReader reader = null;

            string query = "select CED_EMP, APE1_EMP, APE2_EMP from empleados where NOM1_EMP like '" + nombre + "%'";
            MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
            reader = cmd.ExecuteReader();
            EmpleadoCedulas empleado;
            while (reader.Read())
            {
                resultado += reader.GetString(1) + "\n";
                empleado = new EmpleadoCedulas();
                empleado.cedula = reader["CED_EMP"].ToString();
                empleado.nombre = nombre;
                empleado.apellido = reader["APE1_EMP"].ToString();
                empleado.apellido2 = reader["APE2_EMP"].ToString();

                listadoUsuarios.Add(empleado);
            }
            return listadoUsuarios;
        }
        //Metodo para filtrar por Apellido:
        public static List<EmpleadoCedulas> filtroPorApellidoDatos(string apellido)
        {
            List<EmpleadoCedulas> listadoUsuarios = new List<EmpleadoCedulas>();

            string resultado = "";
            Conexion c = new Conexion();
            MySqlDataReader reader = null;

            string query = "select CED_EMP, NOM1_EMP, APE2_EMP from empleados where APE1_EMP = " + apellido;
            MySqlCommand cmd = new MySqlCommand(query, c.obtenerconexion());
            reader = cmd.ExecuteReader();
            EmpleadoCedulas empleado;
            while (reader.Read())
            {
                resultado += reader.GetString(1) + "\n";
                empleado = new EmpleadoCedulas();
                empleado.cedula = reader["CED_EMP"].ToString();
                empleado.nombre = reader["NOM1_EMP"].ToString();
                empleado.apellido = apellido;
                empleado.apellido2 = reader["APE2_EMP"].ToString();

                listadoUsuarios.Add(empleado);
            }
            return listadoUsuarios;
        }

    }
}
