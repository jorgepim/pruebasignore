using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class crudPagarEmpleado
    {
        private Conexion conexion = new Conexion();
        /*public void SelectPago(string id_Empleado)
        {
            String query = "SELECT ";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@id_Membresia", id_Membresia);
            comando.Parameters.AddWithValue("@dui", dui);
            conexion.EjecutarComando(comando);
        }*/
    }
}
