namespace CincoEnLinea
{
    partial class Registro
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
            this.linkLabelRegistrar5EnLinea = new System.Windows.Forms.LinkLabel();
            this.labelRegistrarNuevoUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuarioRegistro = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxConfirmaContrasenia = new System.Windows.Forms.TextBox();
            this.labelContraseniaRegistro = new System.Windows.Forms.Label();
            this.labelRepiteContrasenia = new System.Windows.Forms.Label();
            this.buttonRegistrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelRegistrar5EnLinea
            // 
            this.linkLabelRegistrar5EnLinea.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelRegistrar5EnLinea.AutoSize = true;
            this.linkLabelRegistrar5EnLinea.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrar5EnLinea.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegistrar5EnLinea.Location = new System.Drawing.Point(-7, 24);
            this.linkLabelRegistrar5EnLinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRegistrar5EnLinea.Name = "linkLabelRegistrar5EnLinea";
            this.linkLabelRegistrar5EnLinea.Size = new System.Drawing.Size(426, 16);
            this.linkLabelRegistrar5EnLinea.TabIndex = 1;
            this.linkLabelRegistrar5EnLinea.TabStop = true;
            this.linkLabelRegistrar5EnLinea.Text = "                                 5inco en linea                                  " +
    "       \r\n";
            this.linkLabelRegistrar5EnLinea.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // labelRegistrarNuevoUsuario
            // 
            this.labelRegistrarNuevoUsuario.AutoSize = true;
            this.labelRegistrarNuevoUsuario.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarNuevoUsuario.Location = new System.Drawing.Point(96, 64);
            this.labelRegistrarNuevoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarNuevoUsuario.Name = "labelRegistrarNuevoUsuario";
            this.labelRegistrarNuevoUsuario.Size = new System.Drawing.Size(185, 16);
            this.labelRegistrarNuevoUsuario.TabIndex = 2;
            this.labelRegistrarNuevoUsuario.Text = "-Comienza a jugar-";
            // 
            // labelNombreUsuarioRegistro
            // 
            this.labelNombreUsuarioRegistro.AutoSize = true;
            this.labelNombreUsuarioRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuarioRegistro.Location = new System.Drawing.Point(66, 106);
            this.labelNombreUsuarioRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreUsuarioRegistro.Name = "labelNombreUsuarioRegistro";
            this.labelNombreUsuarioRegistro.Size = new System.Drawing.Size(140, 19);
            this.labelNombreUsuarioRegistro.TabIndex = 3;
            this.labelNombreUsuarioRegistro.Text = "Nombre de usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(68, 135);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreUsuario.MaxLength = 45;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(236, 20);
            this.textBoxNombreUsuario.TabIndex = 4;
            this.textBoxNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarEntrada);
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(69, 201);
            this.textBoxContrasenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.PasswordChar = '*';
            this.textBoxContrasenia.Size = new System.Drawing.Size(235, 20);
            this.textBoxContrasenia.TabIndex = 5;
            // 
            // textBoxConfirmaContrasenia
            // 
            this.textBoxConfirmaContrasenia.Location = new System.Drawing.Point(68, 263);
            this.textBoxConfirmaContrasenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConfirmaContrasenia.Name = "textBoxConfirmaContrasenia";
            this.textBoxConfirmaContrasenia.PasswordChar = '*';
            this.textBoxConfirmaContrasenia.Size = new System.Drawing.Size(236, 20);
            this.textBoxConfirmaContrasenia.TabIndex = 6;
            // 
            // labelContraseniaRegistro
            // 
            this.labelContraseniaRegistro.AutoSize = true;
            this.labelContraseniaRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseniaRegistro.Location = new System.Drawing.Point(67, 171);
            this.labelContraseniaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContraseniaRegistro.Name = "labelContraseniaRegistro";
            this.labelContraseniaRegistro.Size = new System.Drawing.Size(90, 19);
            this.labelContraseniaRegistro.TabIndex = 7;
            this.labelContraseniaRegistro.Text = "Contraseña";
            // 
            // labelRepiteContrasenia
            // 
            this.labelRepiteContrasenia.AutoSize = true;
            this.labelRepiteContrasenia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepiteContrasenia.Location = new System.Drawing.Point(67, 232);
            this.labelRepiteContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepiteContrasenia.Name = "labelRepiteContrasenia";
            this.labelRepiteContrasenia.Size = new System.Drawing.Size(172, 19);
            this.labelRepiteContrasenia.TabIndex = 8;
            this.labelRepiteContrasenia.Text = "Confirma la contraseña";
            // 
            // buttonRegistrame
            // 
            this.buttonRegistrame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrame.Location = new System.Drawing.Point(68, 302);
            this.buttonRegistrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegistrame.Name = "buttonRegistrame";
            this.buttonRegistrame.Size = new System.Drawing.Size(235, 35);
            this.buttonRegistrame.TabIndex = 9;
            this.buttonRegistrame.Text = "Regístrame";
            this.buttonRegistrame.UseVisualStyleBackColor = true;
            this.buttonRegistrame.Click += new System.EventHandler(this.ClicRegistrame);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 367);
            this.Controls.Add(this.buttonRegistrame);
            this.Controls.Add(this.labelRepiteContrasenia);
            this.Controls.Add(this.labelContraseniaRegistro);
            this.Controls.Add(this.textBoxConfirmaContrasenia);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelNombreUsuarioRegistro);
            this.Controls.Add(this.labelRegistrarNuevoUsuario);
            this.Controls.Add(this.linkLabelRegistrar5EnLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelRegistrar5EnLinea;
        private System.Windows.Forms.Label labelRegistrarNuevoUsuario;
        private System.Windows.Forms.Label labelNombreUsuarioRegistro;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.TextBox textBoxConfirmaContrasenia;
        private System.Windows.Forms.Label labelContraseniaRegistro;
        private System.Windows.Forms.Label labelRepiteContrasenia;
        private System.Windows.Forms.Button buttonRegistrame;
    }
}