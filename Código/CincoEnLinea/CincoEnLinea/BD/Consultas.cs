using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using CincoEnLinea.Dominio;

namespace CincoEnLinea.BD {
    
    public class Consultas {

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
        /// <summary>
        /// Método que realiza el registro de un nuevo usuario en la base de datos
        /// Puede lanzar una excepción MySQLException si algo sale mal durante el intento
        /// de conexión
        /// </summary>
        /// <param name="nombreUsuario"> El nombre de usuario a registrar</param>
        /// <param name="contrasena">La contraseña para el usuario, esta contraseña se
        /// almacena usando el método SHA2</param>
        /// <returns>
        /// Un entero indicando el número de filas afectadas por la inserción,
        /// dicho entero será mayor a 0 si y solo si la inserción fue correcta</returns>
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
        /// <summary>
        /// Recupera un usuario dado su nombre. Puede lanzar una MySqlException si algo sale mal
        /// </summary>
        /// <param name="nombreUsuario"> El nombre del usuario a buscar</param>
        /// <returns>Un objeto Usuario que puede estar vacío si no se encuentra el
        /// nombre especificado</returns>
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
                usuario.IdUsuario = reader.GetInt32("idUsuario");
                usuario.Contrasena = reader.GetString("contrasena");
            }
            return usuario;
        }
        /// <summary>
        /// Recupera los mejores jugadores de la base de datos, se ordenan de mayor a menor
        /// tomando como criterio el número de partidas ganadas. Puede lanzar una MySqlException
        /// si algo sale mal al intentar conectar
        /// </summary>
        /// <returns></returns>
        public List<Usuario> RecuperarMejoresJugadores() {
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "select nombreUsuario, partidasGanadas, partidasPerdidas, " +
                "partidasEmpatadas from usuario natural join EstadisticasUsuario where partidasGanadas > 0 order by " +
                "partidasGanadas desc";
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

        /// <summary>
        /// Valida que el nombre del usuario se encuentre registrado en la BD 
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns>True si el usuario está registrado. 
        /// False si el usuario no está registrado.</returns>
        public Boolean ValidaNombreUsuario(String nombreUsuario) {
            String nombreRecuperadoUsuario = "";
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Select nombreUsuario from usuario where nombreUsuario = @nombreUsuario";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.HasRows && reader.Read()) {
                nombreRecuperadoUsuario = reader.GetString("nombreUsuario");
            }

            if (nombreRecuperadoUsuario.Equals("")) {
                return false;
            } else {
                return true;
            }
        }

        /// <summary>
        /// Valida que la contraseña recibida sea igual a la contraseña almacenada en base de datos
        /// </summary>
        /// <param name="contrasenia">La contraseña a comprobar, misma que deberá haber sido cifrada mediante SHA2-256, de lo
        /// contrario el método no funcionará de forma correcta</param>
        /// <returns>True si la contraseña es igual, false en cualquier otro caso</returns>
        public Boolean ValidaContraUsuario(String contrasenia) {
            String contraRecuperadaUsuario = "";
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Select contrasena from usuario where contrasena = @contrasena";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@contrasena", contrasenia);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.HasRows && reader.Read()) {
                contraRecuperadaUsuario = reader.GetString("contrasena");
            }

            if (contraRecuperadaUsuario.Equals("")) {
                return false;
            } else {
                return true;
            }
        }

        /// <summary>
        /// Suma una partida ganada al jugador cuyo id sea recibido como parámetro
        /// </summary>
        /// <param name="idUsuario">El id del usuario al que será sumada la partida</param>
        /// <returns>Un entero que representa el número de filas afectadas por la actualización</returns>
        public int SumarPartidaGanada(int idUsuario) {
            int filasAfectadas = 0; //si es igual a 0 la inserción no salió bien
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Update estadisticasUsuario set partidasGanadas = partidasGanadas + 1 where idUsuario = @idUsuario";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }

        /// <summary>
        /// Suma una partida perdida al jugador cuyo id sea recibido como parámetro
        /// </summary>
        /// <param name="idUsuario">El id del usuario al que será sumada la partida</param>
        /// <returns>Un entero que representa el número de filas afectadas por la actualización</returns>
        public int SumarPartidaPerdida(int idUsuario) {
            int filasAfectadas = 0; //si es igual a 0 la inserción no salió bien
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Update estadisticasUsuario set partidasPerdidas = partidasPerdidas + 1 where idUsuario = @idUsuario";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }

        /// <summary>
        /// Suma una partida empatada al jugador cuyo id sea recibido como parámetro
        /// </summary>
        /// <param name="idUsuario">El id del usuario al que será sumada la partida</param>
        /// <returns>Un entero que representa el número de filas afectadas por la actualización</returns>
        public int SumarPartidaEmpatada(int idUsuario) {
            int filasAfectadas = 0; //si es igual a 0 la inserción no salió bien
            MySqlConnection conexion = new MySqlConnection(conexionBD);
            conexion.Open();
            string sqlQuery = "Update estadisticasUsuario set partidasEmpatadas = partidasEmpatadas + 1 where idUsuario = @idUsuario";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conexion);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
    }
}
