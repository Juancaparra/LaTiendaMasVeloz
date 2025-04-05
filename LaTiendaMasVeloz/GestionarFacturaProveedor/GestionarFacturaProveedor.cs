using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarFacturaProveedor
{
    public partial class GestionarFacturaProveedor : Form
    {
        public GestionarFacturaProveedor()
        {
            InitializeComponent();
        }

        private void BtRegistrarFactura_Click(object sender, EventArgs e)
        {
            RegistrarFactura registrarFactura = new RegistrarFactura();
            registrarFactura.ShowDialog();
        }

        private void BtConsultarFactura_Click(object sender, EventArgs e)
        {
            ConsultarFactura consultarFactura = new ConsultarFactura();
            consultarFactura.ShowDialog();

        }

        private void BtActualizarFactura_Click(object sender, EventArgs e)
        {
            ActualizarFactura actualizarFactura = new ActualizarFactura();
            actualizarFactura.ShowDialog();
        }

        private void BtEliminarFactura_Click(object sender, EventArgs e)
        {
            EliminarFactura eliminarFactura = new EliminarFactura();
            eliminarFactura.ShowDialog();
        }
    }
}
