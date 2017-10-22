using CincoEnLinea.Recursos_Internacionalización;
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
    public partial class Mejores_jugadores : Form {
        public Mejores_jugadores() {
            InitializeComponent();
        }

        private void Mejores_jugadores_Load(object sender, EventArgs e) {
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = StringResources.WindowTitleMejoresJugadores;
            bRegresarMejoresJugadores.Text = StringResources.bRegresar;
            colPosición.Text = StringResources.colPosicion;
            colUsuario.Text = StringResources.colUsuario;
            colGanadas.Text = StringResources.colGanadas;
            colPerdidas.Text = StringResources.colPerdidas;
            colEmpatadas.Text = StringResources.colEmpatadas;
        }

        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }
    }
}
