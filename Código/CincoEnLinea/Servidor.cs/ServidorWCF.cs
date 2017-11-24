using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Security.Principal;
using System.Windows.Forms;
using WcfServicioBaseDatos;

namespace Servidor {

    class ServidorWCF {

        static void Main(string[] args) {
            ServidorWCF ser = new ServidorWCF();
            if(ser.EsAdministrador())
                ser.LevantarServidor();
            else
                MessageBox.Show("¿Lo estás ejecutando como administrador?", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LevantarServidor() {
            using (ServiceHost host = new ServiceHost(typeof(ServicioBD))) {
                host.Open();
                
                Console.WriteLine("Servidor arriba");
                Console.WriteLine("\n");
                Console.WriteLine(" Configuration Name: " + host.Description.ConfigurationName);
                Console.WriteLine(" End point address: " + host.Description.Endpoints[0].Address);
                Console.WriteLine("\n");
                Console.WriteLine("Servidor en uso, presion ctrl+c para finalizar...");

                Console.ReadLine();
                host.Close();
            }
        }

        private bool EsAdministrador() {
            bool isAdmin = false;
            WindowsIdentity usuarioActual = WindowsIdentity.GetCurrent();
            if (usuarioActual != null) {
                WindowsPrincipal principal = new WindowsPrincipal(usuarioActual);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                //se libera el espacio
                principal = null;
            }
            return isAdmin;
        }
    }
}
