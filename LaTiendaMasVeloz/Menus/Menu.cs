using Principal;
using Principal.GestionarClientes;
using Principal.GestionarEmpleado;
using Principal.GestionarProveedor;
using Principal.GestionarVenta;
using Principal.GestionarFacturaProveedor;

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

        private void BtGestionarCliente_Click(object sender, EventArgs e)
        {
            GestionarClientes gestionarCliente = new GestionarClientes();
            gestionarCliente.ShowDialog();
        }

        private void BtGestionarEmpleados_Click(object sender, EventArgs e)
        {
            GestionarEmpleado gestionarEmpleado = new GestionarEmpleado();
            gestionarEmpleado.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarProveedor gestionarProveedor = new GestionarProveedor();
            gestionarProveedor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionarVenta gestionarVenta = new GestionarVenta();
            gestionarVenta.ShowDialog();
        }

        private void btGestionarFacturaProveedores_Click(object sender, EventArgs e)
        {
            GestionarFacturaProveedor gestionarFacturaProveedor = new GestionarFacturaProveedor();
            gestionarFacturaProveedor.ShowDialog();
        }
    }
}

