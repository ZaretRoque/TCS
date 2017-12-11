using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Collections.Generic;
using System.Resources;
using System.ServiceModel;
using System.Windows.Forms;
using WcfServicioBaseDatos;
using CincoEnLinea.Dominio;

namespace CincoEnLinea.GUI {
    public partial class MejoresJugadores : Form {
        private Dominio.Usuario usuario;
        public MejoresJugadores(Dominio.Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
            AplicarIdioma();
            LlenarTablaMejoresJugadores();
        }

        private void AplicarIdioma() {
            this.Text = MejoresJugadoresRes.wTMejoresJugadores;
            labelMejoresJugadores.Text = MejoresJugadoresRes.labMejoresJugadores;
            columnaPosición.Text = MejoresJugadoresRes.posicion;
            columnaUsuario.Text = MejoresJugadoresRes.usuario;
            columnaGanadas.Text = MejoresJugadoresRes.ganadas;
            columnaPerdidas.Text = MejoresJugadoresRes.perdidas;
            columnaEmpatadas.Text = MejoresJugadoresRes.empatadas;
            buttonRegresarMejoresJugadores.Text = MejoresJugadoresRes.bRegresar;
        }

        private void LlenarTablaMejoresJugadores() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MejoresJugadoresRes",
                    typeof(MejoresJugadores).Assembly);
            ChannelFactory<IServicioBD> canalServidor;
            IServicioBD interfazServidor;
            string mensaje;
            string titulo;
            try {
                canalServidor = new ChannelFactory<IServicioBD>("configuracionServidor");
                interfazServidor = canalServidor.CreateChannel();
                //utilizamos el dataContract del servicio para que pueda 'entender' el valor de retorno
                List<WcfServicioBaseDatos.Usuario> mejoresJugadores = interfazServidor.RecuperarMejoresJugadores();
                listViewMejoresJugadores.View = View.Details;
                int contador = 1;
                foreach (WcfServicioBaseDatos.Usuario usuario in mejoresJugadores) {
                    ListViewItem item = listViewMejoresJugadores.Items.Add(contador.ToString());
                    item.SubItems.Add(usuario.NombreUsuario);
                    item.SubItems.Add(usuario.PartidasGanadas.ToString());
                    item.SubItems.Add(usuario.PartidasPerdidas.ToString());
                    item.SubItems.Add(usuario.PartidasEmpatadas.ToString());
                    item.Tag = usuario;
                    contador++;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e) {
                mensaje = rm.GetString("excepcionBD");
                titulo = rm.GetString("tituloExcepcionBD");
                MessageBox.Show(mensaje, titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Evento asosiado al botón Regresar, que libera los recursos de la ventana actual y crea una nueva 
        /// de tipo MenuPrincipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicRegresar(object sender, EventArgs e) {
           this.Dispose();
            MenuPrincipal mP = new MenuPrincipal(usuario);
            mP.Show();
        }

        private void ClicAlCerrarVentana(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
