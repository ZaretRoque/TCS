using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {
    public partial class MesaJuego : Form {
        PictureBox pictureBoxSeleccionado = null;
        private int turno;
        Crupier crupier = new Crupier();
        Usuario usuario;
        Socket socket;
        List<PictureBox> picturesTablero = new List<PictureBox>();
        int tiempoRestante;
        Partida partida;

        public int Turno { get => turno; set => turno = value; }

        public MesaJuego(Usuario usuario, Partida partida) {
            this.usuario = usuario;
            this.partida = partida;
            InitializeComponent();
            AplicarIdioma();
            ConectarAlServidor();
            CargarListaPictureBox();
            String partidaJSON = JsonConvert.SerializeObject(partida);
            socket.Emit("comenzarJuego", partidaJSON);
            
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

        /// <summary>
        /// Contiene los eventos que pueden ser invocados por el servidor
        /// </summary>
        private void ConectarAlServidor() {
            socket = IO.Socket("http://192.168.43.72:9000");
            socket.On(Socket.EVENT_CONNECT, () => {
                socket.On("asignarTurnos", (data) => {
                    String partidaJSON = data as String;
                    Partida partida = JsonConvert.DeserializeObject<Partida>(partidaJSON);
                    if (usuario.NombreUsuario.Equals(partida.NombreJugador1)) {
                        turno = 1;
                    } else {
                        turno = 2;
                    }
                    Console.WriteLine("Turno asignado: " + turno);
                });
                socket.On("pintarTiro", (data) => {
                    String jugadaJSON = data as String;
                    Jugada jugada = JsonConvert.DeserializeObject<Jugada>(jugadaJSON);
                    //PictureBox pulsado = BuscarPictureBoxSeleccionado(jugada.NombrePictureBoxSeleccionado);

                    this.Invoke(new Action(() => PintarTiro(jugada)));
                });
            });
        }

        /// <summary>
        /// Evento asociado que se lanza cuando se da clic sobre algún pictureBox del tablero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicTablero(object sender, EventArgs e) {
            pictureBoxSeleccionado = sender as PictureBox;
            string nombrePicture = pictureBoxSeleccionado.Name;
            int coordenadaY = ConvierteStringEntero(nombrePicture.Substring(11, 1));
            int coordenadaX = ConvierteStringEntero(nombrePicture.Substring(12, 1));
            Jugada jugada = new Jugada {
                CoordenadaX = coordenadaX,
                CoordenadaY = coordenadaY,
                IdPartida = partida.IdPartida,
                NombrePictureBoxSeleccionado = nombrePicture,
                Turno = turno
            };
            String jugadaJSON = JsonConvert.SerializeObject(jugada);
            socket.Emit("realizarTiro", jugadaJSON);
            //PintarTiro(coordenadaY, coordenadaX, pictureBoxSeleccionado);
        }

       
        /// <summary>
        /// Evento asociado al botón Abandonar partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Coloca una ficha en el tablero, según el jugador que la tire
        /// </summary>
        /// <param name="jugada"> Un objeto jugada que contiene las coordenadas del tiro
        /// el jugador, y el pictureBox donde se va a poner</param>
        public void PintarTiro(Jugada jugada) {
            PictureBox pulsado = BuscarPictureBoxSeleccionado(jugada.NombrePictureBoxSeleccionado);
            if (crupier.ValidarTiro(jugada.CoordenadaY, jugada.CoordenadaX)) {
                switch (jugada.Turno) {
                    case 1:
                        DibujaFichaNegra(pulsado);
                        crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                        VerificarVictoriaOEmpate(jugada.Turno);
                        break;
                    case 2:
                        DibujaFichaAzul(pulsado);
                        crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                        VerificarVictoriaOEmpate(jugada.Turno);
                        break;
                    default:
                        break;
                }
                /*if (jugada.Turno) {
                    DibujaFichaNegra(pulsado);
                    crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                    VerificarVictoriaOEmpate(jugada.Turno);
                   // crupier.Turno = 2;
                    //turno = 2;
                } else {
                    DibujaFichaAzul(pulsado);
                    crupier.GuardarTiro(jugada.CoordenadaY, jugada.CoordenadaX, jugada.Turno);
                    VerificarVictoriaOEmpate(jugada.Turno);
                    //crupier.Turno = 1;
                   // turno = 1;
                }
                //pulsado.Enabled = false;*/
            }
        }

        /// <summary>
        /// Una vez hecho el tiro, verifica si hay una victoria o un empate 
        /// </summary>
        /// <param name="turno"> Un entero que representa al jugador que realiza el tiro</param>
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

        /// <summary>
        /// Muestra un mensaje al ganador del juego, para ello busca una cadena en el archivo de recursos, 
        /// esto según el idioma de la interfaz
        /// </summary>
        private void MostrarMensajeGanar() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(TableroJugar).Assembly);
            string mensaje = rm.GetString("mensajeGanar");
            string titulo = rm.GetString("tituloGanar");
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Muestra un mensaje cuando se produce un empate para ello busca una cadena en el archivo de recursos, 
        /// esto según el idioma de la interfaz
        /// </summary>
        private void MostrarMensajeEmpate() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MesaJuegoRes",
                    typeof(TableroJugar).Assembly);
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
        /// Lleva el control del tiempo restante para hacer el tiro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlarTiempo(object sender, EventArgs e) {
            if (tiempoRestante > 0) {
                tiempoRestante--;
                labelTiempoRestante.Text = tiempoRestante + " s";
            } else {
                timer1.Stop();
                labelTiempoRestante.Text = "00 s";

            }
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
        

    }
}
