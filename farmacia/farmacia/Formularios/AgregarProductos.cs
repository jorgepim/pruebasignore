using farmacia.Clases;
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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
            LlenadoTabla();
            LlenadoCombos();
        }

        public void LlenadoTabla()
        {
            CrudProductos llenador = new CrudProductos();
            TablaDeDatos.DataSource = llenador.LlenadoTabla();

            TablaDeDatos.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in TablaDeDatos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void LlenadoCombos()
        {
            CrudProductos producto = new CrudProductos();
            SqlDataReader llenador = producto.ComboMarca();

            CbMarca.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CbMarca.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CbMarca.SelectedIndex = 0;
            llenador.Close();

            llenador = producto.ComboCatagoria();
            CbCategoria.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CbCategoria.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CbCategoria.SelectedIndex = 0;
            llenador.Close();

            llenador = producto.ComboPresentacion();
            CbPresent.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CbPresent.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CbPresent.SelectedIndex = 0;
            llenador.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!(CbCategoria.SelectedIndex != 0 & CbPresent.SelectedIndex != 0 & CbMarca.SelectedIndex != 0))
            {
                MessageBox.Show("Selecciona una opción válida");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) | string.IsNullOrWhiteSpace(TxtDescrip.Text))
            {
                MessageBox.Show("El campo de texto no puede estar vacío");
                return;
            }
            bool recet = checkBox1.Checked; // Esto es booleano true o false
            int recetaValue = recet ? 1 : 0;
            String nombre = TxtNombre.Text;
            String descrip = TxtDescrip.Text;
            decimal precio = numericUpDown1.Value;
            String marca = EncontrarSeleccion(CbMarca);
            String categoria = EncontrarSeleccion(CbCategoria);
            String presentacion = EncontrarSeleccion(CbPresent);
            CrudProductos llenador = new CrudProductos();
            llenador.InsertarProducto(nombre, precio, descrip, recetaValue, categoria, presentacion, marca);
            MessageBox.Show("El producto ha sido almacenado exitosamente");
            LlenadoTabla();
            TxtDescrip.Text = "";
            TxtNombre.Text = "";
            CbCategoria.SelectedIndex = 0;
            CbMarca.SelectedIndex = 0;  
            CbPresent.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            checkBox1.Checked = false;

        }
        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }
    }
}
