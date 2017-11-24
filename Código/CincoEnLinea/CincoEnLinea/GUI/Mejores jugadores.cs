﻿
using CincoEnLinea.BD;
using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
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
using System.ServiceModel;
using WcfServicioBaseDatos;

namespace CincoEnLinea.GUI {
    public partial class Mejores_jugadores : Form {
        public Mejores_jugadores() {
            InitializeComponent();
            AplicarIdioma();
            LlenarTablaMejoresJugadores();
        }

        private void AplicarIdioma() {
            this.Text = MejoresJugadoresRes.wTMejoresJugadores;
            labelMejoresJugadores.Text = MejoresJugadoresRes.labMejoresJugadores;
            colPosición.Text = MejoresJugadoresRes.posicion;
            colUsuario.Text = MejoresJugadoresRes.usuario;
            colGanadas.Text = MejoresJugadoresRes.ganadas;
            colPerdidas.Text = MejoresJugadoresRes.perdidas;
            colEmpatadas.Text = MejoresJugadoresRes.empatadas;
            bRegresarMejoresJugadores.Text = MejoresJugadoresRes.bRegresar;
        }

        private void LlenarTablaMejoresJugadores() {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.MejoresJugadoresRes",
                    typeof(Mejores_jugadores).Assembly);
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

        private void Mejores_jugadores_Load(object sender, EventArgs e) {
            
        }


        private void ClicRegresar(object sender, EventArgs e) {
           this.Dispose();
            MenuPrincipal mP = new MenuPrincipal();
            mP.Show();
        }
    }
}
