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
            string referencia = tbReferencia.Text.Trim();

            if (string.IsNullOrEmpty(referencia))
            {
                MessageBox.Show("Por favor, ingrese una referencia válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductoController controller = new ProductoController();
            ProductoEntity producto = controller.ConsultarProducto(referencia);

            if (producto != null)
            {
                lbNombreConsultar.Text += producto.nombre;
                lbPrecioConsultar.Text += producto.precio.ToString("F2");
                lbMarcaConsultar.Text += producto.marca;
                lbStock.Text += producto.stock.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbStock_Click(object sender, EventArgs e)
        {

        }
    }
}
