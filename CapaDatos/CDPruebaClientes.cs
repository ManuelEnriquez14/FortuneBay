using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class CDPruebaClientes
    {
        public static string ProbarListar()
        {
            try
            {
                using (var cn = new SqlConnection(Conexion.Conn))
                {
                    SqlCommand cmd = new SqlCommand("dbo.sp_listar_clientes", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return "OK: Clientes encontrados = " + dt.Rows.Count;
                }
            }
            catch (System.Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}
