﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProveedorEntity
    {
        public int id_proveedor { get; set; }
        public string nuevoNit { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
    }
}
