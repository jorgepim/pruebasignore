using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class CrudClientes
    {
        private Conexion conexion = new Conexion();
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        public CrudClientes()
        {
            conexion = new Conexion();
        }

        public DataTable VerRegistros()
        {
            DataTable table = new DataTable();
            string query = @"SELECT 
                        C.id_Cliente AS 'ID',
                        C.NombreCliente AS 'NOMBRE', 
                        C.Dui AS 'DUI', 
                        C.Dirección AS 'DIRECCIÓN', 
                        C.Email AS 'E-MAIL', 
                        C.Telefono AS 'TELÉFONO',
                        C.NumCitasAsis AS 'NÚMERO DE CITAS', 
                        M.TipoMembresia AS 'Membresia'
                    FROM 
                        Clientes C
                        INNER JOIN Membresias M ON C.id_Membresia = M.id_Membresia;";
            SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
            comando.CommandType = CommandType.Text;
            conexion.AbrirConexion();
            lector = comando.ExecuteReader();
            table.Load(lector);
            conexion.CerrarConexion();
            return table;
        }

        


        public bool InsertarReg(string PnombreCliente, string Pdui, string Pdireccion, string Pemail, string Ptelefono)
            {
                conexion.AbrirConexion();

                 string query = "INSERT INTO Clientes (id_Usuario, NombreCliente, Dui, Dirección, Email, Telefono, id_Membresia, NumCitasAsis)" +
                                 "VALUES (3, @NombreCliente, @Dui, @Dirección, @Email, @Teléfono, 6, 0)";
                SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@NombreCliente", PnombreCliente);
                comando.Parameters.AddWithValue("@Dui", Pdui);
                comando.Parameters.AddWithValue("@Dirección", Pdireccion);
                comando.Parameters.AddWithValue("@Email", Pemail);
                comando.Parameters.AddWithValue("@Teléfono", Ptelefono);
                comando.Parameters.AddWithValue("@NumCitasAsis", 0);
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

