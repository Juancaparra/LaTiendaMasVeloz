using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
        }

        private void BtAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
        }

        private void BtConsultarProducto_Click(object sender, EventArgs e)
        {
             ConsultarProducto consultarProducto= new ConsultarProducto();
            consultarProducto.ShowDialog();
        }

        private void BtActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto actualizarProducto= new ActualizarProducto();    
            actualizarProducto.ShowDialog();
        }

        private void BtEliminarProducto_Click(object sender, EventArgs e)
        {
           EliminarProducto eliminarProducto= new EliminarProducto();
            eliminarProducto.ShowDialog();
        }
    }
}
