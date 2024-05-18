using farmacia.Clases.DataAccess;
using farmacia.Formularios;
using farmacia.Formularios.multimedia;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace farmacia
{
    public partial class Factura : Form
    {
        int idFactura;
        String idCliente;
        String idEmpleado = Menu.idEmpleado;
        decimal total = 0;
        Form menu;
        Form Clientes;
        public Factura(String cliente, Form menu, Form Clientes)
        {
            InitializeComponent();
            LlenarCombos();
            this.menu = menu;
            BtnEjecutar.Enabled = false;
            BtnEliminar.Enabled = false;
            idCliente = cliente;
            LBDescuento.Text = "";
            LBTotal.Text = "";
            LBCambio.Text = "";
            this.Clientes = Clientes;
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
                CBCategoria.SelectedIndex = 0;
                CBMarca.SelectedIndex = 0;
                CBPresentacion.SelectedIndex = 0;
            }
            else
            {
                CBProductos.Items.Clear();
                LlenarDeProductos();
                CBCategoria.SelectedIndex = 0;
                CBMarca.SelectedIndex = 0;
                CBPresentacion.SelectedIndex = 0;
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

            llenador = datos.ObtenerTodosLosTiposDePago();
            CBTipoPago.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBTipoPago.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBTipoPago.SelectedIndex = 0;
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
            tablaProductos.DataSource = llenador.ObtenerDetallePorFactura(idFactura.ToString());

            // Establecer el ancho de las columnas
            tablaProductos.Columns["ID"].Width = 50;
            tablaProductos.Columns["Cantidad"].Width = 85;
            tablaProductos.Columns["Producto"].Width = 200;
            tablaProductos.Columns["p/u"].Width = 100;
            tablaProductos.Columns["Subtotal"].Width = 100;
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.Columns["ID"].ReadOnly = true;
            tablaProductos.Columns["Cantidad"].ReadOnly = true;
            tablaProductos.Columns["Producto"].ReadOnly = true;
            tablaProductos.Columns["p/u"].ReadOnly = true;
            tablaProductos.Columns["Subtotal"].ReadOnly = true;

            foreach (DataGridViewColumn column in tablaProductos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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
            SqlDataReader llenador = datos.ConsultarPorPresentacion(presentacion);
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(SPCantidad.Value);
            if (CBProductos.SelectedIndex == 0 | cantidad <= 0)
            {
                MessageBox.Show("No ha marcado el producto o la cantidad");
                return;
            }
            String idProducto = EncontrarSeleccion(CBProductos);
            CrudFactura factura = new CrudFactura();
            CrudDetalleCompras detalleCompras = new CrudDetalleCompras();
            if (idFactura != 0)
            {
                detalleCompras.AgregarADetalleCompra(idFactura.ToString(), idProducto, cantidad.ToString());
                LlenadoDeTablas();
                txtPrecio.Text = "";
                SPCantidad.Value = 0;
                LlenadorDeTotales();
                BtnVolver.Enabled = false;
            }
            else
            {
                String sucursal = factura.ObtenerSucusal(idEmpleado.ToString());
                factura.CrearFactura(idEmpleado, idCliente, sucursal);
                idFactura = factura.ObtenerUltimoIdFactura();
                detalleCompras.AgregarADetalleCompra(idFactura.ToString(), idProducto, cantidad.ToString());
                LlenadoDeTablas();
                txtPrecio.Text = "";
                SPCantidad.Value = 0;
                LlenadorDeTotales();
                BtnVolver.Enabled = false;
            }
            BtnEjecutar.Enabled = true;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            CrudFactura factura = new CrudFactura();
            if (tablaProductos.RowCount == 0)
            {
                DialogResult result = MessageBox.Show(
                "¿Desea eliminar la factura?", // Texto del mensaje
                "Confirmación",      // Título del cuadro
                MessageBoxButtons.YesNo, // Botones de Sí/No
                MessageBoxIcon.Question // Icono de pregunta
                );

                // Verificar qué botón fue presionado
                if (result == DialogResult.Yes)
                {
                    factura.EliminarFactura(idFactura);                    // El usuario seleccionó "Sí"
                    MessageBox.Show("La factura se elimino exitosamente");
                    menu.Show();
                    this.Close();
                }
            }
            else
            {
                decimal cambio = SPTotalIngresado.Value;
                if (CBTipoPago.SelectedIndex != 0 && cambio >= total)
                {
                    String tipoPago = EncontrarSeleccion(CBTipoPago);
                    factura.LlenarFactura(idFactura.ToString(), tipoPago);
                    MessageBox.Show("La factura se almaceno exitosamente");
                    menu.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No ha seleccionado el tipo de pago");
                }
            }
        }

        private void CambioProducto(object sender, EventArgs e)
        {
            if (CBProductos.SelectedIndex != 0)
            {
                CrudDetalleCompras detalle = new CrudDetalleCompras();
                String producto = EncontrarSeleccion(CBProductos);
                String precio = detalle.RecuperarPrecio(producto);
                if (precio != null)
                {
                    txtPrecio.Text = "$" + precio;
                }
                else
                {
                    txtPrecio.Text = "";
                }
            }
            else
            {
                txtPrecio.Text = "";
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                CrudDetalleCompras detalle = new CrudDetalleCompras();
                DataGridViewRow selectedRow = tablaProductos.SelectedRows[0];
                string valor = selectedRow.Cells["ID"].Value.ToString();
                detalle.EliminarDetalleCompra(idFactura.ToString(), valor);
                LlenadoDeTablas();
                LlenadorDeTotales();
                BtnEliminar.Enabled = false;
            }
        }

        private void SeleccionTabla(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                // Activar el botón
                BtnEliminar.Enabled = true;
            }
            else
            {
                // Desactivar el botón
                BtnEliminar.Enabled = false;
            }
        }

        public void LlenadorDeTotales()
        {
            decimal subtotal = 0, descuento = 0;
            CrudDetalleCompras llenador = new CrudDetalleCompras();
            SqlDataReader reader = llenador.ObtenerSUMTotalesDescuento(idFactura.ToString());

            if (reader.Read())
            {
                subtotal = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                descuento = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                total = subtotal - descuento;
            }

            reader.Close();
            LBDescuento.Text = "$" + descuento.ToString();
            LBTotal.Text = "$" + total.ToString();
        }

        private void AgregarACambio(object sender, EventArgs e)
        {
            decimal totalIngresado = SPTotalIngresado.Value;
            if (totalIngresado >= total)
            {
                LBCambio.Text = "$" + (totalIngresado - total);
            }
            else
            {
                LBCambio.Text = "Falta";
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            Clientes.Show();
        }

    }
}