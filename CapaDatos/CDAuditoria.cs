using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAuditoria
    {
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_listar_auditoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
