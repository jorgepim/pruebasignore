using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases
{
    internal class CrudProductos
    {
        Conexion conexion;

        public CrudProductos()
        {
            conexion = new Conexion();
        }

        public DataTable LlenadoTabla()
        {
            String consulta = "SELECT id_Producto AS 'ID', NombreProducto AS 'Nombre', PrecioV AS 'Precio', Stock, Descripcion AS 'Descripción', Receta, m.NombreMarca AS 'Marca', pr.TipoDePre AS 'Presentación', ca.NombreCategoria AS 'Categoría' " +
                "FROM Productos p " +
                "JOIN Categorias ca ON p.id_Categoria = ca.id_Categoria " +
                "JOIN Presentaciones pr ON p.id_Presentacion = pr.id_Presentacion " +
                "JOIN Marcas m ON p.id_Marca = m.id_Marca;";
            return conexion.EjecutarConsulta(consulta);
        }

        public SqlDataReader ComboMarca()
        {
            String consulta = "SELECT id_Marca, NombreMarca FROM Marcas;";
            return conexion.EjecutarPeticion(consulta);
        }
        public SqlDataReader ComboPresentacion()
        {
            String consulta = "SELECT id_Presentacion, TipoDePre FROM Presentaciones;";
            return conexion.EjecutarPeticion(consulta);
        }

        public SqlDataReader ComboCatagoria()
        {
            String consulta = "SELECT id_Categoria, NombreCategoria FROM Categorias;";
            return conexion.EjecutarPeticion(consulta);
        }

        public void InsertarProducto(String NombreProducto, Decimal PrecioV, String Descripcion, int Receta, String id_Categoria, String id_Presentacion, String id_Marca)
        {
            String consulta = "INSERT INTO Productos (NombreProducto, PrecioV, Stock, Descripcion, Receta, id_Categoria, id_Presentacion, id_Marca) " +
                "VALUES (@Nombre, @Precio, 0, @Descripcion, @Receta, @Categoria, @Presentacion, @Marca);";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", NombreProducto);
            comando.Parameters.AddWithValue("@Precio", PrecioV);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Receta", Receta);
            comando.Parameters.AddWithValue("@Categoria", id_Categoria);
            comando.Parameters.AddWithValue("@Presentacion", id_Presentacion);
            comando.Parameters.AddWithValue("@Marca", id_Marca);

            conexion.EjecutarComando(comando);
        }
    }
}
