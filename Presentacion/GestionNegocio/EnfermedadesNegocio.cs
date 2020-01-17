using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDatos;
using GestionEntidades;
namespace GestionNegocio
{
    public class EnfermedadesNegocio
    {
        public static List<Enfermedad> DevolverListadoEnfermedadesNegocio()
        {
            return EnfermedadesDatos.DevolverListadoenfermedadsDatos();
        }
    }
}
