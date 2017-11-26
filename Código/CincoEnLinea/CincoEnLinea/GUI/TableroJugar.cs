using CincoEnLinea.Dominio;
using CincoEnLinea.RecursosInternacionalizacion;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CincoEnLinea {
    public partial class TableroJugar : Form {
        private PictureBox[,] pictureTablero = new PictureBox[8, 8];
        private int turno = 1;
        Crupier crupier = new Crupier();

        public TableroJugar() {
            InitializeComponent();
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = TableroJugarRes.wTJugar;
            labelTurno.Text = TableroJugarRes.labTurno;
            labelNombreJugadorTurno.Text = TableroJugarRes.nombreJugador;
            abandonaPartida.Text = TableroJugarRes.bAbandonar;


        }

        
        private void ClicPictureBox0_0(object sender, EventArgs e) {
            //Se define un Bitmap para poder crear un objeto de tipo Graphics
            Bitmap panelPintar = new Bitmap(pictureBox0_0.Height, pictureBox0_0.Width);
            pictureBox0_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            //confirma el turno pero falta validar que no escriba en una posición donde ya se tiró
            PintarTiro(0, 0, panelPintar, pulsado);
            
        }

        private void ClicPictureBox0_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_1.Height, pictureBox0_1.Width);
            pictureBox0_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 1, panelPintar,pulsado);
        }

        private void ClicPictureBox0_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_2.Height, pictureBox0_2.Width);
            pictureBox0_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 2, panelPintar,pulsado);
        }

        private void ClicPictureBox0_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_3.Height, pictureBox0_3.Width);
            pictureBox0_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 3, panelPintar,pulsado);
        }

        private void ClicPictureBox0_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_4.Height, pictureBox0_4.Width);
            pictureBox0_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox0_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_5.Height, pictureBox0_5.Width);
            pictureBox0_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 5, panelPintar,pulsado);
        }

        private void ClicPictureBox0_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_6.Height, pictureBox0_6.Width);
            pictureBox0_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 6, panelPintar,pulsado);
        }

        private void ClicPictureBox0_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_7.Height, pictureBox0_7.Width);
            pictureBox0_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 7, panelPintar,pulsado);
        }

        private void ClicpPictureBox0_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox0_8.Height, pictureBox0_8.Width);
            pictureBox0_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(0, 8, panelPintar,pulsado);
        }

        private void ClicPictureBox1_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_0.Height, pictureBox1_0.Width);
            pictureBox1_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 0, panelPintar,pulsado);
        }

        private void ClicPictureBox1_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_1.Height, pictureBox1_1.Width);
            pictureBox1_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 1, panelPintar,pulsado);
        }

        private void ClicPictureBox1_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_2.Height, pictureBox1_2.Width);
            pictureBox1_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 2, panelPintar,pulsado);
        }

        private void ClicPictureBox1_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_3.Height, pictureBox1_3.Width);
            pictureBox1_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 3, panelPintar,pulsado);
        }

        private void ClicPictureBox1_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_4.Height, pictureBox1_4.Width);
            pictureBox1_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 4, panelPintar,pulsado);
        }

        private void ClicPictureBox1_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_5.Height, pictureBox1_5.Width);
            pictureBox1_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 5, panelPintar,pulsado);
        }

        private void ClicPictureBox1_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_6.Height, pictureBox1_6.Width);
            pictureBox1_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 6, panelPintar,pulsado);
        }

        private void ClicPictureBox1_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_7.Height, pictureBox1_7.Width);
            pictureBox1_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox1_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox1_8.Height, pictureBox1_8.Width);
            pictureBox1_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(1, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox2_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_0.Height, pictureBox2_0.Width);
            pictureBox2_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 0, panelPintar,pulsado);
        }

        private void ClicPictureBox2_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_1.Height, pictureBox2_1.Width);
            pictureBox2_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 1, panelPintar,pulsado);
        }

        private void ClicPictureBox2_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_2.Height, pictureBox2_2.Width);
            pictureBox2_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 2, panelPintar,pulsado);
        }

        private void ClicPictureBox2_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_3.Height, pictureBox2_3.Width);
            pictureBox2_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox2_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_4.Height, pictureBox2_4.Width);
            pictureBox2_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox2_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_5.Height, pictureBox2_5.Width);
            pictureBox2_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox2_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_6.Height, pictureBox2_6.Width);
            pictureBox2_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox2_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_7.Height, pictureBox2_7.Width);
            pictureBox2_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox2_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox2_8.Height, pictureBox2_8.Width);
            pictureBox2_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(2, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox3_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_0.Height, pictureBox3_0.Width);
            pictureBox3_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox3_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_1.Height, pictureBox3_1.Width);
            pictureBox3_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox3_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_2.Height, pictureBox3_2.Width);
            pictureBox3_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox3_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_3.Height, pictureBox3_3.Width);
            pictureBox3_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox3_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_4.Height, pictureBox3_4.Width);
            pictureBox3_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox3_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_5.Height, pictureBox3_5.Width);
            pictureBox3_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox3_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_6.Height, pictureBox3_6.Width);
            pictureBox3_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox3_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_7.Height, pictureBox3_7.Width);
            pictureBox3_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox3_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox3_8.Height, pictureBox3_8.Width);
            pictureBox3_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(3, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox4_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_0.Height, pictureBox4_0.Width);
            pictureBox4_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox4_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_1.Height, pictureBox4_1.Width);
            pictureBox4_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox4_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_2.Height, pictureBox4_2.Width);
            pictureBox4_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox4_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_3.Height, pictureBox4_3.Width);
            pictureBox4_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox4_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_4.Height, pictureBox4_4.Width);
            pictureBox4_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox4_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_5.Height, pictureBox4_5.Width);
            pictureBox4_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox4_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_6.Height, pictureBox4_6.Width);
            pictureBox4_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox4_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_7.Height, pictureBox4_7.Width);
            pictureBox4_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox4_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox4_8.Height, pictureBox4_8.Width);
            pictureBox4_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(4, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox5_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_0.Height, pictureBox5_0.Width);
            pictureBox5_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox5_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_1.Height, pictureBox5_1.Width);
            pictureBox5_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox5_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_2.Height, pictureBox5_2.Width);
            pictureBox5_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox5_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_3.Height, pictureBox5_3.Width);
            pictureBox5_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox5_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_4.Height, pictureBox5_4.Width);
            pictureBox5_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox5_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_5.Height, pictureBox5_5.Width);
            pictureBox5_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox5_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_6.Height, pictureBox5_6.Width);
            pictureBox5_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox5_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_7.Height, pictureBox5_7.Width);
            pictureBox5_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox5_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox5_8.Height, pictureBox5_8.Width);
            pictureBox5_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(5, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox6_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_0.Height, pictureBox6_0.Width);
            pictureBox6_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox6_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_1.Height, pictureBox6_1.Width);
            pictureBox6_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox6_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_2.Height, pictureBox6_2.Width);
            pictureBox6_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox6_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_3.Height, pictureBox6_3.Width);
            pictureBox6_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox6_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_4.Height, pictureBox6_4.Width);
            pictureBox6_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox6_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_5.Height, pictureBox6_5.Width);
            pictureBox6_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox6_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_6.Height, pictureBox6_6.Width);
            pictureBox6_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox6_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_7.Height, pictureBox6_7.Width);
            pictureBox6_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox6_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox6_8.Height, pictureBox6_8.Width);
            pictureBox6_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(6, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox7_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_0.Height, pictureBox7_0.Width);
            pictureBox7_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox7_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_1.Height, pictureBox7_1.Width);
            pictureBox7_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox7_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_2.Height, pictureBox7_2.Width);
            pictureBox7_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox7_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_3.Height, pictureBox7_3.Width);
            pictureBox7_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox7_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_4.Height, pictureBox7_4.Width);
            pictureBox7_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox7_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_5.Height, pictureBox7_5.Width);
            pictureBox7_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox7_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_6.Height, pictureBox7_6.Width);
            pictureBox7_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox7_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_7.Height, pictureBox7_7.Width);
            pictureBox7_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox7_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox7_8.Height, pictureBox7_8.Width);
            pictureBox7_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(7, 8, panelPintar, pulsado);
        }

        private void ClicPictureBox8_0(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_0.Height, pictureBox8_0.Width);
            pictureBox8_0.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 0, panelPintar, pulsado);
        }

        private void ClicPictureBox8_1(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_1.Height, pictureBox8_1.Width);
            pictureBox8_1.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 1, panelPintar, pulsado);
        }

        private void ClicPictureBox8_2(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_2.Height, pictureBox8_2.Width);
            pictureBox8_2.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 2, panelPintar, pulsado);
        }

        private void ClicPictureBox8_3(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_3.Height, pictureBox8_3.Width);
            pictureBox8_3.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 3, panelPintar, pulsado);
        }

        private void ClicPictureBox8_4(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_4.Height, pictureBox8_4.Width);
            pictureBox8_4.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 4, panelPintar, pulsado);
        }

        private void ClicPictureBox8_5(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_5.Height, pictureBox8_5.Width);
            pictureBox8_5.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 5, panelPintar, pulsado);
        }

        private void ClicPictureBox8_6(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_6.Height, pictureBox8_6.Width);
            pictureBox8_6.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 6, panelPintar, pulsado);
        }

        private void ClicPictureBox8_7(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_7.Height, pictureBox8_7.Width);
            pictureBox8_7.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 7, panelPintar, pulsado);
        }

        private void ClicPictureBox8_8(object sender, EventArgs e) {
            Bitmap panelPintar = new Bitmap(pictureBox8_8.Height, pictureBox8_8.Width);
            pictureBox8_8.Image = (Image)panelPintar;
            PictureBox pulsado = sender as PictureBox;
            PintarTiro(8, 8, panelPintar, pulsado);
        }

        private void ClicAbandonarPartida(object sender, EventArgs e) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.TableroJugarRes",
                    typeof(TableroJugar).Assembly);
            string mensaje = rm.GetString("confirmacionSalida");
            string titulo = rm.GetString("tituloConfirmacion");
            if (MessageBox.Show(mensaje, titulo,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                this.Dispose();
            }
        }

        public void DibujaFichaNegra(Image panelPintar) {
            //Asigna el Bitmap del pictureBox al Graphics para dibujar en él
            Graphics panelGrafico = Graphics.FromImage(panelPintar);
            //Solid para rellenar la elipse y Pen para dibujarla
            SolidBrush colorRelleno = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Brushes.Black);
            //Definimos el espacio en donde se encontrará la elipse
            Rectangle rect = new Rectangle(2, 2, 24, 24);
            panelGrafico.DrawEllipse(blackPen, rect);
            panelGrafico.FillEllipse(colorRelleno, rect);
        }

        public void DibujaFichaAzul(Image panelPintar) {
            Graphics panelGrafico = Graphics.FromImage(panelPintar);
            SolidBrush colorRelleno = new SolidBrush(Color.AliceBlue);
            Pen blackPen = new Pen(Brushes.Black);
            Rectangle rect = new Rectangle(2, 2, 24, 24);
            panelGrafico.DrawEllipse(blackPen, rect);
            panelGrafico.FillEllipse(colorRelleno, rect);
        }

        public void PintarTiro(int posY, int posX, Bitmap panelPintar, PictureBox pulsado) {
            ResourceManager rm = new ResourceManager("CincoEnLinea.RecursosInternacionalizacion.TableroJugarRes",
                    typeof(TableroJugar).Assembly);
            if (crupier.ValidarTiro(posY, posX)) {
                if (turno == 1) {
                    DibujaFichaNegra(panelPintar);

                    crupier.GuardarTiro(posY, posX, 1);
                    bool horizontal = crupier.ComprobarHorizontal(turno);
                    bool vertical = crupier.ComprobarVertical(turno);
                    bool diagonalPositiva = crupier.ComprobarDiagonalPositiva(turno);
                    bool diagonalNegativa = crupier.ComprobarDiagonalNegativa(turno);
                    bool empate = crupier.ComprobarEmpate();
                    if(horizontal || vertical || diagonalPositiva || diagonalNegativa) {

                        string mensaje = rm.GetString("mensajeGanar");
                        string titulo = rm.GetString("tituloGanar");
                        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if(empate) {

                        string mensajeEmpate = rm.GetString("mensajeEmpatar");
                        string tituloEmpate = rm.GetString("tituloEmpatar");
                        MessageBox.Show(mensajeEmpate, tituloEmpate, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    crupier.Turno = 2;
                    turno = 2;
                } else {
                    DibujaFichaAzul(panelPintar);
                    
                    crupier.GuardarTiro(posY, posX, 2);
                    bool horizontal = crupier.ComprobarHorizontal(turno);
                    bool vertical = crupier.ComprobarVertical(turno);
                    bool diagonalPositiva = crupier.ComprobarDiagonalPositiva(turno);
                    bool diagonalNegativa = crupier.ComprobarDiagonalNegativa(turno);
                    bool empate = crupier.ComprobarEmpate();
                    if (horizontal || vertical || diagonalPositiva || diagonalNegativa) {

                        string mensaje = rm.GetString("mensajeGanar");
                        string titulo = rm.GetString("tituloGanar");
                        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (empate) {

                        string mensajeEmpate = rm.GetString("mensajeEmpatar");
                        string tituloEmpate = rm.GetString("tituloEmpatar");
                        MessageBox.Show(mensajeEmpate, tituloEmpate, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    crupier.Turno = 1;
                    turno = 1;
                }
                pulsado.Enabled = false;  
            }
        }

        

    }

}
