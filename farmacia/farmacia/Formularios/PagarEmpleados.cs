using farmacia.Clases.Entidades;
using farmacia.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class PagarEmpleados : Form
    {
        Form menu;
        Form Empleado;
        string id;
        string nombre;
        public PagarEmpleados(string id, string nombre, Form menu, Form Empleado)
        {
            InitializeComponent();
            this.menu = menu;
            this.Empleado = Empleado;
            lblNombre.Text = nombre;
        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            Empleado.Show();
        }
    }
}
