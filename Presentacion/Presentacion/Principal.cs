using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            //Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void pictureBoxPacientes_Click(object sender, EventArgs e)
        {
            PacientesListado pacientes = new PacientesListado();
            pacientes.Show();
            this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            PacientesListado pacientes = new PacientesListado();
            pacientes.Show();
            this.Hide();
        }
    }
}
