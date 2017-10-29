using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.Dominio;

namespace CincoEnLineaTest {
    /// <summary>
    /// Descripción resumida de ComprobarVictoriaDiagonalNegativa
    /// </summary>
    [TestClass]
    public class ComprobarVictoriaDiagonalNegativa {
        Crupier cru = new Crupier();

        public ComprobarVictoriaDiagonalNegativa() {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        [TestMethod]
        public void ComprobarVictoria() {
            cru.TableroTiros[0, 2] = 1;
            cru.TableroTiros[1, 3] = 1;
            cru.TableroTiros[2, 4] = 1;
            cru.TableroTiros[3, 5] = 1;
            cru.TableroTiros[4, 6] = 1;
            Boolean esperado = true;

            Boolean resultado = cru.ComprobarDiagonalNegativa(1);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ComprobarDerrota() {
            cru.TableroTiros[0, 2] = 1;
            cru.TableroTiros[1, 3] = 1;
            cru.TableroTiros[2, 4] = 2;
            cru.TableroTiros[3, 5] = 1;
            cru.TableroTiros[4, 6] = 1;
            cru.TableroTiros[5, 7] = 1;
            Boolean esperado = false;

            Boolean resultado = cru.ComprobarDiagonalNegativa(1);

            Assert.AreEqual(resultado, esperado);
        }
    }
}
