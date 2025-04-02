using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        public int GuardarCliente(string cedula, string nombre, string telefono)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Cliente (cedula, nombre, telefono) VALUES (@cedula, @nombre, @telefono)";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
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

        public int ActualizarCliente(ClienteEntity cliente)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Cliente SET nombre = @nombre, telefono = @telefono" +
                              (string.IsNullOrEmpty(cliente.nuevoCedula) ? "" : ", cedula = @nuevoCedula") +
                              " WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cliente.cedula);
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            if (!string.IsNullOrEmpty(cliente.nuevoCedula))
            {
                cmd.Parameters.AddWithValue("@nuevoCedula", cliente.nuevoCedula);
            }
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarCliente(string cedula)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int GuardarProveedor(string nit, string nombre, string telefono)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Proveedor (nit, nombre, telefono) VALUES (@nit, @nombre, @telefono)";
            cmd.Parameters.AddWithValue("@nit", nit);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public ProveedorEntity MostrarProveedor(string nit)
        {
            ProveedorEntity ProveedorActual = new ProveedorEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Proveedor WHERE nit = @nit LIMIT 1";
            cmd.Parameters.AddWithValue("@nit", nit);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProveedorActual.id_proveedor = reader.GetInt32(reader.GetOrdinal("id_proveedor"));
                ProveedorActual.nit = reader.GetString(reader.GetOrdinal("nit"));
                ProveedorActual.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                ProveedorActual.telefono = reader.GetString(reader.GetOrdinal("telefono"));
            }

            return ProveedorActual;
        }

        public int ActualizarProveedor(ProveedorEntity proveedor)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Proveedor SET nombre = @nombre, telefono = @telefono" +
                              (string.IsNullOrEmpty(proveedor.nuevoNit) ? "" : ", nit = @nuevoNit") +
                              " WHERE nit = @nit";
            cmd.Parameters.AddWithValue("@nit", proveedor.nit);
            cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
            cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
            if (!string.IsNullOrEmpty(proveedor.nuevoNit))
            {
                cmd.Parameters.AddWithValue("@nuevoNit", proveedor.nuevoNit);
            }
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarProveedor(string nit)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Proveedor WHERE nit = @nit";
            cmd.Parameters.AddWithValue("@nit", nit);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int GuardarEmpleado(string cedula, string nombre, string usuario, string contraseña)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Empleado (cedula, nombre, usuario, contraseña) VALUES (@cedula, @nombre, @usuario, @contraseña)";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public EmpleadoEntity MostrarEmpleado(string cedula)
        {
            EmpleadoEntity EmpleadoActual = new EmpleadoEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Empleado WHERE cedula = @cedula LIMIT 1";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmpleadoActual.id_empleado = reader.GetInt32(reader.GetOrdinal("id_empleado"));
                EmpleadoActual.cedula = reader.GetString(reader.GetOrdinal("cedula"));
                EmpleadoActual.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                EmpleadoActual.usuario = reader.GetString(reader.GetOrdinal("usuario"));
                EmpleadoActual.contraseña = reader.GetString(reader.GetOrdinal("contraseña"));

            }

            return EmpleadoActual;
        }
    }
}