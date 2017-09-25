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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.linkLabelIdiomaEspañol = new System.Windows.Forms.LinkLabel();
            this.linkLabelIdiomaIngles = new System.Windows.Forms.LinkLabel();
            this.PanelRegistrarteIS = new System.Windows.Forms.Panel();
            this.linkLabelRegistrate = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInicioSesion.SuspendLayout();
            this.PanelRegistrarteIS.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.White;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(57, 70);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(226, 35);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "Usuario";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.cambiaFondo);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(57, 120);
            this.textBoxContraseña.Multiline = true;
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(226, 34);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(57, 188);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(226, 35);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInicioSesion.Controls.Add(this.buttonEntrar);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxContraseña);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxUsuario);
            this.groupBoxInicioSesion.Font = new System.Drawing.Font("Moon", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(76, 65);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(327, 271);
            this.groupBoxInicioSesion.TabIndex = 3;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Iniciar sesion";
            this.groupBoxInicioSesion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabelIdiomaEspañol
            // 
            this.linkLabelIdiomaEspañol.AutoSize = true;
            this.linkLabelIdiomaEspañol.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelIdiomaEspañol.Location = new System.Drawing.Point(366, 30);
            this.linkLabelIdiomaEspañol.Name = "linkLabelIdiomaEspañol";
            this.linkLabelIdiomaEspañol.Size = new System.Drawing.Size(59, 17);
            this.linkLabelIdiomaEspañol.TabIndex = 4;
            this.linkLabelIdiomaEspañol.TabStop = true;
            this.linkLabelIdiomaEspañol.Text = "Español";
            // 
            // linkLabelIdiomaIngles
            // 
            this.linkLabelIdiomaIngles.AutoSize = true;
            this.linkLabelIdiomaIngles.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelIdiomaIngles.Location = new System.Drawing.Point(436, 30);
            this.linkLabelIdiomaIngles.Name = "linkLabelIdiomaIngles";
            this.linkLabelIdiomaIngles.Size = new System.Drawing.Size(54, 17);
            this.linkLabelIdiomaIngles.TabIndex = 5;
            this.linkLabelIdiomaIngles.TabStop = true;
            this.linkLabelIdiomaIngles.Text = "English";
            // 
            // PanelRegistrarteIS
            // 
            this.PanelRegistrarteIS.BackColor = System.Drawing.Color.Transparent;
            this.PanelRegistrarteIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRegistrarteIS.Controls.Add(this.linkLabelRegistrate);
            this.PanelRegistrarteIS.Controls.Add(this.label1);
            this.PanelRegistrarteIS.Location = new System.Drawing.Point(76, 361);
            this.PanelRegistrarteIS.Name = "PanelRegistrarteIS";
            this.PanelRegistrarteIS.Size = new System.Drawing.Size(327, 74);
            this.PanelRegistrarteIS.TabIndex = 6;
            // 
            // linkLabelRegistrate
            // 
            this.linkLabelRegistrate.AutoSize = true;
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
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿No tienes cuenta?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 483);
            this.Controls.Add(this.PanelRegistrarteIS);
            this.Controls.Add(this.linkLabelIdiomaIngles);
            this.Controls.Add(this.linkLabelIdiomaEspañol);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinco en Línea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            this.PanelRegistrarteIS.ResumeLayout(false);
            this.PanelRegistrarteIS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.GroupBox groupBoxInicioSesion;
        private System.Windows.Forms.LinkLabel linkLabelIdiomaEspañol;
        private System.Windows.Forms.LinkLabel linkLabelIdiomaIngles;
        private System.Windows.Forms.Panel PanelRegistrarteIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrate;
    }
}

