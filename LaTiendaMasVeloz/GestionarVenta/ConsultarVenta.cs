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
    public partial class ConsultarVenta : Form
    {

        private VentaController controller = new VentaController();

        public ConsultarVenta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int idVenta;
            if (!int.TryParse(tbIdFactura.Text.Trim(), out idVenta))
            {
                MessageBox.Show("Por favor, ingrese un número de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VentaEntity venta = controller.ConsultarVentaPorId(idVenta);

            if (venta == null)
            {
                MessageBox.Show("No se encontró la venta con el número proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos de la venta
            label7.Text += venta.IdVenta.ToString();
            label4.Text += venta.CedulaEmpleado;
            label5.Text += venta.CedulaCliente;

            // Mostrar productos en la tabla
            dataGridView1.Rows.Clear();
            decimal total = 0;

            foreach (var detalle in venta.Detalles)
            {
                total += detalle.PrecioTotal;
                dataGridView1.Rows.Add(detalle.Referencia, detalle.PrecioUnitario, detalle.Cantidad, detalle.PrecioTotal);
            }

            totalVenta.Text = $"Total: {total:C2}";
        }
    }
}
