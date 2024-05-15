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

        public int CrearFactura(String empleado, String cliente , String sucursal)
        {
            string query = "INSERT INTO Facturas (id_Empleado, id_Cliente, id_Sucursal) VALUES (@Empleado,@Cliente,@Sucursal);";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            command.Parameters.AddWithValue("@Empleado", empleado);
            command.Parameters.AddWithValue("@Cliente", cliente);
            command.Parameters.AddWithValue("@Sucursal", sucursal);

            return conexion.EjecutarComando(command);
        }

        public void LlenarFactura(String idFactura, String TipoPago)
        {
            SqlCommand command = new SqlCommand("CalcularTotalesDeDetalle", conexion.ObtenerConexion());
            command.CommandType = CommandType.StoredProcedure;

            // Agregar los parámetros de entrada
            command.Parameters.Add(new SqlParameter("@idFactura", idFactura));
            command.Parameters.Add(new SqlParameter("@tipoDePago", TipoPago));
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
            string query = "SELECT TOP 1 id_Factura FROM Facturas ORDER BY id_Factura DESC";

            SqlCommand command = new SqlCommand(query, conexion.ObtenerConexion());
            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                ultimoId = Convert.ToInt32(result);
            }
            conexion.CerrarConexion();
            return ultimoId;
        }

        public String ObtenerSucusal(String idEmpleado)
        {
            String consulta = "SELECT id_Sucursal FROM Empleados WHERE id_Empleado = @Empleado;";
            SqlCommand comando = new SqlCommand(consulta,conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Empleado", idEmpleado);
            conexion.AbrirConexion();
            object resultado = comando.ExecuteScalar();
            conexion.CerrarConexion();
            return resultado != null ? resultado.ToString() : null;
        }
    }
}
