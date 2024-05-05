using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    public class Conexion
    {
        private SqlConnection conexion;
        private string cadenaConexion = "server=localhost ; database=BDFarmacia ; integrated security = true";

        public Conexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }

        public void AbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public SqlDataReader EjecutarPeticion(string consulta)
        {
            AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

        public int EjecutarComando(SqlCommand cmd)
        {
            int filasAfectadas = 0;
            try
            {
                AbrirConexion();
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar comando: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return filasAfectadas;
        }
    }
}
