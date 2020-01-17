using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDatos;
using GestionEntidades;
namespace GestionNegocio
{
    public class LoginNegocio
    {
        LoginDatos loginDatos = new LoginDatos();
        public bool loginUserNegocio(string user, string pass)
        {
            return loginDatos.LoginUsuarioDatosSQL(user, pass);
        }

        public string CargoLoginUsuarioNegocio(string user, string pass)
        {
            return loginDatos.CargoLoginUsuarioDatos(user, pass);
        }

        public string listaNombreApellidoNegocio(string cedula)
        {
            return loginDatos.datosUsuarioNombreApelldio(cedula);
        }
    }
}
