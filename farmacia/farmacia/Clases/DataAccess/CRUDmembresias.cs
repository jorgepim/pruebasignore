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
        public SqlDataReader Fillcmb()
        {
            string query = "SELECT m.id_Membresia, pm.id_PeriodoMembresias, m.TipoMembresia, pm.periodoMembresia " +
               "FROM PagoMembresias p " +
               "JOIN PeriodoMembresias pm ON p.id_PeriodoMembresias = pm.id_PeriodoMembresias " +
               "JOIN Membresias m ON p.id_Membresias = m.id_Membresia";
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
