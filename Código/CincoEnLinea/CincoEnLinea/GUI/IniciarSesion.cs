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
        ChannelFactory<IServicioBD> canalServidor;
        IServicioBD interfazServidor;
        
        public IniciarSesion() {
            InitializeComponent();
            IniciarServicio();
            pictureBoxCincoEnLinea.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AplicarIdioma() {
            this.Text = IniciarSesionRes.wTIniciarSesion;
            buttonEntrar.Text = IniciarSesionRes.buttonEntrar;
            label1.Text = IniciarSesionRes.contrasena;
            labelDesarrolladores.Text = IniciarSesionRes.Desarrolladores;
            labelIniciaSesion.Text = IniciarSesionRes.labIniciaSesion;
            labelNoTienesCuenta.Text = IniciarSesionRes.noCuenta;
            labelUsuario.Text = IniciarSesionRes.Usuario;
            linkLabelRegistrate.Text = IniciarSesionRes.registrar;
        }

        /// <summary>
        /// Método que se encarga de las validaciones al dar clic al bontón "Entrar" 
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
            } else {
                if (ConfirmaIngreso(textBoxNombreUsuario.Text, textBoxContrasena.Text)) {
                    WcfServicioBaseDatos.Usuario usuario = interfazServidor.RecuperarUsuario(textBoxNombreUsuario.Text);
                    Dominio.Usuario usuarioDominio = new Dominio.Usuario {
                        IdUsuario = usuario.IdUsuario,
                        NombreUsuario = usuario.NombreUsuario
                    };
                    MenuPrincipal mP = new MenuPrincipal(usuarioDominio);
                    mP.Show();
                    this.Hide();
                }
            }

        }

        /// <summary>
        /// Evento asosiado al Link "Español" que cambia el idioma del juego a español
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabelEspañol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            AplicarIdioma();
        }

        /// <summary>
        /// Evento asosiado al Link "Inglés" que cambia el idioma del juego a inglés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabelEnglish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();
        }

        /// <summary>
        /// Método que crea una ventada Registro al dar clic en el link "Regístrate"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicLabelRegistrate(object sender, LinkLabelLinkClickedEventArgs e) {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
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
            string mensaje;
            string titulo;

            try {
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

        /// <summary>
        /// Método que inicializa el canal por el que se comunicará con el servidor
        /// </summary>
        private void IniciarServicio() {
            canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
            interfazServidor = canalServidor.CreateChannel();
        }

        /// <summary>
        /// Método que comprueba que no se ingresen caracteres inapropiados(-, _, \b, ;) en el textBox del 
        /// nombre de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerificarEntrada(object sender, KeyPressEventArgs e) {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '_' && e.KeyChar != '-') {
                e.Handled = true;
                ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.IniciarSesionRes",
                  typeof(Registro).Assembly);
                ToolTip tool = new ToolTip();
                String mensaje = rm.GetString("toolTip");
                tool.Show(mensaje, textBoxNombreUsuario, 2000);
            }
           
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
