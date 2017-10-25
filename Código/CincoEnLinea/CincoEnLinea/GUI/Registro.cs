using CincoEnLinea.BD;
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
            String nombreUsuario = textBoxNombreUsuario.Text;
            Consultas queries = new Consultas();
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.RegistroRes",
                    typeof(Registro).Assembly);
            string mensaje;
            string titulo;
            if (ValidarCamposLlenos()) {
                //valida que no exista un usuario con el mismo nombre en la BD
                if (!queries.ValidaNombreUsuario(nombreUsuario)) {
                    if (ValidaContrasena(textBoxContrasenia.Text, textBoxConfirmaContrasenia.Text)) {
                        queries.RegistrarUsuario(nombreUsuario, textBoxConfirmaContrasenia.Text);
                        mensaje = rm.GetString("registroExitoso");
                        titulo = rm.GetString("registroExitosoTitulo");

                        MessageBox.Show(mensaje, titulo,
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Dispose();
                    }
                    else {
                        mensaje = rm.GetString("contrasenaInvalida");
                        titulo = rm.GetString("contrasenaInvalidaTitulo");
                        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else {
                    mensaje = rm.GetString("usuarioRepetido");
                    titulo = rm.GetString("usuarioRepetidoTitulo");
                    MessageBox.Show(mensaje, titulo,
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else {
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
    }
}
