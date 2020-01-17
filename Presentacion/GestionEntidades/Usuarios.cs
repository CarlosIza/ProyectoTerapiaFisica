using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades
{
    public class Usuarios
    {
    

        public Usuarios(int id, string cedula, string nombre, string contraseña, string cargo)
        {
            this.Id = id;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Cargo = cargo;
            //this.Estado = Estado;
        }
       

        public Usuarios()
        {
            
        }

        public Usuarios(int id, string cedula, string contraseña, string cargo)
        {
            this.Id = id;
            this.Cedula = cedula;
            this.Contraseña = contraseña;
            this.Cargo = cargo;
        }

        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Cargo { get; set; }
       // public int Estado { get; set; }
    }
}
