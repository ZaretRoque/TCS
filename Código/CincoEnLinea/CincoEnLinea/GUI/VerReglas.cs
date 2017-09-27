using CincoEnLinea.Recursos_Internacionalización;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CincoEnLinea.GUI {
    public partial class VerReglas : Form {
        public VerReglas() {
            InitializeComponent();
        }

        private void labelRegla1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void VerReglas_Load(object sender, EventArgs e) {
            AplicarIdioma();
        }

        private void AplicarIdioma() {
            this.Text = StringResources.WindowTitleVerReglas;
            bRegresarVerReglas.Text = StringResources.bRegresar;
            labelRegla1.Text = StringResources.labelRegla1;
            labelRegla2.Text = StringResources.labelRegla2;
            labelRegla3.Text = StringResources.labelRegla3;
            labelRegla4.Text = StringResources.labelRegla4;
        }
    }
}
