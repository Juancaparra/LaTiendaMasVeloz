using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Security.Cryptography.Xml;

namespace Principal.GestionarProveedor
{
    public partial class ConsultarProveedor : Form
    {
        public ConsultarProveedor()
        {
            InitializeComponent();
        }

        private void ConsultarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string nit = tbNIT.Text;
            ProveedorController controller = new ProveedorController();
            ProveedorEntity proveedor;
            string resultado = controller.MostrarProveedor(nit, out proveedor);

            if (proveedor != null && proveedor.id_proveedor != 0)
            {
                lbNombreConsultar.Text = "Nombre: " + proveedor.nombre;
                lbTelefonoConsultar.Text = "Telefono: " + proveedor.telefono;
            }
            else
            {
                lbResultadoConsultar.Text = resultado;
            }
            
        }
    }
}
