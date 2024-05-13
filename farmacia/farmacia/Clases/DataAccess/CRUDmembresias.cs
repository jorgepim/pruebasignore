using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace farmacia.Clases.DataAccess
{
    internal class CRUDmembresias
    {
        private Conexion conexion = new Conexion();
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public CRUDmembresias()
        {
            conexion = new Conexion();
        }
        public SqlDataReader Fillcmb()
        {
            string query = "SELECT pm.periodoMembresia, m.TipoMembresia " +
               "FROM PagoMembresias p " +
               "JOIN PeriodoMembresias pm ON p.id_PeriodoMembresias = pm.id_PeriodoMembresias " +
               "JOIN Membresias m ON p.id_Membresias = m.id_Membresia";
            return conexion.EjecutarPeticion(query);

        }
    }
}
