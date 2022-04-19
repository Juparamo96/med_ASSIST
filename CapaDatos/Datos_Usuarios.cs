using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Datos_Usuarios
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstacia().crearConexion();
                SqlCommand comando = new SqlCommand("proce_selecion", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        public DataTable Buscar(int valor)
        {

            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstacia().crearConexion();
                SqlCommand comando = new SqlCommand("proce_buscar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = valor;
                conexion.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }
        public string Insertar(Usuarios obj)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstacia().crearConexion();
                SqlCommand comando = new SqlCommand("proce_insertar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                comando.Parameters.Add("@tipo_id", SqlDbType.VarChar).Value = obj.tipo_id;
                comando.Parameters.Add("@num_id", SqlDbType.Int).Value = obj.num_id;
                comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = obj.genero;
                comando.Parameters.Add("@fec_nacimiento", SqlDbType.DateTime2).Value = obj.fec_nacimiento;
                comando.Parameters.Add("@dir_residencia", SqlDbType.VarChar).Value = obj.dir_residencia;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                comando.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = obj.ocupacion;
                comando.Parameters.Add("@nivel_escolaridad", SqlDbType.VarChar).Value = obj.nivel_escolaridad;
                comando.Parameters.Add("@eps", SqlDbType.VarChar).Value = obj.eps;
                comando.Parameters.Add("@regimen", SqlDbType.VarChar).Value = obj.regimen;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                comando.Parameters.Add("@contacto_emergencia", SqlDbType.VarChar).Value = obj.contacto_emergencia;
                comando.Parameters.Add("@sumatoria", SqlDbType.Int).Value = obj.sumatoria;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }
    }
}
