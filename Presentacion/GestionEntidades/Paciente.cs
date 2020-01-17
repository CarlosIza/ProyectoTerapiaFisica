using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades
{
    public class Paciente
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string genero { get; set; }
        public DateTime fechaIngreso { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
      
        public Paciente(int id,string cedula, string apellido1, string apellido2, string nombre1, string nombre2, DateTime fechaNacimiento, string genero, DateTime fechaIngreso, string telefono, string direccion)
        {
            this.id = id;
            this.cedula = cedula;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
            this.direccion = direccion;
        }
        public Paciente(){


        }

}
}
