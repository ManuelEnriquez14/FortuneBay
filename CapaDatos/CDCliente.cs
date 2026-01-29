using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string fecha_nac { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string estatus { get; set; }

        public string Buscar {  get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("clientes");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_listar_clientes", conexion);
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
        public string Registrar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_registrar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.nombre);
                Cmd.Parameters.AddWithValue("@fecha_nac", cli.fecha_nac);
                Cmd.Parameters.AddWithValue("@email", cli.email);
                Cmd.Parameters.AddWithValue("@documento", cli.documento);
                Cmd.Parameters.AddWithValue("@telefono", cli.telefono);
                Cmd.Parameters.AddWithValue("@estatus", cli.estatus);

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

        public string Editar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_editar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", cli.id);
                Cmd.Parameters.AddWithValue("@nombre", cli.nombre);
                Cmd.Parameters.AddWithValue("@fecha_nac", cli.fecha_nac);
                Cmd.Parameters.AddWithValue("@email", cli.email);
                Cmd.Parameters.AddWithValue("@documento", cli.documento);
                Cmd.Parameters.AddWithValue("@telefono", cli.telefono);
                Cmd.Parameters.AddWithValue("@estatus", cli.estatus);

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

        public string Eliminar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_eliminar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@id", cli.id);

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

        public DataTable BuscarNombre(CDCliente cli)
        {
            DataTable resul = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_cliente_por_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", cli.nombre);
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

        public DataTable BuscarDni(CDCliente cli)
        {
            DataTable resul = new DataTable("Cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_por_documento", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@documento", cli.documento);
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
