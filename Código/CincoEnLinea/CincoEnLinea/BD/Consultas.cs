using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using CincoEnLinea.Dominio;

namespace CincoEnLinea.BD {
    
    class Consultas {

        private string conexionBD;

        public Consultas() {
            conexionBD = GetConnectionStringByName("ConexionBD");
        }

        /* Este método obtiene el string de conexión que se encuentra en el archivo
         * de configuración del proyecto*/
        private static string GetConnectionStringByName(string name) {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        public int RegistrarUsuario(string nombreUsuario, string contrasena) {
            int filasAfectadas = 0; //si es igual a 0 la inserción no salió bien
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Insert into usuario (nombreUsuario, contrasena) " +
                "values(@nombreUsuario, SHA2(@contrasena, 256))";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);
            filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }

        public Usuario RecuperarUsuario(string nombreUsuario) {
            Usuario usuario = new Usuario();
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Select idUsuario, nombreUsuario, contrasena " +
                "from usuario where nombreUsuario = @nombreUsuario";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.HasRows && reader.Read()) {
                usuario.NombreUsuario = reader.GetString("nombreUsuario");
            }
            return usuario;
        }

        public List<Usuario> RecuperarMejoresJugadores() {
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "select nombreUsuario, partidasGanadas, partidasEmpatadas, " +
                "partidasEmpatadas from usuario natural join EstadisticasUsuario order by " +
                "partidasGanadas";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Usuario> usuarios = new List<Usuario>();
            while(reader.HasRows && reader.Read()) {
                Usuario usuario = new Usuario();
                usuario.NombreUsuario = reader.GetString("nombreUsuario");
                usuario.PartidasGanadas = reader.GetInt32("partidasGanadas");
                usuario.PartidasEmpatadas = reader.GetInt32("partidasEmpatadas");
                usuario.PartidasPerdidas = reader.GetInt32("partidasPerdidas");
                usuarios.Add(usuario);
            }
            return usuarios;
        }


    }
}
