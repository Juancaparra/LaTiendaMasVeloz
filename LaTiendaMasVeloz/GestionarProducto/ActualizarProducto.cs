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
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            //ProductoEntity producto = new ProductoEntity
            //{
            //    referencia = tbReferencia.Text,
            //    nombre = tbNombre.Text,
            //    precio = decimal.Parse(tbPrecio.Text),
            //    marca = tbMarca.Text,
            //    stock = int.Parse(tbStock.Text),
            //};

            //if (!string.IsNullOrEmpty(tbReferenciaActualizar.Text))
            //{
            //    producto.referencia = tbReferenciaActualizar.Text;
            //}

            //ProductoController pc = new ProductoController();
            //string resultado = pc.ActualizarProducto(producto);

            //lbResultadoActualizar.Text = resultado;
        }
    }
}
