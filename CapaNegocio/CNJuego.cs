using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Runtime.InteropServices;

namespace CapaNegocio
{
    public class CNJuego
    {
        public DataTable Listar()
        {
            CDJuego Datos = new CDJuego();
            return Datos.Listar();
        }

        public string Registrar(string nombre, string tipo)
        {
            CDJuego Datos = new CDJuego();

            Datos.Nombre = nombre;
            Datos.Tipo = tipo;

            return Datos.Registrar(Datos);
        }

        public string Editar(int idJuego, string nombre, string tipo)
        {
            CDJuego Datos = new CDJuego();

            Datos.IdJuego = idJuego;
            Datos.Nombre = nombre;
            Datos.Tipo = tipo;

            return Datos.Editar(Datos);
        }

        public string Eliminar(int idJuego)
        {
            CDJuego Datos = new CDJuego();
            Datos.IdJuego = idJuego;

            return Datos.Eliminar(Datos);
        }

        public DataTable BuscarJuegoNombre(string nombrejuego)
        {
            CDJuego Datos = new CDJuego();
            Datos.buscar = nombrejuego;

            return Datos.BuscarJuegoNombre(Datos);
        }

        public DataTable BuscarJuegoTipo(string tipojuego)
        {
            CDJuego Datos = new CDJuego();
            Datos.buscar = tipojuego;

            return Datos.BuscarJuegoTipo(Datos);
        }


    }
}
