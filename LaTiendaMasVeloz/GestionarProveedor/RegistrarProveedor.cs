using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarProveedor
{
    public partial class RegistrarProveedor : Form
    {
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            ProveedorController controller = new ProveedorController();
            string resultado = controller.GuardarProveedor(tbNIT.Text, tbNombre.Text, tbTelefono.Text);
            lbResultadoRegistrar.Text = resultado;
        }
    }
}
