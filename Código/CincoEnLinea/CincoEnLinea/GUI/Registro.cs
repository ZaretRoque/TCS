using CincoEnLinea.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void ClicRegistrame(object sender, EventArgs e) {
            String nombreUsuario = textBoxNombreUsuario.Text;
            Consultas queries = new Consultas();

            //valida que no exista un usuario con el mismo nombre en la BD
            if(!queries.ValidaNombreUsuario(nombreUsuario)) {
                if(ValidaContrasena(textBoxContrasenia.Text, textBoxConfirmaContrasenia.Text)) {
                    queries.RegistrarUsuario(nombreUsuario, textBoxConfirmaContrasenia.Text);
                    MessageBox.Show("¡A jugar, padrino!", "Registro exitoso",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Dispose();
                }
            } else {
                MessageBox.Show("Ya hay un usuario registrado con ese nombre", "¡Qué incómodo!",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public Boolean ValidaContrasena(String contrasena, String confirmaContra) {
            if (contrasena.Equals(confirmaContra)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
