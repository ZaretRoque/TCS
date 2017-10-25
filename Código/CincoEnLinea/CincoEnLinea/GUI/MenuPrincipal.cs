using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {

    public partial class MenuPrincipal : Form {
        public MenuPrincipal() {
            InitializeComponent();
            AplicarIdioma();
            /* Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            AplicarIdioma();*/
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

        private void MouseClicMejoresJugadores(object sender, EventArgs e) {
            this.Dispose();
            Mejores_jugadores mJuga = new Mejores_jugadores();
            mJuga.Show();
        }

        private void MouseClicSobreVerReglas(object sender, EventArgs e) {
            this.Dispose();
            VerReglas vReglas = new VerReglas();
            vReglas.Show();
        }

        private void ClicEntrarSala(object sender, EventArgs e) {
            this.Dispose();
            SalaEspera sE = new SalaEspera();
            sE.Show();
        }

        private void ClicSalir(object sender, EventArgs e) {
            this.Dispose();
        }

        public void AplicarIdioma() {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            this.Text = MenuPrincipalRes.wTMenuPrincipal;
            labelMenu.Text = MenuPrincipalRes.labMenu;
            labelEntrarSala.Text = MenuPrincipalRes.sala;
            labelMejoresJugadores.Text = MenuPrincipalRes.mejoresJugadores;
            labelVerReglas.Text = MenuPrincipalRes.reglas;
            labelCerrarSesion.Text = MenuPrincipalRes.cerrarSesion;
        }
    }
}
