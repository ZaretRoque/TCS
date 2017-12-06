using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {
    public partial class MesaJuego : Form {
        PictureBox pictureSeleccionado = null;
        private int turno = 1;
        Crupier crupier = new Crupier();
        Usuario usuario;
        Socket socket;

        public MesaJuego(Usuario usuario, Socket socket) {
            this.socket = socket;
            this.usuario = usuario;
            InitializeComponent();
            AplicarIdioma();
        }

        //Se debe quitar
        public MesaJuego() {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = MesaJuegoRes.tituloVentana;
            abandonaPartida.Text = MesaJuegoRes.botonAbandonaPartida;
        }

        private void ClicTablero(object sender, EventArgs e) {
            pictureSeleccionado = sender as PictureBox;
            string nombrePicture = pictureSeleccionado.Name;
            int coordenadaY = ConvierteStringEntero(nombrePicture.Substring(11, 1));
            int coordenadaX = ConvierteStringEntero(nombrePicture.Substring(12, 1));
            PintarTiro(coordenadaY, coordenadaX, pictureSeleccionado);
        }

       

        private void ClicAbandonarPartida(object sender, EventArgs e) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                   typeof(TableroJugar).Assembly);
            string mensaje = rm.GetString("confirmacionSalida");
            string titulo = rm.GetString("tituloConfirmacion");
            if (MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                this.Dispose();
            }
        }

        public void DibujaFichaNegra(PictureBox pictureSeleccionado) {
            string rutaImagen = DevuelveRuta() + "\\Resources\\fichaNegra.png";
            pictureSeleccionado.Image = Image.FromFile(rutaImagen);
            pictureSeleccionado.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void DibujaFichaAzul(PictureBox pictureSeleccionado) {
            string rutaImagen = DevuelveRuta() + "\\Resources\\fichaAzul.png";
            pictureSeleccionado.Image = Image.FromFile(rutaImagen);
            pictureSeleccionado.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void PintarTiro(int posY, int posX, PictureBox pulsado) {

            if (crupier.ValidarTiro(posY, posX)) {
                if (turno == 1) {
                    DibujaFichaNegra(pulsado);
                    crupier.GuardarTiro(posY, posX, 1);
                    VerificarVictoriaOEmpate(turno);
                    crupier.Turno = 2;
                    turno = 2;
                } else {
                    DibujaFichaAzul(pulsado);
                    crupier.GuardarTiro(posY, posX, 2);
                    VerificarVictoriaOEmpate(turno);
                    crupier.Turno = 1;
                    turno = 1;
                }
                pulsado.Enabled = false;
            }
        }

        private void VerificarVictoriaOEmpate(int turno) {
            bool horizontal = crupier.ComprobarHorizontal(turno);
            bool vertical = crupier.ComprobarVertical(turno);
            bool diagonalPositiva = crupier.ComprobarDiagonalPositiva(turno);
            bool diagonalNegativa = crupier.ComprobarDiagonalNegativa(turno);
            bool empate = crupier.ComprobarEmpate();

            if (horizontal || diagonalNegativa || diagonalPositiva || vertical) {
                MostrarMensajeGanar();
            }

            if (empate) {
                MostrarMensajeEmpate();
            }
        }

        private int ConvierteStringEntero(string cadena) {
            return int.Parse(cadena);
        }

        public string DevuelveRuta() {
            string ruta = null;
            ruta = Application.StartupPath;
            int contador = 0;
            for (int i = ruta.Length - 1; i > 0; i--) {
                if (ruta.Substring(i, 1) == ("\\")) {
                    contador++;
                    if (contador == 2) {
                        return ruta.Substring(0, i);
                    }
                }
            }
            return ruta;
        }
        private void MostrarMensajeGanar() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(TableroJugar).Assembly);
            string mensaje = rm.GetString("mensajeGanar");
            string titulo = rm.GetString("tituloGanar");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void MostrarMensajeEmpate() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(TableroJugar).Assembly);
            string mensajeEmpate = rm.GetString("mensajeEmpatar");
            string tituloEmpate = rm.GetString("tituloEmpatar");
            MessageBox.Show(mensajeEmpate, tituloEmpate, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
