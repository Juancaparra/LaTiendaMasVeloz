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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string cedula = tbCedula.Text;
            ClienteController controller = new ClienteController();
            string resultado = controller.EliminarCliente(cedula);
            lbResultadoEliminar.Text = resultado;
        }
    }
}
