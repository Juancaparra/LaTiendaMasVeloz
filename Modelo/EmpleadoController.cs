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
        public string GuardarEmpleado(string cedula, string nombre, string usuario, string contraseña, string rol)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarEmpleado(cedula, nombre, usuario, contraseña, rol);

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

        public string ActualizarEmpleado(EmpleadoEntity empleado, string nuevaCedula)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasActualizadas = db.ActualizarEmpleado(empleado, nuevaCedula);

            if (filasActualizadas > 0)
            {
                resultado = "Actualizado";
            }
            else
            {
                resultado = "No Actualizado";
            }
            return resultado;
        }

        public string EliminarEmpleado(string cedula)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasEliminadas = db.EliminarEmpleado(cedula);

            if (filasEliminadas > 0)
            {
                resultado = "Eliminado";
            }
            else
            {
                resultado = "No Eliminado";
            }
            return resultado;
        }
    }
}
