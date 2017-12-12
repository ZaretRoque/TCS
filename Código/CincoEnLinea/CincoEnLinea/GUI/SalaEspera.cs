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
using System.Configuration;
using System.Resources;

namespace CincoEnLinea.GUI {
    public partial class SalaEspera : Form {
        private Usuario usuario;
        private Socket socket;
        private bool partidaCreada = false;
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
            String usuarioJSON = JsonConvert.SerializeObject(usuario);
            socket.Emit("eliminarPartida", usuarioJSON);
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal(usuario);
            mP.Show();
        }

        private void ClickCrearPartida(object sender, EventArgs e) {
            if (!partidaCreada) {
                Partida partida = new Partida();
                partida.NombreJugador1 = usuario.NombreUsuario;
                partida.UsuariosDentro = 1;
                String partidaJSON = JsonConvert.SerializeObject(partida);
                socket.Emit("nuevaPartida", partidaJSON);
                partidaCreada = true;
            } else {
                MostrarMensajePartidaExistente();
            }
        }

        private void ClickUnirsePartida(object sender, EventArgs e) {
            if (listViewPartidasDisponibles.SelectedIndices.Count > 0) {
                Partida partidaSeleccionada = listViewPartidasDisponibles.SelectedItems[0].Tag as Partida;
                partidaSeleccionada.NombreJugador2 = usuario.NombreUsuario;
                String usuarioJSON = JsonConvert.SerializeObject(usuario);
                String partidaJSON = JsonConvert.SerializeObject(partidaSeleccionada);
                socket.Emit("eliminarPartida", usuarioJSON);
                if(!partidaSeleccionada.NombreJugador1.Equals(usuario.NombreUsuario)) {
                    socket.Emit("unirsePartida", partidaJSON);
                } else {
                    ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.SalaEsperaRes",
                    typeof(SalaEspera).Assembly);
                    string mensaje = rm.GetString("mensajeUnirseMismaPartida");
                    string titulo = rm.GetString("tituloUnirseMismaPartida");
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            } else {
                MostrarMensajeSeleccion();
            }
        }

        private void ConectarConServidor() {
            String direccionIP = ConfigurationManager.AppSettings["direccionIPServidorSalas"];
            socket = IO.Socket(direccionIP);
            socket.On(Socket.EVENT_CONNECT, () => {
                socket.On("actualizarTablaPartidas", (data) => {
                    String partidasJSON = data as String;
                    List<Partida> partidasDisponibles = JsonConvert.DeserializeObject<List<Partida>>(partidasJSON);
                    try {
                        listViewPartidasDisponibles.Invoke(new Action(() => LlenarTablaPartidas(partidasDisponibles)));
                    } catch(InvalidOperationException e) {
                       string excepcion =  e.StackTrace;
                    }
                });
                socket.On("salaLlena", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    MessageBox.Show("Sala llena", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                });
                socket.On("mostrarTablero", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.SalaEsperaRes",
                   typeof(SalaEspera).Assembly);
                    string mensaje = rm.GetString("mensajeComenzarPartida");
                    string titulo = rm.GetString("tituloComenzarPartida");
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void MostrarMensajeSeleccion() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.SalaEsperaRes",
                    typeof(SalaEspera).Assembly);
            string mensaje = rm.GetString("mensajeUnirsePartida");
            string titulo = rm.GetString("tituloUnirsePartida");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void MostrarMensajePartidaExistente() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.SalaEsperaRes",
                    typeof(SalaEspera).Assembly);
            string mensaje = rm.GetString("mensajeCrearPartida");
            string titulo = rm.GetString("tituloUnirsePartida");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
