using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using System.Data.SqlClient;
using System.Globalization;

namespace DB
{
    public partial class AgregarLotes : Form
    {
        public AgregarLotes()
        {
            InitializeComponent();
            LlenadoCombosYMasked();
            LlenadoDeTablas();
            BtnModificar.Enabled = false;
        }
        public void LlenadoDeTablas()
        {
            CrudLotes datos = new CrudLotes();
            tablaDeDatos.DataSource = datos.ObtenerTodosLosLotes();

            // Establecer el ancho de las columnas
            tablaDeDatos.Columns["ID"].Width = 35;
            tablaDeDatos.Columns["Producto"].Width = 150;
            tablaDeDatos.Columns["Proveedor"].Width = 100;
            tablaDeDatos.Columns["Sucursal"].Width = 100;
            tablaDeDatos.Columns["Fecha Compra"].Width = 100;
            tablaDeDatos.Columns["Fecha de Vencimiento"].Width = 100;
            tablaDeDatos.Columns["Precio de Compra"].Width = 100;
            tablaDeDatos.Columns["Descuento"].Width = 100;
            tablaDeDatos.Columns["Cantidad"].Width = 100;

            tablaDeDatos.AllowUserToAddRows = false;
            tablaDeDatos.Columns["ID"].ReadOnly = true;
            tablaDeDatos.Columns["Producto"].ReadOnly = true;
            tablaDeDatos.Columns["Proveedor"].ReadOnly = true;
            tablaDeDatos.Columns["Sucursal"].ReadOnly = true;
            tablaDeDatos.Columns["Fecha Compra"].ReadOnly = true;
            tablaDeDatos.Columns["Fecha de Vencimiento"].ReadOnly = true;
            tablaDeDatos.Columns["Precio de Compra"].ReadOnly = true;
            tablaDeDatos.Columns["Descuento"].ReadOnly = true;
            tablaDeDatos.Columns["Cantidad"].ReadOnly = true;

            foreach (DataGridViewColumn column in tablaDeDatos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }
        public void LlenadoCombosYMasked()
        {
            CrudDetalleCompras producto = new CrudDetalleCompras();
            CrudSucursal sucursal = new CrudSucursal();
            CrudProveedores proveedores = new CrudProveedores();
            SqlDataReader llenador = producto.ObtenerTodosLosProductos();

            CBProducto.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProducto.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProducto.SelectedIndex = 0;
            llenador.Close();

            llenador = sucursal.LlenadorDeCombo();
            CBSucursal.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBSucursal.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBSucursal.SelectedIndex = 0;
            llenador.Close();

            llenador = proveedores.LlenadoCombo();
            CBProveedor.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProveedor.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProveedor.SelectedIndex = 0;
            llenador.Close();

            MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");
            MaskDesc.Text = "0";
            MaskCanti.Text = "1";
            MaskPrecioC.Text = "   000";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime enteredDate = DateTime.Now;
            if (!(CBProducto.SelectedIndex != 0 && CBProveedor.SelectedIndex != 0 && CBSucursal.SelectedIndex != 0))
            {
                MessageBox.Show("Debe seleccionar una opcion");
                return;
            }

            if (DateTime.TryParseExact(MaskFechaV.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate2))
            {
                if (enteredDate2 < DateTime.Today | enteredDate2 < enteredDate)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser menor que la fecha actual y la fecha de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskFechaV.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una fecha válida en el formato dd/MM/yyyy.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(MaskPrecioC.Text.Replace('_', '0').TrimStart('0'), out decimal result))
            {
                if (result < 0)
                {
                    MessageBox.Show("El precio debe ser mayor o igual a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskPrecioC.Text = "   000";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido de precio de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskCanti.Text.Replace('_', '0').TrimStart('0'), out int result2))
            {
                if (result2 < 1)
                {
                    MessageBox.Show("La cantidad debe de ser al menos 1.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskCanti.Text = "1";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una cantidad válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskDesc.Text.Replace('_', '0').TrimStart('0'), out int result3))
            {
                if (result3 < 0 | result3 > 100)
                {
                    MessageBox.Show("El porcentaje de descuento debe de estar entre 0 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskDesc.Text = "0";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idProducto = int.Parse(EncontrarSeleccion(CBProducto));
            int idProveedor = int.Parse(EncontrarSeleccion(CBProveedor));
            int idSucursal = int.Parse(EncontrarSeleccion(CBSucursal));
            decimal pcDescuento = result3 / 100;

            CrudLotes llenador = new CrudLotes();
            llenador.InsertarLote(idProducto, idProveedor, idSucursal, enteredDate, enteredDate2, result, pcDescuento, result2);
            MessageBox.Show("El lote fue agregado correctamente");
            CBProducto.SelectedIndex = 0;
            CBProveedor.SelectedIndex = 0;
            CBSucursal.SelectedIndex = 0;
            MaskCanti.Text = "1";
            MaskDesc.Text = "0";
            MaskPrecioC.Text = "     000";
            MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");
            LlenadoDeTablas();

        }
        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }

        private void SeleccionarTabla(object sender, EventArgs e)
        {
            if (tablaDeDatos.SelectedRows.Count > 0)
            {
                CBProducto.Enabled = false;
                button1.Enabled = false;
                DataGridViewRow filas = tablaDeDatos.SelectedRows[0];
                String proveedor = filas.Cells["Proveedor"].Value.ToString();
                String producto = filas.Cells["Producto"].Value.ToString();
                String sucursal = filas.Cells["Sucursal"].Value.ToString();
                String fechaVencimiento = filas.Cells["Fecha de Vencimiento"].Value.ToString();
                String precio = filas.Cells["Precio de Compra"].Value.ToString();
                String descuento = filas.Cells["Descuento"].Value.ToString();
                String cantidad = filas.Cells["Cantidad"].Value.ToString();

                for (int i = 0; i < CBProveedor.Items.Count; i++)
                {
                    String[] parts = CBProveedor.Items[i].ToString().Split('|');
                    if (parts.Length > 1)
                    {
                        if (parts[1].Trim() == proveedor)
                        {
                            CBProveedor.SelectedIndex = i;
                            break;
                        }
                    }
                }

                for (int i = 0; i < CBSucursal.Items.Count; i++)
                {
                    String[] parts = CBSucursal.Items[i].ToString().Split('|');
                    if (parts.Length > 1)
                    {
                        if (parts[1].Trim() == sucursal)
                        {
                            CBSucursal.SelectedIndex = i;
                            break;
                        }
                    }
                }

                for (int i = 0; i < CBProducto.Items.Count; i++)
                {
                    String[] parts = CBProducto.Items[i].ToString().Split('|');
                    if (parts.Length > 1)
                    {
                        if (parts[1].Trim() == producto)
                        {
                            CBProducto.SelectedIndex = i;
                            break;
                        }
                    }
                }
                string[] partes = fechaVencimiento.Split(' ');
                string[] formatos = { "dd/MM/yyyy", "d/M/yyyy" };
                if (partes.Length > 0)
                {
                    if (DateTime.TryParseExact(partes[0], formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaVencimientoFormateado))
                    {
                        MaskFechaV.Text = fechaVencimientoFormateado.ToString("dd/MM/yyyy");
                    }
                }

                if (decimal.TryParse(precio, out decimal precioFormateado))
                {
                    MaskPrecioC.Text = precioFormateado.ToString("000000.00");

                }
                if (int.TryParse(descuento, out int descuentoFormateado))
                {
                    MaskDesc.Text = descuentoFormateado.ToString("000");

                }
                if (int.TryParse(cantidad, out int cantidadFormateado))
                {
                    MaskCanti.Text = cantidadFormateado.ToString("00000");

                }
                BtnModificar.Enabled = true;
            }
            else
            {
                BtnModificar.Enabled = false;
                button1.Enabled = true;
                CBProducto.Enabled = true;
                CBProducto.SelectedIndex = 0;
                CBProveedor.SelectedIndex = 0;
                CBSucursal.SelectedIndex = 0;
                MaskCanti.Text = "1";
                MaskDesc.Text = "0";
                MaskPrecioC.Text = "     000";
                MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filas = tablaDeDatos.SelectedRows[0];
            String fechaCompra = filas.Cells["Fecha Compra"].Value.ToString();
            string[] partes = fechaCompra.Split(' ');
            string[] formatos = { "dd/MM/yyyy", "d/M/yyyy" };
            if (!(CBProveedor.SelectedIndex != 0 && CBSucursal.SelectedIndex != 0))
            {
                MessageBox.Show("Debe seleccionar una opcion");
                return;
            }

            if (DateTime.TryParseExact(MaskFechaV.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate2))
            {
                if (partes.Length > 0)
                {
                    if (DateTime.TryParseExact(partes[0], formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate))
                    {
                        if (enteredDate2 < enteredDate)
                        {
                            MessageBox.Show("La fecha de vencimiento no puede ser menor que la fecha de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MaskFechaV.Text = DateTime.Now.ToString("dd/MM/yyyy");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una fecha válida en el formato dd/MM/yyyy.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(MaskPrecioC.Text.Replace('_', '0').TrimStart('0'), out decimal result))
            {
                if (result < 0)
                {
                    MessageBox.Show("El precio debe ser mayor o igual a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskPrecioC.Text = "   000";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido de precio de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskCanti.Text.Replace('_', '0').TrimStart('0'), out int result2))
            {
                if (result2 < 1)
                {
                    MessageBox.Show("La cantidad debe de ser al menos 1.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskCanti.Text = "1";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una cantidad válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskDesc.Text.Replace('_', '0').TrimStart('0'), out int result3))
            {
                if (result3 < 0 | result3 > 100)
                {
                    MessageBox.Show("El porcentaje de descuento debe de estar entre 0 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskDesc.Text = "0";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CrudLotes llenador = new CrudLotes();
            DataGridViewRow fila = tablaDeDatos.SelectedRows[0];
            int idLote = int.Parse(fila.Cells["ID"].Value.ToString());
            int idProveedor = int.Parse(EncontrarSeleccion(CBProveedor));
            int idSucursal = int.Parse(EncontrarSeleccion(CBSucursal));
            decimal pcDescuento = (decimal)result3 / 100m;
            llenador.ActualizarLote(idLote, idProveedor, idSucursal, enteredDate2, result, pcDescuento, result2);
            MessageBox.Show("El lote fue actualizado con éxito");
            BtnModificar.Enabled = false;
            button1.Enabled = true;
            CBProducto.Enabled = true;
            CBProducto.SelectedIndex = 0;
            CBProveedor.SelectedIndex = 0;
            CBSucursal.SelectedIndex = 0;
            MaskCanti.Text = "1";
            MaskDesc.Text = "0";
            MaskPrecioC.Text = "     000";
            MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");
            LlenadoDeTablas();
        }
    }
}
