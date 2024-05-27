using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class crudRegistrarHora
    {
        private Conexion conexion = new Conexion();
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        public SqlDataReader FillcmbTipoHora()
        {
            string query = "SELECT * FROM TipoHoras";
            return conexion.EjecutarPeticion(query);
        }
        public bool InsertarHora(int id_Empleado, int HorasTrabajadas, int id_TipoHora)
        {
            conexion.AbrirConexion();

            string consulta = "INSERT INTO HorasTrabajadas (id_Empleado, Fecha, HorasTrabajadas, TipoHora)" +
                "VALUES(@id_Empleado, GETDATE(), @HorasTrabajadas, @id_TipoHora)";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@id_Empleado", id_Empleado);
            comando.Parameters.AddWithValue("@HorasTrabajadas", HorasTrabajadas);
            comando.Parameters.AddWithValue("@id_TipoHora", id_TipoHora);
            int n = comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            if (n > 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }

        }
    }
}
