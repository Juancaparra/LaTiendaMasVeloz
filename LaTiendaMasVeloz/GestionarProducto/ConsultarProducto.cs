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

namespace Principal
{
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text;
            ProductoController controller = new ProductoController();
            ProductoEntity producto;
            string resultado = controller.ConsultarProducto(referencia, out producto);

            if (producto != null && producto.id_producto != 0)
            {
                lbNombreConsultar.Text += producto.nombre;
                lbPrecioConsultar.Text += producto.precio.ToString();
                lbMarcaConsultar.Text += producto.marca;
                lbStock.Text += producto.stock.ToString();
                lbNombreGerente.Text += producto.gerente_nombre;
                lbNombreProveedor.Text += producto.proveedor_nombre;
            }
            else
            {
                lbResultadoConsultar.Text = resultado;
            }
        }

        private void lbStock_Click(object sender, EventArgs e)
        {

        }
    }
}
