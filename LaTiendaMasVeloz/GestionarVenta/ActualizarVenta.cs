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

namespace Principal.GestionarVenta
{
    public partial class ActualizarVenta : Form
    {

        private VentaController controller = new VentaController();

        public ActualizarVenta()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text;
            int cantidad;

            if (string.IsNullOrEmpty(referencia) || !int.TryParse(tbCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una referencia válida y una cantidad mayor a 0.");
                return;
            }

            ProductoEntity producto = controller.ObtenerProducto(referencia);

            if (producto != null)
            {
                decimal valorTotal = producto.precio * cantidad;
                dataGridView1.Rows.Add(producto.referencia, producto.nombre, producto.precio, cantidad, valorTotal);
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("El producto no existe.");
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column4"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Column4"].Value);
                }
            }

            totalVenta.Text += total.ToString("C");
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int idVenta;
            if (!int.TryParse(tbIdVenta.Text, out idVenta))
            {
                MessageBox.Show("Ingrese un ID de venta válido.");
                return;
            }

            string cedulaCliente = tbCliente.Text;
            string cedulaEmpleado = tbEmpleado.Text;
            DateTime fecha = fechaVenta.Value;

            List<DetalleVentaEntity> detalles = new List<DetalleVentaEntity>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column5"].Value != null)
                {
                    detalles.Add(new DetalleVentaEntity
                    {
                        Referencia = row.Cells["Column5"].Value.ToString(),
                        PrecioUnitario = Convert.ToDecimal(row.Cells["Column2"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Column3"].Value),
                        PrecioTotal = Convert.ToDecimal(row.Cells["Column4"].Value)
                    });
                }
            }

            try
            {
                if (controller.ActualizarVenta(idVenta, cedulaEmpleado, cedulaCliente, fecha, detalles))
                {
                    MessageBox.Show("Venta actualizada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
