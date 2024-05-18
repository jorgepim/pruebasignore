using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class CrudSucursal
    {
        Conexion conexion;
        public CrudSucursal()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerDatosTabla()
        {
            String consulta = "SELECT su.NombreSucursal AS 'Sucursal', de.NombreDepartamento AS 'Departamento', pr.NombreProducto AS 'Producto', inv.Cantidad AS 'Cantidad' " +
                "FROM InventarioSucursales inv " +
                "JOIN Sucursales su ON inv.id_Sucursal = su.id_Sucursal " +
                "JOIN Departamentos de ON su.Id_Departamento = de.id_Departamento " +
                "JOIN Productos pr ON inv.id_Producto = pr.id_Producto;";
            return conexion.EjecutarConsulta(consulta);
        }

        public SqlDataReader ObtenerDepartamentos()
        {
            String consulta = "SELECT *FROM Departamentos;";
            return conexion.EjecutarPeticion(consulta);
        }
        public SqlDataReader LlenadorDeCombo()
        {
            String consulta = "SELECT *FROM Sucursales";
            return conexion.EjecutarPeticion(consulta);
        }
        public DataTable FiltrarPorBusqueda(String termino)
        {
            String consulta = "SELECT su.NombreSucursal AS 'Sucursal', de.NombreDepartamento AS 'Departamento', pr.NombreProducto AS 'Producto', inv.Cantidad AS 'Cantidad' " +
                "FROM InventarioSucursales inv " +
                "JOIN Sucursales su ON inv.id_Sucursal = su.id_Sucursal " +
                "JOIN Departamentos de ON su.Id_Departamento = de.id_Departamento " +
                "JOIN Productos pr ON inv.id_Producto = pr.id_Producto " +
                "WHERE pr.NombreProducto LIKE '%' + @termino + '%' OR CONVERT(VARCHAR, pr.id_Producto) LIKE '%' + @termino;";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@termino", termino);
            conexion.AbrirConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable FiltrarPorBusquedaYDepartamento(String termino, String idDepartamento)
        {
            String consulta = "SELECT su.NombreSucursal AS 'Sucursal', de.NombreDepartamento AS 'Departamento', pr.NombreProducto AS 'Producto', inv.Cantidad AS 'Cantidad' " +
                "FROM InventarioSucursales inv " +
                "JOIN Sucursales su ON inv.id_Sucursal = su.id_Sucursal " +
                "JOIN Departamentos de ON su.Id_Departamento = de.id_Departamento JOIN Productos pr ON inv.id_Producto = pr.id_Producto " +
                "WHERE (pr.NombreProducto LIKE '%' + @termino + '%' OR CONVERT(VARCHAR, pr.id_Producto) LIKE '%' + @termino) AND de.id_Departamento = @idDepartamento;";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@termino", termino);
            comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            conexion.AbrirConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable FiltraPorDepartamento(String idDepartamento)
        {
            String consulta = "SELECT su.NombreSucursal AS 'Sucursal', de.NombreDepartamento AS 'Departamento', pr.NombreProducto AS 'Producto', inv.Cantidad AS 'Cantidad' " +
                "FROM InventarioSucursales inv " +
                "JOIN Sucursales su ON inv.id_Sucursal = su.id_Sucursal " +
                "JOIN Departamentos de ON su.Id_Departamento = de.id_Departamento " +
                "JOIN Productos pr ON inv.id_Producto = pr.id_Producto " +
                "WHERE de.id_Departamento = @idDepartamento;";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            conexion.AbrirConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}