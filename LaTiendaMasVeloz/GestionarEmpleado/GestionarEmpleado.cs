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
    public partial class GestionarEmpleado : Form
    {
        public GestionarEmpleado()
        {
            InitializeComponent();
        }

        private void BtRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado registrarEmpleado = new RegistrarEmpleado();
            registrarEmpleado.ShowDialog();
        }

        private void BtConsultarEmpleado_Click(object sender, EventArgs e)
        {
            ConsultarEmpleado consultarEmpleado = new ConsultarEmpleado();
            consultarEmpleado.ShowDialog();
        }

        private void BtActualizarEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado actualizarEmpleado = new ActualizarEmpleado();
            actualizarEmpleado.ShowDialog();
        }

        private void BtEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado eliminarEmpleado = new EliminarEmpleado();
            eliminarEmpleado.ShowDialog();
        }
    }
}
