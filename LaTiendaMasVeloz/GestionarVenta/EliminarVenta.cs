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

namespace Principal.GestionarVenta
{
    public partial class EliminarVenta : Form
    {
        public EliminarVenta()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNumeroFactura.Text, out int idFactura))
            {
                VentaController ventaController = new VentaController();
                try
                {
                    bool resultado = ventaController.EliminarVenta(idFactura);
                    if (resultado)
                    {
                        lbResultadoEliminar.Text = "Venta eliminada correctamente.";
                    }
                    else
                    {
                        lbResultadoEliminar.Text = "No se encontró la venta con el ID proporcionado.";
                    }
                }
                catch (Exception ex)
                {
                    lbResultadoEliminar.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                lbResultadoEliminar.Text = "Por favor, ingrese un ID de factura válido.";
            }
        }
    }
}
