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

namespace Principal.GestionarFacturaProveedor
{
    public partial class ActualizarFactura : Form
    {
        private FacturaProveedorController controller = new FacturaProveedorController();
        private List<FacturaProveedorEntity> productos = new List<FacturaProveedorEntity>();

        public ActualizarFactura()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text.Trim();
            string nombre = tbNombre.Text.Trim();
            decimal precio;
            int cantidad;

            if (string.IsNullOrEmpty(referencia) || string.IsNullOrEmpty(nombre) ||
                !decimal.TryParse(tbPrecio.Text, out precio) || !int.TryParse(tbCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = new FacturaProveedorEntity
            {
                Referencia = referencia,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
            };

            productos.Add(producto);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            decimal total = 0;

            foreach (var producto in productos)
            {
                decimal subtotal = producto.Precio * producto.Cantidad;
                total += subtotal;

                dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, subtotal);
            }

            totalVenta.Text = $"Total: {total:C2}";
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int idFactura;
            if (!int.TryParse(tbIdFactura.Text.Trim(), out idFactura))
            {
                MessageBox.Show("Por favor, ingrese un ID de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nit = tbNit.Text.Trim();
            if (string.IsNullOrEmpty(nit))
            {
                MessageBox.Show("Por favor, ingrese el NIT del proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var producto in productos)
            {
                producto.IdFactura = idFactura;
                producto.Nit = nit;
                producto.FechaLlegada = fechaLlegada.Value;

                bool actualizado = controller.ActualizarFacturaProveedor(producto);
                if (!actualizado)
                {
                    MessageBox.Show($"No se pudo actualizar el producto con referencia {producto.Referencia}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Factura actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            tbIdFactura.Clear();
            tbNit.Clear();
            tbReferencia.Clear();
            tbNombre.Clear();
            tbPrecio.Clear();
            tbCantidad.Clear();
            productos.Clear();
            ActualizarTabla();
        }

       
    }
}
