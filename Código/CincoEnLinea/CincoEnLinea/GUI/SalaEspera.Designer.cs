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
            this.LVPartidasDisponibles = new System.Windows.Forms.ListView();
            this.colPartida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bUnirsePartida = new System.Windows.Forms.Button();
            this.bCrearPartida = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 118);
            this.panel1.TabIndex = 0;
            // 
            // labelPartidasDisponibles
            // 
            this.labelPartidasDisponibles.AutoSize = true;
            this.labelPartidasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartidasDisponibles.ForeColor = System.Drawing.Color.White;
            this.labelPartidasDisponibles.Location = new System.Drawing.Point(80, 40);
            this.labelPartidasDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPartidasDisponibles.Name = "labelPartidasDisponibles";
            this.labelPartidasDisponibles.Size = new System.Drawing.Size(328, 39);
            this.labelPartidasDisponibles.TabIndex = 1;
            this.labelPartidasDisponibles.Text = "Partidas disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "5inco en linea";
            // 
            // LVPartidasDisponibles
            // 
            this.LVPartidasDisponibles.BackColor = System.Drawing.Color.White;
            this.LVPartidasDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPartida,
            this.colUsuario});
            this.LVPartidasDisponibles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPartidasDisponibles.ForeColor = System.Drawing.Color.Black;
            this.LVPartidasDisponibles.FullRowSelect = true;
            this.LVPartidasDisponibles.GridLines = true;
            this.LVPartidasDisponibles.Location = new System.Drawing.Point(36, 158);
            this.LVPartidasDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.LVPartidasDisponibles.MultiSelect = false;
            this.LVPartidasDisponibles.Name = "LVPartidasDisponibles";
            this.LVPartidasDisponibles.Size = new System.Drawing.Size(438, 168);
            this.LVPartidasDisponibles.TabIndex = 2;
            this.LVPartidasDisponibles.UseCompatibleStateImageBehavior = false;
            this.LVPartidasDisponibles.View = System.Windows.Forms.View.Details;
            // 
            // colPartida
            // 
            this.colPartida.Text = "Sala";
            this.colPartida.Width = 217;
            // 
            // colUsuario
            // 
            this.colUsuario.Text = "Usuario";
            this.colUsuario.Width = 216;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.bUnirsePartida);
            this.panel2.Controls.Add(this.bCrearPartida);
            this.panel2.Location = new System.Drawing.Point(-1, 369);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 113);
            this.panel2.TabIndex = 3;
            // 
            // bUnirsePartida
            // 
            this.bUnirsePartida.BackColor = System.Drawing.Color.White;
            this.bUnirsePartida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnirsePartida.Location = new System.Drawing.Point(338, 28);
            this.bUnirsePartida.Margin = new System.Windows.Forms.Padding(2);
            this.bUnirsePartida.Name = "bUnirsePartida";
            this.bUnirsePartida.Size = new System.Drawing.Size(136, 32);
            this.bUnirsePartida.TabIndex = 5;
            this.bUnirsePartida.Text = "Unirse a partida";
            this.bUnirsePartida.UseVisualStyleBackColor = false;
            this.bUnirsePartida.Click += new System.EventHandler(this.ClickUnirsePartida);
            // 
            // bCrearPartida
            // 
            this.bCrearPartida.BackColor = System.Drawing.Color.White;
            this.bCrearPartida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearPartida.Location = new System.Drawing.Point(44, 29);
            this.bCrearPartida.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearPartida.Name = "bCrearPartida";
            this.bCrearPartida.Size = new System.Drawing.Size(134, 31);
            this.bCrearPartida.TabIndex = 4;
            this.bCrearPartida.Text = "Crear partida";
            this.bCrearPartida.UseVisualStyleBackColor = false;
            this.bCrearPartida.Click += new System.EventHandler(this.ClickCrearPartida);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.Silver;
            this.buttonRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(387, 330);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(86, 26);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // SalaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 469);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LVPartidasDisponibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Espera";
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
        private System.Windows.Forms.ListView LVPartidasDisponibles;
        private System.Windows.Forms.ColumnHeader colPartida;
        private System.Windows.Forms.ColumnHeader colUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bUnirsePartida;
        private System.Windows.Forms.Button bCrearPartida;
        private System.Windows.Forms.Button buttonRegresar;
    }
}