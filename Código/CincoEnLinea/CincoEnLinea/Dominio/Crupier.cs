using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    /// <summary>
    /// La clase Crupier será la encargada de la lógica detrás del tablero
    /// </summary>
    public class Crupier {
        private int[,] tableroTiros = new int[9, 9];
        private int turno;

        public int Turno { get => turno; set => turno = value; }
        public int[,] TableroTiros { get => tableroTiros; set => tableroTiros = value; }

        public Crupier() {
            LlenarTableroTiros();
            turno = 1;
        }

        /// <summary>
        /// Llena todo el tablero de juegos con 0, de esta forma se indica que la casilla está vacía y puede ser utilizada
        /// por un jugador para poner su ficha
        /// </summary>
        private void LlenarTableroTiros() {
            for (int fila = 0; fila < 9; fila++) {
                for (int columna = 0; columna < 9; columna++) {
                    tableroTiros[fila, columna] = 0;
                }
            }
        }

        /// <summary>
        /// Comprueba que la casilla donde el jugador quiere poner su ficha esté disponible
        /// </summary>
        /// <param name="posY">La posición en el eje Y</param>
        /// <param name="posX">La posición en el eje X</param>
        /// <returns>Un booleano, false cuando la casilla está ocupada, true cuando está libre</returns>
        public bool ValidarTiro(int posY, int posX) {
            if (tableroTiros[posY, posX] == 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Guarda el tiro del jugador en la posición especificada por la coordenadas recibidas
        /// </summary>
        /// <param name="posY">La posición en el eje Y</param>
        /// <param name="posX">La posición en el eje X</param>
        /// <param name="jugador">El jugador cuyo tiro será guardado, se utiliza un entero para representarlo. Puede ser 1 o 2</param>
        public void GuardarTiro(int posY, int posX, int jugador) {
            tableroTiros[posY, posX] = jugador;
        }

        /// <summary>
        /// Comprueba si hay una línea de cinco fichas consecutivas en horizontal
        /// </summary>
        /// <param name="turno">El número que representa al jugador del cual se quiere comprobar la línea</param>
        /// <returns>True si existe la línea consecutiva, false si no existe</returns>
        public bool ComprobarHorizontal(int turno) {
            int contador = 0;
            int turnoAlterno = RegresaTiroContrario(turno);

            for (int fila = 0; fila < 9; fila++) {
                for (int columna = 0; columna < 9; columna++) {
                    if (turnoAlterno == tableroTiros[fila, columna]) {
                        contador = 0;
                    }
                    if (turno == tableroTiros[fila, columna]) {
                        contador++;
                    }
                    if (contador == 5) {

                        return true;
                    }
                }
                contador = 0;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si hay una línea de cinco fichas consecutivas en vertical
        /// </summary>
        /// <param name="turno">El número que representa al jugador del cual se quiere comprobar la línea</param>
        /// <returns>True si existe la línea, false si no existe</returns>
        public bool ComprobarVertical(int turno) {
            int contador = 0;
            int turnoAlterno = RegresaTiroContrario(turno);

            for (int fila = 0; fila < 9; fila++) {
                for (int columna = 0; columna < 9; columna++) {
                    if (turnoAlterno == tableroTiros[columna, fila]) {
                        contador = 0;
                    }
                    if (turno == tableroTiros[columna, fila]) {
                        contador++;
                    }
                    if (contador == 5) {
                        return true;
                    }
                }
                contador = 0;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si existe una línea de cinco fichas consecutivas en diagonal con pendiente negativa
        /// </summary>
        /// <param name="turno">El número que representa al jugador del cual se quiere comprobar la línea</param>
        /// <returns>True si existe la línea, false si no existe</returns>
        public bool ComprobarDiagonalNegativa(int turno) {
            bool resultado = false;
            for(int fila = 0; fila < 9-4; fila++) {
                for(int columna = 0; columna < 9 - 4; columna++) {
                    if(tableroTiros[fila,columna] ==turno
                        && tableroTiros[fila,columna] == tableroTiros[fila+1, columna+1]
                        && tableroTiros[fila,columna] == tableroTiros[fila+2, columna+2]
                        && tableroTiros[fila,columna] == tableroTiros[fila+3, columna+3]
                        && tableroTiros[fila,columna] == tableroTiros[fila+4, columna + 4]) {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        /// <summary>
        /// Comprueba si existe una línea  de cinco fichas consecutivas en diagonal con pendiente positiva
        /// </summary>
        /// <param name="turno">El número que representa al jugador del cual se quiere comprobar la línea</param>
        /// <returns>True si existe la línea, false si no existe</returns>
        public bool ComprobarDiagonalPositiva(int turno) {
            bool resultado = false;
            for (int fila = 4; fila < 9; fila++) {
                for (int columna = 0; columna < 9 - 4; columna++) {
                    if (tableroTiros[fila, columna] == turno
                        && tableroTiros[fila, columna] == tableroTiros[fila - 1, columna + 1]
                        && tableroTiros[fila, columna] == tableroTiros[fila - 2, columna + 2]
                        && tableroTiros[fila, columna] == tableroTiros[fila - 3, columna + 3]
                        && tableroTiros[fila, columna] == tableroTiros[fila - 4, columna + 4]) {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        /// <summary>
        /// Comprueba que el tablero no se haya llenado
        /// </summary>
        /// <returns>True cuando el tablero está lleno y false cuando no</returns>
        public bool ComprobarEmpate() {
            for (int columna = 0; columna < 9; columna++) {
                for (int fila = 0; fila < 9; fila++) {
                    if(tableroTiros[fila, columna] == 0) {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Obtiene el número que representa al jugador contrario, se utiliza dentro de los métodos que comprueban las línea consecutivas
        /// y saber si la ficha contraria interrumpe la línea del jugador actual
        /// </summary>
        /// <param name="tiro">El tiro contrario al jugador actual</param>
        /// <returns>Un entero que representa el tiro contrario al jugador actual</returns>
        public int RegresaTiroContrario(int tiro) {
            if (turno == 1) {
                return 2;
            } else {
                return 1;
            }
        }
    }
}
