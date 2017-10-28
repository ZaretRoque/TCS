using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoEnLinea.Dominio {
    public class Crupier {
        private int[,] tableroTiros = new int[9, 9];
        private int turno;

        public int Turno { get => turno; set => turno = value; }
        public int[,] TableroTiros { get => tableroTiros; set => tableroTiros = value; }

        public Crupier() {
            LlenarTableroTiros();
            turno = 1;
        }

        private void LlenarTableroTiros() {
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    tableroTiros[i, j] = 0;
                }
            }
        }

        public bool ValidarTiro(int posY, int posX) {
            if(tableroTiros[posY, posX] == 0) {
                return true;
            }else {
                return false;
            }
        }

        public void GuardarTiro(int posY, int posX, int jugador) {
            tableroTiros[posY, posX] = jugador;
        }

        public bool ComprobarHorizontal(int turno) {
            int contador = 0;
            int turnoAlterno = RegresaTiroContrario(turno);

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    if (turnoAlterno == tableroTiros[i, j]) {
                        contador = 0;
                    }
                    if (turno == tableroTiros[i, j]) {
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

        public bool ComprobarVertical(int turno) {
            int contador = 0;
            int turnoAlterno = RegresaTiroContrario(turno);

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    if (turnoAlterno == tableroTiros[j, i]) {
                        contador = 0;
                    }
                    if (turno == tableroTiros[j, i]) {
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

        public bool ComprobarDiagonalPositiva(int turno) {
            bool resultado = false;
            for(int i = 0; i < 9-4; i++) {
                for(int j = 0; j < 9 - 4; j++) {
                    if(tableroTiros[i,j] ==turno
                        && tableroTiros[i,j] == tableroTiros[i+1, j+1]
                        && tableroTiros[i,j] == tableroTiros[i+2, j+2]
                        && tableroTiros[i,j] == tableroTiros[i+3, j+3]
                        && tableroTiros[i,j] == tableroTiros[i+4, j + 4]) {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        public bool ComprobarDiagonalNegativa(int turno) {
            bool resultado = false;
            for (int i = 4; i < 9; i++) {
                for (int j = 0; j < 9 - 4; j++) {
                    if (tableroTiros[i, j] == turno
                        && tableroTiros[i, j] == tableroTiros[i - 1, j + 1]
                        && tableroTiros[i, j] == tableroTiros[i - 2, j + 2]
                        && tableroTiros[i, j] == tableroTiros[i - 3, j + 3]
                        && tableroTiros[i, j] == tableroTiros[i - 4, j + 4]) {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }



        public int RegresaTiroContrario(int tiro) {
            if (turno == 1) {
                return 2;
            }
            else {
                return 1;
            }
        }
    }
}
