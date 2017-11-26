using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    public class Partida {
        private int idPartida;
        private String nombreUsuario;
        private int usuariosDentro;

        public Partida() { }

        public int IdPartida { get => idPartida; set => idPartida = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int UsuariosDentro { get => usuariosDentro; set => usuariosDentro = value; }
    }
}
