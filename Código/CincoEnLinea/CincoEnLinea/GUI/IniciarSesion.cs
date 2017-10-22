using CincoEnLinea.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {
    public partial class IniciarSesion : Form {
        public IniciarSesion() {
            InitializeComponent();
        }


        /// <summary>
        /// Método que contiene la acción al dar clic al bontón "Entrar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicEntrar(object sender, EventArgs e) {
            if(textBoxNombreUsuario.Text.Equals("") || textBoxContrasena.Text.Equals("")) {
                MessageBox.Show("Faltaron campos por llenar, no seas así", "Ups",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else {
                if (ConfirmaIngreso(textBoxNombreUsuario.Text, textBoxContrasena.Text)) {
                    MenuPrincipal mP = new MenuPrincipal();
                    mP.Show();
                }
            }
            
        }

        private void MouseClicRegistrate(object sender, MouseEventArgs e) {
            Registro registro = new Registro();
            registro.Show();
        }

        /// <summary>
        /// Método que valida el ingreso del usuario y devuelve MessageBox en caso de no poder ingresar.
        /// También encripta la contraseña del usuario antes de comprobarla en la BD
        /// </summary>
        /// <param name="usuarioName"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        public Boolean ConfirmaIngreso(String usuarioName, String contrasenia) {
            Consultas queries = new Consultas();
            String contraEncriptada = EncriptaContrasena(contrasenia);
            if(queries.ValidaNombreUsuario(usuarioName)) {
                if(queries.ValidaContraUsuario(contraEncriptada)) {
                    return true;
                } else {
                    MessageBox.Show("La contraseña está mal, inténtalo otra vez", "Pequeño problema",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            } else {
                MessageBox.Show("El usuario no está registrado", "Ups",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        /// <summary>
        /// Método que encripta una cadena
        /// </summary>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        public string EncriptaContrasena(string contrasena) {
            SHA256CryptoServiceProvider encriptado = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(contrasena);
            byte[] hashedBytes = encriptado.ComputeHash(inputBytes);

            StringBuilder contrasenaSha = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++) {
                contrasenaSha.Append(hashedBytes[i].ToString("x2").ToLower());
            }

            return contrasenaSha.ToString();
        }
    }
}
