using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Logica
{
        public class InicioSesionController
        {
            private BaseDatos baseDatos;

            public InicioSesionController()
            {
                baseDatos = new BaseDatos();
            }

        public string IniciarSesion(string nombreUsuario, string contrasena)
        {
            string rol = baseDatos.VerificarCredenciales(nombreUsuario, contrasena);

            if (rol == "Gerente")
            {
                return "Menu";
            }
            else if (rol == "Vendedor")
            {
                return "MenuVendedor";
            }
            else
            {
                return "Usuario o contraseña incorrectos";
            }
        }
    }
    }