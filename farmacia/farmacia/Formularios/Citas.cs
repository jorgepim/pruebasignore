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
    public partial class Citas : Form
    {
        private CrudCitas CrudCitas = new CrudCitas();
        private int idDatConvenios;

        public Citas()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxes();
            cbCliente.SelectedIndexChanged += new EventHandler(cbCliente_SelectedIndexChanged);
            cBhospital.SelectedIndexChanged += new EventHandler(cBhospital_SelectedIndexChanged);
        }
        private void LoadData()
        {

            DataTable dt = CrudCitas.GetConsultas();
            tabalCitas.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = tabalCitas.Rows.Add();
                DataGridViewRow dgvRow = tabalCitas.Rows[rowIndex];
                dgvRow.Cells["CNum"].Value = row["id_ConsultasME"];
                dgvRow.Cells["cHospital"].Value = row["NombreHC"];
                dgvRow.Cells["CDoc"].Value = row["NombreDr"];
                dgvRow.Cells["cEspecialidad"].Value = row["Especialidad"];
                dgvRow.Cells["CFecha"].Value = row["Fecha"];
                dgvRow.Cells["cDetalles"].Value = row["DetallesAdicionales"];
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                cBhospital.DataSource = null;
                cbCliente.DataSource = null;

                // Obtener hospitales
                DataTable dtHospitals = CrudCitas.GetHospitals();
                cBhospital.DataSource = dtHospitals;
                cBhospital.DisplayMember = "NombreHC";
                cBhospital.ValueMember = "id_ConveniosHC";
                if (dtHospitals.Rows.Count > 0)
                {
                    cBhospital.SelectedIndex = 0;
                }

                // Obtener clientes
                DataTable dtClientes = CrudCitas.GetClientes();
                cbCliente.DataSource = dtClientes;
                cbCliente.DisplayMember = "NombreCliente";
                cbCliente.ValueMember = "id_Cliente";
                if (dtClientes.Rows.Count > 0)
                {
                    cbCliente.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBox: " + ex.Message);
            }
        }
        private void cBhospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cBhospital.SelectedValue != null)
                {
                    int idHospital = Convert.ToInt32(cBhospital.SelectedValue);
                    LoadDoctorsByHospital(idHospital);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los doctores: " + ex.Message);
            }
        }

        private void LoadDoctorsByHospital(int idHospital)
        {
            try
            {
                DataTable dtDoctors = CrudCitas.GetDoctorsByHospital(idHospital);
                cbDoctor.DataSource = dtDoctors;
                cbDoctor.DisplayMember = "NombreDr";
                cbDoctor.ValueMember = "id_DrEspecialidades";
                if (dtDoctors.Rows.Count > 0)
                {
                    cbDoctor.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los doctores: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(cbCliente.SelectedValue);
                int idDrEspecialidades = Convert.ToInt32(cbDoctor.SelectedValue);
                DateTime fecha = txtFecha.Value;
                string detallesAdicionales = txtDetalles.Text;

                if (idDatConvenios > 0 && idCliente > 0 && idDrEspecialidades > 0 && !string.IsNullOrEmpty(detallesAdicionales))
                {
                    CrudCitas.AddConsulta(idDatConvenios, idCliente, idDrEspecialidades, fecha, detallesAdicionales);

                    LoadData();

                    txtDetalles.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(cbCliente.SelectedValue);
                int idDatConvenios = CrudCitas.GetDatConveniosIdByCliente(idCliente);
                if (idDatConvenios > 0)
                {

                    this.idDatConvenios = idDatConvenios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la membresía del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
