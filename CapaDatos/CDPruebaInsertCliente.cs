
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class CDPruebaInsertCliente
    {
        public static string ProbarInsert()
        {
            try
            {
                using (var cn = new SqlConnection(Conexion.Conn))
                {
                    SqlCommand cmd = new SqlCommand("dbo.sp_registrar_cliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro OUTPUT (ID)
                    SqlParameter id = new SqlParameter("@idcliente", SqlDbType.Int);
                    id.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(id);

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@nombre", "Cliente Prueba");
                    cmd.Parameters.AddWithValue("@fecha_nac", DateTime.Now.AddYears(-20));
                    cmd.Parameters.AddWithValue("@email", "prueba@test.com");
                    cmd.Parameters.AddWithValue("@documento", "99999999");
                    cmd.Parameters.AddWithValue("@telefono", "123456");
                    cmd.Parameters.AddWithValue("@estatus", "A");

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    return "OK: Cliente insertado con ID = " + id.Value;
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}

