using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicioBaseDatos {

    [ServiceContract]
    public interface IServicioBD {

        [OperationContract]
        int RegistrarUsuario(string nombreUsuario, string contrasena);

        [OperationContract]
        Usuario RecuperarUsuario(string nombreUsuario);

        [OperationContract]
        List<Usuario> RecuperarMejoresJugadores();

        [OperationContract]
        Boolean ValidaNombreUsuario(string nombreUsuario);

        [OperationContract]
        Boolean ValidaContraseniaUsuario(string contraseniaUsuario);

        [OperationContract]
        int SumarPartidaGanada(int idUsuario);

        [OperationContract]
        int SumarPartidaPerdida(int idUsuario);

        [OperationContract]
        int SumarPartidaEmpatada(int idUsuario);

    }

    [DataContract]
    public class Usuario {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasena;
        private int partidasGanadas;
        private int partidasPerdidas;
        private int partidasEmpatadas;

        public Usuario() { }

        public Usuario(int idUsuario, string nombreUsuario, string contrasena) {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
        }

        [DataMember]
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        [DataMember]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        [DataMember]
        public string Contrasena { get => contrasena; set => contrasena = value; }
        [DataMember]
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        [DataMember]
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        [DataMember]
        public int PartidasEmpatadas { get => partidasEmpatadas; set => partidasEmpatadas = value; }


    }
}
