using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoController
    {
        public string GuardarEmpleado(string cedula, string nombre, string usuario, string contraseña)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarEmpleado(cedula, nombre, usuario, contraseña);

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
        public EmpleadoEntity MostrarEmpleado(string cedula)
        {
            BaseDatos db = new BaseDatos();

            EmpleadoEntity empleado = db.MostrarEmpleado(cedula);

            return empleado;
        }
    }
}
