namespace CincoEnLinea.GUI {
    partial class VerReglas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerReglas));
            this.buttonRegresarVerReglas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelReglasTitulo = new System.Windows.Forms.Label();
            this.labelContenidoReglas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegresarVerReglas
            // 
            this.buttonRegresarVerReglas.BackColor = System.Drawing.Color.Silver;
            this.buttonRegresarVerReglas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarVerReglas.Location = new System.Drawing.Point(471, 443);
            this.buttonRegresarVerReglas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresarVerReglas.Name = "buttonRegresarVerReglas";
            this.buttonRegresarVerReglas.Size = new System.Drawing.Size(146, 39);
            this.buttonRegresarVerReglas.TabIndex = 0;
            this.buttonRegresarVerReglas.Text = "Regresar";
            this.buttonRegresarVerReglas.UseVisualStyleBackColor = false;
            this.buttonRegresarVerReglas.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelReglasTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 133);
            this.panel1.TabIndex = 1;
            // 
            // labelReglasTitulo
            // 
            this.labelReglasTitulo.AutoSize = true;
            this.labelReglasTitulo.Font = new System.Drawing.Font("Moon", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReglasTitulo.ForeColor = System.Drawing.Color.White;
            this.labelReglasTitulo.Location = new System.Drawing.Point(265, 39);
            this.labelReglasTitulo.Name = "labelReglasTitulo";
            this.labelReglasTitulo.Size = new System.Drawing.Size(157, 40);
            this.labelReglasTitulo.TabIndex = 0;
            this.labelReglasTitulo.Text = "Reglas";
            // 
            // labelContenidoReglas
            // 
            this.labelContenidoReglas.AutoSize = true;
            this.labelContenidoReglas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenidoReglas.Location = new System.Drawing.Point(29, 158);
            this.labelContenidoReglas.Name = "labelContenidoReglas";
            this.labelContenidoReglas.Size = new System.Drawing.Size(552, 253);
            this.labelContenidoReglas.TabIndex = 2;
            this.labelContenidoReglas.Text = resources.GetString("labelContenidoReglas.Text");
            // 
            // VerReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 508);
            this.Controls.Add(this.labelContenidoReglas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegresarVerReglas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerReglas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresarVerReglas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelReglasTitulo;
        private System.Windows.Forms.Label labelContenidoReglas;
    }
}