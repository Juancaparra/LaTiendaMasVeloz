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

namespace Principal.GestionarEmpleado
{
    public partial class ConsultarEmpleado : Form
    {
        public ConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string cedula = tbCedula.Text;
            BaseDatos bd = new BaseDatos();
            EmpleadoEntity empleado = bd.MostrarEmpleado(cedula);

            lbNombreConsultar.Text = "Nombre: " + empleado.nombre;
            lbUsuarioConsultar.Text = "Usuario: " + empleado.usuario;
            rol.Text = "Rol: " + empleado.rol; 
        }
    }
}
