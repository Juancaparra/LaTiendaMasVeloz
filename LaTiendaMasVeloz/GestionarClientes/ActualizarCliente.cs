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

namespace Principal.GestionarClientes
{
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            ClienteEntity cliente = new ClienteEntity
            {
                cedula = tbCedula.Text,
                nuevoCedula = string.IsNullOrEmpty(tbNuevaCedula.Text) ? null : tbNuevaCedula.Text,
                nombre = tbNombre.Text,
                telefono = tbTelefono.Text
            };

            ClienteController cc = new ClienteController();
            string resultado = cc.ActualizarCliente(cliente);

            lbResultadoActualizar.Text = resultado;
        }
    }
}