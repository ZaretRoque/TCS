using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CincoEnLinea.Dominio;

namespace CincoEnLineaTest {
    /// <summary>
    /// Descripción resumida de ComprobarVictoriaHorizontal
    /// </summary>
    [TestClass]
    public class ComprobarVictoriaHorizontal {
        Crupier cru = new Crupier();

        public ComprobarVictoriaHorizontal() {
           
        }

        [TestMethod]
        public void GanaHorizontal() {
            cru.TableroTiros[0, 4] = 1;
            cru.TableroTiros[0, 5] = 1;
            cru.TableroTiros[0, 6] = 1;
            cru.TableroTiros[0, 7] = 1;
            cru.TableroTiros[0, 8] = 1;
            Boolean esperado = true;

            Boolean resultado = cru.ComprobarHorizontal(1);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void PierdeHorizontal() {
            cru.TableroTiros[2, 3] = 1;
            cru.TableroTiros[2, 4] = 1;
            cru.TableroTiros[2, 5] = 1;
            cru.TableroTiros[2, 6] = 2;
            cru.TableroTiros[2, 7] = 1;
            cru.TableroTiros[2, 8] = 1;
            Boolean esperado = false;

            Boolean resultado = cru.ComprobarHorizontal(1);

            Assert.AreEqual(resultado, esperado);
        }
 

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    }
}
