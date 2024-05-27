using farmacia.Clases.DataAccess;
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
    public partial class RegistrarHoras : Form
    {
        Form menu;
        Form Empleado;
        int id_Empleado;
        string nombre;
        crudRegistrarHora registrarHora = new crudRegistrarHora();
        public RegistrarHoras(string id, string nombre, Form menu, Form Empleado)
        {
            InitializeComponent();
            lblEmpleado.Text = nombre;
            this.menu = menu;
            this.Empleado = Empleado;
            LlenadoCombos();
            numericHoras.Minimum = 0;
            numericHoras.Maximum = 24;
            numericHoras.Increment = 1;
            numericHoras.DecimalPlaces = 0;
            id_Empleado = int.Parse(id);
        }

        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }

        public void LlenadoCombos()
        {
            crudRegistrarHora datos = new crudRegistrarHora();
            SqlDataReader llenador;

            try
            {
                llenador = datos.FillcmbTipoHora();
                comboBoxTipoHora.Items.Clear();

                comboBoxTipoHora.Items.Add("Seleccionar");

                while (llenador.Read())
                {
                    int idTipoHora = llenador.GetInt32(0);
                    string descripcion = llenador.GetString(1);
                    string displayText = $"{idTipoHora}| {descripcion}";
                    comboBoxTipoHora.Items.Add(displayText);
                }
                comboBoxTipoHora.SelectedIndex = 0;
                llenador.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar : " + ex.Message);
            }
        }

        private void btnRegistrarHora_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"Se le asignarán un total de {(int)numericHoras.Value} horas al empleado: {lblEmpleado.Text} ¿Desea registrar las horas trabajadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string id_TipoHora = EncontrarSeleccion(comboBoxTipoHora);
                int id_tipoHoraINT = int.Parse(id_TipoHora);
                bool insertado = registrarHora.InsertarHora(id_Empleado, (int)numericHoras.Value, id_tipoHoraINT);
                if (insertado)
                {
                    MessageBox.Show($"Se le han asignado un total de {(int)numericHoras.Value} horas al Empleado: {lblEmpleado.Text}");
                }
            }
            else
            {
                MessageBox.Show("Registro de horas cancelado.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            Empleado.Show();
        }
    }
}
