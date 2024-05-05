using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    public class CrudProductos
    {
        private Conexion conexionBD;

        public CrudProductos()
        {
            conexionBD = new Conexion();
        }

        public DataTable ObtenerTodosLosProductos()
        {
            string consulta = "SELECT * FROM Productos";
            return conexionBD.EjecutarConsulta(consulta);
        }

        public void InsertarProducto(string nombre, decimal precio, int stock, string descripcion, bool receta, int idCategoria, int idPresentacion, int idMarca)
        {
            string consulta = "INSERT INTO Productos (NombreProducto, PrecioV, Stock, Descripcion, Receta, id_Categoria, id_Presentacion, id_Marca) " +
                              "VALUES (@NombreProducto, @PrecioV, @Stock, @Descripcion, @Receta, @idCategoria, @idPresentacion, @idMarca)";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreProducto", nombre);
            comando.Parameters.AddWithValue("@PrecioV", precio);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Receta", receta);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@idPresentacion", idPresentacion);
            comando.Parameters.AddWithValue("@idMarca", idMarca);

            conexionBD.EjecutarComando(comando);
        }

        public void ActualizarProducto(int idProducto, string nombre, decimal precio, int stock, string descripcion, bool receta, int idCategoria, int idPresentacion, int idMarca)
        {
            string consulta = "UPDATE Productos SET NombreProducto = @NombreProducto, PrecioV = @PrecioV, Stock = @Stock, Descripcion = @Descripcion, " +
                              "Receta = @Receta, id_Categoria = @idCategoria, id_Presentacion = @idPresentacion, id_Marca = @idMarca WHERE id_Producto = @idProducto";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@NombreProducto", nombre);
            comando.Parameters.AddWithValue("@PrecioV", precio);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Receta", receta);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@idPresentacion", idPresentacion);
            comando.Parameters.AddWithValue("@idMarca", idMarca);
            comando.Parameters.AddWithValue("@idProducto", idProducto);

            conexionBD.EjecutarComando(comando);
        }

        public void EliminarProducto(int idProducto)
        {
            string consulta = "DELETE FROM Productos WHERE id_Producto = @idProducto";

            SqlCommand comando = new SqlCommand(consulta, conexionBD.ObtenerConexion());
            comando.Parameters.AddWithValue("@idProducto", idProducto);

            conexionBD.EjecutarComando(comando);
        }
    }
}
