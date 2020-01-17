using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionEntidades;
using GestionDatos;

namespace GestionNegocio
{
    public class EmpleadoNegocio
    {
        public static List<Empleado> DevolverListadoEmpleadosNegocio()
        {
            return EmpleadosDatos.DevolverListadoDoctoresDatos();
        }

        public static Empleado GuardarEmpleadoNegocio(Empleado medico)
        {
            return EmpleadosDatos.GuardarEmpleadoDatos(medico);
        }

        public static Empleado ActualizarEmpleadoNegocio(Empleado medico)
        {
            return EmpleadosDatos.ActualizarEmpleadoDatos(medico);
        }

        public static void EliminarEmpleado(string cedula)
        {
            EmpleadosDatos.EliminarEmpleado(cedula);
        }
    }
}
