using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using farmacia.Clases.Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;

namespace farmacia.Clases.DataAccess
{
    public class CrudDetalleCompras
    {
        private Conexion conexionBD;

        public CrudDetalleCompras()
        {
            conexionBD = new Conexion();
        }
        //Crud de Categorias
        public SqlDataReader ObtenerTodasLasCategorias()
        {
            String consulta = "SELECT * FROM Categorias";
            return conexionBD.EjecutarPeticion(consulta);
        }

        //Crud de Marcas
        public SqlDataReader ObtenerTodasLasMarcas()
        {
            String consulta = "SELECT * FROM Marcas";
            return conexionBD.EjecutarPeticion(consulta);
        }

        //Crud de Presentaciones

        public SqlDataReader ObtenerTodasLasPresentaciones()
        {
            String consulta = "SELECT * FROM Presentaciones";
            return conexionBD.EjecutarPeticion(consulta);
        }

        //Crud de DetalleCompras

        public DataTable ObtenerTodosLosDetallesDeCompra()
        {
            String consulta = "SELECT * FROM DetalleCompras";
            return conexionBD.EjecutarConsulta(consulta);
        }
        public DataTable ObtenerDetallePorFactura(String factura)
        {
            String consulta = "SELECT DetalleCompras.id_Producto as 'ID', SUM(DetalleCompras.Cantidad) AS 'Cantidad', pr.NombreProducto as 'Producto', pr.PrecioV AS 'p/u', SUM(DetalleCompras.Total) AS 'Subtotal' " +
                "FROM DetalleCompras " +
                "INNER JOIN Productos pr ON DetalleCompras.id_Producto = pr.id_Producto " +
                $"WHERE id_Factura = {factura} " +
                "GROUP BY DetalleCompras.id_Producto, pr.NombreProducto, pr.PrecioV;";


            /*"SELECT DetalleCompras.Cantidad, pr.NombreProducto as 'Producto', pr.PrecioV as 'p/u', DetalleCompras.Total as 'Subtotal'" +
            "FROM DetalleCompras " +
            "INNER JOIN Productos pr ON DetalleCompras.id_Producto = pr.id_Producto " +
            "WHERE id_Factura = " + factura + ";";*/
            return conexionBD.EjecutarConsulta(consulta);
        }

        public SqlDataReader ObtenerSUMTotalesDescuento(String factura)
        {
            String consulta = "SELECT SUM(Total), SUM(Descuento) " +
                "FROM DetalleCompras " +
                $"WHERE id_Factura = {factura};";
            return conexionBD.EjecutarPeticion(consulta);
        }

        public String AgregarADetalleCompra(String idFactura, String idProducto, String cantidad)
        {
            SqlParameter errorTextParam = new SqlParameter("@ErrorTexto", SqlDbType.NVarChar, 255);
            errorTextParam.Direction = ParameterDirection.Output;
            String errorText = null;
            SqlCommand command = new SqlCommand("InsertarDetalleCompra", conexionBD.ObtenerConexion());
            command.CommandType = CommandType.StoredProcedure;

            // Agregar los parámetros de entrada
            command.Parameters.AddWithValue("@IdFactura", idFactura);
            command.Parameters.AddWithValue("@IdProducto", idProducto);
            command.Parameters.AddWithValue("@Cantidad", cantidad);

            // Agregar el parámetro de salida
            command.Parameters.Add(errorTextParam);

            try
            {
                conexionBD.AbrirConexion();
                command.ExecuteNonQuery();

                // Recuperar el valor del parámetro de salida
                errorText = errorTextParam.Value.ToString();
                if (errorText != "")
                {
                    MessageBox.Show(errorText);
                }
                conexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }

            return errorText;
        }
        public void ActualizarDetalleCompra(int idDetalleCompra, int idProducto, int idLote, int idFactura, decimal total, decimal descuento, int cantidad)
        {
            String consulta = "UPDATE DetalleCompras SET id_Producto = @IdProducto, id_Lote = @IdLote, id_Factura = @IdFactura, " +
                              "Total = @Total, Descuento = @Descuento, Cantidad = @Cantidad WHERE id_DetalleCompra = @IdDetalleCompra";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.Parameters.AddWithValue("@IdLote", idLote);
            comando.Parameters.AddWithValue("@IdFactura", idFactura);
            comando.Parameters.AddWithValue("@Total", total);
            comando.Parameters.AddWithValue("@Descuento", descuento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@IdDetalleCompra", idDetalleCompra);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarDetalleCompra(String idFactura, String idProducto)
        {
            String consulta = "DELETE FROM DetalleCompras WHERE id_Factura = @idFactura AND id_Producto = @idProducto;";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idFactura", idFactura);
            comando.Parameters.AddWithValue("@idProducto", idProducto);

            conexionBD.EjecutarComando(comando);
        }

        //Productos
        public SqlDataReader ObtenerTodosLosProductos()
        {
            String consulta = "SELECT * FROM Productos";
            return conexionBD.EjecutarPeticion(consulta);
        }

        public SqlDataReader BuscadorDeProductos(String termino)
        {
            String consulta = "SELECT* FROM Productos WHERE NombreProducto LIKE '%' + @termino + '%' OR CONVERT(VARCHAR, id_Producto) LIKE '%' + @termino";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@termino", termino);
            return comando.ExecuteReader();
        }

        public String RecuperarPrecio(String idProducto)
        {
            String consulta = "SELECT PrecioV " +
            "FROM Productos " +
            "WHERE id_Producto = @idProducto;";
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            conexionBD.AbrirConexion();
            object resultado = comando.ExecuteScalar();
            conexionBD.CerrarConexion();
            return resultado != null ? resultado.ToString() : null;
        }

        //TipoPago
        public SqlDataReader ObtenerTodosLosTiposDePago()
        {
            String consulta = "SELECT * FROM TipoDePagos";
            return conexionBD.EjecutarPeticion(consulta);
        }

        //Filtros de productos
        public SqlDataReader ConsultarPorMarca(String marca)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorPresentacion(String presentacion)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Presentacion = @Presentacion";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorCategoria(String categoria)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaYPresentacion(String marca, String presentacion)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Presentacion = @Presentacion";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaYCategoria(String marca, String categoria)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorPresentacionYCategoria(String presentacion, String categoria)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Presentacion = @Presentacion AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaPresentacionYCategoria(String marca, String presentacion, String categoria)
        {
            String consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Presentacion = @Presentacion AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }
    }
}
