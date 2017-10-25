using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CincoEnLinea {
    public partial class Jugar : Form {
        private PictureBox[,] pictureTablero = new PictureBox[8, 8];

        public Jugar() {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = JugarRes.wTJugar;
            labelTurno.Text = JugarRes.labTurno;
            labelNombreJugadorTurno.Text = JugarRes.nombreJugador;
            abandonaPartida.Text = JugarRes.bAbandonar;


        }

        private void tableLayoutPanelTablero_Paint(object sender, PaintEventArgs e) {

        }

        private void Jugar_Load(object sender, EventArgs e) {
        }

        public void pictureBoxLlenaTablero() {
            pictureTablero[0, 0] = pictureBox0_0;
            pictureTablero[0, 1] = pictureBox0_1;
            pictureTablero[0, 2] = pictureBox0_2;
            pictureTablero[0, 3] = pictureBox0_3;
            pictureTablero[0, 4] = pictureBox0_4;
            pictureTablero[0, 5] = pictureBox0_5;
            pictureTablero[0, 6] = pictureBox0_6;
            pictureTablero[0, 7] = pictureBox0_7;
            pictureTablero[0, 8] = pictureBox0_8;

            pictureTablero[1, 0] = pictureBox1_0;
            pictureTablero[1, 1] = pictureBox1_1;
            pictureTablero[1, 2] = pictureBox1_2;
            pictureTablero[1, 3] = pictureBox1_3;
            pictureTablero[1, 4] = pictureBox1_4;
            pictureTablero[1, 5] = pictureBox1_5;
            pictureTablero[1, 6] = pictureBox1_6;
            pictureTablero[1, 7] = pictureBox1_7;
            pictureTablero[1, 8] = pictureBox1_8;

            pictureTablero[2, 0] = pictureBox2_0;
            pictureTablero[2, 1] = pictureBox2_1;
            pictureTablero[2, 2] = pictureBox2_2;
            pictureTablero[2, 3] = pictureBox2_3;
            pictureTablero[2, 4] = pictureBox2_4;
            pictureTablero[2, 5] = pictureBox2_5;
            pictureTablero[2, 6] = pictureBox2_6;
            pictureTablero[2, 7] = pictureBox2_7;
            pictureTablero[2, 8] = pictureBox2_8;

            pictureTablero[3, 0] = pictureBox3_0;
            pictureTablero[3, 1] = pictureBox3_1;
            pictureTablero[3, 2] = pictureBox3_2;
            pictureTablero[3, 3] = pictureBox3_3;
            pictureTablero[3, 4] = pictureBox3_4;
            pictureTablero[3, 5] = pictureBox3_5;
            pictureTablero[3, 6] = pictureBox3_6;
            pictureTablero[3, 7] = pictureBox3_7;
            pictureTablero[3, 8] = pictureBox3_8;

            pictureTablero[4, 0] = pictureBox4_0;
            pictureTablero[4, 1] = pictureBox4_1;
            pictureTablero[4, 2] = pictureBox4_2;
            pictureTablero[4, 3] = pictureBox4_3;
            pictureTablero[4, 4] = pictureBox4_4;
            pictureTablero[4, 5] = pictureBox4_5;
            pictureTablero[4, 6] = pictureBox4_6;
            pictureTablero[4, 7] = pictureBox4_7;
            pictureTablero[4, 8] = pictureBox4_8;

            pictureTablero[5, 0] = pictureBox5_0;
            pictureTablero[5, 1] = pictureBox5_1;
            pictureTablero[5, 2] = pictureBox5_2;
            pictureTablero[5, 3] = pictureBox5_3;
            pictureTablero[5, 4] = pictureBox5_4;
            pictureTablero[5, 5] = pictureBox5_5;
            pictureTablero[5, 6] = pictureBox5_6;
            pictureTablero[5, 7] = pictureBox5_7;
            pictureTablero[5, 8] = pictureBox5_8;

            pictureTablero[6, 0] = pictureBox6_0;
            pictureTablero[6, 1] = pictureBox6_1;
            pictureTablero[6, 2] = pictureBox6_2;
            pictureTablero[6, 3] = pictureBox6_3;
            pictureTablero[6, 4] = pictureBox6_4;
            pictureTablero[6, 5] = pictureBox6_5;
            pictureTablero[6, 6] = pictureBox6_6;
            pictureTablero[6, 7] = pictureBox6_7;
            pictureTablero[6, 8] = pictureBox6_8;

            pictureTablero[7, 0] = pictureBox7_0;
            pictureTablero[7, 1] = pictureBox7_1;
            pictureTablero[7, 2] = pictureBox7_2;
            pictureTablero[7, 3] = pictureBox7_3;
            pictureTablero[7, 4] = pictureBox7_4;
            pictureTablero[7, 5] = pictureBox7_5;
            pictureTablero[7, 6] = pictureBox7_6;
            pictureTablero[7, 7] = pictureBox7_7;
            pictureTablero[7, 8] = pictureBox7_8;

            pictureTablero[8, 0] = pictureBox8_0;
            pictureTablero[8, 1] = pictureBox8_1;
            pictureTablero[8, 2] = pictureBox8_2;
            pictureTablero[8, 3] = pictureBox8_3;
            pictureTablero[8, 4] = pictureBox8_4;
            pictureTablero[8, 5] = pictureBox8_5;
            pictureTablero[8, 6] = pictureBox8_6;
            pictureTablero[8, 7] = pictureBox8_7;
            pictureTablero[8, 8] = pictureBox8_8;
        }

        private void ClicPictureBox0_0(object sender, EventArgs e) {
            
        }

        private void ClicPictureBox0_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox0_7(object sender, EventArgs e) {

        }

        private void ClicpPictureBox0_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox1_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox2_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox3_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox4_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox5_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox6_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox7_8(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_0(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_1(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_2(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_3(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_4(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_5(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_6(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_7(object sender, EventArgs e) {

        }

        private void ClicPictureBox8_8(object sender, EventArgs e) {

        }

        private void ClicAbandonarPartida(object sender, EventArgs e) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.JugarRes",
                    typeof(Jugar).Assembly);
            string mensaje = rm.GetString("confirmacionSalida");
            string titulo = rm.GetString("tituloConfirmacion");
            if (MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                this.Dispose();
            }
        }
    }

}
