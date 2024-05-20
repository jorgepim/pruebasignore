using farmacia.Clases.DataAccess;
using farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using farmacia.Formularios;

namespace DB
{
    public partial class AgregarConvenios : Form
    {
        public AgregarConvenios()
        {
            InitializeComponent();
            LlenadoTabla();
            BtnModificar.Enabled = false;
        }

        public void LlenadoTabla()
        {
            CrudConvenios llenador = new CrudConvenios();
            TablaDeDatos.DataSource = llenador.LlenarTabla();

            // Establecer el ancho de las columnas
            TablaDeDatos.Columns["ID"].Width = 50;
            TablaDeDatos.Columns["Hospital"].Width = 125;
            TablaDeDatos.Columns["Dirección"].Width = 230;
            TablaDeDatos.Columns["Teléfono"].Width = 75;
            TablaDeDatos.Columns["Correo"].Width = 150;
            TablaDeDatos.AllowUserToAddRows = false;
            TablaDeDatos.Columns["ID"].ReadOnly = true;
            TablaDeDatos.Columns["Hospital"].ReadOnly = true;
            TablaDeDatos.Columns["Dirección"].ReadOnly = true;
            TablaDeDatos.Columns["Teléfono"].ReadOnly = true;
            TablaDeDatos.Columns["Correo"].ReadOnly = true;

            foreach (DataGridViewColumn column in TablaDeDatos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public bool Validador()
        {
            //Nombre solo contenga letras
            foreach (char c in txtBoxNombreConve.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Por favor, ingrese solo letras.");
                    return false;
                }
            }
            //Direccion no este vacio
            if (string.IsNullOrWhiteSpace(txtBoxDireccionConve.Text))
            {
                MessageBox.Show("El campo dirección no puede estar vacío");
                return false;
            }
            //Correo contenga  @ o punto
            if (!(txtBoxCorreoConve.Text.Contains("@") && txtBoxCorreoConve.Text.Contains(".")))
            {
                MessageBox.Show("El correo debe contener al menos una '@' y un '.'");
                return false;
            }
            //Numero de telefono 
            if (MaskTel.Text.Trim().Length <= 8)
            {
                MessageBox.Show("El campo de número telélefonico debe estar escrito correctamente");
                return false;
            }
            return true;
        }
        private void btnAgregarConve_Click(object sender, EventArgs e)
        {
            if (Validador())
            {
                CrudConvenios llenador = new CrudConvenios();
                String nombre = txtBoxNombreConve.Text.Trim();
                String direccion = txtBoxDireccionConve.Text.Trim();
                String tel = MaskTel.Text.Trim();
                String correo = txtBoxCorreoConve.Text.Trim();
                llenador.InsertarConvenio(nombre, direccion, tel, correo);
                MessageBox.Show("El convenio se ha guardado correctamente");
                LlenadoTabla();
                txtBoxCorreoConve.Text = "";
                txtBoxDireccionConve.Text = "";
                txtBoxNombreConve.Text = "";
                MaskTel.Text = "";
            }
        }

        private void TablaDeDatos_Click(object sender, EventArgs e)
        {
            if (TablaDeDatos.SelectedRows.Count > 0)
            {
                BtnModificar.Enabled = true;
                btnAgregarConve.Enabled = false;
                DataGridViewRow filas = TablaDeDatos.SelectedRows[0];
                String hospital = filas.Cells["Hospital"].Value.ToString();
                String direccion = filas.Cells["Dirección"].Value.ToString();
                String telefono = filas.Cells["Teléfono"].Value.ToString();
                String correo = filas.Cells["Correo"].Value.ToString();
                txtBoxNombreConve.Text = hospital;
                txtBoxDireccionConve.Text = direccion;
                MaskTel.Text = telefono;
                txtBoxCorreoConve.Text = correo;
            }
            else
            {
                btnAgregarConve.Enabled = true;
                BtnModificar.Enabled = false;
                txtBoxNombreConve.Text = "";
                txtBoxDireccionConve.Text = "";
                MaskTel.Text = "";
                txtBoxCorreoConve.Text = "";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Validador())
            {
                CrudConvenios llenador = new CrudConvenios();
                DataGridViewRow filas = TablaDeDatos.SelectedRows[0];
                String id = filas.Cells["ID"].Value.ToString();
                String nombre = txtBoxNombreConve.Text.Trim();
                String direccion = txtBoxDireccionConve.Text.Trim();
                String tel = MaskTel.Text.Trim();
                String correo = txtBoxCorreoConve.Text.Trim();
                llenador.ActualizarConvenio(id, nombre, direccion, tel, correo);
                MessageBox.Show("El convenio se ha guardado correctamente");
                LlenadoTabla();
                txtBoxCorreoConve.Text = "";
                txtBoxDireccionConve.Text = "";
                txtBoxNombreConve.Text = "";
                MaskTel.Text = "";
            }
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            if (TablaDeDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow filas = TablaDeDatos.SelectedRows[0];
                String id = filas.Cells["ID"].Value.ToString();
                AgregarMedicos abrir = new AgregarMedicos(id);
                abrir.Show();
            }else
            {
                MessageBox.Show("Tiene que seleccionar un convenio");
            }
        }
    }
}
