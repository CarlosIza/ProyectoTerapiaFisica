namespace Presentacion
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbInformacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.botonBuscarCedula = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(503, 86);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(801, 667);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(139, 279);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(186, 28);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.BackColor = System.Drawing.Color.White;
            this.comboBoxCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxCargo.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "MEDICO",
            "SECRETARIA"});
            this.comboBoxCargo.Location = new System.Drawing.Point(139, 351);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(186, 29);
            this.comboBoxCargo.TabIndex = 4;
            this.comboBoxCargo.Text = "Seleccione...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(30, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 45);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificar.Location = new System.Drawing.Point(175, 440);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 45);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.LbInformacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.botonBuscarCedula);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.comboBoxCargo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 765);
            this.panel1.TabIndex = 10;
            // 
            // LbInformacion
            // 
            this.LbInformacion.AutoSize = true;
            this.LbInformacion.BackColor = System.Drawing.Color.Transparent;
            this.LbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInformacion.ForeColor = System.Drawing.Color.Red;
            this.LbInformacion.Location = new System.Drawing.Point(59, 540);
            this.LbInformacion.Name = "LbInformacion";
            this.LbInformacion.Size = new System.Drawing.Size(0, 25);
            this.LbInformacion.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtNombre.Location = new System.Drawing.Point(139, 221);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 28);
            this.txtNombre.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtID.Location = new System.Drawing.Point(139, 101);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(130, 28);
            this.txtID.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "INTERFAZ USUARIOS";
            // 
            // botonBuscarCedula
            // 
            this.botonBuscarCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.botonBuscarCedula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.botonBuscarCedula.FlatAppearance.BorderSize = 0;
            this.botonBuscarCedula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.botonBuscarCedula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.botonBuscarCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscarCedula.ForeColor = System.Drawing.Color.Black;
            this.botonBuscarCedula.Location = new System.Drawing.Point(331, 152);
            this.botonBuscarCedula.Name = "botonBuscarCedula";
            this.botonBuscarCedula.Size = new System.Drawing.Size(117, 28);
            this.botonBuscarCedula.TabIndex = 9;
            this.botonBuscarCedula.Text = "BUSCAR";
            this.botonBuscarCedula.UseVisualStyleBackColor = false;
            this.botonBuscarCedula.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtCedula.Location = new System.Drawing.Point(139, 152);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(186, 28);
            this.txtCedula.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Location = new System.Drawing.Point(316, 440);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 45);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(1230, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrarP.FlatAppearance.BorderSize = 0;
            this.btnCerrarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarP.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarP.ForeColor = System.Drawing.Color.LightBlue;
            this.btnCerrarP.Location = new System.Drawing.Point(1268, 10);
            this.btnCerrarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(36, 28);
            this.btnCerrarP.TabIndex = 23;
            this.btnCerrarP.Text = "X";
            this.btnCerrarP.UseVisualStyleBackColor = false;
            this.btnCerrarP.Click += new System.EventHandler(this.BtnCerrarP_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(587, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(186, 28);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(515, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "Listado Usuarios";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1316, 765);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.Button botonBuscarCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbInformacion;
    }
}