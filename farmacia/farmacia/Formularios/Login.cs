using farmacia.Formularios.multimedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia.Formularios
{
    public partial class Login : Form
    {
        SqlConnection cadenaConexion = new SqlConnection("server=localhost;database=BDFarmacia ; integrated security = true");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            cadenaConexion.Open();
            string consulta = "SELECT * FROM usuarios WHERE nombreUsuario = @Usuario AND Contraseña = @Contraseña";
            SqlCommand comando = new SqlCommand(consulta, cadenaConexion);
            comando.Parameters.AddWithValue("@Usuario", txtUser.Text);
            comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                string id_tipoUsuario = lector["id_tipoUsuario"].ToString();
                if (id_tipoUsuario == "2")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else if (id_tipoUsuario == "1")
                {
                    MessageBox.Show("Broder, es loco va, entró al admin");
                }
            }
            else
            {
                MessageBox.Show("Contraseña o usuarios son incorrectos");
            }
            lector.Close();
            cadenaConexion.Close();

        }
    }
}
