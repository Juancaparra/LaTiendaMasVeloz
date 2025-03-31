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
        public ClienteEntity MostrarCliente(string cedula)
        {
            BaseDatos db = new BaseDatos();

            ClienteEntity cliente = db.MostrarCliente(cedula);

            return cliente;
        }
    }
}
