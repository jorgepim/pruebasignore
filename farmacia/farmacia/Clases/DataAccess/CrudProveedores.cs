using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class CrudProveedores
    {
        private Conexion conexion = new Conexion();
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        public CrudProveedores()
        {
            conexion = new Conexion();
        }

        public SqlDataReader LlenadoCombo()
        {
            String consulta = "SELECT * FROM Proveedores;";
            return conexion.EjecutarPeticion(consulta);
        }

        public DataTable VerRegistros()
        {
            DataTable table = new DataTable();
            string query = @"SELECT * FROM Proveedores";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.CommandType = CommandType.Text;
            conexion.AbrirConexion();
            lector = comando.ExecuteReader();
            table.Load(lector);
            conexion.CerrarConexion();
            return table;
        }
        public bool InsertarReg(string NombreProveedor, string Dirección, string Email, string Telefono)
        {
            conexion.AbrirConexion();

            string query = "INSERT INTO Proveedores (NombreProveedor, Dirección, Email, Telefono)" +
                            "VALUES (@NombreProveedor, @Dirección, @Email, @Telefono)";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
            comando.Parameters.AddWithValue("@Dirección", Dirección);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
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
