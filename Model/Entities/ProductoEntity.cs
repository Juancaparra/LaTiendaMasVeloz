using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int id_producto { get; set; }
        public string referencia { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string marca { get; set; }
        public int stock { get; set; }
        public string ProveedorNombre { get; set; } 
    }
}