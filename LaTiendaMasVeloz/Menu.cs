using Principal;
using Principal.GestionarInventario;
using Principal.GestionarClientes;

namespace LaTiendaMasVeloz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtGestionarProductos_Click(object sender, EventArgs e)
        {
            GestionarProductos gesProductos = new GestionarProductos();
            gesProductos.ShowDialog();
        }

        private void BtGestionarInventario_Click(object sender, EventArgs e)
        {
            GestionarInventario gesInventario = new GestionarInventario();
            gesInventario.ShowDialog();
        }

        private void BtGestionarCliente_Click(object sender, EventArgs e)
        {
            GestionarClientes gestionarCliente = new GestionarClientes();
            gestionarCliente.ShowDialog();
        }
    }
}

