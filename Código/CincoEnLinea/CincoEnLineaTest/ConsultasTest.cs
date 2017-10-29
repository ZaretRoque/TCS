using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.BD;
using CincoEnLinea.Dominio;
using System.Collections.Generic;

namespace CincoEnLineaTest {
    [TestClass]
    public class ConsultasTest {
        [TestMethod]
        public void RegistrarUsuario() {
            Consultas consultas = new Consultas();
            string nombreUsuario = "prueba";
            string contrasenaPrueba = "contrasenaPrueba";
            int esperado = 1;

            int resultado = consultas.RegistrarUsuario(nombreUsuario, contrasenaPrueba);
            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void RecuperarUsuario() {
            Consultas consultas = new Consultas();
            Usuario prueba = new Usuario(2, "zaret", "ddc96936f7d0959e7d7549828deef552384521da0a088893ec4655e0d1967b17");
            string nombreUsuario = "zaret";

            Usuario resultadoParcial = consultas.RecuperarUsuario(nombreUsuario);
            bool resultado = false;
            if(prueba.IdUsuario == resultadoParcial.IdUsuario && prueba.NombreUsuario.Equals(resultadoParcial.NombreUsuario) && prueba.Contrasena.Equals(resultadoParcial.Contrasena)) {
                resultado = true;
            }

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void RecuperarMejoresJugadores() {
            Consultas consultas = new Consultas();
            int esperado = 2;

            List<Usuario> mejoresJugadores = consultas.RecuperarMejoresJugadores();
            int resultado = mejoresJugadores.Count;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void ValidaNombreUsuario() {
            Consultas consultas = new Consultas();
            string nombreUsuario = "zaret";
            bool esperado = true;

            bool resultado = consultas.ValidaNombreUsuario(nombreUsuario);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void ValidaContraUsuario() {
            Consultas consultas = new Consultas();
            string contrasena = "ddc96936f7d0959e7d7549828deef552384521da0a088893ec4655e0d1967b17";
            bool esperado = true;

            bool resultado = consultas.ValidaContraUsuario(contrasena);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SumarPartidaGanada() {
            Consultas consultas = new Consultas();
            int idUsuario = 2;
            int esperado = 1;

            int resultado = consultas.SumarPartidaGanada(idUsuario);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SumarPartidaPerdida() {
            Consultas consultas = new Consultas();
            int idUsuario = 2;
            int esperado = 1;

            int resultado = consultas.SumarPartidaPerdida(idUsuario);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SumarPartidaEmpatada() {
            Consultas consultas = new Consultas();
            int idUsuario = 2;
            int esperado = 1;

            int resultado = consultas.SumarPartidaEmpatada(idUsuario);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
