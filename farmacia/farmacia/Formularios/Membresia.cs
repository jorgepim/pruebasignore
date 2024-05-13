using farmacia.Clases.DataAccess;
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
    public partial class Membresia : Form
    {
        public Membresia(string nombre, string dui)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblDUI.Text = dui;
            LlenadoCombos();
        }
        public Membresia()
        {
            InitializeComponent();
        }

        public void LlenadoCombos()
        {
            CRUDmembresias datos = new CRUDmembresias();
            SqlDataReader llenador = datos.Fillcmb();

            cbMembresia.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                cbMembresia.Items.Add(llenador.GetString(1));
            }
            cbMembresia.SelectedIndex = 0;
            llenador.Close();

            llenador = datos.Fillcmb();
            cbPeriodo.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                cbPeriodo.Items.Add(llenador.GetInt32(0).ToString());
            }
            cbPeriodo.SelectedIndex = 0;
            llenador.Close();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
