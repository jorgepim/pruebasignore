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

    }
}
