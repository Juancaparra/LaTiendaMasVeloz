using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class EmpleadoEntity
    {
        public int id_empleado { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string rol { get; set; } 
    }
}
