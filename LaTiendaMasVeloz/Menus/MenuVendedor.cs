using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Principal.Menus
{
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void BtGestionarCliente_Click(object sender, EventArgs e)
        {
            Principal.GestionarClientes.GestionarClientes gestionarCliente = new Principal.GestionarClientes.GestionarClientes();
            gestionarCliente.ShowDialog();
        }

        private void btGestionarVenta_Click(object sender, EventArgs e)
        {
            Principal.GestionarVenta.GestionarVenta gestionarVenta = new Principal.GestionarVenta.GestionarVenta();
            gestionarVenta.ShowDialog();
        }
    }
}
