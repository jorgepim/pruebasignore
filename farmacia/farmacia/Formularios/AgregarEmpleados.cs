using farmacia;
using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using farmacia.Formularios;
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

namespace DB
{
    public partial class AgregarEmpleados : Form
    {
        crudEmpleados empleados = new crudEmpleados();
        crudPagarEmpleado pagar = new crudPagarEmpleado();
        Form menu;
        public AgregarEmpleados(Form menu)
        {
            InitializeComponent();
            LlenadoDeTablas();
            LlenadoCombos();
            this.menu = menu;
        }

        
        public void LlenadoDeTablas()
        {
            crudEmpleados llenador = new crudEmpleados();
            tablaEmpleados.DataSource = llenador.VerRegistros();

            // Establecer el ancho de las columnas
            tablaEmpleados.Columns["ID"].Width = 80;
            tablaEmpleados.Columns["NOMBRE"].Width = 80;
            tablaEmpleados.Columns["DIRECCION"].Width = 200;
            tablaEmpleados.Columns["CARGO"].Width = 100;
            tablaEmpleados.Columns["SUCURSAL"].Width = 100;
            tablaEmpleados.AllowUserToAddRows = false;
            tablaEmpleados.Columns["ID"].Width = 80;
            tablaEmpleados.Columns["NOMBRE"].ReadOnly = true;
            tablaEmpleados.Columns["DIRECCION"].ReadOnly = true;
            tablaEmpleados.Columns["CARGO"].ReadOnly = true;
            tablaEmpleados.Columns["SUCURSAL"].ReadOnly = true;
            foreach (DataGridViewColumn column in tablaEmpleados.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void ObtenerDatosData()
        {
            if (tablaEmpleados.SelectedRows.Count > 0)
            {
                string nombre = tablaEmpleados.SelectedRows[0].Cells["NOMBRE"].Value?.ToString();
                string direccion = tablaEmpleados.SelectedRows[0].Cells["DIRECCION"].Value?.ToString();
                string cargo = tablaEmpleados.SelectedRows[0].Cells["CARGO"].Value?.ToString();
                string sucursal = tablaEmpleados.SelectedRows[0].Cells["SUCURSAL"].Value?.ToString();

                txtBoxNombre.Text = nombre;
                comboBoxCargo.Text = cargo;
                txtBoxDireccion.Text = direccion;
                comboBoxSucursal.Text = sucursal;
                txtBoxNombre.Enabled = false;
                comboBoxCargo.Enabled = false;
                txtBoxDireccion.Enabled = false;
                comboBoxSucursal.Enabled = false;
                btnAgregar.Enabled = false;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tablaEmpleados.CurrentCell = null;

                foreach (DataGridViewRow r in tablaEmpleados.Rows)
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

        private void tablaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatosData();
        }
        public bool Validacion()
        {
            if (string.IsNullOrEmpty(txtBoxNombre.Text)    ||
                comboBoxCargo.Text == "Seleccionar"        ||
                string.IsNullOrEmpty(txtBoxDireccion.Text) ||
                comboBoxSucursal.Text == "Seleccionar"     ||
                string.IsNullOrEmpty(txtBoxTelefono.Text)  ||
                string.IsNullOrEmpty(txtBoxEdad.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                String Cargo = EncontrarSeleccion(comboBoxCargo);
                String Sucursal = EncontrarSeleccion(comboBoxSucursal);
                bool estado = empleados.InsertarReg(txtBoxNombre.Text, txtBoxDireccion.Text, Cargo, txtBoxEdad.Text, txtBoxTelefono.Text, Sucursal);
                if (estado)
                    MessageBox.Show("El empleado se ha registrado éxitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenadoDeTablas();
        }
        

        public void LlenadoCombos()
        {
            crudEmpleados datos = new crudEmpleados();
            SqlDataReader llenador;

            try
            {
                llenador = datos.FillcmbCargo();
                comboBoxCargo.Items.Clear();

                comboBoxCargo.Items.Add("Seleccionar");

                while (llenador.Read())
                {
                    int idCargo = llenador.GetInt32(0);
                    string descripcion = llenador.GetString(1);
                    string displayText = $"{idCargo}| {descripcion}";
                    comboBoxCargo.Items.Add(displayText);
                }
                comboBoxCargo.SelectedIndex = 0;
                llenador.Close();

                llenador = datos.FillcmbSucursal();
                comboBoxSucursal.Items.Add("Seleccionar");
                while (llenador.Read())
                {
                    int idSucursal = llenador.GetInt32(0); 
                    string descripcion = llenador.GetString(1);
                    string displayText = $"{idSucursal} | {descripcion}";
                    comboBoxSucursal.Items.Add(displayText);
                }
                comboBoxSucursal.SelectedIndex = 0;
                llenador.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar : " + ex.Message);
            }
        }

        private void btnPagarEmp_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados.SelectedRows.Count > 0)
            {
                string id = tablaEmpleados.SelectedRows[0].Cells["ID"].Value.ToString();
                string nombre = tablaEmpleados.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
                int empleadoId = int.Parse(id);
                decimal aPagar = pagar.CalcularTotalPagarEmpleado(empleadoId);
                PagarEmpleados pago = new PagarEmpleados(id, nombre, menu, aPagar, this);
                menu.Hide();
                this.Hide();
                pago.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.");
            }
        }

        private void btnRegisHora_Click(object sender, EventArgs e)
        {
            if (tablaEmpleados.SelectedRows.Count > 0)
            {
                string id = tablaEmpleados.SelectedRows[0].Cells["ID"].Value.ToString();
                string nombre = tablaEmpleados.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
                RegistrarHoras hora = new RegistrarHoras(id, nombre, menu, this);
                menu.Hide();
                this.Hide();
                hora.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.");
            }
        }
    }
}

