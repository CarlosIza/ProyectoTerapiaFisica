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
    public partial class Enfermedad_Formulario : Form
    {
        public Enfermedad_Formulario()
        {
            InitializeComponent();
        }

        private void Enfermedad_Load(object sender, EventArgs e)
        {
            tbEnfermedades.DataSource = null;
            tbEnfermedades.DataSource = EnfermedadesNegocio.DevolverListadoEnfermedadesNegocio();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tbEnfermedades.CurrentCell = null;
                foreach (DataGridViewRow r in tbEnfermedades.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tbEnfermedades.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
            }
            else
            {
                tbEnfermedades.DataSource = EnfermedadesNegocio.DevolverListadoEnfermedadesNegocio();

            }
        }
    }
}
