using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    public class Jugada {

        private int coordenadaX;
        private int coordenadaY;
        private String nombrePictureBoxSeleccionado;
        private int idPartida;
        private int turno;

        public Jugada() {
        }

        public int CoordenadaX { get => coordenadaX; set => coordenadaX = value; }
        public int CoordenadaY { get => coordenadaY; set => coordenadaY = value; }
        public string NombrePictureBoxSeleccionado { get => nombrePictureBoxSeleccionado; set => nombrePictureBoxSeleccionado = value; }
        public int IdPartida { get => idPartida; set => idPartida = value; }
        public int Turno { get => turno; set => turno = value; }
    }
}
