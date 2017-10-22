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
    public partial class IniciarSesion : Form {
        public IniciarSesion() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        /// <summary>
        /// Método que contiene la acción al dar clic al bontón "Entrar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clicEntrar(object sender, EventArgs e) {
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }

        private void mouseClicRegistrate(object sender, MouseEventArgs e) {
            Registro registro = new Registro();
            registro.Show();
        }
    }
}
