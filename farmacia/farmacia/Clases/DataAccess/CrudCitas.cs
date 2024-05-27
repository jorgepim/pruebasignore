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
            if (fecha.Date < DateTime.Now.Date)
            {
                throw new InvalidOperationException("La fecha de la cita debe ser igual o posterior al día actual.");
            }

            if (ExcedeCitasMensuales(idCliente, fecha))
            {
                throw new InvalidOperationException("El cliente ya tiene 3 citas en el mes actual y no puede agregar más citas.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryGetHospitalId = @"
        SELECT Id_ConveniosHC
        FROM DrEspecialidades
        WHERE id_DrEspecialidades = @Id_DrEspecialidades";
                SqlCommand commandGetHospitalId = new SqlCommand(queryGetHospitalId, connection);
                commandGetHospitalId.Parameters.AddWithValue("@Id_DrEspecialidades", idDrEspecialidades);
                int idHospital = (int)commandGetHospitalId.ExecuteScalar();

           
                if (ExisteCitaEnMismoDia(idDrEspecialidades, idHospital, fecha))
                {
                    throw new InvalidOperationException("Ya existe una cita con el mismo doctor en el mismo hospital en la misma fecha.");
                }

                string queryInsert = "INSERT INTO ConsultasME (Id_DatConvenios, Id_Cliente, Id_DrEspecialidades, Fecha, DetallesAdicionales) VALUES (@Id_DatConvenios, @Id_Cliente, @Id_DrEspecialidades, @Fecha, @DetallesAdicionales)";
                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@Id_DatConvenios", idDatConvenios);
                commandInsert.Parameters.AddWithValue("@Id_Cliente", idCliente);
                commandInsert.Parameters.AddWithValue("@Id_DrEspecialidades", idDrEspecialidades);
                commandInsert.Parameters.AddWithValue("@Fecha", fecha);
                commandInsert.Parameters.AddWithValue("@DetallesAdicionales", detallesAdicionales);

              
                string queryUpdate = "UPDATE Clientes SET NumCitasAsis = NumCitasAsis + 1 WHERE id_Cliente = @Id_Cliente";
                SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Id_Cliente", idCliente);

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    commandInsert.Transaction = transaction;
                    commandInsert.ExecuteNonQuery();

                    commandUpdate.Transaction = transaction;
                    commandUpdate.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
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
                string query = "SELECT Id_Cliente, NombreCliente FROM Clientes";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetDoctorsByHospital(int idHospital)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT DrEspecialidades.id_DrEspecialidades, 
               DrEspecialidades.NombreDr, 
               DrEspecialidades.Especialidad
        FROM DrEspecialidades
        WHERE DrEspecialidades.Id_ConveniosHC = @Id_ConveniosHC";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id_ConveniosHC", idHospital);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool ExisteCitaEnMismoDia(int idDoctor, int idHospital, DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT COUNT(*)
        FROM ConsultasME
        JOIN DrEspecialidades ON ConsultasME.Id_DrEspecialidades = DrEspecialidades.id_DrEspecialidades
        WHERE DrEspecialidades.Id_ConveniosHC = @Id_ConveniosHC
        AND ConsultasME.Id_DrEspecialidades = @Id_DrEspecialidades
        AND CAST(ConsultasME.Fecha AS DATE) = CAST(@Fecha AS DATE)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_ConveniosHC", idHospital);
                command.Parameters.AddWithValue("@Id_DrEspecialidades", idDoctor);
                command.Parameters.AddWithValue("@Fecha", fecha);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public bool ExcedeCitasMensuales(int idCliente, DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT COUNT(*)
        FROM ConsultasME
        WHERE Id_Cliente = @Id_Cliente
        AND YEAR(Fecha) = @Year
        AND MONTH(Fecha) = @Month";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Cliente", idCliente);
                command.Parameters.AddWithValue("@Year", fecha.Year);
                command.Parameters.AddWithValue("@Month", fecha.Month);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count >= 3;
            }
        }




    }
}
