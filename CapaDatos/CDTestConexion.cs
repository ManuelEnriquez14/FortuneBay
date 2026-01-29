using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class CDTestConexion
    {
        public static string Probar()
        {
            try
            {
                using (var cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    return $"OK: Server={cn.DataSource} | DB={cn.Database}";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}
