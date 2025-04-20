using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaProveedorEntity
    {
        public int IdFactura { get; set; }
        public string Nit { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public List<ProductoEntity> Productos { get; set; }

    }
}
