using Principal;

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
        }
    }

