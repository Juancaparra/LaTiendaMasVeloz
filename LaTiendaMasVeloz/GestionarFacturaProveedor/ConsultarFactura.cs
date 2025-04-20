using Modelo.Entities;
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

namespace Principal.GestionarFacturaProveedor
{
    public partial class ConsultarFactura : Form
    {
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int idFactura;
            if (!int.TryParse(tbNit.Text.Trim(), out idFactura))
            {
                MessageBox.Show("Por favor, ingrese un número de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FacturaProveedorEntity factura = FacturaProveedorController.ConsultarFacturaProveedor(idFactura);

            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura con el número proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos de la factura
            label7.Text += factura.IdFactura.ToString();
            lbNitProveedor.Text += factura.Nit;
            lbFechaLlegada.Text += factura.FechaLlegada.ToString("dd/MM/yyyy");

            // Mostrar productos en la tabla
            dataGridView1.Rows.Clear();
            decimal total = 0;

            foreach (var producto in factura.Productos)
            {
                decimal subtotal = producto.precio * producto.stock;
                total += subtotal;

                dataGridView1.Rows.Add(producto.referencia, producto.nombre, producto.precio, producto.stock, subtotal);
            }

            totalVenta.Text = $"Total: {total:C2}";
        }
    }
}
