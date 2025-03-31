using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarClientes
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            ClienteController controller = new ClienteController();
            string resultado = controller.GuardarCliente(tbCedula.Text, tbNombre.Text, tbTelefono.Text);
            lbResultadoRegistrar.Text = resultado;
        }
    }
}
