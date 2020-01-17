using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades
{
   public class Empleado
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Especialidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
