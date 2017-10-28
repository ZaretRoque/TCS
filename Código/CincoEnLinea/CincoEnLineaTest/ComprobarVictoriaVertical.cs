using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.Dominio;

namespace CincoEnLineaTest {
    /// <summary>
    /// Descripción resumida de ComprobarVictoriaVertical
    /// </summary>
    [TestClass]
    public class ComprobarVictoriaVertical {
        Crupier cru = new Crupier();

        public ComprobarVictoriaVertical() {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        [TestMethod]
        public void GanaVertical() {
            cru.TableroTiros[4, 0] = 1;
            cru.TableroTiros[5, 0] = 1;
            cru.TableroTiros[6, 0] = 1;
            cru.TableroTiros[7, 0] = 1;
            cru.TableroTiros[8, 0] = 1;
            Boolean esperado = true;

            Boolean resultado = cru.ComprobarVertical(1);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void PierdeVertical() {
            cru.TableroTiros[3, 2] = 1;
            cru.TableroTiros[4, 2] = 1;
            cru.TableroTiros[5, 2] = 1;
            cru.TableroTiros[6, 2] = 2;
            cru.TableroTiros[7, 2] = 1;
            cru.TableroTiros[8, 2] = 1;
            Boolean esperado = false;

            Boolean resultado = cru.ComprobarVertical(1);

            Assert.AreEqual(resultado, esperado);
        }


    }
}
