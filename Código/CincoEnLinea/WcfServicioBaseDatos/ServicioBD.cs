using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicioBaseDatos {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioBD : IServicioBD {
        private readonly Consultas consultas = new Consultas();


        public List<Usuario> RecuperarMejoresJugadores() {
            return consultas.RecuperarMejoresJugadores();
        }

        public Usuario RecuperarUsuario(string nombreUsuario) {
            return consultas.RecuperarUsuario(nombreUsuario);
        }

        public int RegistrarUsuario(string nombreUsuario, string contrasena) {
            return consultas.RegistrarUsuario(nombreUsuario, contrasena);
        }

        public int SumarPartidaEmpatada(int idUsuario) {
            return consultas.SumarPartidaEmpatada(idUsuario);
        }

        public int SumarPartidaGanada(int idUsuario) {
            return consultas.SumarPartidaGanada(idUsuario);
        }

        public int SumarPartidaPerdida(int idUsuario) {
            return consultas.SumarPartidaPerdida(idUsuario);
        }

        public Boolean ValidaContraseniaUsuario(string contraseniaUsuario) {
            return consultas.ValidaContraUsuario(contraseniaUsuario);
        }

        public Boolean ValidaNombreUsuario(string nombreUsuario) {
            return consultas.ValidaNombreUsuario(nombreUsuario);
        }
    }
}
