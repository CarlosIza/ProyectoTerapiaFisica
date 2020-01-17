using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades
{
    public class Enfermedad
    {
      
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string enfermedades { get; set; }

        public Enfermedad(int Id, string Codigo, string enfermedades)
        {
            this.Id = Id;
            this.Codigo = Codigo;
            this.enfermedades = enfermedades;
        }

        public Enfermedad()
        {

        }
    }
}
