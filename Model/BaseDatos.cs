using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        public int GuardarCliente(string cedula, string nombre, string telefono)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Cliente (cedula, nombre, telefono) VALUES ('" + cedula + "','" + nombre + "','" + telefono + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public ClienteEntity MostrarCliente(string cedula)
        {
            ClienteEntity ClienteActual = new ClienteEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Cliente WHERE cedula = @cedula LIMIT 1";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ClienteActual.id_cliente = reader.GetInt32(reader.GetOrdinal("id_cliente"));
                ClienteActual.cedula = reader.GetString(reader.GetOrdinal("cedula"));
                ClienteActual.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                ClienteActual.telefono = reader.GetString(reader.GetOrdinal("telefono"));
            }

            return ClienteActual;
        }
    }
}