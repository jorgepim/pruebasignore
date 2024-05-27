using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using farmacia.Formularios.multimedia;
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
        Form menu;
        public Clientes(Form menu)
        {
            InitializeComponent();
            LoadTheme();
            LlenadoDeTablas();
            cliente = new CrudClientes();
            this.menu = menu;
        }

        private void LoadTheme()
        {
            lblClientes.ForeColor = ThemeColor.SecondaryColor;
        }

        public bool Validacion()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtDui.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTel.Text) ||
                string.IsNullOrEmpty(TxtDirec.Text))
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
            else
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            tablaClientes.Columns["MEMBRESIA"].Width = 100;
            tablaClientes.AllowUserToAddRows = false;
            tablaClientes.Columns["ID"].ReadOnly = true;
            tablaClientes.Columns["NOMBRE"].ReadOnly = true;
            tablaClientes.Columns["DUI"].ReadOnly = true;
            tablaClientes.Columns["DIRECCIÓN"].ReadOnly = true;
            tablaClientes.Columns["E-MAIL"].ReadOnly = true;
            tablaClientes.Columns["NÚMERO DE CITAS"].ReadOnly = true;
            tablaClientes.Columns["MEMBRESIA"].ReadOnly = true;
            foreach (DataGridViewColumn column in tablaClientes.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
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
                LlenadoDeTablas();
            }
        }




        public void ObtenerDatosData()
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                string nombre = tablaClientes.SelectedRows[0].Cells["Nombre"].Value?.ToString();
                string dui = tablaClientes.SelectedRows[0].Cells["DUI"].Value?.ToString();
                string direccion = tablaClientes.SelectedRows[0].Cells["DIRECCIÓN"].Value?.ToString();
                string email = tablaClientes.SelectedRows[0].Cells["E-MAIL"].Value?.ToString();
                string telefono = tablaClientes.SelectedRows[0].Cells["TELÉFONO"].Value?.ToString();

                txtNombre.Text = nombre;
                txtDui.Text = dui;
                TxtDirec.Text = direccion;
                txtEmail.Text = email;
                txtTel.Text = telefono;
                txtNombre.Enabled = false;
                txtDui.Enabled = false;
                TxtDirec.Enabled = false;
                txtEmail.Enabled = false;
                txtTel.Enabled = false;
                btnAgregar.Enabled = false;
            }

        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatosData();
        }

        private void AbrirFactura(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                string id = tablaClientes.SelectedRows[0].Cells["ID"].Value.ToString();
                Factura factura = new Factura(id, menu, this);
                menu.Hide();
                this.Hide();
                factura.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.");
            }
        }

        private void btnMembresia_Click_1(object sender, EventArgs e)
        {
            string TipoMembresia = tablaClientes.SelectedRows[0].Cells["Membresia"].Value.ToString();
            if (TipoMembresia == "Ninguna")
            {
                if (tablaClientes.SelectedRows.Count > 0)
                {
                    string nombre = tablaClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    string dui = tablaClientes.SelectedRows[0].Cells["DUI"].Value.ToString();
                    Membresia membresia = new Membresia(nombre, dui, menu, this);
                    membresia.Show();
                    menu.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente.");
                }
            }
            else
            {
                MessageBox.Show("Este cliente ya tiene una suscripción activa");
            }
        }

    }
}
