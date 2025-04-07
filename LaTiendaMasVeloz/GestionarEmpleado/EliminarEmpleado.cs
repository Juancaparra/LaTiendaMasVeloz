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
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EmpleadoController controller = new EmpleadoController();
            string cedula = tbCedula.Text;
            string resultado = controller.EliminarEmpleado(cedula);
            lbResultadoEliminar.Text = resultado;
        }
    }
}
