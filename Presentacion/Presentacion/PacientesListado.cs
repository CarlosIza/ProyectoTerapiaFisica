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
    public partial class PacientesListado : Form
    {
        public Paciente pacienteSeleccionado { get; set; }
        public PacientesListado()
        {
            InitializeComponent();
        }
        public void cargarListadoPacientes()
        {
            tbPacientes.DataSource = null;
            tbPacientes.DataSource = PacienteNegocio.DevolverListadoPacientesNegocio();
        }
        private void PacientesListado_Load(object sender, EventArgs e)
        {
            cargarListadoPacientes();
            tbPacientes.Columns[0].Width = 45;
            tbPacientes.Columns[7].Width = 50;
            tbPacientes.Columns[0].HeaderText = "Id";
            tbPacientes.Columns[1].HeaderText = "Cédula";
            tbPacientes.Columns[2].HeaderText = "Apellido Paterno";
            tbPacientes.Columns[3].HeaderText = "Apellido Materno";
            tbPacientes.Columns[4].HeaderText = "Primer Nombre";
            tbPacientes.Columns[5].HeaderText = "Segundo Nombre";
            tbPacientes.Columns[6].HeaderText = "Fecha Nacimiento";
            tbPacientes.Columns[7].HeaderText = "Género";
            tbPacientes.Columns[8].HeaderText = "Fecha Ingreso";
            tbPacientes.Columns[9].HeaderText = "Teléfono";
            tbPacientes.Columns[10].HeaderText = "Dirección";
        }
        PacientesRegistro pacientesDatos = new PacientesRegistro();
        private void BtnModificar_Click(object sender, EventArgs e)
        {

            pacientesDatos.ShowDialog();
            this.Close();

        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tbPacientes.CurrentCell = null;
                foreach (DataGridViewRow r in tbPacientes.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tbPacientes.Rows)
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
                tbPacientes.DataSource = PacienteNegocio.DevolverListadoPacientesNegocio();

            }
        }
        int id=0;
        private void TbPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(tbPacientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
            var cedula = tbPacientes.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
            var apellido1 = tbPacientes.Rows[e.RowIndex].Cells["apellido1"].Value.ToString();
            var apellido2 = tbPacientes.Rows[e.RowIndex].Cells["apellido2"].Value.ToString();
            var nombre1 = tbPacientes.Rows[e.RowIndex].Cells["nombre1"].Value.ToString();
            var nombre2= tbPacientes.Rows[e.RowIndex].Cells["nombre2"].Value.ToString();
            DateTime fechaNacimiento= Convert.ToDateTime(tbPacientes.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString());
            var genero = tbPacientes.Rows[e.RowIndex].Cells["genero"].Value.ToString();
            DateTime fechaIngreso = Convert.ToDateTime(tbPacientes.Rows[e.RowIndex].Cells["fechaIngreso"].Value.ToString());
            var telefono = tbPacientes.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            var direccion = tbPacientes.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            Paciente datosPaciente = new Paciente(id,cedula,apellido1, apellido2, nombre1,nombre2,fechaNacimiento,genero,fechaIngreso,telefono,direccion);
            pacienteSeleccionado = datosPaciente;

            if (pacienteSeleccionado != null)
            {
                pacientesDatos.txtIdAuxiliar.Text = Convert.ToInt32(pacienteSeleccionado.id).ToString();
                pacientesDatos.txtCedula.Text = pacienteSeleccionado.cedula;
                pacientesDatos.txtApellido1.Text = pacienteSeleccionado.apellido1;
                pacientesDatos.txtApellido2.Text = pacienteSeleccionado.apellido2;
                pacientesDatos.txtNombre1.Text = pacienteSeleccionado.nombre1;
                pacientesDatos.txtNombre2.Text = pacienteSeleccionado.nombre2;
                string fechaNac= Convert.ToDateTime(pacienteSeleccionado.fechaNacimiento).ToString("yyyy/MM/dd");
                pacientesDatos.txtFechaNac.Text = fechaNac.Replace('/', '-');
                pacientesDatos.cbGenero.Text = pacienteSeleccionado.genero;
                string fechaIng= Convert.ToDateTime(pacienteSeleccionado.fechaIngreso).ToString("yyyy/MM/dd");
                pacientesDatos.txtFechaIngresPac.Text = fechaIng.Replace('/', '-');
                pacientesDatos.txtTelefono.Text = pacienteSeleccionado.telefono;
                pacientesDatos.txtDireccion.Text = pacienteSeleccionado.direccion;

            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            pacientesDatos.ShowDialog();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
           
            Paciente paciente = new Paciente();
            paciente = PacienteNegocio.EliminarPacienteNegocio(paciente,id);
        }
    }
}
