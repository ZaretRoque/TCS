using System;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace CincoEnLinea
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void cambiaFondo(object sender, EventArgs e)
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
        }

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
    }
}
