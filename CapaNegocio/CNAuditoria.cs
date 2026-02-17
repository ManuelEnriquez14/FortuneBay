using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNAuditoria
    {
        public static DataTable Listar()
        {
            CDAuditoria datos = new CDAuditoria();
            return datos.Listar();
        }
    }
}
