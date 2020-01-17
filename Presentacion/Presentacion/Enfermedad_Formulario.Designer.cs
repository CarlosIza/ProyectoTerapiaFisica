namespace Presentacion
{
    partial class Enfermedad_Formulario
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnfermedades = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnfermedades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 84);
            this.panel1.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "TABLA ENFERMEDADES";
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
            this.btnCerrar.Location = new System.Drawing.Point(1145, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 28);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1103, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 28);
            this.btnMinimizar.TabIndex = 18;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(105, 113);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(186, 28);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Buscar";
            // 
            // tbEnfermedades
            // 
            this.tbEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEnfermedades.Location = new System.Drawing.Point(16, 178);
            this.tbEnfermedades.Name = "tbEnfermedades";
            this.tbEnfermedades.RowHeadersWidth = 51;
            this.tbEnfermedades.RowTemplate.Height = 24;
            this.tbEnfermedades.Size = new System.Drawing.Size(1166, 518);
            this.tbEnfermedades.TabIndex = 40;
            // 
            // Enfermedad_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1194, 726);
            this.Controls.Add(this.tbEnfermedades);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enfermedad_Formulario";
            this.Text = "Enfermedad";
            this.Load += new System.EventHandler(this.Enfermedad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnfermedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbEnfermedades;
    }
}