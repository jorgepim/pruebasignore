using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class CrudProveedores
    {
        Conexion conexion;
        public CrudProveedores()
        {
            conexion = new Conexion();
        }

        public SqlDataReader LlenadoCombo()
        {
            String consulta = "SELECT * FROM Proveedores;";
            return conexion.EjecutarPeticion(consulta);
        }
    }
}
