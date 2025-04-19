using LaTiendaMasVeloz;
using Logica;
using Principal.Menus;
using System;
using System.Windows.Forms;

namespace Principal.InicioSesion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            try
            {
                InicioSesionController controller = new InicioSesionController();
                string rol = controller.IniciarSesion(usuario, contraseña)?.Trim().ToLower();

                if (rol == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Solo para verificar qué rol llega
                // MessageBox.Show($"Rol obtenido: '{rol}'");

                if (rol == "gerente" || rol == "supervisor")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else if (rol == "vendedor")
                {
                    MenuVendedor menuVendedor = new MenuVendedor();
                    menuVendedor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Rol no reconocido: '{rol}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
