using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string consulta = "SELECT * FROM Categorias";
            return conexionBD.EjecutarPeticion(consulta);
        }

        public void InsertarCategoria(string nombreCategoria)
        {
            string consulta = "INSERT INTO Categorias (NombreCategoria) VALUES (@NombreCategoria)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarCategoria(int idCategoria, string nombreCategoria)
        {
            string consulta = "UPDATE Categorias SET NombreCategoria = @NombreCategoria WHERE id_Categoria = @idCategoria";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarCategoria(int idCategoria)
        {
            string consulta = "DELETE FROM Categorias WHERE id_Categoria = @idCategoria";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            conexionBD.EjecutarComando(comando);
        }

        //Crud de Marcas
        public SqlDataReader ObtenerTodasLasMarcas()
        {
            string consulta = "SELECT * FROM Marcas";
            return conexionBD.EjecutarPeticion(consulta);
        }

        public void InsertarMarca(string nombreMarca)
        {
            string consulta = "INSERT INTO Marcas (NombreMarca) VALUES (@NombreMarca)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreMarca", nombreMarca);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarMarca(int idMarca, string nombreMarca)
        {
            string consulta = "UPDATE Marcas SET NombreMarca = @NombreMarca WHERE id_Marca = @idMarca";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreMarca", nombreMarca);
            comando.Parameters.AddWithValue("@idMarca", idMarca);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarMarca(int idMarca)
        {
            string consulta = "DELETE FROM Marcas WHERE id_Marca = @idMarca";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idMarca", idMarca);

            conexionBD.EjecutarComando(comando);
        }

        //Crud de Presentaciones

        public SqlDataReader ObtenerTodasLasPresentaciones()
        {
            string consulta = "SELECT * FROM Presentaciones";
            return conexionBD.EjecutarPeticion(consulta);
        }

        public void InsertarPresentacion(string tipoDePre)
        {
            string consulta = "INSERT INTO Presentaciones (TipoDePre) VALUES (@TipoDePre)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@TipoDePre", tipoDePre);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarPresentacion(int idPresentacion, string tipoDePre)
        {
            string consulta = "UPDATE Presentaciones SET TipoDePre = @TipoDePre WHERE id_Presentacion = @idPresentacion";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@TipoDePre", tipoDePre);
            comando.Parameters.AddWithValue("@idPresentacion", idPresentacion);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarPresentacion(int idPresentacion)
        {
            string consulta = "DELETE FROM Presentaciones WHERE id_Presentacion = @idPresentacion";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idPresentacion", idPresentacion);

            conexionBD.EjecutarComando(comando);
        }

        //Crud de DetalleCompras

        public DataTable ObtenerTodosLosDetallesDeCompra()
        {
            string consulta = "SELECT * FROM DetalleCompras";
            return conexionBD.EjecutarConsulta(consulta);
        }

        public void InsertarDetalleCompra(int idProducto, int idLote, int idFactura, decimal total, decimal descuento, int cantidad)
        {
            string consulta = "INSERT INTO DetalleCompras (id_Producto, id_Lote, id_Factura, Total, Descuento, Cantidad) " +
                              "VALUES (@IdProducto, @IdLote, @IdFactura, @Total, @Descuento, @Cantidad)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.Parameters.AddWithValue("@IdLote", idLote);
            comando.Parameters.AddWithValue("@IdFactura", idFactura);
            comando.Parameters.AddWithValue("@Total", total);
            comando.Parameters.AddWithValue("@Descuento", descuento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarDetalleCompra(int idDetalleCompra, int idProducto, int idLote, int idFactura, decimal total, decimal descuento, int cantidad)
        {
            string consulta = "UPDATE DetalleCompras SET id_Producto = @IdProducto, id_Lote = @IdLote, id_Factura = @IdFactura, " +
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

        public void EliminarDetalleCompra(int idDetalleCompra)
        {
            string consulta = "DELETE FROM DetalleCompras WHERE id_DetalleCompra = @IdDetalleCompra";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@IdDetalleCompra", idDetalleCompra);

            conexionBD.EjecutarComando(comando);
        }

        //Productos
        public SqlDataReader ObtenerTodosLosProductos()
        {
            string consulta = "SELECT * FROM Productos";
            return conexionBD.EjecutarPeticion(consulta);
        }

        //Filtros de productos
        public SqlDataReader ConsultarPorMarca(string marca)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorPresentacion(string presentacion)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Presentacion = @Presentacion";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorCategoria(string categoria)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaYPresentacion(string marca, string presentacion)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Presentacion = @Presentacion";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaYCategoria(string marca, string categoria)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorPresentacionYCategoria(string presentacion, string categoria)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Presentacion = @Presentacion AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }

        public SqlDataReader ConsultarPorMarcaPresentacionYCategoria(string marca, string presentacion, string categoria)
        {
            string consulta = "SELECT * FROM Productos WHERE id_Marca = @Marca AND id_Presentacion = @Presentacion AND id_Categoria = @Categoria";
            conexionBD.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Presentacion", presentacion);
            comando.Parameters.AddWithValue("@Categoria", categoria);
            return comando.ExecuteReader();
        }
    }
}
