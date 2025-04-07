using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {

        public string VerificarCredenciales(string nombreUsuario, string contrasena)
        {
                string query = "SELECT Rol FROM empleado WHERE nombreUsuario = @nombreUsuario AND contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                var result = cmd.ExecuteScalar();

                return result?.ToString();
            
        }

        public int GuardarProducto(ProductoEntity producto)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Producto (referencia, nombre, precio, marca, stock) " +
                              "VALUES (@referencia, @nombre, @precio, @marca, @stock)";
            cmd.Parameters.AddWithValue("@referencia", producto.referencia);
            cmd.Parameters.AddWithValue("@nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@precio", producto.precio);
            cmd.Parameters.AddWithValue("@marca", producto.marca);
            cmd.Parameters.AddWithValue("@stock", producto.stock);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public ProductoEntity MostrarProducto(string referencia)
        {
            ProductoEntity producto = null;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = @"
        SELECT p.referencia, p.nombre, p.precio, p.marca, p.stock, pr.nombre AS proveedor_nombre
        FROM PRODUCTO p
        JOIN FACTURA_PROVEEDOR fp ON p.referencia = fp.referencia
        JOIN PROVEEDOR pr ON fp.nit = pr.nit
        WHERE p.referencia = @referencia
        LIMIT 1";
            cmd.Parameters.AddWithValue("@referencia", referencia);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                producto = new ProductoEntity
                {
                    referencia = reader.GetString(reader.GetOrdinal("referencia")),
                    nombre = reader.GetString(reader.GetOrdinal("nombre")),
                    precio = reader.GetDecimal(reader.GetOrdinal("precio")),
                    marca = reader.GetString(reader.GetOrdinal("marca")),
                    stock = reader.GetInt32(reader.GetOrdinal("stock")),
                    ProveedorNombre = reader.GetString(reader.GetOrdinal("proveedor_nombre"))
                };
            }

            return producto;
        }

        public int ActualizarProducto(ProductoEntity producto, string nuevaReferencia)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Producto SET " +
                              "nombre = @nombre, " +
                              "precio = @precio, " +
                              "marca = @marca, " +
                              "stock = @stock" +
                              (string.IsNullOrEmpty(nuevaReferencia) ? "" : ", referencia = @nuevaReferencia") +
                              " WHERE referencia = @referencia";
            cmd.Parameters.AddWithValue("@referencia", producto.referencia);
            cmd.Parameters.AddWithValue("@nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@precio", producto.precio);
            cmd.Parameters.AddWithValue("@marca", producto.marca);
            cmd.Parameters.AddWithValue("@stock", producto.stock);
            if (!string.IsNullOrEmpty(nuevaReferencia))
            {
                cmd.Parameters.AddWithValue("@nuevaReferencia", nuevaReferencia);
            }
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarProducto(string referencia)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Producto WHERE referencia = @referencia";
            cmd.Parameters.AddWithValue("@referencia", referencia);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

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

        public int GuardarEmpleado(string cedula, string nombre, string usuario, string contraseña, string rol)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Empleado (cedula, nombre, usuario, contraseña, rol) VALUES (@cedula, @nombre, @usuario, @contraseña, @rol)";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Parameters.AddWithValue("@rol", rol);
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
                EmpleadoActual.rol = reader.GetString(reader.GetOrdinal("rol")); // Nuevo campo
            }

            return EmpleadoActual;
        }

        public int ActualizarEmpleado(EmpleadoEntity empleado, string nuevaCedula)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Empleado SET nombre = @nombre, usuario = @usuario, contraseña = @contraseña, rol = @rol" +
                              (string.IsNullOrEmpty(nuevaCedula) ? "" : ", cedula = @nuevaCedula") +
                              " WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", empleado.cedula);
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
            cmd.Parameters.AddWithValue("@contraseña", empleado.contraseña);
            cmd.Parameters.AddWithValue("@rol", empleado.rol);
            if (!string.IsNullOrEmpty(nuevaCedula))
            {
                cmd.Parameters.AddWithValue("@nuevaCedula", nuevaCedula);
            }
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarEmpleado(string cedula)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Empleado WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }
    }
}