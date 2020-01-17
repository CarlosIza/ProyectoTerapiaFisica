using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDatos;
using GestionEntidades;
namespace GestionNegocio
{
    public class UsuariosNegocio
    {
        Usuarios ud= new Usuarios();
        //Devolver dATOS USUARIOS
        public static List<Usuarios> DevolverListadousuariossNegocio()
        {
            return UsuarioDatos.devolverListaUsuariosDatos();
        }
        //Datos medicos
        public static List<EmpleadoCedulas> DevolverListadoEmpleados()
        {
            return UsuarioDatos.devolverListadoEmpleados();
        }
        

        //GUARDAR 
        public static Usuarios GuardarusuariosDatos(Usuarios usuarios)
        {
             return UsuarioDatos.GuardarUsuariosDatosSQL(usuarios);
        }
        //Y ACTUALIZAR DATOS
        public static Usuarios ActualizarUsuarioNegocio(Usuarios usuarios)
        {
            return UsuarioDatos.ActualizarUsuariosDatos(usuarios);
        }
        //Eliminar Datos o dar de baja

        public static Usuarios EliminarUsuarioNegocio(Usuarios usuarios)
        {
            return UsuarioDatos.EliminarUsuarioDatos(usuarios);
        }
        //POR FILTROS:
        public static List<EmpleadoCedulas> DevolverFiltroCedula(string cedula)
        {
            return UsuarioDatos.filtroPorCedulaDatos(cedula);
        }

        public static List<EmpleadoCedulas> DevolverFiltroNombre(string nombre)
        {
            return UsuarioDatos.filtroPorNombreDatos(nombre);
        }
        public static List<EmpleadoCedulas> DevolverFiltroApellido(string apellido)
        {
            return UsuarioDatos.filtroPorApellidoDatos(apellido);
        }
    }
}
