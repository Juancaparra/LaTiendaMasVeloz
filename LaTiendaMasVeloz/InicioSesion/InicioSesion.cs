using LaTiendaMasVeloz;
using Logica;
using Principal.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.InicioSesion
{
    public partial class InicioSesion : Form
    {
        private InicioSesionController inicioSesionController;

        public InicioSesion()
        {
            InitializeComponent();
            inicioSesionController = new InicioSesionController();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tbUsuario.Text;
            string contrasena = tbContraseña.Text;

            string resultado = inicioSesionController.IniciarSesion(nombreUsuario, contrasena);

            if (resultado == "Menu")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (resultado == "MenuVendedor")
            {
                MenuVendedor menuVendedor = new MenuVendedor();
                menuVendedor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


