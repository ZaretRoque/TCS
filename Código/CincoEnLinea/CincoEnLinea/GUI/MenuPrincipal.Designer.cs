namespace CincoEnLinea.GUI
{
    partial class MenuPrincipal
    {
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
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntrarSala = new System.Windows.Forms.Label();
            this.labelMejoresJugadores = new System.Windows.Forms.Label();
            this.labelVerReglas = new System.Windows.Forms.Label();
            this.labelCerrarSesion = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBoxEntrarSalaIzq = new System.Windows.Forms.PictureBox();
            this.pictureBoxEntrarSalaDer = new System.Windows.Forms.PictureBox();
            this.pictureBoxMejoresJugadoresIzq = new System.Windows.Forms.PictureBox();
            this.pictureBoxMejoresJugadoresDer = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerReglasIzq = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerReglasDer = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarSesionIzq = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarSesionDer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrarSalaIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrarSalaDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMejoresJugadoresIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMejoresJugadoresDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerReglasIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerReglasDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSesionIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSesionDer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 161);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moon", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "5inco en linea";
            // 
            // labelEntrarSala
            // 
            this.labelEntrarSala.AutoSize = true;
            this.labelEntrarSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEntrarSala.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrarSala.Location = new System.Drawing.Point(316, 297);
            this.labelEntrarSala.Name = "labelEntrarSala";
            this.labelEntrarSala.Size = new System.Drawing.Size(157, 30);
            this.labelEntrarSala.TabIndex = 1;
            this.labelEntrarSala.Text = "Entrar a sala";
            this.labelEntrarSala.Click += new System.EventHandler(this.ClicEntrarSala);
            this.labelEntrarSala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseSobreEntrarSala);
            // 
            // labelMejoresJugadores
            // 
            this.labelMejoresJugadores.AutoSize = true;
            this.labelMejoresJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMejoresJugadores.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMejoresJugadores.Location = new System.Drawing.Point(262, 389);
            this.labelMejoresJugadores.Name = "labelMejoresJugadores";
            this.labelMejoresJugadores.Size = new System.Drawing.Size(278, 30);
            this.labelMejoresJugadores.TabIndex = 2;
            this.labelMejoresJugadores.Text = "Ver mejores jugadores";
            this.labelMejoresJugadores.Click += new System.EventHandler(this.MouseClicMejoresJugadores);
            this.labelMejoresJugadores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseSobreMejoresJugadores);
            // 
            // labelVerReglas
            // 
            this.labelVerReglas.AutoSize = true;
            this.labelVerReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerReglas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerReglas.Location = new System.Drawing.Point(330, 473);
            this.labelVerReglas.Name = "labelVerReglas";
            this.labelVerReglas.Size = new System.Drawing.Size(131, 30);
            this.labelVerReglas.TabIndex = 3;
            this.labelVerReglas.Text = "Ver reglas";
            this.labelVerReglas.Click += new System.EventHandler(this.MouseClicSobreVerReglas);
            this.labelVerReglas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseSobreVerReglas);
            // 
            // labelCerrarSesion
            // 
            this.labelCerrarSesion.AutoSize = true;
            this.labelCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrarSesion.Location = new System.Drawing.Point(316, 561);
            this.labelCerrarSesion.Name = "labelCerrarSesion";
            this.labelCerrarSesion.Size = new System.Drawing.Size(166, 30);
            this.labelCerrarSesion.TabIndex = 4;
            this.labelCerrarSesion.Text = "Cerrar sesión";
            this.labelCerrarSesion.Click += new System.EventHandler(this.ClicSalir);
            this.labelCerrarSesion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseSobreCerrarSesion);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Moon", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(12, 204);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(251, 29);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "Menu principal";
            // 
            // pictureBoxEntrarSalaIzq
            // 
            this.pictureBoxEntrarSalaIzq.BackColor = System.Drawing.Color.Black;
            this.pictureBoxEntrarSalaIzq.Location = new System.Drawing.Point(270, 297);
            this.pictureBoxEntrarSalaIzq.Name = "pictureBoxEntrarSalaIzq";
            this.pictureBoxEntrarSalaIzq.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxEntrarSalaIzq.TabIndex = 6;
            this.pictureBoxEntrarSalaIzq.TabStop = false;
            this.pictureBoxEntrarSalaIzq.Visible = false;
            // 
            // pictureBoxEntrarSalaDer
            // 
            this.pictureBoxEntrarSalaDer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxEntrarSalaDer.Location = new System.Drawing.Point(479, 297);
            this.pictureBoxEntrarSalaDer.Name = "pictureBoxEntrarSalaDer";
            this.pictureBoxEntrarSalaDer.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxEntrarSalaDer.TabIndex = 7;
            this.pictureBoxEntrarSalaDer.TabStop = false;
            this.pictureBoxEntrarSalaDer.Visible = false;
            // 
            // pictureBoxMejoresJugadoresIzq
            // 
            this.pictureBoxMejoresJugadoresIzq.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMejoresJugadoresIzq.Location = new System.Drawing.Point(216, 384);
            this.pictureBoxMejoresJugadoresIzq.Name = "pictureBoxMejoresJugadoresIzq";
            this.pictureBoxMejoresJugadoresIzq.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxMejoresJugadoresIzq.TabIndex = 8;
            this.pictureBoxMejoresJugadoresIzq.TabStop = false;
            // 
            // pictureBoxMejoresJugadoresDer
            // 
            this.pictureBoxMejoresJugadoresDer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMejoresJugadoresDer.Location = new System.Drawing.Point(546, 389);
            this.pictureBoxMejoresJugadoresDer.Name = "pictureBoxMejoresJugadoresDer";
            this.pictureBoxMejoresJugadoresDer.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxMejoresJugadoresDer.TabIndex = 9;
            this.pictureBoxMejoresJugadoresDer.TabStop = false;
            // 
            // pictureBoxVerReglasIzq
            // 
            this.pictureBoxVerReglasIzq.BackColor = System.Drawing.Color.Black;
            this.pictureBoxVerReglasIzq.Location = new System.Drawing.Point(284, 468);
            this.pictureBoxVerReglasIzq.Name = "pictureBoxVerReglasIzq";
            this.pictureBoxVerReglasIzq.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxVerReglasIzq.TabIndex = 10;
            this.pictureBoxVerReglasIzq.TabStop = false;
            // 
            // pictureBoxVerReglasDer
            // 
            this.pictureBoxVerReglasDer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxVerReglasDer.Location = new System.Drawing.Point(479, 468);
            this.pictureBoxVerReglasDer.Name = "pictureBoxVerReglasDer";
            this.pictureBoxVerReglasDer.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxVerReglasDer.TabIndex = 11;
            this.pictureBoxVerReglasDer.TabStop = false;
            // 
            // pictureBoxCerrarSesionIzq
            // 
            this.pictureBoxCerrarSesionIzq.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCerrarSesionIzq.Location = new System.Drawing.Point(270, 561);
            this.pictureBoxCerrarSesionIzq.Name = "pictureBoxCerrarSesionIzq";
            this.pictureBoxCerrarSesionIzq.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxCerrarSesionIzq.TabIndex = 12;
            this.pictureBoxCerrarSesionIzq.TabStop = false;
            // 
            // pictureBoxCerrarSesionDer
            // 
            this.pictureBoxCerrarSesionDer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCerrarSesionDer.Location = new System.Drawing.Point(488, 556);
            this.pictureBoxCerrarSesionDer.Name = "pictureBoxCerrarSesionDer";
            this.pictureBoxCerrarSesionDer.Size = new System.Drawing.Size(40, 35);
            this.pictureBoxCerrarSesionDer.TabIndex = 13;
            this.pictureBoxCerrarSesionDer.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 719);
            this.Controls.Add(this.pictureBoxCerrarSesionDer);
            this.Controls.Add(this.pictureBoxCerrarSesionIzq);
            this.Controls.Add(this.pictureBoxVerReglasDer);
            this.Controls.Add(this.pictureBoxVerReglasIzq);
            this.Controls.Add(this.pictureBoxMejoresJugadoresDer);
            this.Controls.Add(this.pictureBoxMejoresJugadoresIzq);
            this.Controls.Add(this.pictureBoxEntrarSalaDer);
            this.Controls.Add(this.pictureBoxEntrarSalaIzq);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelCerrarSesion);
            this.Controls.Add(this.labelVerReglas);
            this.Controls.Add(this.labelMejoresJugadores);
            this.Controls.Add(this.labelEntrarSala);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseSobrePanelPrincipal);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrarSalaIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrarSalaDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMejoresJugadoresIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMejoresJugadoresDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerReglasIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerReglasDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSesionIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSesionDer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEntrarSala;
        private System.Windows.Forms.Label labelMejoresJugadores;
        private System.Windows.Forms.Label labelVerReglas;
        private System.Windows.Forms.Label labelCerrarSesion;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox pictureBoxEntrarSalaIzq;
        private System.Windows.Forms.PictureBox pictureBoxEntrarSalaDer;
        private System.Windows.Forms.PictureBox pictureBoxMejoresJugadoresIzq;
        private System.Windows.Forms.PictureBox pictureBoxMejoresJugadoresDer;
        private System.Windows.Forms.PictureBox pictureBoxVerReglasIzq;
        private System.Windows.Forms.PictureBox pictureBoxVerReglasDer;
        private System.Windows.Forms.PictureBox pictureBoxCerrarSesionIzq;
        private System.Windows.Forms.PictureBox pictureBoxCerrarSesionDer;
    }
}