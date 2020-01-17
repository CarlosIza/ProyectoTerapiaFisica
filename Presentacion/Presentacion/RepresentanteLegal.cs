using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEntidades;
using GestionNegocio;
namespace Presentacion
{
    public partial class RepresentanteLegal : Form
    {
        public RepresentanteLegal()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Representante representante = new Representante();
                if (txtIdAuxiliar.Text == "")
                {
                    representante.id = 0;
                }
                else
                {
                  representante.id = Convert.ToInt32(txtIdAuxiliar.Text);
                }
            representante.cedula = txtCedula.Text;
            representante.apellido = txtApellido.Text;
            representante.nombre = txtNombre.Text;
            representante.telefono = txtTelefono.Text;
            representante.direccion= txtDireccion.Text;
            representante.parentezco = cbParentesco.Text;
            representante.email = txtEmail.Text;

           representante = RepresentanteNegocio.GuardarRepresentanteNegocio(representante,Convert.ToInt32(txtIdAuxiliar.Text));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
        
        }
    }
}
