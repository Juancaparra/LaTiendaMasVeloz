using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class FacturaProveedorController
    {
        private BaseDatos db = new BaseDatos();

        public bool ValidarProveedor(string nit)
        {
            return db.ValidarProveedor(nit);
        }

        public bool ValidarProducto(string referencia)
        {
            return db.ValidarProducto(referencia);
        }

        public int RegistrarFacturaProveedor(FacturaProveedorEntity factura)
        {
            return db.RegistrarFacturaProveedor(factura);
        }

        public static FacturaProveedorEntity ConsultarFacturaProveedor(int idFactura)
        {
            BaseDatos db = new BaseDatos();
            return db.ConsultarFacturaProveedor(idFactura);
        }

        public static bool EliminarFacturaProveedor(int idFactura)
        {
            BaseDatos db = new BaseDatos();
            return db.EliminarFacturaProveedor(idFactura);
        }
    }
}