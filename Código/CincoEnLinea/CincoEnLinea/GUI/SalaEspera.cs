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
            colPartida.Text = SalaEsperaRes.sala;
            colUsuario.Text = SalaEsperaRes.usuario;
            buttonRegresar.Text = SalaEsperaRes.bRegresar;
            bUnirsePartida.Text = SalaEsperaRes.bUnirse;
            bCrearPartida.Text = SalaEsperaRes.bCrearPartida;
        }

        private void ClicRegresar(object sender, EventArgs e) {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal(usuario);
            mP.Show();
        }

        private void ClickCrearPartida(object sender, EventArgs e) {
            Partida partida = new Partida();
            partida.NombreUsuario = usuario.NombreUsuario;
            partida.UsuariosDentro = 1;
            String partidaJSON = JsonConvert.SerializeObject(partida);
            socket.Emit("nuevaSala", partidaJSON);
        }

        private void ClickUnirsePartida(object sender, EventArgs e) {
            Partida partidaSeleccionada = LVPartidasDisponibles.SelectedItems[0].Tag as Partida;
            String partidaJSON = JsonConvert.SerializeObject(partidaSeleccionada);
            socket.Emit("unirseSala", partidaJSON);
        }

        private void ConectarConServidor() {
            socket = IO.Socket("http://localhost:8000");
            socket.On(Socket.EVENT_CONNECT, () => {
                socket.On("actualizarTablaPartidas", (data) => {
                    String partidasJSON = data as String;
                    List<Partida> partidasDisponibles = JsonConvert.DeserializeObject<List<Partida>>(partidasJSON);
                    LVPartidasDisponibles.Invoke(new Action(() => LlenarTablaPartidas(partidasDisponibles)));
                });
                socket.On("salaLlena", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    MessageBox.Show("Sala llena", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                });
                socket.On("comenzarJuego", (data) => {
                    MessageBox.Show("Comienza el juego", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Invoke(new Action(() => mostrarTablero()));
                });
            });
        }

        private void LlenarTablaPartidas(List<Partida> partidas) {
            LVPartidasDisponibles.Items.Clear();
            LVPartidasDisponibles.View = View.Details;
            foreach (Partida partida in partidas) {
                ListViewItem item = LVPartidasDisponibles.Items.Add(partida.IdPartida.ToString());
                item.SubItems.Add(partida.NombreUsuario);
                item.Tag = partida;
            }
        }

        private void mostrarTablero() {
            TableroJugar tablero = new TableroJugar(usuario, socket);
            tablero.Show();
        }
    }
}
