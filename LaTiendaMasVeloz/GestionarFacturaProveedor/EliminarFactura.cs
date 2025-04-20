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
    public partial class EliminarFactura : Form
    {
        public EliminarFactura()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int idFactura;
            if (!int.TryParse(tbNumeroFactura.Text.Trim(), out idFactura))
            {
                MessageBox.Show("Por favor, ingrese un número de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta factura?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                bool eliminado = FacturaProveedorController.EliminarFacturaProveedor(idFactura);
                if (eliminado)
                {
                    MessageBox.Show("Factura eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumeroFactura.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró la factura con el número proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
