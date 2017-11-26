namespace CincoEnLinea.GUI {
    partial class IniciarSesion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelDatosIniciaSesion = new System.Windows.Forms.Panel();
            this.uvImagen = new System.Windows.Forms.PictureBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelDesarrolladores = new System.Windows.Forms.Label();
            this.labelCincoEnLinea = new System.Windows.Forms.Label();
            this.linkLabelEspañol = new System.Windows.Forms.LinkLabel();
            this.linkLabelEnglish = new System.Windows.Forms.LinkLabel();
            this.labelDivisorIdiomas = new System.Windows.Forms.Label();
            this.labelIniciaSesion = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelNoTienesCuenta = new System.Windows.Forms.Label();
            this.linkLabelRegistrate = new System.Windows.Forms.LinkLabel();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.panelDatosIniciaSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uvImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatosIniciaSesion
            // 
            this.panelDatosIniciaSesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelDatosIniciaSesion.Controls.Add(this.uvImagen);
            this.panelDatosIniciaSesion.Controls.Add(this.labelNombres);
            this.panelDatosIniciaSesion.Controls.Add(this.labelDesarrolladores);
            this.panelDatosIniciaSesion.Location = new System.Drawing.Point(2, 344);
            this.panelDatosIniciaSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDatosIniciaSesion.Name = "panelDatosIniciaSesion";
            this.panelDatosIniciaSesion.Size = new System.Drawing.Size(476, 110);
            this.panelDatosIniciaSesion.TabIndex = 0;
            // 
            // uvImagen
            // 
            this.uvImagen.BackColor = System.Drawing.Color.White;
            this.uvImagen.Image = global::CincoEnLinea.Properties.Resources.Logo_UV;
            this.uvImagen.Location = new System.Drawing.Point(0, 0);
            this.uvImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uvImagen.Name = "uvImagen";
            this.uvImagen.Size = new System.Drawing.Size(118, 110);
            this.uvImagen.TabIndex = 0;
            this.uvImagen.TabStop = false;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelNombres.Location = new System.Drawing.Point(178, 36);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(183, 51);
            this.labelNombres.TabIndex = 2;
            this.labelNombres.Text = "Luis David Galicia Garcia\r\n\r\nZaret Sahar Jahzeel Roque";
            // 
            // labelDesarrolladores
            // 
            this.labelDesarrolladores.AutoSize = true;
            this.labelDesarrolladores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.labelDesarrolladores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelDesarrolladores.Location = new System.Drawing.Point(137, 7);
            this.labelDesarrolladores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesarrolladores.Name = "labelDesarrolladores";
            this.labelDesarrolladores.Size = new System.Drawing.Size(114, 19);
            this.labelDesarrolladores.TabIndex = 1;
            this.labelDesarrolladores.Text = "Desarrolladores:";
            // 
            // labelCincoEnLinea
            // 
            this.labelCincoEnLinea.AutoSize = true;
            this.labelCincoEnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelCincoEnLinea.Location = new System.Drawing.Point(9, 7);
            this.labelCincoEnLinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCincoEnLinea.Name = "labelCincoEnLinea";
            this.labelCincoEnLinea.Size = new System.Drawing.Size(117, 18);
            this.labelCincoEnLinea.TabIndex = 1;
            this.labelCincoEnLinea.Text = "5inco en Linea";
            // 
            // linkLabelEspañol
            // 
            this.linkLabelEspañol.AutoSize = true;
            this.linkLabelEspañol.Location = new System.Drawing.Point(325, 10);
            this.linkLabelEspañol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelEspañol.Name = "linkLabelEspañol";
            this.linkLabelEspañol.Size = new System.Drawing.Size(45, 13);
            this.linkLabelEspañol.TabIndex = 2;
            this.linkLabelEspañol.TabStop = true;
            this.linkLabelEspañol.Text = "Español";
            this.linkLabelEspañol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEspañol_LinkClicked);
            // 
            // linkLabelEnglish
            // 
            this.linkLabelEnglish.AutoSize = true;
            this.linkLabelEnglish.Location = new System.Drawing.Point(394, 10);
            this.linkLabelEnglish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelEnglish.Name = "linkLabelEnglish";
            this.linkLabelEnglish.Size = new System.Drawing.Size(41, 13);
            this.linkLabelEnglish.TabIndex = 3;
            this.linkLabelEnglish.TabStop = true;
            this.linkLabelEnglish.Text = "English";
            this.linkLabelEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEnglish_LinkClicked);
            // 
            // labelDivisorIdiomas
            // 
            this.labelDivisorIdiomas.AutoSize = true;
            this.labelDivisorIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDivisorIdiomas.Location = new System.Drawing.Point(374, 7);
            this.labelDivisorIdiomas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDivisorIdiomas.Name = "labelDivisorIdiomas";
            this.labelDivisorIdiomas.Size = new System.Drawing.Size(19, 29);
            this.labelDivisorIdiomas.TabIndex = 4;
            this.labelDivisorIdiomas.Text = "|";
            // 
            // labelIniciaSesion
            // 
            this.labelIniciaSesion.AutoSize = true;
            this.labelIniciaSesion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelIniciaSesion.Location = new System.Drawing.Point(67, 51);
            this.labelIniciaSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIniciaSesion.Name = "labelIniciaSesion";
            this.labelIniciaSesion.Size = new System.Drawing.Size(164, 28);
            this.labelIniciaSesion.TabIndex = 5;
            this.labelIniciaSesion.Text = "Iniciar Sesión";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelUsuario.Location = new System.Drawing.Point(92, 106);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(75, 22);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(95, 145);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreUsuario.MaxLength = 45;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(219, 20);
            this.textBoxNombreUsuario.TabIndex = 7;
            this.textBoxNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarEntrada);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.Location = new System.Drawing.Point(92, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(95, 212);
            this.textBoxContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(219, 20);
            this.textBoxContrasena.TabIndex = 9;
            // 
            // labelNoTienesCuenta
            // 
            this.labelNoTienesCuenta.AutoSize = true;
            this.labelNoTienesCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNoTienesCuenta.Location = new System.Drawing.Point(93, 313);
            this.labelNoTienesCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoTienesCuenta.Name = "labelNoTienesCuenta";
            this.labelNoTienesCuenta.Size = new System.Drawing.Size(113, 15);
            this.labelNoTienesCuenta.TabIndex = 10;
            this.labelNoTienesCuenta.Text = "¿No tienes cuenta?";
            // 
            // linkLabelRegistrate
            // 
            this.linkLabelRegistrate.AutoSize = true;
            this.linkLabelRegistrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabelRegistrate.Location = new System.Drawing.Point(250, 313);
            this.linkLabelRegistrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRegistrate.Name = "linkLabelRegistrate";
            this.linkLabelRegistrate.Size = new System.Drawing.Size(63, 15);
            this.linkLabelRegistrate.TabIndex = 11;
            this.linkLabelRegistrate.TabStop = true;
            this.linkLabelRegistrate.Text = "Regístrate";
            this.linkLabelRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClicLabelRegistrate);
            this.linkLabelRegistrate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClicRegistrate);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.LightGray;
            this.buttonEntrar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.buttonEntrar.Location = new System.Drawing.Point(95, 255);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(218, 32);
            this.buttonEntrar.TabIndex = 12;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.ClicEntrar);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 453);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.linkLabelRegistrate);
            this.Controls.Add(this.labelNoTienesCuenta);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelIniciaSesion);
            this.Controls.Add(this.labelDivisorIdiomas);
            this.Controls.Add(this.linkLabelEnglish);
            this.Controls.Add(this.linkLabelEspañol);
            this.Controls.Add(this.labelCincoEnLinea);
            this.Controls.Add(this.panelDatosIniciaSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.panelDatosIniciaSesion.ResumeLayout(false);
            this.panelDatosIniciaSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uvImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosIniciaSesion;
        private System.Windows.Forms.PictureBox uvImagen;
        private System.Windows.Forms.Label labelCincoEnLinea;
        private System.Windows.Forms.LinkLabel linkLabelEspañol;
        private System.Windows.Forms.LinkLabel linkLabelEnglish;
        private System.Windows.Forms.Label labelDivisorIdiomas;
        private System.Windows.Forms.Label labelIniciaSesion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelNoTienesCuenta;
        private System.Windows.Forms.LinkLabel linkLabelRegistrate;
        private System.Windows.Forms.Label labelDesarrolladores;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Button buttonEntrar;
    }
}