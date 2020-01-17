using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDatos;
using GestionEntidades;

namespace GestionNegocio
{
    public class RepresentanteNegocio {

        public static Representante GuardarRepresentanteNegocio(Representante representante, int idPaciente)
        {
            if (representante.id == 0)
            {
                return RepresentanteDatos.GuardarRepresentanteDatos(representante, idPaciente);
            }
            else
            {
                return RepresentanteDatos.ModificarRepresentanteDatosDatos(representante, idPaciente);
            }
        }
        //public static Paciente ModificarPacienteNegocio(Paciente paciente,string cedulaSeleccionada)
        //{
        //    return PacientesDatos.ModificarPacienteDatos(paciente,cedulaSeleccionada);
        //}

        //public static List<Paciente> DevolverListadoPacientesNegocio()
        //    {
        //        return PacientesDatos.DevolverListadoPacientesDatos();
        //    }
        //    public static Paciente EliminarPacienteNegocio(Paciente paciente, int idEliminar)
        //    {
        //        return PacientesDatos.EliminarPacienteDatos(paciente, idEliminar);

        //    }
        public static void DevolverListadoRepresentantesNegocio(int idPaciente, TextBox id, TextBox cedula,
                                                            TextBox apellido, TextBox nombre, TextBox telefono, TextBox direccion,
                                                             ComboBox parentesco,TextBox email)
        {
            RepresentanteDatos.DevolverListadoRepresentanteDatos(idPaciente, id, cedula,apellido,nombre,telefono, direccion, parentesco, email);
        }


        }
}
