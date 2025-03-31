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
            BaseDatos bd = new BaseDatos();
            ClienteEntity cliente = bd.MostrarCliente(cedula);

            lbNombreConsultar.Text = "Nombre: " + cliente.nombre;
            lbTelefonoConsultar.Text = "Telefono: " + cliente.telefono;
        }
    }
}