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
            this.bRegresarVerReglas = new System.Windows.Forms.Button();
            this.labelRegla1 = new System.Windows.Forms.Label();
            this.labelRegla2 = new System.Windows.Forms.Label();
            this.labelRegla3 = new System.Windows.Forms.Label();
            this.labelRegla4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRegresarVerReglas
            // 
            this.bRegresarVerReglas.Location = new System.Drawing.Point(13, 328);
            this.bRegresarVerReglas.Name = "bRegresarVerReglas";
            this.bRegresarVerReglas.Size = new System.Drawing.Size(75, 23);
            this.bRegresarVerReglas.TabIndex = 0;
            this.bRegresarVerReglas.Text = "Regresar";
            this.bRegresarVerReglas.UseVisualStyleBackColor = true;
            // 
            // labelRegla1
            // 
            this.labelRegla1.AutoSize = true;
            this.labelRegla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla1.Location = new System.Drawing.Point(13, 13);
            this.labelRegla1.Name = "labelRegla1";
            this.labelRegla1.Size = new System.Drawing.Size(81, 24);
            this.labelRegla1.TabIndex = 1;
            this.labelRegla1.Text = "Regla 1";
            this.labelRegla1.Click += new System.EventHandler(this.labelRegla1_Click);
            // 
            // labelRegla2
            // 
            this.labelRegla2.AutoSize = true;
            this.labelRegla2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla2.Location = new System.Drawing.Point(13, 52);
            this.labelRegla2.Name = "labelRegla2";
            this.labelRegla2.Size = new System.Drawing.Size(75, 24);
            this.labelRegla2.TabIndex = 2;
            this.labelRegla2.Text = "Regla2";
            this.labelRegla2.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRegla3
            // 
            this.labelRegla3.AutoSize = true;
            this.labelRegla3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla3.Location = new System.Drawing.Point(16, 96);
            this.labelRegla3.Name = "labelRegla3";
            this.labelRegla3.Size = new System.Drawing.Size(66, 24);
            this.labelRegla3.TabIndex = 3;
            this.labelRegla3.Text = "label1";
            // 
            // labelRegla4
            // 
            this.labelRegla4.AutoSize = true;
            this.labelRegla4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegla4.Location = new System.Drawing.Point(16, 150);
            this.labelRegla4.Name = "labelRegla4";
            this.labelRegla4.Size = new System.Drawing.Size(66, 24);
            this.labelRegla4.TabIndex = 4;
            this.labelRegla4.Text = "label1";
            // 
            // VerReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 363);
            this.Controls.Add(this.labelRegla4);
            this.Controls.Add(this.labelRegla3);
            this.Controls.Add(this.labelRegla2);
            this.Controls.Add(this.labelRegla1);
            this.Controls.Add(this.bRegresarVerReglas);
            this.Name = "VerReglas";
            this.Text = "VerReglas";
            this.Load += new System.EventHandler(this.VerReglas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRegresarVerReglas;
        private System.Windows.Forms.Label labelRegla1;
        private System.Windows.Forms.Label labelRegla2;
        private System.Windows.Forms.Label labelRegla3;
        private System.Windows.Forms.Label labelRegla4;
    }
}