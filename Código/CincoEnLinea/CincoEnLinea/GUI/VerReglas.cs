
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

        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }
    }
}
