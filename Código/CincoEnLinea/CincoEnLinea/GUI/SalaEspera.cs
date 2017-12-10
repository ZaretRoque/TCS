using CincoEnLinea.Dominio;
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
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;

namespace CincoEnLinea.GUI {
    public partial class SalaEspera : Form {
        Usuario usuario;
        Socket socket;
        public SalaEspera(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
            AplicarIdioma();
            ConectarConServidor();
        }

        private void AplicarIdioma() {
            this.Text = SalaEsperaRes.wTSalaEspera;
            labelPartidasDisponibles.Text = SalaEsperaRes.labPartidasDisp;
            columnaPartida.Text = SalaEsperaRes.sala;
            columnaUsuario.Text = SalaEsperaRes.usuario;
            buttonRegresar.Text = SalaEsperaRes.bRegresar;
            buttonUnirsePartida.Text = SalaEsperaRes.bUnirse;
            buttonCrearPartida.Text = SalaEsperaRes.bCrearPartida;
        }

        /// <summary>
        /// Evento asosiado al botón Regresar, libera los recursos de esta ventana y crea una nueva de 
        /// tipo MenuPrincipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal(usuario);
            mP.Show();
        }

        private void ClickCrearPartida(object sender, EventArgs e) {
            Partida partida = new Partida();
            partida.NombreJugador1 = usuario.NombreUsuario;
            partida.UsuariosDentro = 1;
            String partidaJSON = JsonConvert.SerializeObject(partida);
            socket.Emit("nuevaPartida", partidaJSON);
        }

        private void ClickUnirsePartida(object sender, EventArgs e) {
            Partida partidaSeleccionada = listViewPartidasDisponibles.SelectedItems[0].Tag as Partida;
            partidaSeleccionada.NombreJugador2 = usuario.NombreUsuario;
            String partidaJSON = JsonConvert.SerializeObject(partidaSeleccionada);
            socket.Emit("unirsePartida", partidaJSON);
        }

        private void ConectarConServidor() {
            socket = IO.Socket("http://localhost:8000");
            socket.On(Socket.EVENT_CONNECT, () => {
                socket.On("actualizarTablaPartidas", (data) => {
                    String partidasJSON = data as String;
                    List<Partida> partidasDisponibles = JsonConvert.DeserializeObject<List<Partida>>(partidasJSON);
                    listViewPartidasDisponibles.Invoke(new Action(() => LlenarTablaPartidas(partidasDisponibles)));
                });
                socket.On("salaLlena", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    MessageBox.Show("Sala llena", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                });
                socket.On("mostrarTablero", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    MessageBox.Show("Comienza el juego", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Invoke(new Action(() => MostrarTablero(partida)));
                });

            });
        }

        private void LlenarTablaPartidas(List<Partida> partidas) {
            listViewPartidasDisponibles.Items.Clear();
            listViewPartidasDisponibles.View = View.Details;
            foreach (Partida partida in partidas) {
                ListViewItem item = listViewPartidasDisponibles.Items.Add(partida.IdPartida.ToString());
                item.SubItems.Add(partida.NombreJugador1);
                item.Tag = partida;
            }
        }

        private void MostrarTablero(Partida partida) {
            this.Dispose();
            MesaJuego tablero = new MesaJuego(usuario, partida);
            tablero.Show();
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
