using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class CDPruebaExisteSP
    {
        public static string Existe(string nombreSp)
        {
            try
            {
                using (var cn = new SqlConnection(Conexion.Conn))
                using (var cmd = new SqlCommand("SELECT OBJECT_ID(@sp)", cn))
                {
                    cmd.Parameters.AddWithValue("@sp", nombreSp);
                    cn.Open();
                    var r = cmd.ExecuteScalar();

                    return r == null || r == DBNull.Value
                        ? "NO existe: " + nombreSp
                        : "SÍ existe: " + nombreSp;
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}
