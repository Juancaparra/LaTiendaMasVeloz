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
        public ProveedorEntity MostrarProveedor(string nit)
        {
            BaseDatos db = new BaseDatos();

            ProveedorEntity proveedor = db.MostrarProveedor(nit);

            return proveedor;
        }
    }
}
