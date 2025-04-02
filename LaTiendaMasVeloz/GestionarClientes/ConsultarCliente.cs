using Logica;
using Modelo;
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


namespace Principal.GestionarClientes
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string cedula = tbCedula.Text;
            ClienteController controller = new ClienteController();
            ClienteEntity cliente;
            string resultado = controller.MostrarCliente(cedula, out cliente);

            if (cliente != null && cliente.id_cliente != 0)
            {
                lbNombreConsultar.Text = "Nombre: " + cliente.nombre;
                lbTelefonoConsultar.Text = "Telefono: " + cliente.telefono;
            }
            else
            {
                lbResultadoConsultar.Text = resultado;
            }
        }
    }
}