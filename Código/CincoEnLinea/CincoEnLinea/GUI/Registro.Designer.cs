﻿namespace CincoEnLinea
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
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelRegistrar5EnLinea
            // 
            this.linkLabelRegistrar5EnLinea.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelRegistrar5EnLinea.AutoSize = true;
            this.linkLabelRegistrar5EnLinea.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrar5EnLinea.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegistrar5EnLinea.Location = new System.Drawing.Point(-9, 30);
            this.linkLabelRegistrar5EnLinea.Name = "linkLabelRegistrar5EnLinea";
            this.linkLabelRegistrar5EnLinea.Size = new System.Drawing.Size(534, 21);
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
            this.labelRegistrarNuevoUsuario.Location = new System.Drawing.Point(128, 79);
            this.labelRegistrarNuevoUsuario.Name = "labelRegistrarNuevoUsuario";
            this.labelRegistrarNuevoUsuario.Size = new System.Drawing.Size(234, 21);
            this.labelRegistrarNuevoUsuario.TabIndex = 2;
            this.labelRegistrarNuevoUsuario.Text = "-Comienza a jugar-";
            // 
            // labelNombreUsuarioRegistro
            // 
            this.labelNombreUsuarioRegistro.AutoSize = true;
            this.labelNombreUsuarioRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuarioRegistro.Location = new System.Drawing.Point(88, 130);
            this.labelNombreUsuarioRegistro.Name = "labelNombreUsuarioRegistro";
            this.labelNombreUsuarioRegistro.Size = new System.Drawing.Size(168, 21);
            this.labelNombreUsuarioRegistro.TabIndex = 3;
            this.labelNombreUsuarioRegistro.Text = "Nombre de usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(91, 166);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombreUsuario.MaxLength = 45;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(313, 22);
            this.textBoxNombreUsuario.TabIndex = 4;
            this.textBoxNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarEntrada);
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(92, 247);
            this.textBoxContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.PasswordChar = '*';
            this.textBoxContrasenia.Size = new System.Drawing.Size(312, 22);
            this.textBoxContrasenia.TabIndex = 5;
            // 
            // textBoxConfirmaContrasenia
            // 
            this.textBoxConfirmaContrasenia.Location = new System.Drawing.Point(91, 324);
            this.textBoxConfirmaContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmaContrasenia.Name = "textBoxConfirmaContrasenia";
            this.textBoxConfirmaContrasenia.PasswordChar = '*';
            this.textBoxConfirmaContrasenia.Size = new System.Drawing.Size(313, 22);
            this.textBoxConfirmaContrasenia.TabIndex = 6;
            // 
            // labelContraseniaRegistro
            // 
            this.labelContraseniaRegistro.AutoSize = true;
            this.labelContraseniaRegistro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseniaRegistro.Location = new System.Drawing.Point(89, 210);
            this.labelContraseniaRegistro.Name = "labelContraseniaRegistro";
            this.labelContraseniaRegistro.Size = new System.Drawing.Size(109, 21);
            this.labelContraseniaRegistro.TabIndex = 7;
            this.labelContraseniaRegistro.Text = "Contraseña";
            // 
            // labelRepiteContrasenia
            // 
            this.labelRepiteContrasenia.AutoSize = true;
            this.labelRepiteContrasenia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepiteContrasenia.Location = new System.Drawing.Point(89, 286);
            this.labelRepiteContrasenia.Name = "labelRepiteContrasenia";
            this.labelRepiteContrasenia.Size = new System.Drawing.Size(206, 21);
            this.labelRepiteContrasenia.TabIndex = 8;
            this.labelRepiteContrasenia.Text = "Confirma la contraseña";
            // 
            // buttonRegistrame
            // 
            this.buttonRegistrame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrame.Location = new System.Drawing.Point(91, 372);
            this.buttonRegistrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistrame.Name = "buttonRegistrame";
            this.buttonRegistrame.Size = new System.Drawing.Size(313, 43);
            this.buttonRegistrame.TabIndex = 9;
            this.buttonRegistrame.Text = "Regístrame";
            this.buttonRegistrame.UseVisualStyleBackColor = true;
            this.buttonRegistrame.Click += new System.EventHandler(this.ClicRegistrame);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(12, 12);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(114, 28);
            this.buttonRegresar.TabIndex = 10;
            this.buttonRegresar.Text = "Regresa";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.ClicRegresar);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 452);
            this.Controls.Add(this.buttonRegresar);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClicAlCerrarVentana);
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
        private System.Windows.Forms.Button buttonRegresar;
    }
}