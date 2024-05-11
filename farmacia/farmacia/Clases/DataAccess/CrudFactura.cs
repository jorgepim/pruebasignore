using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using farmacia.Clases.Entidades;

namespace farmacia.Clases.DataAccess
{
    public class CrudFactura
    {
        private Conexion conexion;

        public CrudFactura()
        {
            conexion = new Conexion();
        }

        public int CrearFactura(string empleado, string cliente)
        {
            string query = "INSERT INTO Facturas (id_Empleado, id_Cliente) VALUES (@Empleado,@Cliente);";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            command.Parameters.AddWithValue("@Empleado", empleado);
            command.Parameters.AddWithValue("@Cliente", cliente);

            return conexion.EjecutarComando(command);
        }

        public void LlenarFactura(String idFactura)
        {
            SqlCommand command = new SqlCommand("CalcularTotalesDeDetalle", conexion.ObtenerConexion());
            command.CommandType = CommandType.StoredProcedure;

            // Agregar los parámetros de entrada
            command.Parameters.AddWithValue("@IdFactura", idFactura);
            
            try
            {
                conexion.AbrirConexion();
                command.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
        }

        public DataTable LeerTodasLasFacturas()
        {
            string query = "SELECT * FROM Facturas";
            return conexion.EjecutarConsulta(query);
        }

        public void ActualizarFactura(int idFactura, DateTime fecha, string cliente, decimal total)
        {
            string query = "UPDATE Facturas SET Fecha = @Fecha, Cliente = @Cliente, Total = @Total WHERE IdFactura = @IdFactura";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@Cliente", cliente);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@IdFactura", idFactura);

            conexion.EjecutarComando(command);
        }

        public void EliminarFactura(int idFactura)
        {
            string query = "DELETE FROM Facturas WHERE IdFactura = @IdFactura";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            command.Parameters.AddWithValue("@IdFactura", idFactura);
            conexion.EjecutarComando(command);

        }

        public int ObtenerUltimoIdFactura()
        {
            int ultimoId = 0;
            conexion.AbrirConexion();
            string query = "SELECT TOP 1 IdFactura FROM Facturas ORDER BY IdFactura DESC";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                ultimoId = Convert.ToInt32(result);
            }
            conexion.CerrarConexion();
            return ultimoId;
        }
    }
}
