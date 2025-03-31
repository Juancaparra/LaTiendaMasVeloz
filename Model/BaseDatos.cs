using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        public int GuardarCliente(string nombre, string descripcion, string autor)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Cliente (id_cliente, cedula, nombre, telefono) VALUES ('" + nombre + "','" + descripcion + "','" + autor + "')";
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
                ClienteActual.id_cliente = reader.GetInt32(1);
                ClienteActual.cedula = reader.GetString(2);
                ClienteActual.nombre = reader.GetString(3);
                ClienteActual.telefono = reader.GetString(4);
            }

            return ClienteActual;
        }
    }
}