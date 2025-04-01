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

namespace Principal.GestionarProveedor
{
    public partial class ActualizarProveedor : Form
    {
        public ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void ActualizarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            ProveedorEntity proveedor = new ProveedorEntity
            {
                nit = tbNIT.Text,
                nuevoNit = textBox3.Text,
                nombre = textBox1.Text,
                telefono = textBox2.Text
            };

            ProveedorController pc = new ProveedorController();
            string resultado = pc.ActualizarProveedor(proveedor);

            lbResultado.Text = resultado;
        }
    }
}