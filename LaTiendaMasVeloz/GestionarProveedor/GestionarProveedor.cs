using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarProveedor
{
    public partial class GestionarProveedor : Form
    {
        public GestionarProveedor()
        {
            InitializeComponent();
        }

        private void BtRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarProveedor registrarProveedor = new RegistrarProveedor();
            registrarProveedor.ShowDialog();
        }

        private void BtConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarProveedor consultarProveedor = new ConsultarProveedor();
            consultarProveedor.ShowDialog();
        }

        private void BtActualizarCliente_Click(object sender, EventArgs e)
        {
            ActualizarProveedor actualizarProveedor = new ActualizarProveedor();
            actualizarProveedor.ShowDialog();
        }

        private void BtEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarProveedor eliminarProveedor =new EliminarProveedor();
            eliminarProveedor.ShowDialog();
        }
    }
}
