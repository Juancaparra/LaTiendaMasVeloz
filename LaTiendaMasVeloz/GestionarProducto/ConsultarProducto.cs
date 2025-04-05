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
            ProductoController pc = new ProductoController();
            ProductoEntity producto;
            string resultado = pc.ConsultarProducto(tbReferencia.Text, out producto);

            if (producto != null && producto.id_producto != 0)
            {
                lbNombreConsultar.Text += producto.nombre;
                lbPrecioConsultar.Text += producto.precio.ToString();
                lbMarcaConsultar.Text += producto.marca;
                lbStock.Text += producto.stock.ToString();
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
