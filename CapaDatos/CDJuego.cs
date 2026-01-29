using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CDJuego
    {
        public int IdJuego { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public string buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("juegos");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_listar_juegos", conexion);
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

        public string Registrar(CDJuego cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_registrar_juego", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@juego_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@tipo", cli.Tipo);

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

        public string Editar(CDJuego cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_editar_juego", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@juego_id", IdJuego);
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@tipo", cli.Tipo);

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

        public string Eliminar(CDJuego cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_eliminar_Juego", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@juego_id", cli.IdJuego);

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

        public DataTable BuscarJuegoNombre(CDJuego cli)
        {
            DataTable resul = new DataTable("juegos");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_juego_por_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
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

        public DataTable BuscarJuegoTipo(CDJuego cli)
        {
            DataTable resul = new DataTable("juegos");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_juego_por_tipo", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@tipo", cli.Tipo);
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
