using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VentaController
    {
        private BaseDatos db = new BaseDatos();

        public bool ValidarEmpleado(string cedula)
        {
            return db.ValidarEmpleado(cedula);
        }

        public bool ValidarCliente(string cedula)
        {
            return db.ValidarCliente(cedula);
        }

        public ProductoEntity ConsultarProductoPorReferencia(string referencia)
        {
            return db.ConsultarProductoPorReferencia(referencia);
        }

        public int RegistrarVenta(string cedulaEmpleado, string cedulaCliente, DateTime fecha, List<DetalleVentaEntity> detalles)
        {
            return db.RegistrarVenta(cedulaEmpleado, cedulaCliente, fecha, detalles);
        }

        public VentaEntity ConsultarVentaPorId(int idVenta)
        {
            BaseDatos db = new BaseDatos();
            return db.ConsultarVentaPorId(idVenta); 
        }

        public bool ActualizarVenta(int idVenta, string cedulaEmpleado, string cedulaCliente, DateTime fecha, List<DetalleVentaEntity> detalles)
        {
            BaseDatos db = new BaseDatos();

            if (!db.ValidarCliente(cedulaCliente))
            {
                throw new Exception("La cédula del cliente no existe.");
            }

            if (!db.ValidarEmpleado(cedulaEmpleado))
            {
                throw new Exception("La cédula del empleado no existe.");
            }

            return db.ActualizarVenta(idVenta, cedulaEmpleado, cedulaCliente, fecha, detalles);
        }

        public ProductoEntity ObtenerProducto(string referencia)
        {
            BaseDatos db = new BaseDatos();
            if (db.ValidarProducto(referencia))
            {
                return db.ConsultarProductoPorReferencia(referencia);
            }
            return null;
        }

        public bool EliminarVenta(int idFactura)
        {
            return db.EliminarVenta(idFactura);
        }
    }
}
