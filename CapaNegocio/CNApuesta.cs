using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNApuesta
    {
        public DataTable Lista()
        {
            CDApuesta Datos = new CDApuesta();

            return Datos.Listar();
        }

        public string Registrar(int id_cliente, int id_juego, double monto, string resultado)
        {
            CDApuesta Datos = new CDApuesta();
            Datos.IdCliente = id_cliente;
            Datos.IdJuego = id_juego;
            Datos.Monto = monto;
            Datos.Resultado = resultado;

            return Datos.Registrar(Datos);
        }

        public string Editar(int id_apuesta, int id_cliente, int id_juego, double monto, string resultado)
        {
            CDApuesta Datos = new CDApuesta();

            Datos.IdApuesta = id_apuesta;
            Datos.IdCliente = id_cliente;
            Datos.IdJuego = id_juego;
            Datos.Monto = monto;
            Datos.Resultado = resultado;

            return Datos.Editar(Datos);
        }

        public string Eliminar(int id_apuesta)
        {
            CDApuesta Datos = new CDApuesta();

            Datos.IdApuesta = id_apuesta;

            return Datos.Eliminar(Datos);
        }

        public DataTable BuscarPorCliente(string idcliente)
        {
            CDApuesta Datos = new CDApuesta();
            Datos.buscar = idcliente;

            return Datos.BuscarApuestaPorCliente(Datos);
        }

        public DataTable BuscarPorJuego(string idJuego)
        {
            CDApuesta Datos = new CDApuesta();
            Datos.buscar = idJuego;

            return Datos.BuscarApuestaPorJuego(Datos);
        }
    }
}
