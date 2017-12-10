namespace CincoEnLinea.GUI {
    partial class MejoresJugadores {
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
            this.listViewMejoresJugadores = new System.Windows.Forms.ListView();
            this.columnaPosición = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaGanadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPerdidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEmpatadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRegresarMejoresJugadores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMejoresJugadores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMejoresJugadores
            // 
            this.listViewMejoresJugadores.BackColor = System.Drawing.Color.White;
            this.listViewMejoresJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaPosición,
            this.columnaUsuario,
            this.columnaGanadas,
            this.columnaPerdidas,
            this.columnaEmpatadas});
            this.listViewMejoresJugadores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMejoresJugadores.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listViewMejoresJugadores.Location = new System.Drawing.Point(16, 153);
            this.listViewMejoresJugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewMejoresJugadores.Name = "listViewMejoresJugadores";
            this.listViewMejoresJugadores.Size = new System.Drawing.Size(716, 278);
            this.listViewMejoresJugadores.TabIndex = 0;
            this.listViewMejoresJugadores.UseCompatibleStateImageBehavior = false;
            this.listViewMejoresJugadores.View = System.Windows.Forms.View.Details;
            // 
            // columnaPosición
            // 
            this.columnaPosición.Text = "Posición";
            this.columnaPosición.Width = 90;
            // 
            // columnaUsuario
            // 
            this.columnaUsuario.Text = "Usuario";
            this.columnaUsuario.Width = 110;
            // 
            // columnaGanadas
            // 
            this.columnaGanadas.Text = "Ganadas";
            this.columnaGanadas.Width = 110;
            // 
            // columnaPerdidas
            // 
            this.columnaPerdidas.Text = "Perdidas";
            this.columnaPerdidas.Width = 123;
            // 
            // columnaEmpatadas
            // 
            this.columnaEmpatadas.Text = "Empatadas";
            this.columnaEmpatadas.Width = 142;
            // 
            // buttonRegresarMejoresJugadores
            // 
            this.buttonRegresarMejoresJugadores.BackColor = System.Drawing.Color.Silver;
            this.buttonRegresarMejoresJugadores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMejoresJugadores.Location = new System.Drawing.Point(515, 459);
            this.buttonRegresarMejoresJugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegresarMejoresJugadores.Name = "buttonRegresarMejoresJugadores";
            this.buttonRegresarMejoresJugadores.Size = new System.Drawing.Size(153, 38);
            this.buttonRegresarMejoresJugadores.TabIndex = 1;
            this.buttonRegresarMejoresJugadores.Text = "Regresar";
            this.buttonRegresarMejoresJugadores.UseVisualStyleBackColor = false;
            this.buttonRegresarMejoresJugadores.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelMejoresJugadores);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 122);
            this.panel1.TabIndex = 2;
            // 
            // labelMejoresJugadores
            // 
            this.labelMejoresJugadores.AutoSize = true;
            this.labelMejoresJugadores.BackColor = System.Drawing.Color.Black;
            this.labelMejoresJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMejoresJugadores.ForeColor = System.Drawing.Color.White;
            this.labelMejoresJugadores.Location = new System.Drawing.Point(176, 48);
            this.labelMejoresJugadores.Name = "labelMejoresJugadores";
            this.labelMejoresJugadores.Size = new System.Drawing.Size(333, 44);
            this.labelMejoresJugadores.TabIndex = 0;
            this.labelMejoresJugadores.Text = "Mejores jugadores";
            // 
            // MejoresJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegresarMejoresJugadores);
            this.Controls.Add(this.listViewMejoresJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MejoresJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mejores jugadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClicAlCerrarVentana);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMejoresJugadores;
        private System.Windows.Forms.ColumnHeader columnaPosición;
        private System.Windows.Forms.ColumnHeader columnaUsuario;
        private System.Windows.Forms.ColumnHeader columnaGanadas;
        private System.Windows.Forms.ColumnHeader columnaPerdidas;
        private System.Windows.Forms.ColumnHeader columnaEmpatadas;
        private System.Windows.Forms.Button buttonRegresarMejoresJugadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMejoresJugadores;
    }
}