using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    [Serializable]
    class Usuario {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasena;

        public Usuario() { }

        public Usuario(int idUsuario, string nombreUsuario, string contrasena) {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        
    }
}
