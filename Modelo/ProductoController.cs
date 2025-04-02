﻿using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoController
    {
        public string GuardarProducto(ProductoEntity producto)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarProducto(producto);

            if (filasInsertadas > 0)
            {
                resultado = "Producto guardado correctamente";
            }
            else
            {
                resultado = "Error al guardar el producto";
            }
            return resultado;
        }

        public string EliminarProducto(string referencia)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasEliminadas = db.EliminarProducto(referencia);

            if (filasEliminadas > 0)
            {
                resultado = "Producto eliminado correctamente";
            }
            else
            {
                resultado = "Error al eliminar el producto";
            }
            return resultado;
        }
    }
}
