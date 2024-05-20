using farmacia.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.DataAccess
{
    internal class CrudConvenios
    {
        Conexion conexion;

        public CrudConvenios()
        {
            conexion = new Conexion();
        }

        public DataTable LlenarTabla()
        {
            String consulta = "SELECT id_ConveniosHC AS 'ID', NombreHC AS 'Hospital', Direccion AS 'Dirección', Telefono AS 'Teléfono', Correo FROM ConveniosHC;";
            return conexion.EjecutarConsulta(consulta);
        }

        public void InsertarConvenio(String nombre, String direccion, String telefono, String correo)
        {
            String consulta = "INSERT INTO ConveniosHC (NombreHC, Direccion, Telefono, Correo) " +
                "VALUES (@Nombre, @Direccion, @Telefono, @Correo);";

            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Correo", correo);
            conexion.EjecutarComando(comando);
        }

        public void ActualizarConvenio(String id,String nombre, String direccion, String telefono, String correo)
        {
            String consulta = "UPDATE ConveniosHC " +
                "SET NombreHC = @Nombre, " +
                "Direccion = @Direccion, " +
                "Telefono = @Telefono, " +
                "Correo = @Correo " +
                "WHERE id_ConveniosHC = @Id";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Id", id);
            conexion.EjecutarComando(comando);
        }

        //Medicos
        public DataTable LlenarTablaMedico(String id)
        {
            String consulta = "SELECT id_DrEspecialidades AS 'ID', NombreDr AS 'Nombre', Especialidad, Tel AS 'Teléfono' FROM DrEspecialidades " +
                $"WHERE Id_ConveniosHC = {id};";
            return conexion.EjecutarConsulta(consulta);
        }
        public void InsertarMedicos(String idConvenio, String nombre, String especialidad, String tel)
        {
            String consulta = "INSERT INTO DrEspecialidades (NombreDr, Especialidad, Tel, Id_ConveniosHC) " +
                "VALUES (@Nombre, @Especialidad, @Tel, @IdConvenio);";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Especialidad", especialidad);
            comando.Parameters.AddWithValue("@Tel", tel);
            comando.Parameters.AddWithValue("@IdConvenio", idConvenio);
            conexion.EjecutarComando(comando);
        }

        public void ModificarMedicos(String id, String nombre, String especialidad, String tel)
        {
            String consulta = "UPDATE DrEspecialidades " +
                "SET NombreDr = @Nombre, Especialidad = @Especialidad, Tel = @Tel " +
                "WHERE id_DrEspecialidades = @ID;";
            SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Especialidad", especialidad);
            comando.Parameters.AddWithValue("@Tel", tel);
            comando.Parameters.AddWithValue("@ID", id);
            conexion.EjecutarComando(comando);
        }
    }
}
