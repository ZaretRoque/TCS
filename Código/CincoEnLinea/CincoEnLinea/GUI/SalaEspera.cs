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
    public partial class SalaEspera : Form {
        public SalaEspera() {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = SalaEsperaRes.wTSalaEspera;
            labelPartidasDisponibles.Text = SalaEsperaRes.labPartidasDisp;
            coUsuario.Text = SalaEsperaRes.usuario;
            coPartidasGa.Text = SalaEsperaRes.ganadas;
            coPartidasPer.Text = SalaEsperaRes.perdidas;
            buttonRegresar.Text = SalaEsperaRes.bRegresar;
            bUnirsePartida.Text = SalaEsperaRes.bUnirse;
            bCrearPartida.Text = SalaEsperaRes.bCrearPartida;
        }

        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }
    }
}
