using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteController
    {
        public string GuardarCliente(string cedula, string nombre, string telefono)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarCliente(cedula, nombre, telefono);

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
        public string MostrarCliente(string cedula, out ClienteEntity cliente)
        {
            BaseDatos db = new BaseDatos();

            cliente = db.MostrarCliente(cedula);

            if (cliente == null || cliente.id_cliente == 0)
            {
                return "Cliente no encontrado";
            }
            return "Cliente encontrado";
        }
        public string ActualizarCliente(ClienteEntity cliente)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasActualizadas = db.ActualizarCliente(cliente);

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

        public string EliminarCliente(string cedula)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasEliminadas = db.EliminarCliente(cedula);

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
