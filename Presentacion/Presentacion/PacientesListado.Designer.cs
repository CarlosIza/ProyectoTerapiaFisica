namespace Presentacion
{
    partial class PacientesListado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPacientes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1586, 84);
            this.panel1.TabIndex = 32;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.LightBlue;
            this.btnCerrar.Location = new System.Drawing.Point(1362, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 28);
            this.btnCerrar.TabIndex = 36;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 35;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1320, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 28);
            this.btnMinimizar.TabIndex = 37;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(601, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Listado Pacientes";
            // 
            // tbPacientes
            // 
            this.tbPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPacientes.Location = new System.Drawing.Point(12, 162);
            this.tbPacientes.Name = "tbPacientes";
            this.tbPacientes.RowHeadersWidth = 51;
            this.tbPacientes.RowTemplate.Height = 24;
            this.tbPacientes.Size = new System.Drawing.Size(1399, 518);
            this.tbPacientes.TabIndex = 33;
            this.tbPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbPacientes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificar.Location = new System.Drawing.Point(180, 700);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 49);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Location = new System.Drawing.Point(343, 700);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 49);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(84, 104);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(186, 28);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Buscar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.btnNuevo.Location = new System.Drawing.Point(17, 700);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 49);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PacientesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1423, 776);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbPacientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PacientesListado";
            this.Text = "PacientesListado";
            this.Load += new System.EventHandler(this.PacientesListado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tbPacientes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
    }
}