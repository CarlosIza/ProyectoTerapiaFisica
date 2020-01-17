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
    public partial class PacientesRegistro : Form
    {
        public PacientesRegistro()
        {
            InitializeComponent();
        }

        private void TxtCedula_Enter(object sender, EventArgs e)
        {

        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {

        }
        private void CargarListadoPacientes()
        {
      
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrarP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
       
        private void BtnLogiar_Click(object sender, EventArgs e)
        {

            Paciente paciente = new Paciente();
                            if (txtIdAuxiliar.Text == "")
                            {
                                paciente.id = 0;
                            }
                            else
                            {
                                  paciente.id = Convert.ToInt32(txtIdAuxiliar.Text);
                            }
                        paciente.cedula = txtCedula.Text;
                        paciente.apellido1 = txtApellido1.Text;
                        paciente.apellido2 = txtApellido2.Text;
                        paciente.nombre1 = txtNombre1.Text;
                        paciente.nombre2 = txtNombre2.Text;
                        paciente.fechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);
                        paciente.genero = cbGenero.SelectedItem.ToString();
                        paciente.fechaIngreso = Convert.ToDateTime(txtFechaIngresPac.Text);
                        paciente.telefono = txtTelefono.Text;
                        paciente.direccion = txtDireccion.Text;


                       paciente = PacienteNegocio.GuardarPacienteNegocio(paciente);

            //PacientesListado pacientesListado = new PacientesListado();
            //pacientesListado.ShowDialog();
            //this.Close();

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.cedula = txtCedula.Text;
            paciente.apellido1 = txtApellido1.Text;
            paciente.apellido2 = txtApellido2.Text;
            paciente.nombre1 = txtNombre1.Text;
            paciente.nombre2 = txtNombre2.Text;
            paciente.fechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Value.Date.ToString("yyyy/MM/dd"));
            paciente.genero = cbGenero.SelectedItem.ToString();
            paciente.fechaIngreso = Convert.ToDateTime(txtFechaNac.Text);
            paciente.telefono = txtTelefono.Text;
            paciente.direccion = txtDireccion.Text;


       //     paciente = PacienteNegocio.ModificarPacienteNegocio(paciente,paciente.cedula);
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
           
            //CargarListadoPacientes();
            //tbPacientes.Columns[0].HeaderText = "Cédula";
            //tbPacientes.Columns[1].HeaderText = "Apellido Paterno";
            //tbPacientes.Columns[2].HeaderText = "Apellido Materno";
            //tbPacientes.Columns[3].HeaderText = "Primer Nombre";
            //tbPacientes.Columns[4].HeaderText = "Segundo Nombre";
            //tbPacientes.Columns[5].HeaderText = "Fecha Nacimiento";
            //tbPacientes.Columns[6].HeaderText = "Género";
            //tbPacientes.Columns[7].HeaderText = "Fecha Ingreso";
            //tbPacientes.Columns[8].HeaderText = "Teléfono";
            //tbPacientes.Columns[9].HeaderText = "Dirección";
            //tbPacientes.Columns[10].HeaderText = "Motivo Consulta";
            //tbPacientes.Columns[11].HeaderText = "Antesc. Pat. Perso.";
            //tbPacientes.Columns[12].HeaderText = "Antesc. Pat. Famil";
            //tbPacientes.Columns[13].HeaderText = "Diagnóstico";
            //tbPacientes.Columns[14].HeaderText = "Tratamiento";

        }

        private void DtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            string fI = dtFechaIngreso.Value.ToString("yyyy/MM/dd");
            txtFechaNac.Text = fI.Replace('/', '-');
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            string fI= dtFechaIngreso.Value.ToString("yyyy/MM/dd");
            txtFechaIngresPac.Text = fI.Replace('/', '-');


        }

        private void TbPacientes_SelectionChanged(object sender, EventArgs e)
        {
            //if (tbPacientes.SelectedRows.Count>0)
            //{
            //    txtApellido1.Text = tbPacientes.CurrentRow.Cells["apellido1"].Value.ToString();
            //}
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles c = new Controles();
            c.soloNumeros(e);
            c.controlarNumeroCaracteres(e,txtCedula);
        }
    }
}
