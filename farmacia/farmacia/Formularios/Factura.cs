using farmacia.Clases;
using farmacia.Clases.DataAccess;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace farmacia
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            LlenarCombos();
            LlenadoDeTablas();
        }

        private void MarcaCambio(object sender, EventArgs e)
        {
            if (CBMarca.SelectedIndex > 0)
            {
                if (CBCategoria.SelectedIndex > 0 && CBPresentacion.SelectedIndex <= 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaYCategoria();
                }
                else if (CBCategoria.SelectedIndex > 0 && CBPresentacion.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaPresentacionYCategoria();
                }
                else if (CBCategoria.SelectedIndex <= 0 && CBPresentacion.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaYPresentacion();
                }
                else
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcas();
                }
            }
            else if (CBMarca.SelectedIndex <= 0 && CBCategoria.SelectedIndex <= 0 && CBPresentacion.SelectedIndex <= 0)
            {
                CBProductos.Items.Clear();
                LlenarDeProductos();
            }
        }

        private void CategoriaCambio(object sender, EventArgs e)
        {
            if (CBCategoria.SelectedIndex > 0)
            {
                if (CBMarca.SelectedIndex > 0 && CBPresentacion.SelectedIndex <= 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaYCategoria();
                }
                else if (CBMarca.SelectedIndex > 0 && CBPresentacion.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaPresentacionYCategoria();
                }
                else if (CBMarca.SelectedIndex <= 0 && CBPresentacion.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorPresentacionYCategoria();
                }
                else
                {
                    CBProductos.Items.Clear();
                    FiltrarPorCategorias();
                }
            }
            else if (CBMarca.SelectedIndex <= 0 && CBCategoria.SelectedIndex <= 0 && CBPresentacion.SelectedIndex <= 0)
            {
                CBProductos.Items.Clear();
                LlenarDeProductos();
            }
        }

        private void PresentacionCambio(object sender, EventArgs e)
        {
            if (CBPresentacion.SelectedIndex > 0)
            {
                if (CBCategoria.SelectedIndex > 0 && CBMarca.SelectedIndex <= 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorPresentacionYCategoria();
                }
                else if (CBCategoria.SelectedIndex > 0 && CBMarca.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaPresentacionYCategoria();
                }
                else if (CBCategoria.SelectedIndex <= 0 && CBMarca.SelectedIndex > 0)
                {
                    CBProductos.Items.Clear();
                    FiltrarPorMarcaYPresentacion();
                }
                else
                {
                    CBProductos.Items.Clear();
                    FiltrarPorPresentacion();
                }
            }
            else if (CBMarca.SelectedIndex <= 0 && CBCategoria.SelectedIndex <= 0 && CBPresentacion.SelectedIndex <= 0)
            {
                CBProductos.Items.Clear();
                LlenarDeProductos();
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String termino = txtBuscar.Text.ToString().Trim();
            if (termino != "")
            {
                CBProductos.Items.Clear();
                CrudDetalleCompras funcion = new CrudDetalleCompras();
                SqlDataReader llenador = funcion.BuscadorDeProductos(termino);
                CBProductos.Items.Add("Seleccionar");
                while (llenador.Read())
                {
                    CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
                }
                CBProductos.SelectedIndex = 0;
                llenador.Close();
            }
            else
            {
                CBProductos.Items.Clear();
                LlenarDeProductos();
            }


        }

        //Llenado inicial 
        public void LlenarCombos()
        {
            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ObtenerTodasLasCategorias();

            CBCategoria.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBCategoria.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBCategoria.SelectedIndex = 0;
            llenador.Close();

            llenador = datos.ObtenerTodasLasMarcas();
            CBMarca.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBMarca.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBMarca.SelectedIndex = 0;
            llenador.Close();

            llenador = datos.ObtenerTodasLasPresentaciones();
            CBPresentacion.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBPresentacion.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBPresentacion.SelectedIndex = 0;
            llenador.Close();

            LlenarDeProductos();
        }

        public void LlenarDeProductos()
        {
            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ObtenerTodosLosProductos();

            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void LlenadoDeTablas()
        {
            CrudDetalleCompras llenador = new CrudDetalleCompras();
            tablaProductos.DataSource = llenador.ObtenerDetallePorFactura("1");

            // Establecer el ancho de las columnas
            tablaProductos.Columns["No"].Width = 50;
            tablaProductos.Columns["Cantidad"].Width = 85;
            tablaProductos.Columns["Producto"].Width = 200;
            tablaProductos.Columns["p/u"].Width = 100;
            tablaProductos.Columns["Subtotal"].Width = 100;
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.Columns["No"].ReadOnly = true;
            tablaProductos.Columns["Cantidad"].ReadOnly = true;
            tablaProductos.Columns["Producto"].ReadOnly = true;
            tablaProductos.Columns["p/u"].ReadOnly = true;
            tablaProductos.Columns["Subtotal"].ReadOnly = true;

            foreach (DataGridViewColumn column in tablaProductos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            tablaProductos.DataBindingComplete += (sender, e) =>
            {
                if (tablaProductos.Columns.Contains("No"))
                {
                    for (int i = 0; i < tablaProductos.Rows.Count; i++)
                    {
                        tablaProductos.Rows[i].Cells["No"].Value = (i + 1).ToString(); // Establecer el valor del índice (fila autoincrementable)
                    }
                }
            };
        }
        //Filtradores
        public void FiltrarPorMarcas()
        {
            String marca = EncontrarSeleccion(CBMarca);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorMarca(marca);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorCategorias()
        {
            String categoria = EncontrarSeleccion(CBCategoria);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorCategoria(categoria);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorPresentacion()
        {
            String presentacion = EncontrarSeleccion(CBPresentacion);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorCategoria(presentacion);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorMarcaYCategoria()
        {
            String marca = EncontrarSeleccion(CBMarca);
            String categoria = EncontrarSeleccion(CBCategoria);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorMarcaYCategoria(marca, categoria);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorMarcaYPresentacion()
        {
            String marca = EncontrarSeleccion(CBMarca);
            String presentacion = EncontrarSeleccion(CBPresentacion);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorMarcaYPresentacion(marca, presentacion);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorPresentacionYCategoria()
        {
            String presentacion = EncontrarSeleccion(CBPresentacion);
            String categoria = EncontrarSeleccion(CBCategoria);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorPresentacionYCategoria(presentacion, categoria);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public void FiltrarPorMarcaPresentacionYCategoria()
        {
            String marca = EncontrarSeleccion(CBMarca);
            String presentacion = EncontrarSeleccion(CBPresentacion);
            String categoria = EncontrarSeleccion(CBCategoria);

            CrudDetalleCompras datos = new CrudDetalleCompras();
            SqlDataReader llenador = datos.ConsultarPorMarcaPresentacionYCategoria(marca, presentacion, categoria);
            CBProductos.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProductos.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProductos.SelectedIndex = 0;
            llenador.Close();
        }

        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}