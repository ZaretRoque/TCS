using CincoEnLinea.Recursos_Internacionalización;
using CincoEnLinea.GUI;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace CincoEnLinea {
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            groupBoxInicioSesion.Text = StringResources.gBoxIniciarSesion;
            textBoxUsuario.Text = StringResources.textBoxUsuario;
            buttonEntrar.Text = StringResources.butttonEntrar;
            label1.Text = StringResources.labelNoTienesCuenta;
            linkLabelRegistrate.Text = StringResources.linkLabelRegistrate;
            buttonTablero.Text = StringResources.botonTablero;
            buttonReglas.Text = StringResources.botonReglas;
            buttonJugadores.Text = StringResources.botonJugadores;

        }

       /* private void cambiaFondo(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "")
            {
                ImageBrush textoFondo = new ImageBrush();
                textoFondo.ImageSource = new BitmapImage(
                    new Uri(@"EtiquetaUsuario.jpg", UriKind.Relative)
                    );
                textoFondo.AlignmentX = AlignmentX.Left;
                textoFondo.Stretch = Stretch.None;
                //se supone que debería ir la propiedad background pero no está para mi textBox :c
                
            } else
            {
                
            }
        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clicRegistrate(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro rs = new Registro();
            rs.Show();
            this.Hide();
        }

        private void cambiarIdiomaIngles(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("EN-US");
            AplicarIdioma();
        }

        private void cambiarIdiomaEspanol(object sender, LinkLabelLinkClickedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ES-MX");
            AplicarIdioma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugar jg = new Jugar();
            jg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mejores_jugadores mJ = new Mejores_jugadores();
            mJ.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerReglas verRs = new VerReglas();
            verRs.Show();
            this.Hide();
        }

        private void PanelRegistrarteIS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
