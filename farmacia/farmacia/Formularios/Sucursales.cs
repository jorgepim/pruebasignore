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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
            LoadTheme();
            LlenadoTabla();
            LlenadoCombo();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
                }
            }
            //lblClientes.ForeColor = ThemeColor.SecondaryColor;
        }

        public void LlenadoTabla()
        {
            CrudSucursal llenador = new CrudSucursal();
            TablaSucursales.DataSource = llenador.ObtenerDatosTabla();
            TablaSucursales.DefaultCellStyle.ForeColor = Color.Black;
            TablaSucursales.Columns["Sucursal"].Width = 107;
            TablaSucursales.Columns["Producto"].Width = 150;
            TablaSucursales.Columns["Cantidad"].Width = 75;
            TablaSucursales.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in TablaSucursales.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void LlenadoCombo()
        {
            CrudSucursal datos = new CrudSucursal();
            SqlDataReader llenador = datos.ObtenerDepartamentos();

            CBDepartamento.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBDepartamento.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBDepartamento.SelectedIndex = 0;
            llenador.Close();
        }

        private void TXTProducto_TextChanged(object sender, EventArgs e)
        {
            String departamento = EncontrarSeleccion(CBDepartamento);
            String texto = TXTProducto.Text.Trim();
            CrudSucursal llenador = new CrudSucursal();
            if (texto != "" && departamento != "Seleccionar")
            {
                TablaSucursales.DataSource = llenador.FiltrarPorBusquedaYDepartamento(texto, departamento);
            }
            else if (texto == "" && departamento != "Seleccionar")
            {
                TablaSucursales.DataSource = llenador.FiltraPorDepartamento(departamento);
            }
            else if (texto == "")
            {
                LlenadoTabla();
            }
            else
            {
                TablaSucursales.DataSource = llenador.FiltrarPorBusqueda(texto);
            }
        }
        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }

        private void CBDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String departamento = EncontrarSeleccion(CBDepartamento);
            String texto = TXTProducto.Text.Trim();
            CrudSucursal llenador = new CrudSucursal();
            if (texto != "" && departamento != "Seleccionar")
            {
                TablaSucursales.DataSource = llenador.FiltrarPorBusquedaYDepartamento(texto, departamento);
            }
            else if (texto != "" && departamento == "Seleccionar")
            {
                TablaSucursales.DataSource = llenador.FiltrarPorBusqueda(texto);
            }
            else if (departamento == "Seleccionar")
            {
                LlenadoTabla();
            }
            else
            {
                TablaSucursales.DataSource = llenador.FiltraPorDepartamento(departamento);
            }
        }
    }
}
