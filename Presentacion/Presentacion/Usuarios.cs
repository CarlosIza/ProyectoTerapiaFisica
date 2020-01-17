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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            txtID.Visible = false;
            txtCedula.MaxLength = 10;
            txtNombre.MaxLength = 10;
            txtContraseña.MaxLength = 10;
        }

       

        private void Usuarios_Load(object sender, EventArgs e)
        {

            cargarListadoUsuarios();
        }


     
   
        private void cargarListadoUsuarios()
        {
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = UsuariosNegocio.DevolverListadousuariossNegocio();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            //if (txtContraseña.Text == "")
            //{
            //    txtContraseña.Text = "Ingrese Contraseña";
            //    txtContraseña.ForeColor = Color.DimGray;
            //    txtContraseña.UseSystemPasswordChar = false;
            //}
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {

            //if (txtContraseña.Text == "Ingrese Contraseña")
            //{
            //    txtContraseña.Text = "";
            //    txtContraseña.ForeColor = Color.DimGray;
            //    txtContraseña.UseSystemPasswordChar = true;
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarUsuarios();
            cargarListadoUsuarios();
        }

        private void guardarUsuarios()
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                LbInformacion.Text = "Seleccione la Cédula...";
                botonBuscarCedula.Focus();
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                LbInformacion.Text = "Ingrese el Nombre...";
                txtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                LbInformacion.Text = "Ingrese la Contraseña...";
            }
            else if (comboBoxCargo.Text.Equals("Seleccione..."))
            {
                LbInformacion.Text = "Seleccione el Cargo";
                comboBoxCargo.Focus();
            }
            else 
            {
                GestionEntidades.Usuarios usuarios = new GestionEntidades.Usuarios();
                usuarios.Nombre = txtNombre.Text;
                usuarios.Cargo = comboBoxCargo.Text;
                usuarios.Cedula = txtCedula.Text;
                usuarios.Contraseña = txtContraseña.Text;
                //usuarios.Estado = 1;
                usuarios = UsuariosNegocio.GuardarusuariosDatos(usuarios);
                LbInformacion.Text = "";
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarCedula();
        }

        private void agregarCedula()
        {
            Form_Cedulas formularioCedulas = new Form_Cedulas();
            formularioCedulas.ShowDialog();
            if (formularioCedulas.cedulaSeleccionado != null)
            {
                txtCedula.Text = formularioCedulas.cedulaSeleccionado.cedula;
                txtNombre.Text = formularioCedulas.cedulaSeleccionado.nombre;
            }
            
        }

      
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.DimGray;

            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
        ///// Esta función "desencripta" la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted =
            Convert.FromBase64String(_cadenaAdesencriptar);
            //result = 
            System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtCedula.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
            txtNombre.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            var contraseña = dataGridViewUsuarios.Rows[e.RowIndex].Cells["contraseña"].Value.ToString();
            txtContraseña.Text = DesEncriptar(contraseña);
            comboBoxCargo.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
            SetearTextos();
            cargarListadoUsuarios();
        }
        private void SetearTextos()
        {
            txtCedula.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            comboBoxCargo.Text = "Seleccione...";

        }

        private void ModificarUsuario()
        {
            GestionEntidades.Usuarios usuarios = new GestionEntidades.Usuarios();
            usuarios.Id = Convert.ToInt32(txtID.Text);
            usuarios.Nombre = txtNombre.Text;
            usuarios.Cargo = comboBoxCargo.Text;
            usuarios.Cedula = txtCedula.Text;
            usuarios.Contraseña = txtContraseña.Text;
            usuarios = UsuariosNegocio.ActualizarUsuarioNegocio(usuarios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
            SetearTextos();
            cargarListadoUsuarios();
        }

        private void EliminarUsuario()
        {
            GestionEntidades.Usuarios usuarios = new GestionEntidades.Usuarios();
            usuarios.Id = Convert.ToInt32(txtID.Text);
            usuarios = UsuariosNegocio.EliminarUsuarioNegocio(usuarios);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridViewUsuarios.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridViewUsuarios.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dataGridViewUsuarios.Rows)
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
                cargarListadoUsuarios();

            }
        }
    }
}
