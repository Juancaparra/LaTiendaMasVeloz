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
    public partial class RegistrarVenta : Form
    {
        private VentaController controller = new VentaController();
        private List<DetalleVentaEntity> detalles = new List<DetalleVentaEntity>();

        public RegistrarVenta()
        {
            InitializeComponent();
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text.Trim();
            int cantidad;

            if (string.IsNullOrEmpty(referencia) || !int.TryParse(tbCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, complete los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductoEntity producto = controller.ConsultarProductoPorReferencia(referencia);
            if (producto == null)
            {
                MessageBox.Show("El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (producto.stock < cantidad)
            {
                MessageBox.Show($"No hay suficiente stock para el producto con referencia '{producto.referencia}'. Stock disponible: {producto.stock}, cantidad solicitada: {cantidad}.",
                                "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var detalle = new DetalleVentaEntity
            {
                Referencia = producto.referencia,
                PrecioUnitario = producto.precio,
                Cantidad = cantidad,
                PrecioTotal = producto.precio * cantidad
            };

            detalles.Add(detalle);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            decimal total = 0;

            foreach (var detalle in detalles)
            {
                total += detalle.PrecioTotal;
                dataGridView1.Rows.Add(detalle.Referencia, detalle.PrecioUnitario, detalle.Cantidad, detalle.PrecioTotal);
            }

            totalVenta.Text = $"Total: {total:C2}";
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string cedulaEmpleado = tbCedulaEmpleado.Text.Trim();
            string cedulaCliente = tbCliente.Text.Trim();

            if (string.IsNullOrEmpty(cedulaEmpleado) || string.IsNullOrEmpty(cedulaCliente))
            {
                MessageBox.Show("Por favor, complete las cédulas del empleado y cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!controller.ValidarEmpleado(cedulaEmpleado))
            {
                MessageBox.Show("La cédula del empleado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!controller.ValidarCliente(cedulaCliente))
            {
                MessageBox.Show("La cédula del cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idVenta = controller.RegistrarVenta(cedulaEmpleado, cedulaCliente, dateTimePicker1.Value, detalles);
            MessageBox.Show($"Venta registrada exitosamente con ID: {idVenta}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();

        }

        private void LimpiarFormulario()
        {
            tbCedulaEmpleado.Clear();
            tbCliente.Clear();
            tbReferencia.Clear();
            tbCantidad.Clear();
            detalles.Clear();
            ActualizarTabla();
        }


    }
}
