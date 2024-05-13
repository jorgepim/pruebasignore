﻿using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using farmacia.Formularios.multimedia;
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
    public partial class Membresia : Form
    {
        public Membresia(string nombre, string dui)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblDUI.Text = dui;
            LlenadoCombos();
        }
        public Membresia()
        {
            InitializeComponent();
        }

        // Lista para almacenar los IDs de las membresías
        List<int> idsMembresia = new List<int>();

        public void LlenadoCombos()
        {
            CRUDmembresias datos = new CRUDmembresias();
            SqlDataReader llenador;

            // Llenado de cbMembresia
            try
            {
                llenador = datos.Fillcmb();
                cbMembresia.Items.Clear();
                idsMembresia.Clear();

                cbMembresia.Items.Add("Seleccionar");
                idsMembresia.Add(-1); // Alinea los índices con el ComboBox

                while (llenador.Read())
                {
                    int idMembresia = llenador.GetInt32(0);
                    string descripcion = llenador.GetString(2);
                    string displayText = $"{idMembresia}| {descripcion}";
                    cbMembresia.Items.Add(displayText);
                    idsMembresia.Add(idMembresia);
                }
                cbMembresia.SelectedIndex = 0;
                llenador.Close();

                llenador = datos.Fillcmb();
                cbPeriodo.Items.Add("Seleccionar");
                while (llenador.Read())
                {
                    cbPeriodo.Items.Add(llenador.GetInt32(1).ToString() + "| " + llenador.GetInt32(3).ToString());
                }
                cbPeriodo.SelectedIndex = 0;
                llenador.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar cbMembresia: " + ex.Message);
            }
        }


         private void btnRegresar_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CRUDmembresias actualizar = new CRUDmembresias();
            if (cbMembresia.SelectedIndex > 0) // Asegura que se ha seleccionado una membresía válida y no 'Seleccionar'
            {
                int selectedId = idsMembresia[cbMembresia.SelectedIndex];
                try
                {
                    actualizar.ActualizarMembresia(selectedId, lblDUI.Text);
                    MessageBox.Show("Se le ha agregado una membresía al cliente exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar la membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una membresía válida.", "Selección Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
