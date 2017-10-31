using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.Dominio;

namespace CincoEnLineaTest {
    /// <summary>
    /// Descripción resumida de ComprobarEmpate
    /// </summary>
    [TestClass]
    public class ComprobarEmpate {
        Crupier cru = new Crupier();
        public ComprobarEmpate() {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        
        [TestMethod]
        public void CompruebaEmpateVerdadero() {
            for (int i = 0; i < 9; i++) {
                for (int k = 0; k < 9; k++) {
                    cru.TableroTiros[i, k] = 1;
                }
            }

            Boolean esperado = true;

            Boolean resultado = cru.ComprobarEmpate();

            Assert.AreEqual(resultado, esperado);
        }
    }
}
