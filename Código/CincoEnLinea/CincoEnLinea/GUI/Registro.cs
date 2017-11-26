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

namespace CincoEnLinea
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = RegistroRes.wTRegistro;
            labelRegistrarNuevoUsuario.Text = RegistroRes.labComienzaJugar;
            labelNombreUsuarioRegistro.Text = RegistroRes.nombreUsuario;
            labelContraseniaRegistro.Text = RegistroRes.contrasena;
            labelRepiteContrasenia.Text = RegistroRes.confirmaContrasena;
            buttonRegistrame.Text = RegistroRes.bRegistro;
        }

        private void ClicRegistrame(object sender, EventArgs e) {
            
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.RegistroRes",
                    typeof(Registro).Assembly);
            String nombreUsuario = textBoxNombreUsuario.Text;
            string mensaje;
            string titulo;
            ChannelFactory<IServicioBD> canalServidor;
            IServicioBD interfazServidor;

            if (ValidarCamposLlenos()) {
                try {
                    canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
                    interfazServidor = canalServidor.CreateChannel();
                    
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

        public Boolean ValidaContrasena(String contrasena, String confirmaContra) {
            if (contrasena.Equals(confirmaContra)) {
                return true;
            } else {
                return false;
            }
        }

        private Boolean ValidarCamposLlenos() {
            string contrasena = textBoxContrasenia.Text;
            string contrasenaConfirmada = textBoxConfirmaContrasenia.Text;
            string nombreUsuario = textBoxNombreUsuario.Text;

            if(contrasena.Length >0 && contrasenaConfirmada.Length >0 && nombreUsuario.Length > 0) {
                return true;
            }
            else {
                return false;
            }
        }

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
    }
}
