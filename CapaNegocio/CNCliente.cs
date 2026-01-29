using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using System.Net;

namespace CapaNegocio
{
    public class CNCliente
    {


        public static DataTable Listar()
        {
            CDCliente Datos = new CDCliente();
            return Datos.Listar();
        }

        public static string Registrar(string nombre, string fecha_nac, string documento, string telefono, string estatus, string email)
        {
            CDCliente Datos = new CDCliente();

            Datos.nombre = nombre;
            Datos.fecha_nac = fecha_nac;
            Datos.documento = documento;
            Datos.telefono = telefono;
            Datos.estatus = estatus;
            Datos.email = email;
            return Datos.Registrar(Datos);

        }

        public static string Editar(int idClinete, string nombre, string documento, string telefono, string estatus, string email)
        {
            CDCliente Datos = new CDCliente();
            Datos.id = idClinete;
            Datos.nombre = nombre;
            Datos.documento = documento ;
            Datos.fecha_nac = telefono;
            Datos.estatus = estatus;
            Datos.email = email;
            return Datos.Editar(Datos);

        }

        public static string Eliminar(int IdCliente)
        {
            CDCliente Datos = new CDCliente();
            Datos.id = IdCliente;
            return Datos.Eliminar(Datos);

        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarDni(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarDni(Datos);
        }
    }
}
