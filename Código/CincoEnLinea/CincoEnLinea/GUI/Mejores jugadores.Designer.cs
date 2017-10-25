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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMejoresJugadores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMejoresJugadores
            // 
            this.listViewMejoresJugadores.BackColor = System.Drawing.Color.White;
            this.listViewMejoresJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPosición,
            this.colUsuario,
            this.colGanadas,
            this.colPerdidas,
            this.colEmpatadas});
            this.listViewMejoresJugadores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMejoresJugadores.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listViewMejoresJugadores.Location = new System.Drawing.Point(12, 124);
            this.listViewMejoresJugadores.Name = "listViewMejoresJugadores";
            this.listViewMejoresJugadores.Size = new System.Drawing.Size(538, 227);
            this.listViewMejoresJugadores.TabIndex = 0;
            this.listViewMejoresJugadores.UseCompatibleStateImageBehavior = false;
            this.listViewMejoresJugadores.View = System.Windows.Forms.View.Details;
            // 
            // colPosición
            // 
            this.colPosición.Text = "Posición";
            this.colPosición.Width = 90;
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
            this.colPerdidas.Width = 123;
            // 
            // colEmpatadas
            // 
            this.colEmpatadas.Text = "Empatadas";
            this.colEmpatadas.Width = 142;
            // 
            // bRegresarMejoresJugadores
            // 
            this.bRegresarMejoresJugadores.BackColor = System.Drawing.Color.Silver;
            this.bRegresarMejoresJugadores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresarMejoresJugadores.Location = new System.Drawing.Point(386, 373);
            this.bRegresarMejoresJugadores.Name = "bRegresarMejoresJugadores";
            this.bRegresarMejoresJugadores.Size = new System.Drawing.Size(115, 31);
            this.bRegresarMejoresJugadores.TabIndex = 1;
            this.bRegresarMejoresJugadores.Text = "Regresar";
            this.bRegresarMejoresJugadores.UseVisualStyleBackColor = false;
            this.bRegresarMejoresJugadores.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelMejoresJugadores);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 99);
            this.panel1.TabIndex = 2;
            // 
            // labelMejoresJugadores
            // 
            this.labelMejoresJugadores.AutoSize = true;
            this.labelMejoresJugadores.BackColor = System.Drawing.Color.Black;
            this.labelMejoresJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMejoresJugadores.ForeColor = System.Drawing.Color.White;
            this.labelMejoresJugadores.Location = new System.Drawing.Point(132, 39);
            this.labelMejoresJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMejoresJugadores.Name = "labelMejoresJugadores";
            this.labelMejoresJugadores.Size = new System.Drawing.Size(261, 36);
            this.labelMejoresJugadores.TabIndex = 0;
            this.labelMejoresJugadores.Text = "Mejores jugadores";
            // 
            // Mejores_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRegresarMejoresJugadores);
            this.Controls.Add(this.listViewMejoresJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mejores_jugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mejores jugadores";
            this.Load += new System.EventHandler(this.Mejores_jugadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMejoresJugadores;
    }
}