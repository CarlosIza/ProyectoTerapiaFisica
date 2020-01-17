namespace Presentacion
{
    partial class Login
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogiar = new System.Windows.Forms.Button();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensajeErrorLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.índice;
            this.pictureBox3.Location = new System.Drawing.Point(31, 89);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 311;
            this.lineShape2.X2 = 718;
            this.lineShape2.Y1 = 190;
            this.lineShape2.Y2 = 190;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 307;
            this.lineShape1.X2 = 714;
            this.lineShape1.Y1 = 120;
            this.lineShape1.Y2 = 120;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(308, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(407, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(308, 157);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(407, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // btnLogiar
            // 
            this.btnLogiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLogiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLogiar.FlatAppearance.BorderSize = 0;
            this.btnLogiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLogiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogiar.Location = new System.Drawing.Point(311, 240);
            this.btnLogiar.Name = "btnLogiar";
            this.btnLogiar.Size = new System.Drawing.Size(408, 40);
            this.btnLogiar.TabIndex = 3;
            this.btnLogiar.Text = "ACCEDER";
            this.btnLogiar.UseVisualStyleBackColor = false;
            this.btnLogiar.Click += new System.EventHandler(this.BtnLogiar_Click);
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkPass.Location = new System.Drawing.Point(429, 291);
            this.linkPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(185, 17);
            this.linkPass.TabIndex = 0;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "¿Has olvidado la contraseña?";
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
            this.btnCerrarP.Location = new System.Drawing.Point(742, 2);
            this.btnCerrarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(27, 23);
            this.btnCerrarP.TabIndex = 15;
            this.btnCerrarP.Text = "X";
            this.btnCerrarP.UseVisualStyleBackColor = false;
            this.btnCerrarP.Click += new System.EventHandler(this.BtnCerrarP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(713, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblMensajeErrorLogin
            // 
            this.lblMensajeErrorLogin.AutoSize = true;
            this.lblMensajeErrorLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeErrorLogin.Location = new System.Drawing.Point(308, 202);
            this.lblMensajeErrorLogin.Name = "lblMensajeErrorLogin";
            this.lblMensajeErrorLogin.Size = new System.Drawing.Size(272, 16);
            this.lblMensajeErrorLogin.TabIndex = 17;
            this.lblMensajeErrorLogin.Text = "USUARIO O CONTRASEÑA INCORRECTOS!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblMensajeErrorLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.btnLogiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogiar;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensajeErrorLogin;
    }
}