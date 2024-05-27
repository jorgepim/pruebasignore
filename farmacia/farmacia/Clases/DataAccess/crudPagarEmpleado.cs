using farmacia.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class crudPagarEmpleado
    {
        private Conexion conexion = new Conexion();
        public decimal CalcularTotalPagarEmpleado(int idEmpleado)
        {
            decimal pagoNeto = 0;

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand("CalcularTotalPagarEmpleado", conexion.ObtenerConexion()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Empleado", idEmpleado);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pagoNeto = Convert.ToDecimal(reader["PagoNeto"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return pagoNeto;
        }
        public DataTable CalcularPagoEmpleadoHistorial(int idEmpleado)
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand("CalcularPagoEmpleadoHistorial", conexion.ObtenerConexion()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_Empleado", idEmpleado);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return dataTable;
        }

        public bool InsertarRegPagosRealizados(int id_Empleado, double MontoTotal, int id_DetallePago)
        {
            
            conexion.AbrirConexion();

            string query = "INSERT INTO PagosRealizados (id_Empleado, FechaDePago, MontoTotal, id_DetallePago)" +
                   "VALUES (@id_Empleado, GETDATE(), @MontoTotal, @id_DetallePago)";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());

            comando.Parameters.AddWithValue("@id_Empleado", id_Empleado);
            comando.Parameters.AddWithValue("@MontoTotal", MontoTotal);
            comando.Parameters.AddWithValue("@id_DetallePago", id_DetallePago);
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

        public bool InsertarRegDetallePagos(int TotXHoras, double TotDescuentos)
        {

            conexion.AbrirConexion();

            string query = "INSERT INTO DetallePago (TotXHoras, TotDescuentos, Aguinaldo)" +
                   "VALUES (@TotXHoras, @TotDescuentos, 0.00)";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());

            comando.Parameters.AddWithValue("@TotXHoras", TotXHoras);
            comando.Parameters.AddWithValue("@TotDescuentos", TotDescuentos);
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
