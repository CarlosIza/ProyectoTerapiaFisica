namespace Presentacion
{
    partial class HistoriaClínica
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoSangre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 84);
            this.panel1.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(541, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Historia Clínico";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedula.Location = new System.Drawing.Point(164, 110);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(143, 28);
            this.txtCedula.TabIndex = 32;
            this.txtCedula.Text = "Ingrese Cédula";
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombres:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido1.Location = new System.Drawing.Point(164, 159);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(262, 28);
            this.txtApellido1.TabIndex = 34;
            this.txtApellido1.Text = "Apellido Pat.";
            this.txtApellido1.WordWrap = false;
            // 
            // txtNombre1
            // 
            this.txtNombre1.BackColor = System.Drawing.Color.White;
            this.txtNombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre1.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre1.Location = new System.Drawing.Point(164, 199);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(262, 28);
            this.txtNombre1.TabIndex = 35;
            this.txtNombre1.Text = "Primer Nomb..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tipo Sangre:";
            // 
            // cbTipoSangre
            // 
            this.cbTipoSangre.FormattingEnabled = true;
            this.cbTipoSangre.Items.AddRange(new object[] {
            "O positivo",
            "O negativo",
            "A negativo",
            "A positivo",
            "B negativo",
            "B positivo",
            "AB negativo",
            "AB positivo"});
            this.cbTipoSangre.Location = new System.Drawing.Point(164, 243);
            this.cbTipoSangre.Name = "cbTipoSangre";
            this.cbTipoSangre.Size = new System.Drawing.Size(143, 24);
            this.cbTipoSangre.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(517, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Antscedentes Patológicos Personales";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(521, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 160);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(521, 414);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(762, 174);
            this.listView2.TabIndex = 43;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(517, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Antscedentes Patológicos Personales";
            // 
            // HistoriaClínica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1362, 772);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoSangre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.panel1);
            this.Name = "HistoriaClínica";
            this.Text = "HistoriaClínica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoSangre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label8;
    }
}