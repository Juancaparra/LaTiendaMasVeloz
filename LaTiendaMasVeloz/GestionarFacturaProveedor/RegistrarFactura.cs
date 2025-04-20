using Modelo.Entities;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Principal.GestionarFacturaProveedor
{
    public partial class RegistrarFactura : Form
    {


        public RegistrarFactura()
        {
            InitializeComponent();
        }

        private FacturaProveedorController controller = new FacturaProveedorController();
        private List<FacturaProveedorEntity> productos = new List<FacturaProveedorEntity>();

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

            if (!controller.ValidarProducto(referencia))
            {
                MessageBox.Show("La referencia del producto no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = new FacturaProveedorEntity
            {
                Referencia = referencia,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad,
                FechaLlegada = fechaLlegada.Value
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

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string nit = tbNit.Text.Trim();

            if (string.IsNullOrEmpty(nit) || !controller.ValidarProveedor(nit))
            {
                MessageBox.Show("El NIT del proveedor no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var producto in productos)
            {
                producto.Nit = nit;
                controller.RegistrarFacturaProveedor(producto);
            }

            MessageBox.Show("Factura registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
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