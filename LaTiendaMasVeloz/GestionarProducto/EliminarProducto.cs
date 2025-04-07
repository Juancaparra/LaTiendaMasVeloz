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

namespace Principal
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text;
            ProductoController controller = new ProductoController();
            string resultado = controller.EliminarProducto(referencia);
            lbResultadoEliminar.Text = resultado;
        }
    }
}
