using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDatos;
using GestionEntidades;
namespace GestionNegocio
{
    public class PacienteNegocio
    {
        public static Paciente GuardarPacienteNegocio(Paciente paciente)
        {   
            if (paciente.id == 0)
            {
                return PacientesDatos.GuardarPacienteDatos(paciente);
            }
            else
            {
                return PacientesDatos.ModificarPacienteDatos(paciente);
            }

        }

        //public static Paciente ModificarPacienteNegocio(Paciente paciente,string cedulaSeleccionada)
        //{
        //    return PacientesDatos.ModificarPacienteDatos(paciente,cedulaSeleccionada);
        //}

        public static List<Paciente> DevolverListadoPacientesNegocio()
        {
            return PacientesDatos.DevolverListadoPacientesDatos();
        }
        public static Paciente EliminarPacienteNegocio(Paciente paciente, int idEliminar)
        {
                return PacientesDatos.EliminarPacienteDatos(paciente, idEliminar);

        }
        //public static List<Paciente> DevolverListadoPacientesNegocioCedula(string cedulaCliente)
        //{
        //    return PacientesDatos.DevolverListadoPacientesDatosCedula(cedulaCliente);
        //}
    }
}
