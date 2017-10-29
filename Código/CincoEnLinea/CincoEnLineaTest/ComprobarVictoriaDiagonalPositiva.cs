using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.Dominio;

namespace CincoEnLineaTest {
    /// <summary>
    /// Descripción resumida de ComprobarVictoriaDiagonalPositiva
    /// </summary>
    [TestClass]
    public class ComprobarVictoriaDiagonalPositiva {
        Crupier cru = new Crupier();

        public ComprobarVictoriaDiagonalPositiva() {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        [TestMethod]
        public void ComprobarVictoria() {
            cru.TableroTiros[0, 8] = 1;
            cru.TableroTiros[1, 7] = 1;
            cru.TableroTiros[2, 6] = 1;
            cru.TableroTiros[3, 5] = 1;
            cru.TableroTiros[4, 4] = 1;
            Boolean esperado = true;

            Boolean resultado = cru.ComprobarDiagonalPositiva(1);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ComprobarDerrota() {
            cru.TableroTiros[0, 8] = 1;
            cru.TableroTiros[1, 7] = 1;
            cru.TableroTiros[2, 6] = 2;
            cru.TableroTiros[3, 5] = 1;
            cru.TableroTiros[4, 4] = 1;
            cru.TableroTiros[5, 3] = 1;
            Boolean esperado = false;

            Boolean resultado = cru.ComprobarDiagonalPositiva(1);

            Assert.AreEqual(resultado, esperado);
        }
    }
}
