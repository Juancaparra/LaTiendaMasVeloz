using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarVenta
{
    public partial class GestionarVenta : Form
    {
        public GestionarVenta()
        {
            InitializeComponent();
        }

        private void BtRegistrarVenta_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta();
            registrarVenta.ShowDialog();
        }

        private void BtConsultarVenta_Click(object sender, EventArgs e)
        {
            ConsultarVenta consultarVenta = new ConsultarVenta();
            consultarVenta.ShowDialog();
        }

        private void BtActualizarVenta_Click(object sender, EventArgs e)
        {
            ActualizarVenta actualizarVenta = new ActualizarVenta();
            actualizarVenta.ShowDialog();
        }

        private void BtEliminarVenta_Click(object sender, EventArgs e)
        {
            EliminarVenta eliminarVenta= new EliminarVenta();
            eliminarVenta.ShowDialog();
        }
    }
}
