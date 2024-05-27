using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
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
    public partial class Proveedores : Form
    {
        CrudProveedores proveedor;

        public Proveedores()
        {
            InitializeComponent();
            LlenadoDeTablas();
            proveedor = new CrudProveedores();
        }

        public void LlenadoDeTablas()
        {
            CrudProveedores llenador = new CrudProveedores();
            tablaProveedores.DataSource = llenador.VerRegistros();

            // Establecer el ancho de las columnas
            tablaProveedores.Columns["id_Proveedor"].Width = 50;
            tablaProveedores.Columns["NombreProveedor"].Width = 85;
            tablaProveedores.Columns["Dirección"].Width = 200;
            tablaProveedores.Columns["Email"].Width = 100;
            tablaProveedores.Columns["Telefono"].Width = 100;
            tablaProveedores.AllowUserToAddRows = false;
            tablaProveedores.Columns["id_Proveedor"].ReadOnly = true;
            tablaProveedores.Columns["NombreProveedor"].ReadOnly = true;
            tablaProveedores.Columns["Dirección"].ReadOnly = true;
            tablaProveedores.Columns["Email"].ReadOnly = true;
            tablaProveedores.Columns["Telefono"].ReadOnly = true;
            foreach (DataGridViewColumn column in tablaProveedores.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public bool Validacion()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTel.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                try
                {
                    bool estado = proveedor.InsertarReg(txtNombre.Text, txtDireccion.Text, txtEmail.Text, txtTel.Text);
                    if (estado)
                        MessageBox.Show("El cliente se ha registrado éxitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LlenadoDeTablas();
            }
            else
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
