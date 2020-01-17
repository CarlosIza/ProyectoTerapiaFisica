namespace Presentacion
{
    partial class Form_Cedulas
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtoApellido = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonCedula = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(1214, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 28);
            this.button3.TabIndex = 26;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.btnCerrarP.Location = new System.Drawing.Point(1253, 23);
            this.btnCerrarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(36, 28);
            this.btnCerrarP.TabIndex = 25;
            this.btnCerrarP.Text = "X";
            this.btnCerrarP.UseVisualStyleBackColor = false;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(480, 21);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(218, 28);
            this.txtBuscar.TabIndex = 29;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 693);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.radioButtoApellido);
            this.panel1.Controls.Add(this.radioButtonNombre);
            this.panel1.Controls.Add(this.radioButtonCedula);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 790);
            this.panel1.TabIndex = 30;
            // 
            // radioButtoApellido
            // 
            this.radioButtoApellido.AutoSize = true;
            this.radioButtoApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.radioButtoApellido.ForeColor = System.Drawing.Color.White;
            this.radioButtoApellido.Location = new System.Drawing.Point(32, 355);
            this.radioButtoApellido.Name = "radioButtoApellido";
            this.radioButtoApellido.Size = new System.Drawing.Size(99, 25);
            this.radioButtoApellido.TabIndex = 33;
            this.radioButtoApellido.TabStop = true;
            this.radioButtoApellido.Text = "Apellido";
            this.radioButtoApellido.UseVisualStyleBackColor = true;
            this.radioButtoApellido.CheckedChanged += new System.EventHandler(this.radioButtoApellido_CheckedChanged);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.radioButtonNombre.ForeColor = System.Drawing.Color.White;
            this.radioButtonNombre.Location = new System.Drawing.Point(32, 248);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(98, 25);
            this.radioButtonNombre.TabIndex = 32;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.CheckedChanged += new System.EventHandler(this.radioButtonNombre_CheckedChanged);
            // 
            // radioButtonCedula
            // 
            this.radioButtonCedula.AutoSize = true;
            this.radioButtonCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.radioButtonCedula.ForeColor = System.Drawing.Color.White;
            this.radioButtonCedula.Location = new System.Drawing.Point(32, 129);
            this.radioButtonCedula.Name = "radioButtonCedula";
            this.radioButtonCedula.Size = new System.Drawing.Size(93, 25);
            this.radioButtonCedula.TabIndex = 31;
            this.radioButtonCedula.TabStop = true;
            this.radioButtonCedula.Text = "Cédula";
            this.radioButtonCedula.UseVisualStyleBackColor = true;
            this.radioButtonCedula.CheckedChanged += new System.EventHandler(this.radioButtonCedula_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(113, 459);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 36);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtApellido.Location = new System.Drawing.Point(71, 395);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(181, 28);
            this.txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtNombre.Location = new System.Drawing.Point(71, 288);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(181, 28);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtCedula.Location = new System.Drawing.Point(71, 169);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(181, 28);
            this.txtCedula.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "FILTRAR DATOS POR:";
            // 
            // Form_Cedulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1301, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCerrarP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Cedulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpleadosCedulas";
            this.Load += new System.EventHandler(this.EmpleadosCedulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioButtonCedula;
        private System.Windows.Forms.RadioButton radioButtoApellido;
        private System.Windows.Forms.RadioButton radioButtonNombre;
    }
}