using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WcfServicioBaseDatos;

namespace CincoEnLinea {
    public partial class Registro : Form {
        ChannelFactory<IServicioBD> canalServidor;
        IServicioBD interfazServidor;

        public Registro() {
            InitializeComponent();
            AplicarIdioma();
            IniciarServicio();
        }

        private void AplicarIdioma() {
            this.Text = RegistroRes.wTRegistro;
            labelRegistrarNuevoUsuario.Text = RegistroRes.labComienzaJugar;
            labelNombreUsuarioRegistro.Text = RegistroRes.nombreUsuario;
            labelContraseniaRegistro.Text = RegistroRes.contrasena;
            labelRepiteContrasenia.Text = RegistroRes.confirmaContrasena;
            buttonRegistrame.Text = RegistroRes.bRegistro;
            buttonRegresar.Text = RegistroRes.bRegresar;
        }

        /// <summary>
        /// Método que valida el registro de un nuevo usuario, comprobando que no existan campos vacíos, 
        /// que las contraseñas coincidan y que los caracteres sean validos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicRegistrame(object sender, EventArgs e) {   
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.RegistroRes",
                    typeof(Registro).Assembly);
            String nombreUsuario = textBoxNombreUsuario.Text;
            string mensaje;
            string titulo;

            if (ValidarCamposLlenos()) {
                try {
                    //valida que no exista un usuario con el mismo nombre en la BD
                    if (!interfazServidor.ValidaNombreUsuario(nombreUsuario)) {
                        if (ValidaContrasena(textBoxContrasenia.Text, textBoxConfirmaContrasenia.Text)) {
                            interfazServidor.RegistrarUsuario(nombreUsuario, textBoxConfirmaContrasenia.Text);
                            mensaje = rm.GetString("registroExitoso");
                            titulo = rm.GetString("registroExitosoTitulo");

                            MessageBox.Show(mensaje, titulo,
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Dispose();
                            //se puede crear un objeto Iniciar sesión
                            Application.Restart();
                        } else {
                            mensaje = rm.GetString("contrasenaInvalida");
                            titulo = rm.GetString("contrasenaInvalidaTitulo");
                            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    } else {
                        mensaje = rm.GetString("usuarioRepetido");
                        titulo = rm.GetString("usuarioRepetidoTitulo");
                        MessageBox.Show(mensaje, titulo,
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    mensaje = rm.GetString("excepcionBD");
                    titulo = rm.GetString("tituloExcepcionBD");
                    MessageBox.Show(mensaje, titulo,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                } catch (System.ServiceModel.FaultException ex) {
                    mensaje = rm.GetString("excepcionServicioWcf");
                    titulo = rm.GetString("tituloExcepcionWcf");
                    MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            } else {
                mensaje = rm.GetString("camposVacios");
                titulo = rm.GetString("camposVaciosTitulo");
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Método que valida que las contraseñas ingresadas seas iguales
        /// </summary>
        /// <param name="contrasena"></param>
        /// <param name="confirmaContra"></param>
        /// <returns></returns>
        public Boolean ValidaContrasena(String contrasena, String confirmaContra) {
            if (contrasena.Equals(confirmaContra)) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Método que valida que los campos en los textBox Contraseña, ConfirmarContraseña y 
        /// NombreUsuario no estén vacíos
        /// </summary>
        /// <returns></returns>
        private Boolean ValidarCamposLlenos() {
            string contrasena = textBoxContrasenia.Text;
            string contrasenaConfirmada = textBoxConfirmaContrasenia.Text;
            string nombreUsuario = textBoxNombreUsuario.Text;

            if(contrasena.Length >0 && contrasenaConfirmada.Length >0 && nombreUsuario.Length > 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Método que inicializa el canal por el que se comunicará con el servidor
        /// </summary>
        private void IniciarServicio() {
            canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
            interfazServidor = canalServidor.CreateChannel();
        }

        /// <summary>
        /// Valida que los caracteres en el nombreUsuario sean válidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerificarEntrada(object sender, KeyPressEventArgs e) {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '_' && e.KeyChar != '-') {
                e.Handled = true;
                ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.RegistroRes",
                    typeof(Registro).Assembly);
                ToolTip tool = new ToolTip();
                String mensaje = rm.GetString("toolTip");
                tool.Show(mensaje, textBoxNombreUsuario, 2000);
            }
        }

        /// <summary>
        /// Evento que se produce cuando el usuario da clic en en regresar liberando los recursos de 
        /// este ventana y haciendo un Restar() en la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            Application.Restart();
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
