﻿using farmacia.Formularios.multimedia;
using PharmaSync.formularios;
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



        private void IniciarSesion_Click_1(object sender, EventArgs e)
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
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("La contraseña o el usuario son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lector.Close();
            cadenaConexion.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !checkBox1.Checked;

        }
    }
}
