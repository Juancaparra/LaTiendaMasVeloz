using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {

        public bool ValidarEmpleado(string cedula)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Empleado WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public bool ValidarCliente(string cedula)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Cliente WHERE cedula = @cedula";
            cmd.Parameters.AddWithValue("@cedula", cedula);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public ProductoEntity ConsultarProductoPorReferencia(string referencia)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Producto WHERE referencia = @referencia LIMIT 1";
            cmd.Parameters.AddWithValue("@referencia", referencia);
            MySqlDataReader reader = cmd.ExecuteReader();

            ProductoEntity producto = null;
            if (reader.Read())
            {
                producto = new ProductoEntity
                {
                    referencia = reader.GetString(reader.GetOrdinal("referencia")),
                    nombre = reader.GetString(reader.GetOrdinal("nombre")),
                    precio = reader.GetDecimal(reader.GetOrdinal("precio"))
                };
            }

            reader.Close();
            return producto;
        }

        public VentaEntity ConsultarVentaPorId(int idVenta)
        {
            VentaEntity venta = null;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = @"
        SELECT v.cedula_em, v.cedula_cliente, v.fecha, 
               p.nombre, df.precio_unitario, df.cantidad, df.precio_total
        FROM Factura v
        INNER JOIN Detalle_factura df ON v.id_factura = df.id_factura
        INNER JOIN Producto p ON df.referencia = p.referencia
        WHERE v.id_factura = @idVenta";
            cmd.Parameters.AddWithValue("@idVenta", idVenta);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<DetalleVentaEntity> detalles = new List<DetalleVentaEntity>();

            while (reader.Read())
            {
                if (venta == null)
                {
                    venta = new VentaEntity
                    {
                        IdVenta = idVenta,
                        CedulaEmpleado = reader.GetString(reader.GetOrdinal("cedula_em")),
                        CedulaCliente = reader.GetString(reader.GetOrdinal("cedula_cliente")),
                        Fecha = reader.GetDateTime(reader.GetOrdinal("fecha")),
                        Detalles = detalles
                    };
                }

                detalles.Add(new DetalleVentaEntity
                {
                    Referencia = reader.GetString(reader.GetOrdinal("nombre")),
                    PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("precio_unitario")),
                    Cantidad = reader.GetInt32(reader.GetOrdinal("cantidad")),
                    PrecioTotal = reader.GetDecimal(reader.GetOrdinal("precio_total"))
                });
            }

            reader.Close();
            return venta;
        }

        public int RegistrarVenta(string cedulaEmpleado, string cedulaCliente, DateTime fecha, List<DetalleVentaEntity> detalles)
        {
            MySqlTransaction transaction = GetConnection().BeginTransaction();
            try
            {
                // Insertar la venta
                MySqlCommand cmd = GetConnection().CreateCommand();
                cmd.Transaction = transaction;
                cmd.CommandText = "INSERT INTO Factura (cedula_em, cedula_cliente, fecha) VALUES (@cedulaEmpleado, @cedulaCliente, @fecha)";
                cmd.Parameters.AddWithValue("@cedulaEmpleado", cedulaEmpleado);
                cmd.Parameters.AddWithValue("@cedulaCliente", cedulaCliente);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.ExecuteNonQuery();

                int idFactura = (int)cmd.LastInsertedId;

                // Insertar los detalles de la venta
                foreach (var detalle in detalles)
                {
                    cmd = GetConnection().CreateCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO Detalle_factura (id_factura, referencia, precio_unitario, cantidad, precio_total) " +
                                      "VALUES (@idFactura, @referencia, @precioUnitario, @cantidad, @precioTotal)";
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);
                    cmd.Parameters.AddWithValue("@referencia", detalle.Referencia);
                    cmd.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@precioTotal", detalle.PrecioTotal);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return idFactura;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public bool ValidarProveedor(string nit)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Proveedor WHERE nit = @nit";
            cmd.Parameters.AddWithValue("@nit", nit);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public bool ValidarProducto(string referencia)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Producto WHERE referencia = @referencia";
            cmd.Parameters.AddWithValue("@referencia", referencia);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public int RegistrarFacturaProveedor(FacturaProveedorEntity factura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO Factura_proveedor (nit, referencia, fecha_llegada, nombre, precio, cantidad) " +
                              "VALUES (@nit, @referencia, @fecha_llegada, @nombre, @precio, @cantidad)";
            cmd.Parameters.AddWithValue("@nit", factura.Nit);
            cmd.Parameters.AddWithValue("@referencia", factura.Referencia);
            cmd.Parameters.AddWithValue("@fecha_llegada", factura.FechaLlegada);
            cmd.Parameters.AddWithValue("@nombre", factura.Nombre);
            cmd.Parameters.AddWithValue("@precio", factura.Precio);
            cmd.Parameters.AddWithValue("@cantidad", factura.Cantidad);
            return cmd.ExecuteNonQuery();
        }

        public FacturaProveedorEntity ConsultarFacturaProveedor(int idFactura)
        {
            FacturaProveedorEntity factura = null;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = @"
        SELECT fp.id_factura_proveedor, fp.nit, fp.fecha_llegada, p.referencia, p.nombre, fp.precio, fp.cantidad
        FROM Factura_proveedor fp
        INNER JOIN Producto p ON fp.referencia = p.referencia
        WHERE fp.id_factura_proveedor = @idFactura";
            cmd.Parameters.AddWithValue("@idFactura", idFactura);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<ProductoEntity> productos = new List<ProductoEntity>();

            while (reader.Read())
            {
                if (factura == null)
                {
                    factura = new FacturaProveedorEntity
                    {
                        IdFactura = reader.GetInt32(reader.GetOrdinal("id_factura_proveedor")),
                        Nit = reader.GetString(reader.GetOrdinal("nit")),
                        FechaLlegada = reader.GetDateTime(reader.GetOrdinal("fecha_llegada")),
                        Productos = productos
                    };
                }

                productos.Add(new ProductoEntity
                {
                    referencia = reader.GetString(reader.GetOrdinal("referencia")),
                    nombre = reader.GetString(reader.GetOrdinal("nombre")),
                    precio = reader.GetDecimal(reader.GetOrdinal("precio")),
                    stock = reader.GetInt32(reader.GetOrdinal("cantidad"))
                });
            }

            reader.Close();
            return factura;
        }

        public bool EliminarFacturaProveedor(int idFactura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM Factura_proveedor WHERE id_factura_proveedor = @idFactura";
            cmd.Parameters.AddWithValue("@idFactura", idFactura);
            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }

        public bool ActualizarFacturaProveedor(FacturaProveedorEntity factura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = @"
        UPDATE Factura_proveedor 
        SET nit = @nit, fecha_llegada = @fecha_llegada, nombre = @nombre, precio = @precio, cantidad = @cantidad
        WHERE id_factura_proveedor = @idFactura AND referencia = @referencia";
            cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);
            cmd.Parameters.AddWithValue("@nit", factura.Nit);
            cmd.Parameters.AddWithValue("@fecha_llegada", factura.FechaLlegada);
            cmd.Parameters.AddWithValue("@referencia", factura.Referencia);
            cmd.Parameters.AddWithValue("@nombre", factura.Nombre);
            cmd.Parameters.AddWithValue("@precio", factura.Precio);
            cmd.Parameters.AddWithValue("@cantidad", factura.Cantidad);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
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

        public ProductoEntity ConsultarProducto(string referencia)
        {
            ProductoEntity producto = null;
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT id_producto, referencia, nombre, precio, marca, stock FROM Producto WHERE referencia = @referencia LIMIT 1";
            cmd.Parameters.AddWithValue("@referencia", referencia);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                producto = new ProductoEntity
                {
                    id_producto = reader.GetInt32(reader.GetOrdinal("id_producto")),
                    referencia = reader.GetString(reader.GetOrdinal("referencia")),
                    nombre = reader.GetString(reader.GetOrdinal("nombre")),
                    precio = reader.GetDecimal(reader.GetOrdinal("precio")),
                    marca = reader.GetString(reader.GetOrdinal("marca")),
                    stock = reader.GetInt32(reader.GetOrdinal("stock"))
                };
            }

            reader.Close();
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