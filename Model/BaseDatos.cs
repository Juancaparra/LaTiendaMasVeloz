using Modelo.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class BaseDatos:ConexionMySql
    {
        public int GuardarProducto(string nombre, string descripcion, string autor)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO libros (nombre,descripcion,autor) VALUES ('" + nombre + "','" + descripcion + "','" + autor + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }
    }
}
