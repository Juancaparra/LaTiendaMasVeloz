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

namespace Principal.GestionarEmpleado
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            EmpleadoController controller = new EmpleadoController();
            string rol = comboBoxRol.SelectedItem.ToString();
            string resultado = controller.GuardarEmpleado(tbCedula.Text, tbNombre.Text, tbUsuario.Text, tbContraseña.Text, rol);
            lbResultadoRegistrar.Text = resultado;
        }

    }
}
