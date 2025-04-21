using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class VentaEntity
    {
        public int IdVenta { get; set; }
        public string CedulaEmpleado { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVentaEntity> Detalles { get; set; }
    }
}
