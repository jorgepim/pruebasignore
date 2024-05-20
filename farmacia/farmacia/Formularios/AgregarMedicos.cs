using farmacia.Clases.DataAccess;
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
    public partial class AgregarMedicos : Form
    {
        String idConvenio = "1";
        public AgregarMedicos(String id)
        {
            this.idConvenio = id;
            InitializeComponent();
            LlenarCombo();
            LlenarTabla();
            BtnModificar.Enabled = false;
        }

        public void LlenarTabla()
        {
            CrudConvenios llenador = new CrudConvenios();
            TablaDeDatos.DataSource = llenador.LlenarTablaMedico(idConvenio);

            // Establecer el ancho de las columnas
            TablaDeDatos.Columns["ID"].Width = 50;
            TablaDeDatos.Columns["Nombre"].Width = 125;
            TablaDeDatos.Columns["Especialidad"].Width = 230;
            TablaDeDatos.Columns["Teléfono"].Width = 75;
            TablaDeDatos.AllowUserToAddRows = false;
            TablaDeDatos.Columns["ID"].ReadOnly = true;
            TablaDeDatos.Columns["Nombre"].ReadOnly = true;
            TablaDeDatos.Columns["Especialidad"].ReadOnly = true;
            TablaDeDatos.Columns["Teléfono"].ReadOnly = true;

            foreach (DataGridViewColumn column in TablaDeDatos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public bool Validador()
        {
            //Nombre solo contenga letras
            foreach (char c in TxtNombre.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Por favor, ingrese solo letras.");
                    return false;
                }
            }
            //Combo
            if (CBEspecialidades.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecciona una especialidad");
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
        public void LlenarCombo()
        {
            List<string> especialidadesMedicas = new List<string>()
            {
                "Seleccionar",
                "General",
                "Oftalmología",
                "Medicina Interna",
                "Cardiología",
                "Dermatología",
                "Endocrinología",
                "Gastroenterología",
                "Nefrología",
                "Neurología",
                "Oncología",
                "Pediatría",
                "Psiquiatría",
                "Reumatología"
            };
            CBEspecialidades.DataSource = especialidadesMedicas;
            CBEspecialidades.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validador())
            {
                CrudConvenios llenador = new CrudConvenios();
                String especialidad = CBEspecialidades.SelectedItem.ToString();
                llenador.InsertarMedicos(idConvenio, TxtNombre.Text.Trim(), especialidad, MaskTel.Text.Trim());
                MessageBox.Show("La información se ha guardado correctamente");
                LlenarTabla();
                TxtNombre.Text = "";
                CBEspecialidades.SelectedIndex = 0;
                MaskTel.Text = "";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Validador())
            {
                CrudConvenios llenador = new CrudConvenios();
                String especialidad = CBEspecialidades.SelectedItem.ToString();
                DataGridViewRow filas = TablaDeDatos.SelectedRows[0];
                String id = filas.Cells["ID"].Value.ToString();
                llenador.ModificarMedicos(id, TxtNombre.Text.Trim(), especialidad, MaskTel.Text.Trim());
                MessageBox.Show("La información se ha modificado correctamente");
                LlenarTabla();
                TxtNombre.Text = "";
                CBEspecialidades.SelectedIndex = 0;
                MaskTel.Text = "";
            }
        }

        private void TablaDeDatos_Click(object sender, EventArgs e)
        {
            if (TablaDeDatos.SelectedRows.Count > 0)
            {
                BtnModificar.Enabled = true;
                BtnAgregar.Enabled = false;
                DataGridViewRow filas = TablaDeDatos.SelectedRows[0];
                String nombre = filas.Cells["Nombre"].Value.ToString();
                String telefono = filas.Cells["Teléfono"].Value.ToString();
                String especialidad = filas.Cells["Especialidad"].Value.ToString();
                for (int i = 0; i < CBEspecialidades.Items.Count; i++)
                {
                    if (CBEspecialidades.Items[i].ToString().Equals(especialidad, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si se encuentra una coincidencia, seleccionar el ítem
                        CBEspecialidades.SelectedIndex = i;
                        break;
                    }
                }
                TxtNombre.Text = nombre;
                MaskTel.Text = telefono;

            }
            else
            {
                BtnAgregar.Enabled = true;
                BtnModificar.Enabled = false;
                TxtNombre.Text = "";
                CBEspecialidades.SelectedIndex = 0;
                MaskTel.Text = "";
            }
        }
    }
}

