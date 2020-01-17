using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNegocio;
using GestionEntidades;

namespace Presentacion
{
    public partial class Form_Cedulas : Form
    {
        public EmpleadoCedulas cedulaSeleccionado { get; set; }

        public Form_Cedulas()
        {
            InitializeComponent();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EmpleadosCedulas_Load(object sender, EventArgs e)
        {
            cargarListadoCedulas();
        }

        private void cargarListadoCedulas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UsuariosNegocio.DevolverListadoEmpleados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cedula = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
            var nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            var apellido = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            var apellido2 = dataGridView1.Rows[e.RowIndex].Cells["apellido2"].Value.ToString();
            EmpleadoCedulas empleadoCedulas = new EmpleadoCedulas(cedula,nombre,apellido,apellido2);
            cedulaSeleccionado = empleadoCedulas;
            this.Close();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButtonCedula.Checked)
            {
                filtrarPorCedula();
            }
            else if (radioButtonNombre.Checked)
            {
                dataGridView1.DataSource = UsuariosNegocio.DevolverFiltroNombre(txtNombre.Text);

            }
            else if (radioButtoApellido.Checked)
            {
                dataGridView1.DataSource = UsuariosNegocio.DevolverFiltroApellido(txtApellido.Text);

            }

            //filtrarPorCedula();
        }

        private void filtrarPorCedula()
        {
            dataGridView1.DataSource = UsuariosNegocio.DevolverFiltroCedula(txtCedula.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
            }
            else
            {
                dataGridView1.DataSource = UsuariosNegocio.DevolverListadoEmpleados();

            }
        }

        private void radioButtonCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCedula.Checked)
            {
              
                txtCedula.ReadOnly = false;
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
            }
        }

        private void radioButtonNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNombre.Checked)
            {

                txtCedula.ReadOnly = true;
                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = true;
            }
        }

        private void radioButtoApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtoApellido.Checked)
            {

                txtCedula.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = false;
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = UsuariosNegocio.DevolverFiltroNombre(txtNombre.Text);
        }
    }
}
