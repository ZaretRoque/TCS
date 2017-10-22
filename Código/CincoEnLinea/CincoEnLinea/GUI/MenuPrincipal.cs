using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {

    public partial class MenuPrincipal : Form {
        public MenuPrincipal() {
            InitializeComponent();
        }

        /// <summary>
        /// Método que hace invisibles todos los pictureBox de cada opción del menú principal,
        /// mientras el mouse no se pose sobre alguna opción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseSobrePanelPrincipal(object sender, MouseEventArgs e) {
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
        private void mouseSobreEntrarSala(object sender, MouseEventArgs e) {
            pictureBoxEntrarSalaDer.Visible = true;
            pictureBoxEntrarSalaIzq.Visible = true;

        }

        /// <summary>
        /// Método que hace visibles los pictureBox de mejores jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseSobreMejoresJugadores(object sender, MouseEventArgs e) {
            pictureBoxMejoresJugadoresDer.Visible = true;
            pictureBoxMejoresJugadoresIzq.Visible = true;
        }

        /// <summary>
        /// Método que hace visibles los pictureBox de ver reglas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseSobreVerReglas(object sender, MouseEventArgs e) {
            pictureBoxVerReglasDer.Visible = true;
            pictureBoxVerReglasIzq.Visible = true;
        }

        /// <summary>
        /// Método que hace visibles los pictureBox de cerrar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouseSobreCerrarSesion(object sender, MouseEventArgs e) {
            pictureBoxCerrarSesionIzq.Visible = true;
            pictureBoxCerrarSesionDer.Visible = true;
        }

        private void mouseClicMejoresJugadores(object sender, EventArgs e) {
            Mejores_jugadores mJuga = new Mejores_jugadores();
            mJuga.Show();
        }

        private void mouseClicSobreVerReglas(object sender, EventArgs e) {
            VerReglas vReglas = new VerReglas();
            vReglas.Show();
        }
    }
}
