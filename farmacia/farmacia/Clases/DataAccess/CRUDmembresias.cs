using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;

namespace farmacia.Clases.DataAccess
{
    internal class CRUDmembresias
    {
        private Conexion conexion = new Conexion();
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public CRUDmembresias()
        {
            conexion = new Conexion();
        }
        public SqlDataReader FillcmbTipoMembresia()
        {
            string query = "SELECT id_Membresia, TipoMembresia" +
               " FROM Membresias";
            return conexion.EjecutarPeticion(query);

        }
        public SqlDataReader FillcmbTipoPeriodo()
        {
            string query = "SELECT id_PeriodoMembresias, periodoMembresia " +
               "FROM PeriodoMembresias";
            return conexion.EjecutarPeticion(query);

        }
        public void ActualizarMembresia(int id_Membresia, String dui)
        {
            String query = "UPDATE Clientes SET id_Membresia = @id_Membresia " +
               "WHERE Dui = @dui";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@id_Membresia", id_Membresia);
            comando.Parameters.AddWithValue("@dui", dui);
            conexion.EjecutarComando(comando);
        }
    }
}
