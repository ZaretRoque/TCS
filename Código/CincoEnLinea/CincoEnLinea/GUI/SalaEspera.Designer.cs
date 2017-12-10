namespace CincoEnLinea.GUI {
    partial class SalaEspera {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPartidasDisponibles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPartidasDisponibles = new System.Windows.Forms.ListView();
            this.columnaPartida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUnirsePartida = new System.Windows.Forms.Button();
            this.buttonCrearPartida = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelPartidasDisponibles);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 145);
            this.panel1.TabIndex = 0;
            // 
            // labelPartidasDisponibles
            // 
            this.labelPartidasDisponibles.AutoSize = true;
            this.labelPartidasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartidasDisponibles.ForeColor = System.Drawing.Color.White;
            this.labelPartidasDisponibles.Location = new System.Drawing.Point(107, 49);
            this.labelPartidasDisponibles.Name = "labelPartidasDisponibles";
            this.labelPartidasDisponibles.Size = new System.Drawing.Size(410, 51);
            this.labelPartidasDisponibles.TabIndex = 1;
            this.labelPartidasDisponibles.Text = "Partidas disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "5inco en linea";
            // 
            // listViewPartidasDisponibles
            // 
            this.listViewPartidasDisponibles.BackColor = System.Drawing.Color.White;
            this.listViewPartidasDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaPartida,
            this.columnaUsuario});
            this.listViewPartidasDisponibles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPartidasDisponibles.ForeColor = System.Drawing.Color.Black;
            this.listViewPartidasDisponibles.FullRowSelect = true;
            this.listViewPartidasDisponibles.GridLines = true;
            this.listViewPartidasDisponibles.Location = new System.Drawing.Point(48, 194);
            this.listViewPartidasDisponibles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPartidasDisponibles.MultiSelect = false;
            this.listViewPartidasDisponibles.Name = "listViewPartidasDisponibles";
            this.listViewPartidasDisponibles.Size = new System.Drawing.Size(583, 206);
            this.listViewPartidasDisponibles.TabIndex = 2;
            this.listViewPartidasDisponibles.UseCompatibleStateImageBehavior = false;
            this.listViewPartidasDisponibles.View = System.Windows.Forms.View.Details;
            // 
            // columnaPartida
            // 
            this.columnaPartida.Text = "Sala";
            this.columnaPartida.Width = 217;
            // 
            // columnaUsuario
            // 
            this.columnaUsuario.Text = "Usuario";
            this.columnaUsuario.Width = 216;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonUnirsePartida);
            this.panel2.Controls.Add(this.buttonCrearPartida);
            this.panel2.Location = new System.Drawing.Point(-1, 454);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 139);
            this.panel2.TabIndex = 3;
            // 
            // buttonUnirsePartida
            // 
            this.buttonUnirsePartida.BackColor = System.Drawing.Color.White;
            this.buttonUnirsePartida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnirsePartida.Location = new System.Drawing.Point(451, 34);
            this.buttonUnirsePartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnirsePartida.Name = "buttonUnirsePartida";
            this.buttonUnirsePartida.Size = new System.Drawing.Size(181, 39);
            this.buttonUnirsePartida.TabIndex = 5;
            this.buttonUnirsePartida.Text = "Unirse a partida";
            this.buttonUnirsePartida.UseVisualStyleBackColor = false;
            this.buttonUnirsePartida.Click += new System.EventHandler(this.ClickUnirsePartida);
            // 
            // buttonCrearPartida
            // 
            this.buttonCrearPartida.BackColor = System.Drawing.Color.White;
            this.buttonCrearPartida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearPartida.Location = new System.Drawing.Point(59, 36);
            this.buttonCrearPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearPartida.Name = "buttonCrearPartida";
            this.buttonCrearPartida.Size = new System.Drawing.Size(179, 38);
            this.buttonCrearPartida.TabIndex = 4;
            this.buttonCrearPartida.Text = "Crear partida";
            this.buttonCrearPartida.UseVisualStyleBackColor = false;
            this.buttonCrearPartida.Click += new System.EventHandler(this.ClickCrearPartida);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.Silver;
            this.buttonRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(516, 406);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(115, 32);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // SalaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 577);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewPartidasDisponibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Espera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClicAlCerrarVentana);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPartidasDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPartidasDisponibles;
        private System.Windows.Forms.ColumnHeader columnaPartida;
        private System.Windows.Forms.ColumnHeader columnaUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUnirsePartida;
        private System.Windows.Forms.Button buttonCrearPartida;
        private System.Windows.Forms.Button buttonRegresar;
    }
}