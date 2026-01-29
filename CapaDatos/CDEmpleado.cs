using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CDEmpleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public byte Estado { get; set; }
        public DateTime fecha_alta { get; set; }

        public string buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("empleados");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_listar_empleados", conexion);
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

        public string Registrar(CDEmpleados cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_registrar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@empleado_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@usuario", cli.Usuario);
                Cmd.Parameters.AddWithValue("@password", cli.Password);

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

        public string Editar(CDEmpleados cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_editar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@empleado_id", IdEmpleado);
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@usuario", cli.Usuario);

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

        public string Eliminar(CDEmpleados cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("sp_eliminar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@empleado_id", cli.IdEmpleado);

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

        public DataTable BuscarNombre(CDEmpleados cli)
        {
            DataTable resul = new DataTable("empleados");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_empleado_por_nombre_usuario", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@texto", cli.Usuario);
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

        public DataTable BuscarPorId(CDEmpleados cli)
        {
            DataTable resul = new DataTable("empleados");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_buscar_empleado_por_id", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@texto", cli.Usuario);
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
