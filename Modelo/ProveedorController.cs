using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProveedorController
    {
        public string GuardarProveedor(string nit, string nombre, string telefono)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarProveedor(nit, nombre, telefono);

            if (filasInsertadas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No Guardado";
            }
            return resultado;
        }

        public string MostrarProveedor(string nit, out ProveedorEntity proveedor)
        {
            BaseDatos db = new BaseDatos();
            proveedor = db.MostrarProveedor(nit);

            if (proveedor == null || proveedor.id_proveedor == 0)
            {
                return "Proveedor no encontrado";
            }
            return "Proveedor encontrado";
        }

        public string ActualizarProveedor(ProveedorEntity proveedor)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasActualizadas = db.ActualizarProveedor(proveedor);

            if (filasActualizadas > 0)
            {
                resultado = "Actualizado";
            }
            else
            {
                resultado = "No Actualizado";
            }
            return resultado;
        }

        public string EliminarProveedor(string nit)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasEliminadas = db.EliminarProveedor(nit);

            if (filasEliminadas > 0)
            {
                resultado = "Eliminado";
            }
            else
            {
                resultado = "No Eliminado";
            }
            return resultado;
        }
    }
}