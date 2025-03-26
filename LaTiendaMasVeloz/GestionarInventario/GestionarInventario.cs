using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GestionarInventario
{
    public partial class GestionarInventario : Form
    {
        public GestionarInventario()
        {
            InitializeComponent();
        }

        private void BtAgregarInventario_Click(object sender, EventArgs e)
        {
            AgregarInventario agregarInventario = new AgregarInventario();
            agregarInventario.ShowDialog();
        }

        private void BtConsultarInventario_Click(object sender, EventArgs e)
        {
            ConsultarInventario consultarInventario = new ConsultarInventario();
            consultarInventario.ShowDialog();  

        }

        private void BtEliminarInventario_Click(object sender, EventArgs e)
        {
            EliminarInventario eliminarInventario = new EliminarInventario();
            eliminarInventario.ShowDialog();
        }
    }
}
