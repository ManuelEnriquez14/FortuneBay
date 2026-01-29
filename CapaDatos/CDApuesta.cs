using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CDApuesta
    {
        public int IdApuesta { get; set; }
        public int IdCliente { get; set; }
        public int IdJuego { get; set; }
        public double Monto { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; }

        public string buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("apuestas");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_listar_apuestas", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Registrar(CDApuesta cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_registrar_apuesta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@apuesta_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@cliente_id", cli.IdCliente);
                Cmd.Parameters.AddWithValue("@juego_id", cli.IdJuego);
                Cmd.Parameters.AddWithValue("@monto", cli.Monto);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Editar(CDApuesta cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_editar_apuesta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@apuesta_id", IdApuesta);
                Cmd.Parameters.AddWithValue("@juego_id", cli.IdJuego);
                Cmd.Parameters.AddWithValue("@monto", cli.Monto);
                Cmd.Parameters.AddWithValue("@resultado", cli.Resultado);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Eliminar(CDApuesta cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_eliminar_apuesta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@apuesta_id", cli.IdApuesta);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public DataTable BuscarApuestaPorCliente(CDApuesta cli)
        {
            DataTable resul = new DataTable("apuestas");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_apuesta_por_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@cliente_id", cli.IdCliente);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public DataTable BuscarApuestaPorJuego(CDApuesta cli)
        {
            DataTable resul = new DataTable("apuestas");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_apuesta_por_juego", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@juego_id", cli.IdJuego);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }


    }
}
