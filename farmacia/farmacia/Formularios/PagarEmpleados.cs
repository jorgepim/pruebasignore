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
        decimal pagar;
        public PagarEmpleados(string id, string nombre, Form menu, decimal aPagar, Form Empleado)
        {
            InitializeComponent();
            this.menu = menu;
            this.Empleado = Empleado;
            this.nombre = nombre;
            lblNombre.Text = nombre; 
            lblPago.Text = "$" + aPagar.ToString("F2");
            this.id = id;
        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            Empleado.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int empleadoId = int.Parse(id);
            Historial historial = new Historial(empleadoId, nombre, menu, Empleado);
            menu.Hide();
            this.Hide();
            historial.Show();
        }

       
    }
}
