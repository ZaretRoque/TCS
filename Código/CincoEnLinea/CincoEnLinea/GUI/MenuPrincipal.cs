using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {

    public partial class MenuPrincipal : Form {
        Usuario usuario;
        public MenuPrincipal(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
            AplicarIdioma();
        }

        public void AplicarIdioma() {
            this.Text = MenuPrincipalRes.wTMenuPrincipal;
            labelMenu.Text = MenuPrincipalRes.labMenu;
            labelEntrarSala.Text = MenuPrincipalRes.sala;
            labelMejoresJugadores.Text = MenuPrincipalRes.mejoresJugadores;
            labelVerReglas.Text = MenuPrincipalRes.reglas;
            labelCerrarSesion.Text = MenuPrincipalRes.cerrarSesion;
        }

        /// <summary>
        /// Método que hace invisibles todos los pictureBox de cada opción del menú principal,
        /// mientras el mouse no se pose sobre alguna opción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseSobrePanelPrincipal(object sender, MouseEventArgs e) {
            pictureBoxEntrarSalaDer.Visible = false;
            pictureBoxEntrarSalaIzq.Visible = false;
            pictureBoxMejoresJugadoresDer.Visible = false;
            pictureBoxMejoresJugadoresIzq.Visible = false;
            pictureBoxVerReglasDer.Visible = false;
            pictureBoxVerReglasIzq.Visible = false;
            pictureBoxCerrarSesionIzq.Visible = false;
            pictureBoxCerrarSesionDer.Visible = false;
        }

        /// <summary>
        /// Método que hace visibles los pictureBox de entrar a sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseSobreEntrarSala(object sender, MouseEventArgs e) {
            pictureBoxEntrarSalaDer.Visible = true;
            pictureBoxEntrarSalaIzq.Visible = true;

        }

        /// <summary>
        /// Método que hace visibles los pictureBox de mejores jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseSobreMejoresJugadores(object sender, MouseEventArgs e) {
            pictureBoxMejoresJugadoresDer.Visible = true;
            pictureBoxMejoresJugadoresIzq.Visible = true;
        }

        /// <summary>
        /// Método que hace visibles los pictureBox de ver reglas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseSobreVerReglas(object sender, MouseEventArgs e) {
            pictureBoxVerReglasDer.Visible = true;
            pictureBoxVerReglasIzq.Visible = true;
        }

        /// <summary>
        /// Método que hace visibles los pictureBox de cerrar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseSobreCerrarSesion(object sender, MouseEventArgs e) {
            pictureBoxCerrarSesionIzq.Visible = true;
            pictureBoxCerrarSesionDer.Visible = true;
        }

        /// <summary>
        /// Método que libera los recursos de la ventana actual y crea una de tipo MejoresJugadores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseClicMejoresJugadores(object sender, EventArgs e) {
            this.Dispose();
            MejoresJugadores mJuga = new MejoresJugadores(usuario);
            mJuga.Show();
        }

        /// <summary>
        /// Método que libera los recursos de la ventana actual y crea una de tipo VerReglas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseClicSobreVerReglas(object sender, EventArgs e) {
            this.Dispose();
            VerReglas vReglas = new VerReglas(usuario);
            vReglas.Show();
        }

        /// <summary>
        /// Método que libera los recursos de la ventana actual y crea una de tipo SalaEspera 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicEntrarSala(object sender, EventArgs e) {
            this.Dispose();
            SalaEspera sE = new SalaEspera(usuario);
            sE.Show();
        }

        /// <summary>
        /// Método que libera los recursos solo si el usuario da clic en 'Si' al mensaje de confirmación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicSalir(object sender, EventArgs e) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MenuPrincipalRes",
                   typeof(MenuPrincipal).Assembly);
            string mensaje = rm.GetString("confirmacionSalida");
            string titulo = rm.GetString("tituloConfirmacion");
            if (MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
