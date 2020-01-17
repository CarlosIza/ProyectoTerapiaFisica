using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestionEntidades;
using GestionNegocio;
namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl= btnLogiar;
            lblMensajeErrorLogin.Visible = false;

        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void BtnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogiar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    LoginNegocio usuario = new LoginNegocio();
                    var validarLogin = usuario.loginUserNegocio(txtUsuario.Text, txtContraseña.Text);
                    string cargo = usuario.CargoLoginUsuarioNegocio(txtUsuario.Text, txtContraseña.Text);
                    //MessageBox.Show(cargo + 1);
                    string nombresApellidos;

                    if (validarLogin == true)
                    {
                      
                         

                        if ("ADMINISTRADOR".Equals(cargo))
                        {
                            Principal principal = new Principal();
                            principal.Show();
                            principal.FormClosed += cerrarSesion;
                            nombresApellidos = usuario.listaNombreApellidoNegocio(txtUsuario.Text);
                            principal.toolStripStatusLabel1.Text = "Bienvenido Usuario: " +nombresApellidos;
                            this.Hide();

                            //principal.button1.Enabled = true;


                        }
                        else if ("MEDICO".Equals(cargo))
                        {
                            Principal principal = new Principal();
                            principal.Show();
                            principal.FormClosed += cerrarSesion;
                            nombresApellidos = usuario.listaNombreApellidoNegocio(txtUsuario.Text);
                            principal.toolStripStatusLabel1.Text = "Bienvenido Usuario: " + nombresApellidos;
                            principal.btnUsuarios.Enabled = false;
                            principal.btnPacientes.Enabled = false;
                            principal.btnMedicos.Enabled = false;
                            principal.pictureBoxUsuarios.Enabled = false;
                            principal.pictureBoxMedicos.Enabled = false;
                            principal.pictureBoxPacientes.Enabled = false;


                            //principal.button1.Enabled = false;
                            this.Hide();
                        }

                       

                    }
                    else
                    {
                        mensajeLabel("Usuario o Contraseña Incorrectos! \n Porfavor intenta de nuevo...");
                        txtContraseña.Clear();
                        //txtContraseña.Text = "CONTRASEÑA";
                        txtUsuario.Focus();
                    }
                }
                else mensajeLabel("Porfavor ingrese su Contraseña...");
            }
            else mensajeLabel("Porfavor ingrese su Usuario...");
        }

        private void mensajeLabel(string msg)
        {
            lblMensajeErrorLogin.Text = msg;
            lblMensajeErrorLogin.Visible = true;
        }

        private void cerrarSesion(Object sender, FormClosedEventArgs e)
        {
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeErrorLogin.Visible = false;
            this.Show();
            //  txtUsuario.Focus();
        }
    }
}
