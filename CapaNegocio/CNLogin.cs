using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNLogin
    {
        public static DataTable Login(string usuario, string password)
        {
            CDLogin datos = new CDLogin();
            return datos.Login(usuario, password);
        }

        public static int RegistrarInicio(int empleadoId)
        {
            CDLogin datos = new CDLogin();
            return datos.RegistrarInicio(empleadoId);
        }

        public static void RegistrarFin(int sesionId)
        {
            CDLogin datos = new CDLogin();
            datos.RegistrarFin(sesionId);
        }

        public static DataTable ListarSesiones()
        {
            CDLogin datos = new CDLogin();
            return datos.ListarSesiones();
        }
    }
}
