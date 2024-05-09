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
    public partial class Clientes : Form
    {
        CrudClientes cliente;
        public Clientes()
        {
            InitializeComponent();
            LoadTheme();
            LlenadoDeTablas();
            cliente = new CrudClientes();
        }

        private void LoadTheme()
        {
            lblClientes.ForeColor = ThemeColor.SecondaryColor;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool estado = cliente.InsertarReg(txtNombre.Text, txtDui.Text, TxtDirec.Text, txtEmail.Text, txtTel.Text);
                if (estado)
                    MessageBox.Show("El cliente se ha registrado éxitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenadoDeTablas();

        }
        public void LlenadoDeTablas()
        {
            CrudClientes llenador = new CrudClientes();
            tablaClientes.DataSource = llenador.VerRegistros();

            // Establecer el ancho de las columnas
            tablaClientes.Columns["ID"].Width = 50;
            tablaClientes.Columns["NOMBRE"].Width = 85;
            tablaClientes.Columns["DUI"].Width = 200;
            tablaClientes.Columns["DIRECCIÓN"].Width = 100;
            tablaClientes.Columns["E-MAIL"].Width = 100;
            tablaClientes.Columns["NÚMERO DE CITAS"].Width = 100;
            tablaClientes.AllowUserToAddRows = false;
            tablaClientes.Columns["ID"].ReadOnly = true;
            tablaClientes.Columns["NOMBRE"].ReadOnly = true;
            tablaClientes.Columns["DUI"].ReadOnly = true;
            tablaClientes.Columns["DIRECCIÓN"].ReadOnly = true;
            tablaClientes.Columns["E-MAIL"].ReadOnly = true;
            tablaClientes.Columns["NÚMERO DE CITAS"].ReadOnly = true;
            foreach (DataGridViewColumn column in tablaClientes.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tablaClientes.CurrentCell = null;
                
                foreach (DataGridViewRow r in tablaClientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        else
                        {
                            r.Visible = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Broder, ponga un nombre primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
