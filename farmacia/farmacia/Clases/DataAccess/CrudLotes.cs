using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    public class CrudLotes
    {
        private Conexion conexionBD;

        public CrudLotes()
        {
            conexionBD = new Conexion();
        }

        public DataTable ObtenerTodosLosLotes()
        {
            string consulta = "SELECT * FROM Lotes";
            return conexionBD.EjecutarConsulta(consulta);
        }

        public void InsertarLote(int idProducto, int idProveedor, int idSucursal, DateTime fechaCompra, DateTime fechaVencimiento, decimal precioCompra, decimal pDescuento, int cantidad)
        {
            string consulta = "INSERT INTO Lotes (id_Producto, id_Proveedor, id_Sucursal, FechaCompra, FechaVencimiento, PrecioCompra, PDescuento, Cantidad) " +
                              "VALUES (@IdProducto, @IdProveedor, @IdSucursal, @FechaCompra, @FechaVencimiento, @PrecioCompra, @PDescuento, @Cantidad)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.Parameters.AddWithValue("@IdProveedor", idProveedor);
            comando.Parameters.AddWithValue("@IdSucursal", idSucursal);
            comando.Parameters.AddWithValue("@FechaCompra", fechaCompra);
            comando.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            comando.Parameters.AddWithValue("@PrecioCompra", precioCompra);
            comando.Parameters.AddWithValue("@PDescuento", pDescuento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarLote(int idLote, int idProducto, int idProveedor, int idSucursal, DateTime fechaCompra, DateTime fechaVencimiento, decimal precioCompra, decimal pDescuento, int cantidad)
        {
            string consulta = "UPDATE Lotes SET id_Producto = @IdProducto, id_Proveedor = @IdProveedor, id_Sucursal = @IdSucursal, " +
                              "FechaCompra = @FechaCompra, FechaVencimiento = @FechaVencimiento, PrecioCompra = @PrecioCompra, " +
                              "PDescuento = @PDescuento, Cantidad = @Cantidad WHERE id_Lotes = @IdLote";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.Parameters.AddWithValue("@IdProveedor", idProveedor);
            comando.Parameters.AddWithValue("@IdSucursal", idSucursal);
            comando.Parameters.AddWithValue("@FechaCompra", fechaCompra);
            comando.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            comando.Parameters.AddWithValue("@PrecioCompra", precioCompra);
            comando.Parameters.AddWithValue("@PDescuento", pDescuento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@IdLote", idLote);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarLote(int idLote)
        {
            string consulta = "DELETE FROM Lotes WHERE id_Lotes = @IdLote";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdLote", idLote);

            conexionBD.EjecutarComando(comando);
        }
    }
}
