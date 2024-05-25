using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia.Clases.DataAccess
{
    internal class CrudCitas
    {
       public string connectionString = "server=localhost;database=BDFarmacia;integrated security=true";

        public DataTable GetConsultas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT ConsultasME.id_ConsultasME, ConveniosHC.NombreHC, DrEspecialidades.NombreDr,
                DrEspecialidades.Especialidad, ConsultasME.Fecha, ConsultasME.DetallesAdicionales
                FROM ConsultasME
                JOIN DrEspecialidades ON ConsultasME.Id_DrEspecialidades = DrEspecialidades.id_DrEspecialidades
                JOIN ConveniosHC ON DrEspecialidades.Id_ConveniosHC = ConveniosHC.id_ConveniosHC";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public int GetDatConveniosIdByCliente(int idCliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT TOP 1 DatosConvenios.id_DatConvenios
            FROM DatosConvenios
            JOIN Clientes ON Clientes.id_Membresia = DatosConvenios.Id_Membresia
            WHERE Clientes.id_Cliente = @Id_Cliente
            ORDER BY DatosConvenios.FechaVencimiento DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Cliente", idCliente);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? (int)result : 0;
            }
        }

        public void AddConsulta(int idDatConvenios, int idCliente, int idDrEspecialidades, DateTime fecha, string detallesAdicionales)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ConsultasME (Id_DatConvenios, Id_Cliente, Id_DrEspecialidades, Fecha, DetallesAdicionales) VALUES (@Id_DatConvenios, @Id_Cliente, @Id_DrEspecialidades, @Fecha, @DetallesAdicionales)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_DatConvenios", idDatConvenios);
                command.Parameters.AddWithValue("@Id_Cliente", idCliente);
                command.Parameters.AddWithValue("@Id_DrEspecialidades", idDrEspecialidades);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@DetallesAdicionales", detallesAdicionales);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public void UpdateConsulta(int id, int idConveniosHC, int idCliente, int idDrEspecialidades, DateTime fecha, string detallesAdicionales)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ConsultasME SET Id_ConveniosHC = @Id_Cliente = @Id_Cliente, Id_DrEspecialidades = @Id_DrEspecialidades, Fecha = @Fecha, DetallesAdicionales = @DetallesAdicionales WHERE id_ConsultasME = @Id";
                SqlCommand command = new SqlCommand(query, connection);
       
                command.Parameters.AddWithValue("@Id_ConveniosHC", idConveniosHC);
                command.Parameters.AddWithValue("@Id_Cliente", idCliente);
                command.Parameters.AddWithValue("@Id_DrEspecialidades", idDrEspecialidades);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@DetallesAdicionales", detallesAdicionales);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteConsulta(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ConsultasME WHERE id_ConsultasME = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int GetDatConveniosId(int idConveniosHC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 id_DatConvenios FROM DatosConvenios WHERE Id_ConveniosHC = @Id_ConveniosHC ORDER BY FechaVencimiento DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_ConveniosHC", idConveniosHC);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? (int)result : 0;
            }
        }


        public DataTable GetDoctors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_DrEspecialidades, NombreDr ,  Especialidad FROM DrEspecialidades";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetHospitals()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_ConveniosHC, NombreHC FROM ConveniosHC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ConsultasME.Id_Cliente, clientes.NombreCliente FROM ConsultasME  JOIN Clientes ON ConsultasME.Id_Cliente= Clientes.id_Cliente";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}
