using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades
{
    public class EmpleadoCedulas
    {
        public EmpleadoCedulas()
        {
       
        }
        public EmpleadoCedulas(string cedula, string nombre, string apellido, string apellido2)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.apellido2 = apellido2;
        }

        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string apellido2 { get; set; }

    }
}
