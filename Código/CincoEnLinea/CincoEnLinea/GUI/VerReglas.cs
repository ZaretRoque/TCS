
using CincoEnLinea.RecursosInternacionalizacion;
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
    public partial class VerReglas : Form {
        public VerReglas() {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = ReglasRes.wTReglas;
            labelReglasTitulo.Text = ReglasRes.labReglas;
            buttonRegresarVerReglas.Text = ReglasRes.bRegresar;
            labelContenidoReglas.Text = ReglasRes.reglas;
        }

        /// <summary>
        /// Evento asosiado al botón Regresar, libera los recursos de esta ventana y crea una nueva de 
        /// tipo MenuPrincipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
