using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia.Formularios
{
    public partial class Historial : Form
    {
        Form menu;
        Form Empleado;
        int empleado_id;
        public Historial(int id, string nombre, Form menu, Form Empleado)
        {
            InitializeComponent();
            empleado_id = id;
            lblEmpleado.Text = nombre;
            LlenadoDeTablas(empleado_id);
            this.menu = menu;
            this.Empleado = Empleado;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            Empleado.Show();
        }
        public void LlenadoDeTablas(int empleado_id)
        {
            crudPagarEmpleado pagar = new crudPagarEmpleado();
            DataTable resultTable = pagar.CalcularPagoEmpleadoHistorial(empleado_id);
            tablaHistorial.DataSource = resultTable;

            tablaHistorial.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in tablaHistorial.Columns)
            {
                column.ReadOnly = true;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
