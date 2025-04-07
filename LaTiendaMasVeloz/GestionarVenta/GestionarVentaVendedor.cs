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
    public partial class GestionarVentaVendedor : Form
    {
        public GestionarVentaVendedor()
        {
            InitializeComponent();
        }

        private void BtRegistrarVentaVendedor_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta();
            registrarVenta.ShowDialog();
        }

        private void btConsultarVentaVendedor_Click(object sender, EventArgs e)
        {
            ConsultarVenta consultarVenta = new ConsultarVenta();
            consultarVenta.ShowDialog();
        }

        private void btActualizarVentaVendedor_Click(object sender, EventArgs e)
        {
            ActualizarProducto actualizarProducto = new ActualizarProducto();
            actualizarProducto.ShowDialog();
        }
    }
}
