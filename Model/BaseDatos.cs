using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {

        public int GuardarProducto(ProductoEntity producto)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Producto (referencia, nombre, precio, marca, stock, fk_gerente_usuario, fk_nit_proveedor) " +
                              "VALUES (@referencia, @nombre, @precio, @marca, @stock, @fk_gerente_usuario, @fk_nit_proveedor)";
            cmd.Parameters.AddWithValue("@referencia", producto.referencia);
            cmd.Parameters.AddWithValue("@nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@precio", producto.precio);
            cmd.Parameters.AddWithValue("@marca", producto.marca);
            cmd.Parameters.AddWithValue("@stock", producto.stock);
            cmd.Parameters.AddWithValue("@fk_gerente_usuario", producto.usuario);
            cmd.Parameters.AddWithValue("@fk_nit_proveedor", producto.nit_proveedor);
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public ProductoEntity MostrarProducto(string referencia)
        {
            ProductoEntity ProductoActual = new ProductoEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = @"
        SELECT p.id_producto, p.referencia, p.nombre, p.precio, p.marca, p.stock, 
               g.usuario AS gerente_usuario, g.nombre AS gerente_nombre, 
               pr.nit AS proveedor_nit, pr.nombre AS proveedor_nombre
        FROM Producto p
        JOIN Gerente g ON p.fk_gerente_usuario = g.usuario
        JOIN Proveedor pr ON p.fk_nit_proveedor = pr.nit
        WHERE p.referencia = @referencia
        LIMIT 1";
            cmd.Parameters.AddWithValue("@referencia", referencia);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductoActual.id_producto = reader.GetInt32(reader.GetOrdinal("id_producto"));
                ProductoActual.referencia = reader.GetString(reader.GetOrdinal("referencia"));
                ProductoActual.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                ProductoActual.precio = reader.GetDecimal(reader.GetOrdinal("precio"));
                ProductoActual.marca = reader.GetString(reader.GetOrdinal("marca"));
                ProductoActual.stock = reader.GetInt32(reader.GetOrdinal("stock"));
                ProductoActual.usuario = reader.GetString(reader.GetOrdinal("gerente_usuario"));
                ProductoActual.gerente_nombre = reader.GetString(reader.GetOrdinal("gerente_nombre"));
                ProductoActual.nit_proveedor = reader.GetString(reader.GetOrdinal("proveedor_nit"));
                ProductoActual.proveedor_nombre = reader.GetString(reader.GetOrdinal("proveedor_nombre"));
            }

            return ProductoActual;
        }

        public int ActualizarProducto(ProductoEntity producto)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE Producto SET " +
                              "nombre = @nombre, " +
                              "precio = @precio, " +
                              "marca = @marca, " +
                              "stock = @stock, " +
                              "fk_gerente_usuario = @fk_gerente_usuario, " +
                              "fk_nit_proveedor = @fk_nit_proveedor" +
                              (string.IsNullOrEmpty(producto.referencia) ? "" : ", referencia = @nuevaReferencia") +
                              " WHERE referencia = @referencia";
            cmd.Parameters.AddWithValue("@referencia", producto.referencia);
            cmd.Parameters.AddWithValue("@nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@precio", producto.precio);
            cmd.Parameters.AddWithValue("@marca", producto.marca);
            cmd.Parameters.AddWithValue("@stock", producto.stock);
            cmd.Parameters.AddWithValue("@fk_gerente_usuario", producto.usuario);
            cmd.Parameters.AddWithValue("@fk_nit_proveedor", producto.nit_proveedor);
            if (!string.IsNullOrEmpty(producto.referencia))
            {
                cmd.Parameters.AddWithValue("@nuevaReferencia", producto.referencia);
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