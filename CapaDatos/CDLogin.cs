using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDLogin
    {
        public DataTable Login(string usuario, string password)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_login_empleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public int RegistrarInicio(int empleadoId)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_iniciar_sesion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empleado_id", empleadoId);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void RegistrarFin(int sesionId)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_cerrar_sesion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sesion_id", sesionId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarSesiones()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Conn))
            {
                SqlCommand cmd = new SqlCommand("sp_listar_sesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

    }
}
