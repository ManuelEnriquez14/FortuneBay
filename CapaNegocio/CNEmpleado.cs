using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Net;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        public static DataTable Listar()
        {
            CDEmpleados Datos = new CDEmpleados();
            return Datos.Listar();
        }

        public static string Registrar(string nombre, string usuario, string password, Byte Estado, DateTime fecha_alta)
        {
            CDEmpleados Datos = new CDEmpleados();
            Datos.Nombre = nombre;
            Datos.Usuario = usuario;
            Datos.fecha_alta = fecha_alta;
            Datos.Password = password;
            Datos.Estado = Estado;
            Datos.fecha_alta = fecha_alta;

            return Datos.Registrar(Datos);

        }

        public static string Editar(int IdEmpelado, string nombre, string usuario, string password, Byte Estado, DateTime fecha_alta)
        {
            CDEmpleados Datos = new CDEmpleados();
            Datos.IdEmpleado = IdEmpelado;
            Datos.Nombre = nombre;
            Datos.Usuario = usuario;
            Datos.fecha_alta = fecha_alta;
            Datos.Password = password;
            Datos.Estado = Estado;
            Datos.fecha_alta = fecha_alta;

            return Datos.Editar(Datos);

        }

        public static string Eliminar(int IdEmpleado)
        {
            CDEmpleados Datos = new CDEmpleados();
            Datos.IdEmpleado = IdEmpleado;
            return Datos.Eliminar(Datos);

        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDEmpleados Datos = new CDEmpleados();
            Datos.buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarPorId(string idEmpleado)
        {
            CDEmpleados Datos = new CDEmpleados();
            Datos.buscar = idEmpleado;
            return Datos.BuscarNombre(Datos);
        }

    }
}
