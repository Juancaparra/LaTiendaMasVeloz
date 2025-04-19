using Modelo;
using MySql.Data.MySqlClient;
using System;

namespace Logica
{
    public class InicioSesionController
    {
        private ConexionMySql conexion;

        public InicioSesionController()
        {
            conexion = new ConexionMySql();
        }

        public string IniciarSesion(string usuario, string contraseña)
        {
            var connection = conexion.GetConnection();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT rol FROM Empleado WHERE usuario = @usuario AND contraseña = @contraseña";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            MySqlDataReader reader = cmd.ExecuteReader();

            string rol = null;
            if (reader.Read())
            {
                rol = reader["rol"].ToString();
            }

            reader.Close();
            return rol;
        }
    }
}
