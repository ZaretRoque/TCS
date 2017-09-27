namespace CincoEnLinea
{
    partial class InicioSesion
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
            this.linkLabelIdiomaEspañol = new System.Windows.Forms.LinkLabel();
            this.linkLabelIdiomaIngles = new System.Windows.Forms.LinkLabel();
            this.PanelRegistrarteIS = new System.Windows.Forms.Panel();
            this.linkLabelRegistrate = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTablero = new System.Windows.Forms.Button();
            this.buttonReglas = new System.Windows.Forms.Button();
            this.buttonJugadores = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.PanelRegistrarteIS.SuspendLayout();
            this.groupBoxInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelIdiomaEspañol
            // 
            this.linkLabelIdiomaEspañol.AutoSize = true;
            this.linkLabelIdiomaEspañol.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelIdiomaEspañol.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabelIdiomaEspañol.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelIdiomaEspañol.Location = new System.Drawing.Point(365, 30);
            this.linkLabelIdiomaEspañol.Name = "linkLabelIdiomaEspañol";
            this.linkLabelIdiomaEspañol.Size = new System.Drawing.Size(59, 17);
            this.linkLabelIdiomaEspañol.TabIndex = 4;
            this.linkLabelIdiomaEspañol.TabStop = true;
            this.linkLabelIdiomaEspañol.Text = "Español";
            this.linkLabelIdiomaEspañol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cambiarIdiomaEspanol);
            // 
            // linkLabelIdiomaIngles
            // 
            this.linkLabelIdiomaIngles.AutoSize = true;
            this.linkLabelIdiomaIngles.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelIdiomaIngles.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelIdiomaIngles.Location = new System.Drawing.Point(436, 30);
            this.linkLabelIdiomaIngles.Name = "linkLabelIdiomaIngles";
            this.linkLabelIdiomaIngles.Size = new System.Drawing.Size(54, 17);
            this.linkLabelIdiomaIngles.TabIndex = 5;
            this.linkLabelIdiomaIngles.TabStop = true;
            this.linkLabelIdiomaIngles.Text = "English";
            this.linkLabelIdiomaIngles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cambiarIdiomaIngles);
            // 
            // PanelRegistrarteIS
            // 
            this.PanelRegistrarteIS.BackColor = System.Drawing.Color.Transparent;
            this.PanelRegistrarteIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelRegistrarteIS.Controls.Add(this.linkLabelRegistrate);
            this.PanelRegistrarteIS.Controls.Add(this.label1);
            this.PanelRegistrarteIS.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelRegistrarteIS.Location = new System.Drawing.Point(76, 337);
            this.PanelRegistrarteIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRegistrarteIS.Name = "PanelRegistrarteIS";
            this.PanelRegistrarteIS.Size = new System.Drawing.Size(330, 73);
            this.PanelRegistrarteIS.TabIndex = 6;
            this.PanelRegistrarteIS.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegistrarteIS_Paint);
            // 
            // linkLabelRegistrate
            // 
            this.linkLabelRegistrate.AutoSize = true;
            this.linkLabelRegistrate.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelRegistrate.Location = new System.Drawing.Point(209, 30);
            this.linkLabelRegistrate.Name = "linkLabelRegistrate";
            this.linkLabelRegistrate.Size = new System.Drawing.Size(73, 17);
            this.linkLabelRegistrate.TabIndex = 1;
            this.linkLabelRegistrate.TabStop = true;
            this.linkLabelRegistrate.Text = "Regístrate";
            this.linkLabelRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clicRegistrate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿No tienes cuenta?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonTablero
            // 
            this.buttonTablero.Location = new System.Drawing.Point(420, 160);
            this.buttonTablero.Name = "buttonTablero";
            this.buttonTablero.Size = new System.Drawing.Size(85, 32);
            this.buttonTablero.TabIndex = 7;
            this.buttonTablero.Text = "Tablero";
            this.buttonTablero.UseVisualStyleBackColor = true;
            this.buttonTablero.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReglas
            // 
            this.buttonReglas.Location = new System.Drawing.Point(420, 97);
            this.buttonReglas.Name = "buttonReglas";
            this.buttonReglas.Size = new System.Drawing.Size(85, 32);
            this.buttonReglas.TabIndex = 8;
            this.buttonReglas.Text = "Reglas";
            this.buttonReglas.UseVisualStyleBackColor = true;
            this.buttonReglas.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonJugadores
            // 
            this.buttonJugadores.Location = new System.Drawing.Point(420, 215);
            this.buttonJugadores.Name = "buttonJugadores";
            this.buttonJugadores.Size = new System.Drawing.Size(85, 33);
            this.buttonJugadores.TabIndex = 9;
            this.buttonJugadores.Text = "Jugadores";
            this.buttonJugadores.UseVisualStyleBackColor = true;
            this.buttonJugadores.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUsuario.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(57, 48);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(226, 35);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "Usuario";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(59, 109);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContraseña.Multiline = true;
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(225, 34);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEntrar.FlatAppearance.BorderSize = 2;
            this.buttonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(57, 188);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(227, 34);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInicioSesion.Controls.Add(this.buttonEntrar);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxContraseña);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxUsuario);
            this.groupBoxInicioSesion.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(76, 63);
            this.groupBoxInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(330, 270);
            this.groupBoxInicioSesion.TabIndex = 3;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Iniciar sesion";
            this.groupBoxInicioSesion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::CincoEnLinea.Properties.Resources.FondoInicioSesion;
            this.ClientSize = new System.Drawing.Size(517, 482);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.Controls.Add(this.buttonJugadores);
            this.Controls.Add(this.buttonReglas);
            this.Controls.Add(this.buttonTablero);
            this.Controls.Add(this.PanelRegistrarteIS);
            this.Controls.Add(this.linkLabelIdiomaIngles);
            this.Controls.Add(this.linkLabelIdiomaEspañol);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinco en Línea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelRegistrarteIS.ResumeLayout(false);
            this.PanelRegistrarteIS.PerformLayout();
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelIdiomaEspañol;
        private System.Windows.Forms.LinkLabel linkLabelIdiomaIngles;
        private System.Windows.Forms.Panel PanelRegistrarteIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrate;
        private System.Windows.Forms.Button buttonTablero;
        private System.Windows.Forms.Button buttonReglas;
        private System.Windows.Forms.Button buttonJugadores;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.GroupBox groupBoxInicioSesion;
    }
}

