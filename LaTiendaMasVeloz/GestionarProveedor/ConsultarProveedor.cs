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
            BaseDatos bd = new BaseDatos();
            ProveedorEntity proveedor = bd.MostrarProveedor(nit);

            lbNombreConsultar.Text = "Nombre: " + proveedor.nombre;
            lbTelefonoConsultar.Text = "Telefono: " + proveedor.telefono;
        }
    }
}
