using CincoEnLinea.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Resources;
using CincoEnLinea.RecursosInternacionalizacion;
using System.ServiceModel;
using WcfServicioBaseDatos;

namespace CincoEnLinea.GUI {
    public partial class IniciarSesion : Form {
        
        public IniciarSesion() {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
        }


        /// <summary>
        /// Método que contiene la acción al dar clic al bontón "Entrar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicEntrar(object sender, EventArgs e) {
            
            if (textBoxNombreUsuario.Text.Equals("") || textBoxContrasena.Text.Equals("")) {
                ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.IniciarSesionRes", 
                    typeof(IniciarSesion).Assembly);
                string mensaje = rm.GetString("camposVacios");
                MessageBox.Show(mensaje, "Ups",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                if (ConfirmaIngreso(textBoxNombreUsuario.Text, textBoxContrasena.Text)) {
                    MenuPrincipal mP = new MenuPrincipal();
                    mP.Show();
                    this.Hide();
                    //mP.AplicarIdioma();
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
            String contraEncriptada = EncriptaContrasena(contrasenia);
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.IniciarSesionRes",
                    typeof(IniciarSesion).Assembly);
            ChannelFactory<IServicioBD> canalServidor;
            IServicioBD interfazServidor;
            string mensaje;
            string titulo;

            try {
                canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
                interfazServidor = canalServidor.CreateChannel();

                if (interfazServidor.ValidaNombreUsuario(usuarioName)) {
                    if (interfazServidor.ValidaContraseniaUsuario(contraEncriptada)) {
                        return true;
                    } else {
                        mensaje = rm.GetString("contrasenaIncorrecta");
                        titulo = rm.GetString("tituloMensajeContrasena");
                        MessageBox.Show(mensaje, titulo,
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                } else {
                    mensaje = rm.GetString("noRegistrado");
                    MessageBox.Show(mensaje, "Ups",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            } catch (MySql.Data.MySqlClient.MySqlException e) {
                mensaje = rm.GetString("excepcionBD");
                titulo = rm.GetString("tituloExcepcionBD");
                MessageBox.Show(mensaje, titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            } catch (FaultException e) {
                mensaje = rm.GetString("excepcionServicioWcf");
                titulo = rm.GetString("tituloExcepcionWcf");
                MessageBox.Show(mensaje, titulo,
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

        private void linkLabelEspañol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            
            AplicarIdioma();
        }

        private void linkLabelEnglish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            
            AplicarIdioma();
        }

        private void AplicarIdioma() {
           // ResourceManager rm = new ResourceManager("RecursosInternacionalizacion.IniciarSesionRes", typeof(IniciarSesion).Assembly);
            this.Text = IniciarSesionRes.wTIniciarSesion;
            buttonEntrar.Text = IniciarSesionRes.buttonEntrar;
            label1.Text = IniciarSesionRes.contrasena;
            labelDesarrolladores.Text = IniciarSesionRes.Desarrolladores;
            labelIniciaSesion.Text = IniciarSesionRes.labIniciaSesion;
            labelNoTienesCuenta.Text = IniciarSesionRes.noCuenta;
            labelUsuario.Text = IniciarSesionRes.Usuario;
            linkLabelRegistrate.Text = IniciarSesionRes.registrar;
        }

        private void ClicLabelRegistrate(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
        }
    }
}
