using Logica;
using Modelo.Entities;
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
    public partial class ActualizarEmpleado : Form
    {
        public ActualizarEmpleado()
        {
            InitializeComponent();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            EmpleadoController controller = new EmpleadoController();
            EmpleadoEntity empleado = new EmpleadoEntity
            {
                cedula = tbCedula.Text,
                nombre = textBox1.Text,
                usuario = tbUsuario.Text,
                contraseña = tbContraseña.Text,
                rol = comboBoxRol.SelectedItem.ToString()
            };

            string nuevaCedula = tbCedulaActualizar.Text;
            string resultado = controller.ActualizarEmpleado(empleado, nuevaCedula);
            lbResultadoActualizar.Text = resultado;
        }
    }
}
