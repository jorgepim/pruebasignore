using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class crudEmpleados
    {
            private Conexion conexion = new Conexion();
            DataTable table = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
        public DataTable VerRegistros()
        {
            DataTable table = new DataTable();
            string query = @"SELECT id_Empleado AS ID,
                                Nombre AS  NOMBRE, 
                                Direccion AS DIRECCION, 
                                nombreCargo AS CARGO, 
                                NombreSucursal AS SUCURSAL FROM Empleados E
                                    JOIN 
                                        Cargo C ON E.Id_Cargo = C.id_cargo
                                    JOIN 
                                        Sucursales S ON E.id_Sucursal = S.id_Sucursal; ";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.CommandType = CommandType.Text;
            conexion.AbrirConexion();
            lector = comando.ExecuteReader();
            table.Load(lector);
            conexion.CerrarConexion();
            return table;
        }
        public SqlDataReader FillcmbCargo()
        {
            string query = "SELECT id_Cargo, nombreCargo FROM Cargo";
            return conexion.EjecutarPeticion(query);

        }
        public SqlDataReader FillcmbSucursal()
        {
            string query = "SELECT id_Sucursal, NombreSucursal FROM Sucursales";
            return conexion.EjecutarPeticion(query);

        }

        public bool InsertarReg(string pNombreEmpleado, string pDireccion, string pId_Cargo, string pEdad, string pTelefono, string pId_Sucursal)
        {
            
                conexion.AbrirConexion();

            string query = "INSERT INTO Empleados (id_Usuario, Nombre, Direccion, Id_Cargo, Edad, Telefono, FechaIngreso, id_Sucursal)" +
                   "VALUES (2, @Nombre, @Direccion, @Id_Cargo, @Edad, @Telefono, @FechaIngreso, @Id_Sucursal)";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());

            comando.Parameters.AddWithValue("@Nombre", pNombreEmpleado);
            comando.Parameters.AddWithValue("@Direccion", pDireccion);
            comando.Parameters.AddWithValue("@Id_Cargo", pId_Cargo);
            comando.Parameters.AddWithValue("@Edad", pEdad);
            comando.Parameters.AddWithValue("@Telefono", pTelefono);
            comando.Parameters.AddWithValue("@FechaIngreso", DateTime.Now);
            comando.Parameters.AddWithValue("@Id_Sucursal", pId_Sucursal);
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
