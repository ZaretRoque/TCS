using System;
using System.Windows.Forms;

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
