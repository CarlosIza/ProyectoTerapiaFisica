using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionEntidades;
using GestionNegocio;

namespace Presentacion
{
    public partial class Form_Medidos : Form
    {
        public Form_Medidos()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLogiar_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(textBox_Correo.Text))
            {
                GuardarEmpleado();
                CargarTablaEmpleados();
                SetearTextos();
            }
            else
            {
                MessageBox.Show("Correo invalido...","Mensaje");
            }
                     
           
        }

        private void GuardarEmpleado()
        {
            Empleado medico = new Empleado();
            medico.Id = 0;
            medico.Cedula = textBox_Cedula.Text;
            medico.Apellido1 = textBox_ApellidoP.Text;
            medico.Apellido2 = textBox_ApellidoM.Text;
            medico.Nombre1 = textBox_NombreP.Text;
            medico.Nombre2 = textBox_NombreM.Text;
            medico.Telefono = textBox_Telefono.Text;
            medico.Direccion = textBox_Direccion.Text;
            medico.Especialidad = comboBox_Especialidad.SelectedItem.ToString();
            medico.Email = textBox_Correo.Text;
            medico = EmpleadoNegocio.GuardarEmpleadoNegocio(medico);
        }

        private void SetearTextos()
        {

            textBox_Cedula.Text = "";
            textBox_ApellidoP.Text = "";
            textBox_ApellidoM.Text = "";
            textBox_NombreP.Text = "";
            textBox_NombreM.Text = "";
            textBox_Telefono.Text = "";
            textBox_Direccion.Text = "";
            comboBox_Especialidad.Text = "";
            textBox_Correo.Text = "";

        }

        private void txtCedula_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Cedula.Text == "Ingrese Cédula")
            {
                textBox_Cedula.Text = "";
                textBox_Cedula.ForeColor = Color.DimGray;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (textBox_Cedula.Text == "")
            {
                textBox_Cedula.Text = "Ingrese Cédula";
                textBox_Cedula.ForeColor = Color.DimGray;
            }
        }

        private void Medicos_Load(object sender, EventArgs e)
        {

            CargarTablaEmpleados();

        }

        private void CargarTablaEmpleados()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = EmpleadoNegocio.DevolverListadoEmpleadosNegocio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarEmpleado();         
            SetearTextos();
            CargarTablaEmpleados();
        }

        private void ModificarEmpleado()
        {
            Empleado medico = new Empleado();
            medico.Cedula = textBox_Cedula.Text;
            medico.Apellido1 = textBox_ApellidoP.Text;
            medico.Apellido2 = textBox_ApellidoM.Text;
            medico.Nombre1 = textBox_NombreP.Text;
            medico.Nombre2 = textBox_NombreM.Text;
            medico.Telefono = textBox_Telefono.Text;
            medico.Direccion = textBox_Direccion.Text;
            medico.Especialidad = comboBox_Especialidad.SelectedItem.ToString();
            medico.Email = textBox_Correo.Text;
            medico = EmpleadoNegocio.ActualizarEmpleadoNegocio(medico);
        }

        private void RecuperarDatos(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Cedula.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
            textBox_ApellidoP.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido1"].Value.ToString();
            textBox_ApellidoM.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido2"].Value.ToString();
            textBox_NombreP.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre1"].Value.ToString();
            textBox_NombreM.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre2"].Value.ToString();
            textBox_Telefono.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            textBox_Direccion.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            comboBox_Especialidad.SelectedItem = dataGridViewClientes.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
            textBox_Correo.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarEmpleado(textBox_Cedula.Text);

        }

        private void EliminarEmpleado(string cedula)
        {
            if (MessageBox.Show("Desea Eliminar","Mensaje de Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                EmpleadoNegocio.EliminarEmpleado(cedula);
            }
            else
            {
                Console.WriteLine("No se va a eliminar");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
