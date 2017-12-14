using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfServicioBaseDatos;

namespace CincoEnLinea.GUI {
    public partial class MesaJuego : Form {
        PictureBox pictureBoxSeleccionado = null;
        private int turno;
        private int turnoActual;
        Crupier crupier = new Crupier();
        Dominio.Usuario usuario;
        Socket socket;
        List<PictureBox> picturesTablero = new List<PictureBox>();
        Partida partida;

        public int Turno { get => turno; set => turno = value; }
        public int TurnoActual { get => turnoActual; set => turnoActual = value; }


        public MesaJuego(Dominio.Usuario usuario, Partida partida) {
            this.usuario = usuario;
            this.partida = partida;
            InitializeComponent();
            AplicarIdioma();
            ConectarAlServidor();
            CargarListaPictureBox();
            labelNombreJugador.Text = partida.NombreJugador1;
            String partidaJSON = JsonConvert.SerializeObject(partida);
            socket.Emit("comenzarJuego", partidaJSON);
            
        }

        private void AplicarIdioma() {
            this.Text = MesaJuegoRes.tituloVentana;
            abandonaPartida.Text = MesaJuegoRes.botonAbandonaPartida;
            labelTurnoDe.Text = MesaJuegoRes.labelTurno;
        }

        /// <summary>
        /// Contiene los eventos que pueden ser invocados por el servidor
        /// </summary>
        private void ConectarAlServidor() {
            String direccionIP = ConfigurationManager.AppSettings["direccionIPServidorJuego"];
            socket = IO.Socket(direccionIP);
            socket.On(Socket.EVENT_CONNECT, () => {
                socket.On("asignarTurnos", (data) => {
                    String partidaJSON = data as String;
                    Partida partidaDominio = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    //this.Invoke(new Action(() => AsignarTurnos(partidaDominio)));
                    if (usuario.NombreUsuario.Equals(partida.NombreJugador1)) {
                        turno = 1;
                        turnoActual = 1;
                    } else {
                        turno = 2;
                    }
                });
                socket.On("pintarTiro", (data) => {
                    String jugadaJSON = data as String;
                    Jugada jugada = JsonConvert.DeserializeObject<Jugada>(jugadaJSON);
                    Crupier crup = new Crupier();
                    turnoActual = crup.RegresaTiroContrario(jugada.Turno);
                   
                    this.Invoke(new Action(() => PintarTiro(jugada)));
                    
                });
                socket.On("jugadorAbandonaPartida", (data) => {
                    String jugadaJSON = data as String;
                    Jugada jugada = JsonConvert.DeserializeObject<Jugada>(jugadaJSON);
                    this.Invoke(new Action(() => AbandonarPartida(jugada)));
                });
            });
        }

        /// <summary>
        /// Evento asociado que se lanza cuando se da clic sobre algún pictureBox del tablero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicTablero(object sender, EventArgs e) {
            if(turnoActual == turno) {
                RealizaTiro(sender);
            } else {
                ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                                    typeof(MesaJuego).Assembly);
                string mensaje = rm.GetString("mensajeNoTurno");
                string titulo = rm.GetString("tituloNoTurno");
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void RealizaTiro(object sender) {
            pictureBoxSeleccionado = sender as PictureBox;
            string nombrePicture = pictureBoxSeleccionado.Name;
            int coordenadaY = ConvierteStringEntero(nombrePicture.Substring(11, 1));
            int coordenadaX = ConvierteStringEntero(nombrePicture.Substring(12, 1));
            Jugada jugada = new Jugada {
                CoordenadaX = coordenadaX,
                CoordenadaY = coordenadaY,
                IdPartida = partida.IdPartida,
                NombrePictureBoxSeleccionado = nombrePicture,
                Turno = turno,
                TurnoActual = turnoActual
            };
            String jugadaJSON = JsonConvert.SerializeObject(jugada);
            socket.Emit("realizarTiro", jugadaJSON);
        }
       
        /// <summary>
        /// Evento asociado al botón Abandonar partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicAbandonarPartida(object sender, EventArgs e) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                   typeof(MesaJuego).Assembly);
            string mensaje = rm.GetString("confirmacionSalida");
            string titulo = rm.GetString("tituloConfirmacion");
            if (MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                Jugada jugada = new Jugada {
                    Turno = turno,
                    IdPartida = partida.IdPartida
                };
                String jugadaJSON = JsonConvert.SerializeObject(jugada);
                socket.Emit("abandonarPartida", jugadaJSON);
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

        /// <summary>
        /// Coloca una ficha en el tablero, según el jugador que la tire
        /// </summary>
        /// <param name="jugada"> Un objeto jugada que contiene las coordenadas del tiro
        /// el jugador, y el pictureBox donde se va a poner</param>
        public void PintarTiro(Jugada jugada) {
            PictureBox pulsado = BuscarPictureBoxSeleccionado(jugada.NombrePictureBoxSeleccionado);
            if (turnoActual == 1) {
                labelNombreJugador.Text = partida.NombreJugador1;
            } else {
                labelNombreJugador.Text = partida.NombreJugador2;
            }
            if (crupier.ValidarTiro(jugada.CoordenadaY, jugada.CoordenadaX)) {
                switch (jugada.Turno) {
                    case 1:
                        DibujaFichaNegra(pulsado);
                        crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                        VerificarVictoriaOEmpate(jugada);
                        break;
                    case 2:
                        DibujaFichaAzul(pulsado);
                        crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                        VerificarVictoriaOEmpate(jugada);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Una vez hecho el tiro, verifica si hay una victoria o un empate 
        /// </summary>
        /// <param name="jugada"> Objetivo tipo Jugada para comprobar el turno actual en caso de victoria</param>
        private void VerificarVictoriaOEmpate(Jugada jugada) {
            bool horizontal = crupier.ComprobarHorizontal(jugada.Turno);
            bool vertical = crupier.ComprobarVertical(jugada.Turno);
            bool diagonalPositiva = crupier.ComprobarDiagonalPositiva(jugada.Turno);
            bool diagonalNegativa = crupier.ComprobarDiagonalNegativa(jugada.Turno);
            bool empate = crupier.ComprobarEmpate();

            if (horizontal || diagonalNegativa || diagonalPositiva || vertical) {
                if (turno == jugada.TurnoActual) {
                    MostrarMensajeGanar();
                    RegistrarResultadosPartida(usuario, "partidaGanada");
                    MuestraMenuPrincipal();
                } else {
                    MostrarMensajePerder();
                    RegistrarResultadosPartida(usuario, "partidaPerdida");
                    MuestraMenuPrincipal();
                }   
            }

            if (empate) {
                MostrarMensajeEmpate();
                RegistrarResultadosPartida(usuario, "partidaEmpatada");
                MuestraMenuPrincipal();
            }
        }

        /// <summary>
        /// Convierte una cadena a un entero
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>returna el entero casteado o 0 si algo sale mal</returns>
        private int ConvierteStringEntero(string cadena) {
            try {
                return int.Parse(cadena);
            } catch(FormatException e) {
                MessageBox.Show("Error al castear", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return 0;
        }

        /// <summary>
        /// Método que devuelve la ruta abosoluta de la ejecución hasta ..\CincoEnLinea
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Muestra un mensaje al ganador del juego, para ello busca una cadena en el archivo de recursos, 
        /// esto según el idioma de la interfaz
        /// </summary>
        private void MostrarMensajeGanar() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(MesaJuego).Assembly);
            string mensaje = rm.GetString("mensajeGanar");
            string titulo = rm.GetString("tituloGanar");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Muestra un mensaje al perdedor del juego, para ello busca una cadena en el archivo de recursos,
        /// esto según el idioma de la interfaz
        /// </summary>
        private void MostrarMensajePerder() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(MesaJuego).Assembly);
            string mensaje = rm.GetString("mensajePerder");
            string titulo = rm.GetString("tituloPerder");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Muestra un mensaje cuando se produce un empate para ello busca una cadena en el archivo de recursos, 
        /// esto según el idioma de la interfaz
        /// </summary>
        private void MostrarMensajeEmpate() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(MesaJuego).Assembly);
            string mensajeEmpate = rm.GetString("mensajeEmpatar");
            string tituloEmpate = rm.GetString("tituloEmpatar");
            MessageBox.Show(mensajeEmpate, tituloEmpate, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Añade los pictureBox del tablero a una lista para hacer más fácil el manejo de los tiros en las 
        /// ventanas de los jugadores
        /// </summary>
        private void CargarListaPictureBox() {
            picturesTablero.Add(pictureBox_00);
            picturesTablero.Add(pictureBox_01);
            picturesTablero.Add(pictureBox_02);
            picturesTablero.Add(pictureBox_03);
            picturesTablero.Add(pictureBox_04);
            picturesTablero.Add(pictureBox_05);
            picturesTablero.Add(pictureBox_06);
            picturesTablero.Add(pictureBox_07);
            picturesTablero.Add(pictureBox_08);
            picturesTablero.Add(pictureBox_10);
            picturesTablero.Add(pictureBox_11);
            picturesTablero.Add(pictureBox_12);
            picturesTablero.Add(pictureBox_13);
            picturesTablero.Add(pictureBox_14);
            picturesTablero.Add(pictureBox_15);
            picturesTablero.Add(pictureBox_16);
            picturesTablero.Add(pictureBox_17);
            picturesTablero.Add(pictureBox_18);
            picturesTablero.Add(pictureBox_20);
            picturesTablero.Add(pictureBox_21);
            picturesTablero.Add(pictureBox_22);
            picturesTablero.Add(pictureBox_23);
            picturesTablero.Add(pictureBox_24);
            picturesTablero.Add(pictureBox_25);
            picturesTablero.Add(pictureBox_26);
            picturesTablero.Add(pictureBox_27);
            picturesTablero.Add(pictureBox_28);
            picturesTablero.Add(pictureBox_30);
            picturesTablero.Add(pictureBox_31);
            picturesTablero.Add(pictureBox_32);
            picturesTablero.Add(pictureBox_33);
            picturesTablero.Add(pictureBox_34);
            picturesTablero.Add(pictureBox_35);
            picturesTablero.Add(pictureBox_36);
            picturesTablero.Add(pictureBox_37);
            picturesTablero.Add(pictureBox_38);
            picturesTablero.Add(pictureBox_40);
            picturesTablero.Add(pictureBox_41);
            picturesTablero.Add(pictureBox_42);
            picturesTablero.Add(pictureBox_43);
            picturesTablero.Add(pictureBox_44);
            picturesTablero.Add(pictureBox_45);
            picturesTablero.Add(pictureBox_46);
            picturesTablero.Add(pictureBox_47);
            picturesTablero.Add(pictureBox_48);
            picturesTablero.Add(pictureBox_50);
            picturesTablero.Add(pictureBox_51);
            picturesTablero.Add(pictureBox_52);
            picturesTablero.Add(pictureBox_53);
            picturesTablero.Add(pictureBox_54);
            picturesTablero.Add(pictureBox_55);
            picturesTablero.Add(pictureBox_56);
            picturesTablero.Add(pictureBox_57);
            picturesTablero.Add(pictureBox_58);
            picturesTablero.Add(pictureBox_60);
            picturesTablero.Add(pictureBox_61);
            picturesTablero.Add(pictureBox_62);
            picturesTablero.Add(pictureBox_63);
            picturesTablero.Add(pictureBox_64);
            picturesTablero.Add(pictureBox_65);
            picturesTablero.Add(pictureBox_66);
            picturesTablero.Add(pictureBox_67);
            picturesTablero.Add(pictureBox_68);
            picturesTablero.Add(pictureBox_70);
            picturesTablero.Add(pictureBox_71);
            picturesTablero.Add(pictureBox_72);
            picturesTablero.Add(pictureBox_73);
            picturesTablero.Add(pictureBox_74);
            picturesTablero.Add(pictureBox_75);
            picturesTablero.Add(pictureBox_76);
            picturesTablero.Add(pictureBox_77);
            picturesTablero.Add(pictureBox_78);
            picturesTablero.Add(pictureBox_80);
            picturesTablero.Add(pictureBox_81);
            picturesTablero.Add(pictureBox_82);
            picturesTablero.Add(pictureBox_83);
            picturesTablero.Add(pictureBox_84);
            picturesTablero.Add(pictureBox_85);
            picturesTablero.Add(pictureBox_86);
            picturesTablero.Add(pictureBox_87);
            picturesTablero.Add(pictureBox_88);
        }

        /// <summary>
        /// Busca un pictureBox en la lista de los que están en el tablero, útil para manejar los tiros en las ventanas de los
        /// jugadores
        /// </summary>
        /// <param name="nombrePictureBoxSeleccionado">Un String con el nombre del pictureBox a buscar</param>
        /// <returns>Un pictureBox dentro del tablero</returns>
        private PictureBox BuscarPictureBoxSeleccionado(String nombrePictureBoxSeleccionado) {
            PictureBox encontrado = new PictureBox();
            for(int i = 0; i<picturesTablero.Count; i++) {
                String nombrePictureBox = picturesTablero[i].Name;
                Console.WriteLine(nombrePictureBox);
                if (nombrePictureBoxSeleccionado.Equals(nombrePictureBox)) {
                    encontrado = picturesTablero[i];
                    Console.WriteLine("encontrado");
                }
            }
            return encontrado;
        }

        /// <summary>
        /// Método que libera los recursos de la ventana actual y crea una nueva de tipo MenuPrincipal
        /// </summary>
        public void MuestraMenuPrincipal() {
            this.Dispose();
            MenuPrincipal mP = new MenuPrincipal(usuario);
            mP.Show();
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// Se encarga de registrar en la base de datos los resultados de cada partida. Se comunica con el servicio WCF
        /// </summary>
        /// <param name="usuario"> Objeto Usuario al que se registrará el resultado de la partida</param>
        /// <param name="operacionSolicitada"> String especificando lo que será registrado, partidaGanada, partidaPerdida,
        /// partidaEmpatada. </param>
        private void RegistrarResultadosPartida(Dominio.Usuario usuario, String operacionSolicitada) {
            ChannelFactory<IServicioBD> canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
            IServicioBD interfazServidor = canalServidor.CreateChannel();
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.IniciarSesionRes",
                    typeof(IniciarSesion).Assembly);
            string mensaje;
            string titulo;
            try {
                switch (operacionSolicitada) {
                    case "partidaGanada":
                        interfazServidor.SumarPartidaGanada(usuario.IdUsuario);
                        break;
                    case "partidaPerdida":
                        interfazServidor.SumarPartidaPerdida(usuario.IdUsuario);
                        break;
                    case "partidaEmpatada":
                        interfazServidor.SumarPartidaEmpatada(usuario.IdUsuario);
                        break;
                    default:
                        break;
                }
            } catch(MySql.Data.MySqlClient.MySqlException e) {
                
                mensaje = rm.GetString("excepcionBD");
                titulo = rm.GetString("tituloExcepcionBD");
                MessageBox.Show(mensaje, titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch(FaultException e) {
                mensaje = rm.GetString("excepcionServicioWcf");
                titulo = rm.GetString("tituloExcepcionWcf");
                MessageBox.Show(mensaje, titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Asigna los turnos a los jugadores
        /// </summary>
        /// <param name="partida">Un objeto partida, que representa la partida
        /// a la que están unidos</param>
        private void AsignarTurnos(Partida partida) {
            if (usuario.NombreUsuario.Equals(partida.NombreJugador1)) {
                turno = 1;
                turnoActual = 1;
            } else {
                turno = 2;
            }
        }

        private void AbandonarPartida(Jugada jugada) {
            if(jugada.Turno == turno) {
                RegistrarResultadosPartida(usuario, "partidaPerdida");
                this.Dispose();
                MuestraMenuPrincipal();
            } else {
                RegistrarResultadosPartida(usuario, "partidaGanada");
                this.Dispose();
                MuestraMenuPrincipal();
            }

            
        }
    }
}
