using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    public class Partida {
        private int idPartida;
        private String nombreJugador1;
        private String nombreJugador2;
        private int usuariosDentro;

        public Partida() { }

        public int IdPartida { get => idPartida; set => idPartida = value; }
        public int UsuariosDentro { get => usuariosDentro; set => usuariosDentro = value; }
        public string NombreJugador2 { get => nombreJugador2; set => nombreJugador2 = value; }
        public string NombreJugador1 { get => nombreJugador1; set => nombreJugador1 = value; }
    }
}
