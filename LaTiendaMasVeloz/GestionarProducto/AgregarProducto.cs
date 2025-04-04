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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        public void btRegistrar_Click(object sender, EventArgs e)
        {
            ProductoEntity producto = new ProductoEntity
            {
                referencia = tbReferencia.Text,
                nombre = tbNombre.Text,
                precio = decimal.Parse(tbPrecio.Text),
                marca = tbMarca.Text,
                stock = int.Parse(tbStock.Text),
                usuario = tbUsuario.Text,
                nit_proveedor = tbNitProveedor.Text,
                fechaLlegada = fechaLlegada.Value
            };

            ProductoController pc = new ProductoController();
            string resultado = pc.GuardarProducto(producto);

            lbResultado.Text = resultado;
        }
    }
}
