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
    public partial class EliminarProveedor : Form
    {
        public EliminarProveedor()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string nit = tbNIT.Text;
            ProveedorController controller = new ProveedorController();
            string resultado = controller.EliminarProveedor(nit);
            lbResultadoEliminar.Text = resultado;
        }
    }
}
