namespace CincoEnLinea.GUI {
    partial class Mejores_jugadores {
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
            this.colPosición = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGanadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerdidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpatadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bRegresarMejoresJugadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMejoresJugadores
            // 
            this.listViewMejoresJugadores.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewMejoresJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPosición,
            this.colUsuario,
            this.colGanadas,
            this.colPerdidas,
            this.colEmpatadas});
            this.listViewMejoresJugadores.Location = new System.Drawing.Point(16, 15);
            this.listViewMejoresJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMejoresJugadores.Name = "listViewMejoresJugadores";
            this.listViewMejoresJugadores.Size = new System.Drawing.Size(727, 363);
            this.listViewMejoresJugadores.TabIndex = 0;
            this.listViewMejoresJugadores.UseCompatibleStateImageBehavior = false;
            this.listViewMejoresJugadores.View = System.Windows.Forms.View.Details;
            // 
            // colPosición
            // 
            this.colPosición.Text = "Posición";
            this.colPosición.Width = 110;
            // 
            // colUsuario
            // 
            this.colUsuario.Text = "Usuario";
            this.colUsuario.Width = 110;
            // 
            // colGanadas
            // 
            this.colGanadas.Text = "Ganadas";
            this.colGanadas.Width = 110;
            // 
            // colPerdidas
            // 
            this.colPerdidas.Text = "Perdidas";
            this.colPerdidas.Width = 110;
            // 
            // colEmpatadas
            // 
            this.colEmpatadas.Text = "Empatadas";
            this.colEmpatadas.Width = 110;
            // 
            // bRegresarMejoresJugadores
            // 
            this.bRegresarMejoresJugadores.Location = new System.Drawing.Point(17, 418);
            this.bRegresarMejoresJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.bRegresarMejoresJugadores.Name = "bRegresarMejoresJugadores";
            this.bRegresarMejoresJugadores.Size = new System.Drawing.Size(100, 28);
            this.bRegresarMejoresJugadores.TabIndex = 1;
            this.bRegresarMejoresJugadores.Text = "Regresar";
            this.bRegresarMejoresJugadores.UseVisualStyleBackColor = true;
            this.bRegresarMejoresJugadores.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mejores_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CincoEnLinea.Properties.Resources.negroDegradado;
            this.ClientSize = new System.Drawing.Size(762, 483);
            this.Controls.Add(this.bRegresarMejoresJugadores);
            this.Controls.Add(this.listViewMejoresJugadores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mejores_jugadores";
            this.Text = "Mejores jugadores";
            this.Load += new System.EventHandler(this.Mejores_jugadores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMejoresJugadores;
        private System.Windows.Forms.ColumnHeader colPosición;
        private System.Windows.Forms.ColumnHeader colUsuario;
        private System.Windows.Forms.ColumnHeader colGanadas;
        private System.Windows.Forms.ColumnHeader colPerdidas;
        private System.Windows.Forms.ColumnHeader colEmpatadas;
        private System.Windows.Forms.Button bRegresarMejoresJugadores;
    }
}