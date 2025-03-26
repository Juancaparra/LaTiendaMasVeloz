using Principal;
using Principal.GestionarInventario;

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
    }
}

